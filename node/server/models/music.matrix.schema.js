const mongoose = require('mongoose')
const Schema = mongoose.Schema

const MusicMatrixSchema = new Schema({
    1: String,
    2: String,
    3: String,
    4: String,
    5: String,
    6: String,
    7: String,
    8: String,
    9: String,
    10: String
})

const MusicMatrix = mongoose.model('music_matrix', MusicMatrixSchema, 'music_matrix')

module.exports = MusicMatrix