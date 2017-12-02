function contentChange(item, where) {
    object = document.getElementById(where).innerHTML;
    document.getElementById(item).innerHTML = object;
  
}
/*<img src="~/Content/Kolonko/kolonko1.jpg" />*/
 
 
var id = 1;
var check = true;
function galeryChanger() {
    var picture = document.getElementById("Img" + id).innerHTML;
    document.getElementById("main").innerHTML = picture;
    document.getElementById("main").style.display = 'none';
    $("#main").fadeIn(1500);
    

 

    var generator = document.getElementById("generator").innerHTML;
    id++; if (id >= 9) id = 1;  
}
function checker() {
    if (check == true) {
        document.getElementById("main").style.display = 'block';
        galeryChanger();
        check = false;
    }
    else if (check == false) {
        check = true;
        document.getElementById("main").style.display = 'none';
    }
}
