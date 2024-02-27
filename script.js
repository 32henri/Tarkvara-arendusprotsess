
function changeStyle1() {
    const body = document.getElementById("stylebody");

    if (body.classList.contains("body1")) {
        body.classList.remove("body1");
        body.classList.add("body2");
    } 
    else if (body.classList.contains("body2")){
        body.classList.remove("body2");
        body.classList.add("body3");
    }
    else {
        body.classList.remove("body3");
        body.classList.add("body1");
        body.style.animationPlayState = "paused";
        body.offsetWidth = body.offsetWidth; 
        body.style.animationPlayState = "running"; 
    }
}