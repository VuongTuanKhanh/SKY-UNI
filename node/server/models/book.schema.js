const mongoose = require('mongoose')
const Schema = mongoose.Schema

const BookSchema = new Schema({
    book_id: {
        type: Number,
        required: true
    },
    title: {
        type: String,
        required: true
    },
    image_url: {
        type: String,
        required: true,
        maxlength: 255
    }
})

const Book = mongoose.model('book', BookSchema)

module.exports = Book