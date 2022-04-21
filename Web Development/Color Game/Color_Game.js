var colors = []
var pickedColor;
var colorDisplay = document.getElementById("colorDisplay")
var squares = document.querySelectorAll(".square")
var messageDisplay = document.getElementById("message")
var h1 = document.querySelector("h1")
var newColors = document.querySelector("#newColors")
var modeButtons = document.querySelectorAll(".mode")
var easyMode = false

init()

function init(){
    reset()
    for(var i = 0; i < squares.length; i++){
        squares[i].style.backgroundColor = colors[i]
        squares[i].addEventListener("click", function(){
           var clickedColor = this.style.backgroundColor
           if(clickedColor === pickedColor){
               messageDisplay.textContent = "Correct"
               changeColors(clickedColor);
               h1.style.backgroundColor = clickedColor;
               newColors.textContent = "Play Again"
           } else{
               this.style.backgroundColor = "#232323";
               messageDisplay.textContent = "Try Again"
           }
        })
    }
    for(var i = 0; i < modeButtons.length; i++){
        modeButtons[i].addEventListener("click", function(){
            modeButtons[0].classList.remove("selected")
            modeButtons[1].classList.remove("selected")
            this.classList.add("selected")
            if(modeButtons[0].classList.contains("selected")){
                easyMode = true
            } else if(modeButtons[1].classList.contains("selected")){
                easyMode = false
            }
            reset()
        })
    }
   
}

function changeColors (x){
    for(var i = 0; i < squares.length; i++){
        squares[i].style.backgroundColor = x;

    }
}
    
function pickColor(){
    var random = Math.floor(Math.random() * colors.length)
    return colors[random];
}

function generateRandomColors(num){
    var arr = []
    for(var i = 0; i <num; i++){
        arr.push(randomColor())
    }
    return arr;
}

function randomColor(){
    var r = Math.floor(Math.random() * 256)
    var g = Math.floor(Math.random() * 256)
    var b = Math.floor(Math.random() * 256)
    return "rgb(" + r + ", " + g + ", " + b + ")"   
}

newColors.addEventListener("click", function(){
    reset()
})

function reset(){
    if(easyMode){
        colors = generateRandomColors(3)
    } else {
        colors = generateRandomColors(6)
    }
    pickedColor = pickColor()
    colorDisplay.textContent = pickedColor;
    messageDisplay.textContent = ""
    h1.style.backgroundColor = "steelblue"
    newColors.textContent = "New Colors"
    for(var i = 0; i < squares.length; i++){
        squares[i].style.backgroundColor = colors[i]
    }
    if(easyMode){
        for(var i = 0; i < squares.length; i++){
            if(colors[i]){
                squares[i].style.backgroundColor = colors[i]
            } else {
                squares[i].style.display = "none"
            }
        }
    } else {
        for(var i = 0; i < squares.length; i++){
            squares[i].style.display = "block"
            squares[i].style.backgroundColor = colors[i]
        }
    }
}
