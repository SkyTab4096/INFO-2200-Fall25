/*
Name: Kory Anderson
Class: INFO 2200
Section: 001
Professor: Sharp
Date: November 10, 2025
Participation or Assignment #: 05
By submitting this assignment, I declare that the source code contained in this assignment was written solely by me, unless specifically provided in the assignment. I attest that no part of this assignment, in whole or in part, was directly created by Generative AI, unless explicitly stated in the assignment instructions, nor obtained from a subscription service. I understand that copying any source code, in whole or in part, unless specifically provided in the assignment, constitutes cheating, and that I will receive a zero on this project if I am found in violation of this policy.
*/

using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace _2200_AndersonK_Assignment05
{
    public class JellyBellyDB : DbContext
    {
        // Your context has been configured to use a 'JellyBellyDB' connection string from your application's 
        // configuration file (App.config or Web.config). By default, this connection string targets the 
        // '_2200_AndersonK_Assignment05.JellyBellyDB' database on your LocalDb instance. 
        // 
        // If you wish to target a different database and/or database provider, modify the 'JellyBellyDB' 
        // connection string in the application configuration file.
        public JellyBellyDB()
            : base("name=JellyBellyDB")
        {
        }

        // Add a DbSet for each entity type that you want to include in your model. For more information 
        // on configuring and using a Code First model, see http://go.microsoft.com/fwlink/?LinkId=390109.

        public virtual DbSet<JellyBelly> JellyBellies { get; set; }
    }

    /// <summary>
    /// Create the new class for each jelly belly flavor, while also creating the code to create the database
    /// </summary>
    [Table("JellyBellyTable")]
    public class JellyBelly
    {
        // Sets up the integar value for the id number for the jelly bean.  Also sets the id number as the primary key for the table
        [Key]
        public int JellyBellyId { get; set; }

        // Sets up the string value for the flavor for the jelly bean.  Also sets the flavor as a value in the database.
        [StringLength(50)]
        public string jellyBellyFlavor { get; set; }

        // Sets up the string value for the category for the jelly bean.  Also sets the category as a value in the database.
        [StringLength(50)]
        public string category { get; set; }
    }
}