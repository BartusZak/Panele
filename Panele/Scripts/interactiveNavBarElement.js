
var checker = 1;
function showList() {
    var value = document.getElementById("listActive");
    var designElement = document.getElementById("designElement");
    

    if (checker == 1) {
        value.style.display = 'block';
        designElement.style.border = '2px dotted #FFF';
        designElement.style.color = 'aqua';
        checker++;
       
    }
    else {
        value.style.display = 'none';
        designElement.style.border = 'none';
        designElement.style.color = 'azure';
        checker--;
    }
       
   
 
   
    
    
}
