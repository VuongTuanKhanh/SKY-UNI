require('dotenv').config()
const Express = require('express')
const Nexmo = require('nexmo')
const spawn = require('child_process').spawn
const mongoose = require('mongoose')
const path = require('path')

const BookRoute = require('./books/book.route')
const MusicRoute = require('./music/music.route')
// --------------------------------------------------------------------//

mongoose.connect(process.env.DB_URL, { useNewUrlParser: true })
mongoose.connection
    .once('open', () => console.log('Connected to Database'))
    .on('error', err => console.log('Error occured while connect to Database: ', err))
const app = Express()
const nexmo = new Nexmo({
    apiKey: process.env.NEXMO_KEY,
    apiSecret: process.env.NEXMO_SECRET
})

app.use(Express.json())
app.use(Express.urlencoded({ extended : false }))
//default static source
app.use(Express.static(path.join(__dirname, '../static')))

// --------------------------------------------------------------------//

app.get('/', (req, res) => {
    res.sendFile(path.join(__dirname, '../static/index.html'))
})

app.use('/books', BookRoute)
app.use('/music', MusicRoute)

app.get('/python-batch', (req, res) => {
    const file = 'test.py'
    const process = spawn('python', [file, ...req.query])
    let result = ''

    process.stdout.on('data', data => result += data.toString() )
    process.stdout.on('end', () => res.end(result))
})

app.post('/sms', (req, res) => {
    const from = process.env.SENDER_NUMBER
    const { to, text } = req.body
    nexmo.message.sendSms(from, to, text, { type: 'unicode' }, err => {
        if(err) res.send(err)
        else res.send('Success')
    })
})

app.listen(process.env.PORT, () => console.log(`Listenling on localhost:${process.env.PORT}`))