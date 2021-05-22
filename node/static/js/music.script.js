function LatestMusic(music) {
    document.cookie = `lastIdMusic=${music._id}`
}

document.addEventListener("DOMContentLoaded", async function(event) {

    const getCookie = (name) => {
        return document.cookie.split('; ').reduce((r, v) => {
            const parts = v.split('=')
            return parts[0] === name ? decodeURIComponent(parts[1]) : r
        }, '')
    }
    const lastId = getCookie('lastIdMusic')
    let json = {}

    if(lastId) {
        const res1 = await fetch(`http://localhost:3000/music/${lastId}/recommend`)
        json = await res1.json()
    } else {
        const res = await fetch('http://localhost:3000/music')
        json = await res.json()
    }
    console.log(json)


    for (let i = 0; i < document.getElementsByClassName("product-name").length; i++) {
        document.getElementsByClassName("product-name")[i].childNodes[0].textContent = json[i].name;
        document.getElementsByClassName("product-name")[i].childNodes[0].href = json[i].Link;
        document.getElementsByClassName("primary-image")[i].src = json[i].Image
        document.getElementsByClassName("secondary-image")[i].src = json[i].Image
        document.getElementsByClassName("secondary-image")[i].style.display = "inline-block";
        document.getElementsByClassName("secondary-image")[i].style.width = "100%"
        document.getElementsByClassName("secondary-image")[i].style.height = "299px"
        document.getElementsByClassName("primary-image")[i].style.display = "inline-block";
        document.getElementsByClassName("primary-image")[i].style.width = "100%"
        document.getElementsByClassName("primary-image")[i].style.height = "229px"
        document.getElementsByClassName("product-name")[i].addEventListener("click", LatestMusic(json[i]))
    }
})

async function getMusic() {
}