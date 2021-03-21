using System;
using System.Data.Entity;
using System.Linq;
using TaskElreefelmasry2.Models;

namespace TaskElreefelmasry2.DB
{
    public class Test : DbContext
    {
        // Your context has been configured to use a 'Test' connection string from your application's 
        // configuration file (App.config or Web.config). By default, this connection string targets the 
        // 'TaskElreefelmasry2.DB.Test' database on your LocalDb instance. 
        // 
        // If you wish to target a different database and/or database provider, modify the 'Test' 
        // connection string in the application configuration file.
        public Test()
            : base("name=Test")
        {
        }

        // Add a DbSet for each entity type that you want to include in your model. For more information 
        // on configuring and using a Code First model, see http://go.microsoft.com/fwlink/?LinkId=390109.

         public virtual DbSet<Booklets>  Booklets { get; set; }
         public virtual DbSet<BookletSales>  BookletSales { get; set; }
    }

    //public class MyEntity
    //{
    //    public int Id { get; set; }
    //    public string Name { get; set; }
    //}
}