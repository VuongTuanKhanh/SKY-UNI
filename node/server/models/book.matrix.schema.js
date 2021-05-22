const mongoose = require('mongoose')
const Schema = mongoose.Schema

const BookMatrixSchema = new Schema({
    1: String,
    2: String,
    3: String,
    4: String,
    5: String,
    6: String,
    7: String,
    8: String,
    9: String,
    10: String,
    11: String,
    12: String,
    13: String,
    14: String,
    15: String,
    16: String,
    17: String,
    18: String,
    19: String,
    20: String,
})

const BookMatrix = mongoose.model('book_matrix', BookMatrixSchema, 'book_matrix')

module.exports = BookMatrix