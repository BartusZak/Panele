function show(id) {
   
    
    var file = document.getElementById("slideCont" + id).innerHTML;
    document.getElementById("placeForItems").innerHTML = file;
    document.getElementById("placeForItems").style.display = 'none';
    $("#placeForItems").fadeIn(1500);
  
}

function starts() {
    var file = document.getElementById("slideCont").innerHTML;
    document.getElementById("placeForItems").innerHTML = file;
}

