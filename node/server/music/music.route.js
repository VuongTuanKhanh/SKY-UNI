const router = require('express').Router()
const Music = require('../models/music.schema')
const MusicMatrix = require('../models/music.matrix.schema')

router.get('/', async (req, res) => {
    const music = await Music.find({})
    res.send(music)
})

router.get('/:id', async (req, res) => {
    const book = await Music.findById(req.params.id)
    res.send(book)
})

router.get('/:id/recommend', async (req, res) => {
    const book = await Music.findById(req.params.id)

    const matrix = await MusicMatrix.find({})

    let result = {}
    let count = 0
    let limit = Math.floor(Math.random(5) * 10)

    for(let i = 0; i < matrix.length; i++) {
        if(Object.values(matrix[i].toObject()).includes(book.name) && count == limit) {
            result = matrix[i].toObject()
            break
        }
        if(Object.values(matrix[i].toObject()).includes(book.name)) {
            count++
        }
    }

    const booksNameRecommend = Object.values(result)
    const mapped = await Promise.all(booksNameRecommend.map(async name => {
        const bookObj = await Music.findOne({ name })
        return bookObj
    }))
    res.send(mapped)
})

module.exports = router