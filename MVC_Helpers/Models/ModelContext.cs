namespace MVC_Helpers.Models
{
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class ModelContext : DbContext
    {
        // Votre contexte a été configuré pour utiliser une chaîne de connexion « ModelContext » du fichier 
        // de configuration de votre application (App.config ou Web.config). Par défaut, cette chaîne de connexion cible 
        // la base de données « MVC_Helpers.Models.ModelContext » sur votre instance LocalDb. 
        // 
        // Pour cibler une autre base de données et/ou un autre fournisseur de base de données, modifiez 
        // la chaîne de connexion « ModelContext » dans le fichier de configuration de l'application.
        public ModelContext()
            : base("name=ModelContext")
        {
        }

  
        public virtual DbSet<Student> Students { get; set; }
        public virtual DbSet<Group> Groups { get; set; }
    }


}