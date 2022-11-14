namespace AutomatedMigrationPOC.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using AutomatedMigrationPOC.Models;
    using System.Collections.Generic;
  
    internal sealed class Configuration : DbMigrationsConfiguration<AutomatedMigrationPOC.Models.RecordContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(AutomatedMigrationPOC.Models.RecordContext context)
        {
            var students = new List<Student>
            {
            new Student{Name="Ragini",Email="r@gmail.com",Course="Java", Contact="+919999999999"},
            new Student{Name="Ragini Singh",Email="ragini@gmail.com",Course="C Programming Language", Contact="+919999999999"},
            new Student{Name="Ragini Ragini",Email="raginibxr@gmail.com",Course="DSA", Contact="+919999999999"},
            new Student{Name="R Singh",Email="raginiragini@gmail.com",Course="Web Technology", Contact="+919999999999"},
            };
            students.ForEach(s => context.Students.Add(s));
            context.SaveChanges();
        }

    }
}  
