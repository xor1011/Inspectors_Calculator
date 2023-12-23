var l=0;
var disclaimer="Disclaimer: No liability is claimed for the use of these calculations. Use them at your own risk";
var speed=100;
function typewriter(){

 if(l<disclaimer.length){  
    document.getElementById("disclaim").innerHTML+=disclaimer.charAt(l);
    l++;
    setTimeout(typewriter, speed);
 }
 
}


