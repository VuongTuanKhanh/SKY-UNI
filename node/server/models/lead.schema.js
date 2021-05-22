const mongoose = require('mongoose')
const Schema = mongoose.Schema

const LeadSchema = new Schema({
    phoneNumber: {
        type: String,
        required: true,
        maxlength: 11
    },
    otp: {
        type: String,
        required: true,
        maxlength: 4
    }
})

const Lead = mongoose.model('lead', LeadSchema)

module.exports = Lead