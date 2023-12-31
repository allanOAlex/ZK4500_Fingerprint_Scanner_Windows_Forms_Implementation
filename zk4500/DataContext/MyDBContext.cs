﻿//using MySql.Data.MySqlClient;
using System.Data.Common;
using System.Data.Entity;
using zk4500.Entities;

namespace zk4500.DataContext
{
    //[DbConfigurationType(typeof(MySqlConfiguration))]
    public class MyDBContext : DbContext
    {
        public MyDBContext() : base()
        {

        }
        public MyDBContext(DbConnection existingConnection, bool contextOwnsConnection) : base(existingConnection, contextOwnsConnection)
        {

        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }


        public DbSet<FingerPrint> FingerPrints { get; set; }
        public DbSet<Patient> Patients { get; set; }
        public DbSet<PatientForVerification> PatientForVerifications { get; set; }


    }
}
