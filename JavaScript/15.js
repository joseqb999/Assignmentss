function percen(perc)
{


 if (perc >=90){
    console.log("Grade-S and Grade Point- 10.0 ");      
        } 
else if (perc >= 85 && perc < 90) {
    console.log("Grade-A+ and Grade Point- 9.0 ");
        } 
else if (perc >= 80 && perc < 85) {
    console.log("Grade-A and Grade Point- 8.5 "); 
        }
else if (perc >= 75 && perc < 80) {
    console.log("Grade-B+ and Grade Point- 8.0 "); 
        } 
else if (perc >= 70 && perc < 75) {
    console.log("Grade-B and Grade Point- 7.5 "); 
}
else if (perc >= 65 && perc < 70) {
    console.log("Grade-C+ and Grade Point- 7.0 "); 
}
}
percen(86)