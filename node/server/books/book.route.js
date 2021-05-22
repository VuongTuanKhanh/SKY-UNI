const router = require('express').Router()
const Book = require('../models/book.schema')
const BookMatrix = require('../models/book.matrix.schema')

router.get('/', async (req, res) => {
    const books = await Book.find({})
    books.length = 12
    res.send(books)
})

router.get('/:id', async (req, res) => {
    const book = await Book.findOne({ book_id: req.params.id })
    res.send(book)
})

router.get('/:id/recommend', async (req, res) => {
    const book = await Book.findOne({ book_id: req.params.id })

    const matrix = await BookMatrix.find({})

    let result = {}
    let count = 0
    let limit = Math.floor(Math.random() * 10)

    for(let i = 0; i < matrix.length; i++) {
        if(Object.values(matrix[i].toObject()).includes(book.title) && count == limit) {
            result = matrix[i].toObject()
            break
        }
        if(Object.values(matrix[i].toObject()).includes(book.title)) {
            count++
        }
    }

    const booksNameRecommend = Object.values(result)
    const mapped = await Promise.all(booksNameRecommend.map(async title => {
        const bookObj = await Book.findOne({ title })
        return bookObj
    }))
    res.send(mapped)
})

module.exports = router