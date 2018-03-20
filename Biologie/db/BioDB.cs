namespace Biologie.db
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity;
    using System.Linq;

    public class BioDB : DbContext
    {
        // Your context has been configured to use a 'BioDB' connection string from your application's 
        // configuration file (App.config or Web.config). By default, this connection string targets the 
        // 'Biologie.db.BioDB' database on your LocalDb instance. 
        // 
        // If you wish to target a different database and/or database provider, modify the 'BioDB' 
        // connection string in the application configuration file.
        public BioDB()
            : base("name=BioDB")
        {
        }

        // Add a DbSet for each entity type that you want to include in your model. For more information 
        // on configuring and using a Code First model, see http://go.microsoft.com/fwlink/?LinkId=390109.

        public virtual DbSet<Account> Accounts { get; set; }
        public virtual DbSet<Enunt> Enunturi { get; set; }
        public virtual DbSet<Test> Teste { get; set; }
        public virtual DbSet<Rezultat> Rezultate { get; set; }
        
        public virtual DbSet<Clasa> Clase { get; set; }
    }

    public class Account
    {
        public int Id { get; set; }
        [Column(TypeName = "nvarchar")]
        [StringLength(10)]
        [Required]
        public string User { get; set; }
        [Column(TypeName = "nvarchar")]
        [StringLength(500)]
        [Required]
        public string Password { get; set; }
        public Nullable<bool> IsAdmin { get; set; }
        [Required]
        public int ClasaId { get; set; }
        [ForeignKey("ClasaId")]
        public Clasa Clasa { get; set; }
    }

    public class Enunt
    {
        public int Id { get; set; }
        [Required]
        public int Dificultate { get; set; }
        [Column(TypeName = "nvarchar")]
        [StringLength(2000)]
        [Required]
        public string EnuntText { get; set; }
        [Required]
        public int Tip { get; set; }
        [Required]
        [Column(TypeName = "nvarchar")]
        [StringLength(2000)]
        public string Raspuns { get; set; }
        [Column(TypeName = "nvarchar")]
        [StringLength(2000)]
        public string Varianta1 { get; set; }
        [Column(TypeName = "nvarchar")]
        [StringLength(2000)]
        public string Varianta2 { get; set; }
        [Column(TypeName = "nvarchar")]
        [StringLength(2000)]
        public string Varianta3 { get; set; }
        [Column(TypeName = "nvarchar")]
        [StringLength(2000)]
        public string Varianta4 { get; set; }
        public int RaspunsA { get; set; }
    }

    public class Test
    {
        public int Id { get; set; }
        [Column(TypeName = "nvarchar")]
        [StringLength(50)]
        public string Nume { get; set; }
        [Required]
        public int ClasaId { get; set; }
        [Required]
        public int EnuntId { get; set; }
        //[ForeignKey("ClasaId")]
        //public Clasa Clasa { get; set; }
        [ForeignKey("EnuntId")]
        public Enunt Enunt { get; set; }
    }

    public class Rezultat
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        [Column(TypeName = "nvarchar")]
        [StringLength(50)]
        public string Nota { get; set; }
        public int Mark { get; set; }
        public int TestId { get; set; }
        [ForeignKey("TestId")]
        public Test Test { get; set; }
        [ForeignKey("UserId")]
        public Account Account { get; set; }
    }

    [Table("Clase")]
    public class Clasa
    {
        public int Id { get; set; }
        [Required]
        [Column(TypeName = "nvarchar")]
        [StringLength(50)]
        public string ClasaName { get; set; }
    }
}