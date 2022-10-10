const compute=()=>{
    let amount=document.getElementById("amount").value;
    let Tip=document.getElementById("Tip").value;

    let TipAmount=parseFloat(Tip*100)/amount;
    let payment=parseFloat (amount) + parseFloat (Tip);
    document.getElementById("TipAmount").innerHTML=TipAmount.toFixed(2)+"%";
    document.getElementById("payment").innerHTML=payment.toFixed(2);

};