var zero = 0;

function sum_value(id) {
    
    
    var value = parseInt(document.getElementById(id).value);
    
    if (value > 0) {
        zero += value;
        event.target.style.backgroundColor = "black";
        event.target.style.color ='white';
        document.getElementById("total_value").innerHTML = "<p11 style='font-weight:900;font-size:20px'>SUMOWANIE</p11>";
       
        
        const clear_btn = document.getElementById("total_1").innerHTML = '<div id="temp_div" class="fifo_nazwa_isa_ilosc_total_suma border border border-secondary rounded" style="text-align:center;font-size: 20px;position:relative; bottom:-76px;left:1px;float:left;margin-right:2px; text-align:left;"></div><button onclick="clear_sum()" class="btn btn-danger" style="position:relative; bottom:-38px;left:-33px; height:34px;width:34px;float:left;text-align:center;">X</button>';
        document.getElementById("temp_div").innerHTML = zero;
       document.getElementById(id).disabled = true;


        
    }
    
}

function clear_sum() {
    zero = 0;
    document.getElementById("temp_div").innerHTML = zero;
    location.reload();
}
function dosmth(val) {
    
    var sum = parseInt(val);
    if (sum > 0) {

       
        console.log(zero += sum);
        
        event.target.style.backgroundColor = "yellow";
        
       
    }

    
   
//}

