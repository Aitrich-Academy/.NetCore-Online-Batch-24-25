// function validateUser()
// {
    
//     var email=document.getElementById("email").value;
//     var password=document.getElementById("password").value;
//     if(email=="" ||  email==null)
//     {
//         alert("Please Enter Your Email ");
//         return false;
//     }
//     if(password=="" ||  password==null)
//     {
//         alert("Please Enter Your Password ");
//         return false;
//     }
  

// }

function loginCheck()
{
    var email=document.getElementById("email").value;
    var password=document.getElementById("password").value;
    event.preventDefault();




    let emailPattern =  /^[^\s@]+@[^\s@]+\.[^\s@]+$/;
    if(!email.match(emailPattern)){
      alert("invalid email format");
      return false;
    }
     
    if(password.length<8){
        alert("password must be atleast 8 charccters")
        return false;
    }

    
    
//     if(email== "lessile@gmail.com" && password=="1234")
//     {
//         window.location = "./profile.html";
        
//         return true;
//     }
//     else{
//         alert("invalid email or password");
//         return false;
//     }
window.location = "./profile.html";
return true;
 }


