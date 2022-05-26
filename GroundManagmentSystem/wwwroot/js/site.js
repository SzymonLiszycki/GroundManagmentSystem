var zero = 0;

function sum_value(id) {
    
    
    var value = parseInt(document.getElementById(id).value);
    
    if (value > 0) {
        zero += value;
        event.target.style.backgroundColor = "yellow";
        document.getElementById("total_value").innerHTML = "<p11>SUMOWANIE</p11>";
        document.getElementById("total_value").style.backgroundColor = "lightblue";
        document.getElementById("total").style.backgroundColor = "white";
        
        const clear_btn = document.getElementById("total").innerHTML = '<div id="temp_div" class="rounded-start" style="font-size: 12px;position:relative; bottom:0px;left:0px; height:34px;width:180px;background-color: red;"></div><p_temp_div id="p_temp_div"></p_temp_div><button onclick="clear_sum()" class="rounded-end btn btn-warning " style="position:relative; bottom:34px;left:89px; height:33px;width:85px;">Wyczyść</button>';
        document.getElementById("p_temp_div").innerHTML = zero;
        document.getElementById(id).disabled = true;


        
    }

}
function clear_sum() {
   
    location.reload();
}
function dosmth(val) {
    
    var sum = parseInt(val);
    if (sum > 0) {

       
        console.log(zero += sum);
        
        event.target.style.backgroundColor = "yellow";
        
       
    }

    
   
}
//onclick="dosomething(this.value)"
//