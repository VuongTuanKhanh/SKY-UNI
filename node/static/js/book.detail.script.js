async function chayFunc() {
    console.log(recentbooks);
    const getCookie = (name) => {
        return document.cookie.split('; ').reduce((r, v) => {
            const parts = v.split('=')
            return parts[0] === name ? decodeURIComponent(parts[1]) : r
        }, '')
    }
    const lastId = getCookie('lastId')

    const res1 = await fetch(`http://localhost:3000/books/${lastId}`)
    const res2 = await fetch(`http://localhost:3000/books/${lastId}/recommend`)
    const json1 = await res1.json()
    const json2 = await res2.json()


    document.getElementById("book-img").src = json1.image_url
    document.getElementById("shit").innerText = json1.title
    document.getElementById("book-img").style.width = "200px"
    document.getElementById("book-img").style.height = "280px"

    const primaryImage = document.getElementsByClassName('primary-image')
    const productName = document.getElementsByClassName('product-name')

    for (let i=0; i<4; i++) {
        primaryImage[i].src = json2[i].image_url
        productName[i].childNodes[0].textContent = json2[i].title
        document.getElementsByClassName("secondary-image")[i].src = json2[i].image_url
    }
    console.log(window.recentbooks);
    for (let i=0; i<3; i++) {
        document.getElementsByClassName("recent primary-image").src = window.recentbooks[i].image_url
        document.getElementsByClassName("recent secondary-image").src = window.recentbooks[i].image_url
        document.getElementsByClassName("recent new-price").textContent = Math.floor(Math.random() * 100) + "$"
        document.getElementsByClassName("recent product-name").textContent = window.recentbooks[i].title
    }
}