function changeStyle() {

    const button = document.getElementById("stylebutton");

    if (button.classList.contains("button-blue")) {

        button.classList.remove("button-blue");

        button.classList.add("button-red");

    } else {

        button.classList.remove("button-red");

        button.classList.add("button-blue");

    }

}
function changeStyle1() {
    const body = document.getElementById("stylebody");

    if (body.classList.contains("body1")) {
        body.classList.remove("body1");
        body.classList.add("body2");
    } else {
        body.classList.remove("body2");
        body.classList.add("body1");
        body.style.animationPlayState = "paused";
        body.offsetWidth = body.offsetWidth; 
        body.style.animationPlayState = "running"; 
    }
}