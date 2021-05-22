const mongoose = require('mongoose')
const Schema = mongoose.Schema

const MusicSchema = new Schema({
    name: {
        type: String,
        required: true
    },
    Image: {
        type: String,
        required: true
    },
    Link: {
        type: String,
        required: true,
        maxlength: 255
    }
})

const Music = mongoose.model('music', MusicSchema, 'music')

module.exports = Music