namespace CIS.Data.DataAccess
{
    using CIS.Data.DataAccess.Mapping;
    using CIS.Data.Entities;
    using System.Data.Entity;

    public class ClinicModel : DbContext
    {
        // El contexto se ha configurado para usar una cadena de conexión 'ClinicModel' del archivo 
        // de configuración de la aplicación (App.config o Web.config). De forma predeterminada, 
        // esta cadena de conexión tiene como destino la base de datos 'Data_Access.ClinicModel' de la instancia LocalDb. 
        // 
        // Si desea tener como destino una base de datos y/o un proveedor de base de datos diferente, 
        // modifique la cadena de conexión 'ClinicModel'  en el archivo de configuración de la aplicación.
        public ClinicModel()
            : base("ClinicModel")
        {
            Database.SetInitializer(new ClinicInitializer());
        }

        // Agregue un DbSet para cada tipo de entidad que desee incluir en el modelo. Para obtener más información 
        // sobre cómo configurar y usar un modelo Code First, vea http://go.microsoft.com/fwlink/?LinkId=390109.

        public virtual DbSet<ClinicTable> Clinicians { get; set; }
        public virtual DbSet<PatientTable> Patients { get; set; }
        public virtual DbSet<UserTable> Users { get; set; }
        public virtual DbSet<AppointmentTable> Appointments { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add<ClinicTable>(new ClinicConfiguration());
            modelBuilder.Configurations.Add<UserTable>(new UserConfiguration());
            modelBuilder.Configurations.Add<AppointmentTable>(new AppointmentConfiguration());
            modelBuilder.Configurations.Add<PatientTable>(new PatientConfiguration());

            base.OnModelCreating(modelBuilder);
        }
    }
}