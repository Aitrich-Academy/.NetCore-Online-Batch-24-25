function validateForm()
{
    var name=document.getElementById("name").value;
    var email=document.getElementById("email").value;
    var phone=document.getElementById("phone").value;
    var role=document.getElementById("role").value;
    var location=document.getElementById("location").value; 
    var website=document.getElementById("website").value;
     if(name==null  || name=="")
    {
        alert("Please Enter Name");
        return false;
    }
  
    if(email==null || email=="")
    {
        alert("Please Enter Email");
        return false;
    }
    
    let emailPattern =  /^[^\s@]+@[^\s@]+\.[^\s@]+$/;
    if(!email.match(emailPattern)){
      alert("invalid email format");
      return false;
    }
   
    let phonepattern=/^[6-9]\d{9}$/;
    if(!phone.match(phonepattern)){
        alert("phone number must be 10 digits")
        return false;
    }
    if(phone==null  || phone=="")
    {
        alert("Please Enter Phone Number");
        return false;
    }


  
    if(role=="" || role==null)
    {
        alert("Please Enter Role");
        return false;
    }
    if(location==null || location=="")
    {
        alert("Please Enter Location");
        return false;
    }
    let websitePattern = /^(https?:\/\/)?([a-z0-9]+[.]){1,2}[a-z]{2,6}(\/[a-z0-9%_.~+=-]*)*$/;
    if(website==null || website=="")
    {
        alert("Please Enter Website");
        return false;
   
    }
   
    else if (!website.match(websitePattern)) {
        alert("Please enter a valid website (e.g., http://example.com)");
        return false;
    }
    return true;
} 

// function validateMail()
// {
//     let emailPattern =  /^[^\s@]+@[^\s@]+\.[^\s@]+$/;
//     if(!email.match(emailPattern)){
//       alert("invalid email format");
//       return false;
//     }
//    return true;
// }
