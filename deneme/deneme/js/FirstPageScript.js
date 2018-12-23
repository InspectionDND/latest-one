

for(let i = 0; i < $(".sectionBoard")[0].children.length; i++){
    
        $("button")[i].addEventListener("click", function(){
            checkUp();
            if(getComputedStyle($("button")[i]).color == "rgb(104, 103, 103)"){
                
                this.style.boxShadow = "0 0 30px rgba(33,156,243,.5), 0 0 40px rgba(33,156,243,.5), 0 0 50px rgba(33,156,243,.5), inset 0 0 30px rgba(33,156,243,.1)";
                this.style.textShadow = "0 0 30px rgba(33,156,243,.5), 0 0 40px rgba(33,156,243,.5)";
                this.style.color = "white";
            }
            else{
                
                this.style.boxShadow = "none";
                this.style.textShadow = "none";
                this.style.color = "rgb(104, 103, 103)";
            }

        })
}


function checkUp(){
    
    for(let k = 0; k < $(".sectionBoard")[0].children.length; k++){
        if(getComputedStyle($("button")[k]).color == "rgb(255, 255, 255)"){
            $("button")[k].style.boxShadow = "none";
            $("button")[k].style.textShadow = "none";
            $("button")[k].style.color = "rgb(104, 103, 103)";
        }
    }
}

let numb = 80;
let check = true;

$(".slideToggle").click(function(){


    $(".sectionBoard").slideToggle();

    
    if(check){
    let handler = setInterval(function(){
        
        
        if(numb < 98){
            numb += 1;
            
            $(".section").css("top", numb + "vh");
        }
        
        if(numb == 97){
            check = false;
            clearInterval(handler);
        }
        
        
    },30);
    }
    else {
        let handler = setInterval(function(){
        
        
            if(numb > 79){
                numb -= 1;
                
                $(".section").css("top", numb + "vh");
            }
            
            if(numb == 80 ){
                check = true;
                clearInterval(handler);
            }
            
            
        },30);
    }
    

    
  });

  
