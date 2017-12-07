function changingColor() {
    var span = document.getElementById("actualRate");
    var Value = span.textContent;
    var intVal = parseFloat(Value);

    var first = document.getElementById("first");
    var second = document.getElementById("second");
    var third = document.getElementById("third");
    var fourth = document.getElementById("fourth");
    var five = document.getElementById("five");

    switch (intVal) {
        case 1:
            first.style.color = 'orange';
            break;
        case 2:
            first.style.color = 'orange';
            second.style.color = 'orange';
            break;
        case 3:
            first.style.color = 'orange';
            second.style.color = 'orange';
            third.style.color = 'orange';
            break;
        case 4:
            first.style.color = 'orange';
            second.style.color = 'orange';
            third.style.color = 'orange';
            fourth.style.color = 'orange';
            break;
        case 5:
            first.style.color = 'orange';
            second.style.color = 'orange';
            third.style.color = 'orange';
            fourth.style.color = 'orange';
            five.style.color = 'orange';
            break;
    }

}


    





