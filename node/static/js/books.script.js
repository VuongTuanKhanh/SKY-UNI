function LatestBook(book) {
    document.cookie = `lastId=${book.book_id}`
    if (window.recentbooks == 3) {
        window.recentbooks.pop()
    }
    window.recentbooks.push(book)
    console.log(window.recentbooks)
    window.location.href = '/product-virtual.html'
}

document.addEventListener("DOMContentLoaded", async function(event) {
    const getCookie = (name) => {
        return document.cookie.split('; ').reduce((r, v) => {
            const parts = v.split('=')
            return parts[0] === name ? decodeURIComponent(parts[1]) : r
        }, '')
    }
    const lastId = getCookie('lastId')

    let json = {}

    if(lastId) {
        const res1 = await fetch(`http://localhost:3000/books/${lastId}/recommend`)
        json = await res1.json()
    } else {
        const res = await fetch('http://localhost:3000/books')
        json = await res.json()
    }

    console.log('book', json)

    for (let i = 0; i < document.getElementsByClassName("product-name").length; i++) {
        document.getElementsByClassName("product-name")[i].childNodes[0].textContent = json[i].title;
        document.getElementsByClassName("new-price")[i].textContent = Math.floor(Math.random() * 100) + "$";
        document.getElementsByClassName("primary-image")[i].src = json[i].image_url
        document.getElementsByClassName("secondary-image")[i].src = json[i].image_url
        document.getElementsByClassName("secondary-image")[i].style.display = "inline-block";
        document.getElementsByClassName("secondary-image")[i].style.width = "100%"
        document.getElementsByClassName("secondary-image")[i].style.height = "275px"
        document.getElementsByClassName("primary-image")[i].style.display = "inline-block";
        document.getElementsByClassName("primary-image")[i].style.width = "100%"
        document.getElementsByClassName("primary-image")[i].style.height = "275px"
        document.getElementsByClassName("product-content")[i].style.height = "130px"
        document.getElementsByClassName("product-name")[i].addEventListener("click", function(){ LatestBook(json[i])} )
    }
})

async function getBooks() {
    // const getCookie = (name) => {
    //     return document.cookie.split('; ').reduce((r, v) => {
    //         const parts = v.split('=')
    //         return parts[0] === name ? decodeURIComponent(parts[1]) : r
    //     }, '')
    // }
    // const lastId = getCookie('lastId')

    // let json = {}

    // if(lastId) {
    //     const res1 = await fetch(`http://localhost:3000/books/${lastId}/recommend`)
    //     json = await res1.json()
    //     console.log(json)
    // } else {
    //     const res = await fetch('http://localhost:3000/books')
    //     json = await res.json()
    // }

    // for (let i = 0; i < document.getElementsByClassName("product-name").length; i++) {
    //     document.getElementsByClassName("product-name")[i].childNodes[0].textContent = json[i].title;
    //     document.getElementsByClassName("new-price")[i].textContent = Math.floor(Math.random() * 100) + "$";
    //     document.getElementsByClassName("primary-image")[i].src = json[i].image_url
    //     document.getElementsByClassName("secondary-image")[i].src = json[i].image_url
    //     document.getElementsByClassName("secondary-image")[i].style.display = "inline-block";
    //     document.getElementsByClassName("secondary-image")[i].style.width = "100%"
    //     document.getElementsByClassName("secondary-image")[i].style.height = "275px"
    //     document.getElementsByClassName("primary-image")[i].style.display = "inline-block";
    //     document.getElementsByClassName("primary-image")[i].style.width = "100%"
    //     document.getElementsByClassName("primary-image")[i].style.height = "275px"
    //     document.getElementsByClassName("product-content")[i].style.height = "130px"
    //     document.getElementsByClassName("product-name")[i].addEventListener("click", function(){ LatestBook(json[i])} )
    // }
}
