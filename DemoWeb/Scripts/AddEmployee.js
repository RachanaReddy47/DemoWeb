function Add() {
    var eno = document.getElementById("txtEmployeeNo").value;
    var ename = document.getElementById("txtEmployeeName").value;
    var job = document.getElementById("txtJob").value;
    var MGR=  document.getElementById("txtMGR").value;
    var HireDate =document.getElementById("txtHireDate").value;
    var Salary = document.getElementById("txtSalary").value;
    var Commission = document.getElementById("txtCommission").value;
    var DepartmentNo = document.getElementById("txtDepartmentNo").value;



    if (eno.length == 0 || ename.length == 0 || job.length==0 || MGR.length==0 || HireDate.length==0 || Salary.length==0 || Commission.length==0|| DepartmentNo.length ==0)
    {
        alert("Enter all details");
        return false;
    }
    else
        return true;
}