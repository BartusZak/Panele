
var checker = 1;
function showList() {
    var value = document.getElementById("listActive");
    

    if (checker == 1) {
        value.style.display = 'block';
        checker++;
       
    }
    else {
        value.style.display = 'none';
        checker--;
    }
       
   
 
   
    
    
}
