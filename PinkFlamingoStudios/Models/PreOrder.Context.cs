﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PinkFlamingoStudios.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class PinkFlamingosEntities : DbContext
    {
        public PinkFlamingosEntities()
            : base("name=PinkFlamingosEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<billingAddress> billingAddresses { get; set; }
        public virtual DbSet<creditCardInfo> creditCardInfoes { get; set; }
        public virtual DbSet<PreOrder> PreOrders { get; set; }
    }
}
