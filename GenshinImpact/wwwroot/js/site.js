function filter(type, color) {
    let cards, i;
    let count = 0;
    cards = document.getElementsByClassName("card");
    for (i = 0; i < cards.length; i++) {
        cards[i].parentElement.style.display = 'none';
        if (cards[i].classList.contains(type) || type === "all") {
            cards[i].parentElement.style.display = 'block';
            count += 1;
        };
    };
    
    if (type === "all") {
        document.getElementsByClassName("album")[0].style = "background-color: #f8f9fa";
    }
    else
    {
        document.getElementsByClassName("album")[0].style = "background-color: " + color;
    }

    if (count == 0){
        document.getElementById("zeroChar").style.display = 'flex';
        document.getElementById("zeroChar").style.height = 'calc(100vh - 420px)';
    }
    else {
        document.getElementById("zeroChar").style.display = 'none';
        document.getElementById("zeroChar").style.height = '0';
    }
}