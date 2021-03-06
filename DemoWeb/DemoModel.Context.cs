﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DemoWeb
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class DemoEntities : DbContext
    {
        public DemoEntities()
            : base("name=DemoEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<EMPDATA> EMPDATAs { get; set; }
        public virtual DbSet<DEPTDATA> DEPTDATAs { get; set; }
        public virtual DbSet<OrderInfo> OrderInfoes { get; set; }
        public virtual DbSet<Total> Totals { get; set; }
    
        public virtual int sp_AddEmp(Nullable<int> eno, string ename, string job, Nullable<int> mgr, Nullable<System.DateTime> hdate, Nullable<int> sal, Nullable<int> com, Nullable<int> dno, ObjectParameter oP)
        {
            var enoParameter = eno.HasValue ?
                new ObjectParameter("Eno", eno) :
                new ObjectParameter("Eno", typeof(int));
    
            var enameParameter = ename != null ?
                new ObjectParameter("Ename", ename) :
                new ObjectParameter("Ename", typeof(string));
    
            var jobParameter = job != null ?
                new ObjectParameter("Job", job) :
                new ObjectParameter("Job", typeof(string));
    
            var mgrParameter = mgr.HasValue ?
                new ObjectParameter("Mgr", mgr) :
                new ObjectParameter("Mgr", typeof(int));
    
            var hdateParameter = hdate.HasValue ?
                new ObjectParameter("hdate", hdate) :
                new ObjectParameter("hdate", typeof(System.DateTime));
    
            var salParameter = sal.HasValue ?
                new ObjectParameter("sal", sal) :
                new ObjectParameter("sal", typeof(int));
    
            var comParameter = com.HasValue ?
                new ObjectParameter("Com", com) :
                new ObjectParameter("Com", typeof(int));
    
            var dnoParameter = dno.HasValue ?
                new ObjectParameter("Dno", dno) :
                new ObjectParameter("Dno", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_AddEmp", enoParameter, enameParameter, jobParameter, mgrParameter, hdateParameter, salParameter, comParameter, dnoParameter, oP);
        }
    }
}
