function Validate()
{
    var un = document.getElementById("txtUsername").value;
    var pwd = document.getElementById("txtPassword").value;
    if (un.length == 0 || pwd.length == 0) {
        alert("Enter Username/Password");
        return false;
    }
    else
        return true;
}