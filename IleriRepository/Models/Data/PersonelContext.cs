namespace IleriRepository.Models.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity;
    using System.Linq;

    public class PersonelContext : DbContext
    {
        // Your context has been configured to use a 'PersonelContext' connection string from your application's 
        // configuration file (App.config or Web.config). By default, this connection string targets the 
        // 'IleriRepository.Models.Data.PersonelContext' database on your LocalDb instance. 
        // 
        // If you wish to target a different database and/or database provider, modify the 'PersonelContext' 
        // connection string in the application configuration file.
        public PersonelContext()
            : base("name=Baglanti")
        {
        }

        // Add a DbSet for each entity type that you want to include in your model. For more information 
        // on configuring and using a Code First model, see http://go.microsoft.com/fwlink/?LinkId=390109.

        public virtual DbSet<Personel> Personel{ get; set; }
        public virtual DbSet<Sehir> Sehir{ get; set; }
        public virtual DbSet<Egitim> Egitim { get; set; }
    }
    [Table("Personel")]
    public class Personel
    {
        [Key]
        public int PersonelId { get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public int SehirId { get; set; }
        public int EgitimId { get; set; }
        [ForeignKey("SehirId")]
        public virtual Sehir Sehir{ get; set; }
        [ForeignKey("EgitimId")]
        public virtual Egitim Egitim { get; set; }
    }
    [Table("Sehir")]
    public class Sehir
    {
        public Sehir()
        {
            Personeller = new HashSet<Personel>();
        }
        [Key]
        public int SehirId { get; set; }
        public string SehirAd { get; set; }
        public virtual ICollection<Personel> Personeller{ get; set; }
    }
    [Table("Egitim")]
    public class Egitim
    {
        public Egitim()
        {
            Personeller = new HashSet<Personel>();
        }
        [Key]
        public int EgitimId { get; set; }
        public string EgitimAd { get; set; }
        public virtual ICollection<Personel> Personeller { get; set; }
    }
}