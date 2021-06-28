using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace HMS.DBO.Models
{
    public partial class HospitalManagementContext : DbContext
    {
        //public HospitalManagementContext()
        //{
        //}

        public HospitalManagementContext(DbContextOptions<HospitalManagementContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Allergy> Allergy { get; set; }
        public virtual DbSet<AllergyType> AllergyType { get; set; }
        public virtual DbSet<Appointment> Appointment { get; set; }
        public virtual DbSet<Dashboard> Dashboard { get; set; }
        public virtual DbSet<Diagnosis> Diagnosis { get; set; }
        public virtual DbSet<DrugData> DrugData { get; set; }
        public virtual DbSet<ExceptionLog> ExceptionLog { get; set; }
        public virtual DbSet<Login> Login { get; set; }
        public virtual DbSet<Nurse> Nurse { get; set; }
        public virtual DbSet<Patient> Patient { get; set; }
        public virtual DbSet<PatientAllergyDetails> PatientAllergyDetails { get; set; }
        public virtual DbSet<PatientMedicationDetails> PatientMedicationDetails { get; set; }
        public virtual DbSet<PatientVisitDignosisDetails> PatientVisitDignosisDetails { get; set; }
        public virtual DbSet<PatientVisitProcedureDetails> PatientVisitProcedureDetails { get; set; }
        public virtual DbSet<PatientVitalDetails> PatientVitalDetails { get; set; }
        public virtual DbSet<Physician> Physician { get; set; }
        public virtual DbSet<Procedure> Procedure { get; set; }
        public virtual DbSet<Role> Role { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
//            if (!optionsBuilder.IsConfigured)
//            {
//#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
//                optionsBuilder.UseSqlServer("Data Source=IMCMBCP129-MSL2\\SQLEXPRESS2017;Initial Catalog=HospitalManagement;User Id=Citiustechdemo;Password=Citiustech_2222;MultipleActiveResultSets=true");
//            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Allergy>(entity =>
            {
                entity.HasKey(e => e.AllergyId)
                    .HasName("PK_Allergy_Id");

                entity.Property(e => e.AllergyId)
                    .HasColumnName("Allergy_Id")
                    .ValueGeneratedNever();

                entity.Property(e => e.AllergyClinicalInformation).HasColumnName("Allergy_Clinical_Information");

                entity.Property(e => e.AllergyDescription).HasColumnName("Allergy_Description");

                entity.Property(e => e.AllergyName)
                    .HasColumnName("Allergy_Name")
                    .HasMaxLength(100);

                entity.Property(e => e.AllergyType)
                    .HasColumnName("Allergy_Type")
                    .HasMaxLength(50);

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<AllergyType>(entity =>
            {
                entity.HasKey(e => e.AllergyId)
                    .HasName("PK_AllergyId");

                entity.ToTable("Allergy_Type");

                entity.Property(e => e.AllergyId)
                    .HasColumnName("Allergy_Id")
                    .ValueGeneratedNever();

                entity.Property(e => e.AllergyCode)
                    .HasColumnName("Allergy_Code")
                    .HasMaxLength(50);

                entity.Property(e => e.AllergyType1)
                    .HasColumnName("Allergy_Type")
                    .HasMaxLength(50);

                entity.Property(e => e.Id).ValueGeneratedOnAdd();

                entity.HasOne(d => d.Allergy)
                    .WithOne(p => p.AllergyTypeNavigation)
                    .HasForeignKey<AllergyType>(d => d.AllergyId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Allergy_Type_Allergy");
            });

            modelBuilder.Entity<Appointment>(entity =>
            {
                entity.HasKey(e => e.AppointmentId)
                    .HasName("PK_Appointment_Id");

                entity.Property(e => e.AppointmentId)
                    .HasColumnName("Appointment_Id")
                    .HasMaxLength(50);

                entity.Property(e => e.AppointmentDate)
                    .HasColumnName("Appointment_Date")
                    .HasColumnType("date");

                entity.Property(e => e.AppointmentStatus)
                    .HasColumnName("Appointment_status")
                    .HasMaxLength(50);

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.MeetingTitle)
                    .HasColumnName("Meeting_Title")
                    .HasMaxLength(50);

                entity.Property(e => e.NurseId)
                    .IsRequired()
                    .HasColumnName("Nurse_Id")
                    .HasMaxLength(50);

                entity.Property(e => e.PatientId)
                    .IsRequired()
                    .HasColumnName("Patient_ID")
                    .HasMaxLength(50);

                entity.Property(e => e.PhysicianId)
                    .IsRequired()
                    .HasColumnName("Physician_Id")
                    .HasMaxLength(50);

                entity.Property(e => e.ScheduledDate)
                    .HasColumnName("Scheduled_Date")
                    .HasColumnType("date");

                entity.Property(e => e.ScheduledTime).HasColumnName("Scheduled_Time");

                entity.Property(e => e.Ssn)
                    .HasColumnName("SSN")
                    .HasMaxLength(50);

                entity.Property(e => e.StatusReason)
                    .HasColumnName("Status_Reason")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<Dashboard>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.CountOfPatientDiagnosed)
                    .HasColumnName("Count_Of_Patient_Diagnosed")
                    .HasMaxLength(50);

                entity.Property(e => e.EmployeeId).HasColumnName("Employee_id");

                entity.Property(e => e.LastUpdatedOn)
                    .HasColumnName("last_updated_on")
                    .HasColumnType("datetime");

                entity.Property(e => e.PendingCount).HasColumnName("Pending_Count");
            });

            modelBuilder.Entity<Diagnosis>(entity =>
            {
                entity.HasKey(e => e.DiagnosisId);

                entity.Property(e => e.DiagnosisId)
                    .HasColumnName("Diagnosis_Id")
                    .ValueGeneratedNever();

                entity.Property(e => e.DiagnosisCode)
                    .HasColumnName("Diagnosis_Code")
                    .HasMaxLength(50);

                entity.Property(e => e.DiagnosisDescription).HasColumnName("Diagnosis_Description");

                entity.Property(e => e.DiagnosisIsDepricated).HasColumnName("Diagnosis_Is_Depricated");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<DrugData>(entity =>
            {
                entity.HasKey(e => e.DrugId);

                entity.Property(e => e.DrugId)
                    .HasColumnName("Drug_ID")
                    .ValueGeneratedNever();

                entity.Property(e => e.DrugForm)
                    .HasColumnName("Drug_Form")
                    .HasMaxLength(50);

                entity.Property(e => e.DrugGenericName)
                    .HasColumnName("Drug_Generic_Name")
                    .HasMaxLength(50);

                entity.Property(e => e.DrugManufacturerName)
                    .HasColumnName("Drug_Manufacturer_Name")
                    .HasMaxLength(50);

                entity.Property(e => e.DrugName)
                    .HasColumnName("Drug_Name")
                    .HasMaxLength(50);

                entity.Property(e => e.DrugStrength)
                    .HasColumnName("Drug_Strength")
                    .HasMaxLength(50);

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<ExceptionLog>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.ExeptionMsg).HasColumnName("Exeption_msg");

                entity.Property(e => e.LoggedOn)
                    .HasColumnName("Logged_on")
                    .HasColumnType("datetime");
            });

            modelBuilder.Entity<Login>(entity =>
            {
                entity.HasKey(e => e.UserId);

                entity.Property(e => e.UserId)
                    .HasColumnName("User_Id")
                    .HasMaxLength(50);

                entity.Property(e => e.AdditionalRole)
                    .HasColumnName("Additional_Role")
                    .HasMaxLength(50);

                entity.Property(e => e.CreationDate)
                    .HasColumnName("Creation_Date")
                    .HasColumnType("date");

                entity.Property(e => e.DefaultRole)
                    .HasColumnName("Default_Role")
                    .HasMaxLength(50);

                entity.Property(e => e.Email).IsRequired();

                entity.Property(e => e.EncryPassword).HasMaxLength(150);

                entity.Property(e => e.Id).ValueGeneratedOnAdd();

                entity.Property(e => e.IsEnabled).HasColumnName("Is_Enabled");

                entity.Property(e => e.OtpRequired)
                    .HasColumnName("OTP_Required")
                    .HasMaxLength(50);

                entity.Property(e => e.Password).HasMaxLength(50);
            });

            modelBuilder.Entity<Nurse>(entity =>
            {
                entity.HasKey(e => e.NurseId);

                entity.Property(e => e.NurseId)
                    .HasColumnName("Nurse_Id")
                    .HasMaxLength(50);

                entity.Property(e => e.Id).ValueGeneratedOnAdd();

                entity.Property(e => e.LastUpdatedOn)
                    .HasColumnName("Last_updated_on")
                    .HasColumnType("date");

                entity.Property(e => e.NurseName)
                    .HasColumnName("Nurse_Name")
                    .HasMaxLength(50);

                entity.Property(e => e.Ssn)
                    .HasColumnName("SSN")
                    .HasMaxLength(50);

                entity.HasOne(d => d.NurseNavigation)
                    .WithOne(p => p.Nurse)
                    .HasForeignKey<Nurse>(d => d.NurseId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Nurse_Login");
            });

            modelBuilder.Entity<Patient>(entity =>
            {
                entity.HasKey(e => e.PatientId);

                entity.Property(e => e.PatientId)
                    .HasColumnName("Patient_ID")
                    .HasMaxLength(50);

                entity.Property(e => e.AccessFlag)
                    .HasColumnName("Access_Flag")
                    .HasMaxLength(20);

                entity.Property(e => e.ContactNumber)
                    .HasColumnName("Contact_Number")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Dob)
                    .HasColumnName("DOB")
                    .HasColumnType("date");

                entity.Property(e => e.EmergencyAddress)
                    .HasColumnName("Emergency_Address")
                    .HasMaxLength(50);

                entity.Property(e => e.EmergencyEmail)
                    .HasColumnName("Emergency_Email")
                    .HasMaxLength(50);

                entity.Property(e => e.EmergencyFname)
                    .HasColumnName("Emergency_Fname")
                    .HasMaxLength(50);

                entity.Property(e => e.EmergencyLname)
                    .HasColumnName("Emergency_Lname")
                    .HasMaxLength(50);

                entity.Property(e => e.EmergencyMobileNo)
                    .HasColumnName("Emergency_Mobile_No")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Ethinicity).HasMaxLength(50);

                entity.Property(e => e.Fname)
                    .HasColumnName("FName")
                    .HasMaxLength(50);

                entity.Property(e => e.Gender).HasMaxLength(10);

                entity.Property(e => e.HomeAddress)
                    .HasColumnName("Home_Address")
                    .HasMaxLength(50);

                entity.Property(e => e.Id).ValueGeneratedOnAdd();

                entity.Property(e => e.IsAllergyFatal).HasColumnName("Is_Allergy_Fatal");

                entity.Property(e => e.LanguagesKnown)
                    .HasColumnName("Languages_Known")
                    .HasMaxLength(50);

                entity.Property(e => e.Lname)
                    .HasColumnName("LName")
                    .HasMaxLength(50);

                entity.Property(e => e.Race).HasMaxLength(50);

                entity.Property(e => e.RegistrationDate)
                    .HasColumnName("Registration_Date")
                    .HasColumnType("date");

                entity.Property(e => e.Relationship)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Ssn)
                    .HasColumnName("SSN")
                    .HasMaxLength(50);

                entity.Property(e => e.Title).HasMaxLength(50);

                entity.Property(e => e.TypeofAllergies)
                    .HasColumnName("Typeof_Allergies")
                    .HasMaxLength(50);

                entity.HasOne(d => d.PatientNavigation)
                    .WithOne(p => p.Patient)
                    .HasForeignKey<Patient>(d => d.PatientId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Patient_Login");
            });

            modelBuilder.Entity<PatientAllergyDetails>(entity =>
            {
                entity.HasKey(e => e.PatientId)
                    .HasName("PK_Patient_Id");

                entity.Property(e => e.PatientId)
                    .HasColumnName("Patient_Id")
                    .HasMaxLength(50);

                entity.Property(e => e.AllergyId).HasColumnName("Allergy_Id");

                entity.Property(e => e.AllergyType)
                    .HasColumnName("Allergy_Type")
                    .HasMaxLength(50);

                entity.Property(e => e.Id).ValueGeneratedOnAdd();

                entity.Property(e => e.LastModifiedDate)
                    .HasColumnName("LastModified_Date")
                    .HasColumnType("date");

                entity.HasOne(d => d.Allergy)
                    .WithMany(p => p.PatientAllergyDetails)
                    .HasForeignKey(d => d.AllergyId)
                    .HasConstraintName("FK_PatientAllergyDetails_Allergy");
            });

            modelBuilder.Entity<PatientMedicationDetails>(entity =>
            {
                entity.HasKey(e => e.AppointmentId)
                    .HasName("PK_Appointments_Id");

                entity.Property(e => e.AppointmentId)
                    .HasColumnName("Appointment_Id")
                    .HasMaxLength(50);

                entity.Property(e => e.Dosage).HasMaxLength(50);

                entity.Property(e => e.Id).ValueGeneratedOnAdd();

                entity.Property(e => e.Medication).HasMaxLength(50);

                entity.Property(e => e.MedicationFrequency)
                    .HasColumnName("Medication_Frequency")
                    .HasMaxLength(100);

                entity.Property(e => e.MedicationStrength)
                    .HasColumnName("Medication_Strength")
                    .HasMaxLength(150);

                entity.Property(e => e.PatientId)
                    .IsRequired()
                    .HasColumnName("Patient_Id")
                    .HasMaxLength(50);

                entity.Property(e => e.PhysicianCheckupDate)
                    .HasColumnName("Physician_Checkup_Date")
                    .HasColumnType("date");

                entity.Property(e => e.PreRequisite)
                    .HasColumnName("Pre_Requisite")
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.HasOne(d => d.Patient)
                    .WithMany(p => p.PatientMedicationDetails)
                    .HasForeignKey(d => d.PatientId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PatientMedicationDetails_Patient");
            });

            modelBuilder.Entity<PatientVisitDignosisDetails>(entity =>
            {
                entity.HasKey(e => e.AppointmentId)
                    .HasName("PK_App_Id");

                entity.Property(e => e.AppointmentId)
                    .HasColumnName("Appointment_Id")
                    .HasMaxLength(50);

                entity.Property(e => e.DignosisCode)
                    .HasColumnName("Dignosis_Code")
                    .HasMaxLength(50);

                entity.Property(e => e.Id).ValueGeneratedOnAdd();

                entity.Property(e => e.PatientId)
                    .IsRequired()
                    .HasColumnName("Patient_Id")
                    .HasMaxLength(50);

                entity.Property(e => e.PhysicianCheckupDate)
                    .HasColumnName("Physician_Checkup_Date")
                    .HasColumnType("date");

                entity.HasOne(d => d.Patient)
                    .WithMany(p => p.PatientVisitDignosisDetails)
                    .HasForeignKey(d => d.PatientId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PatientVisitDignosisDetails_Patient");
            });

            modelBuilder.Entity<PatientVisitProcedureDetails>(entity =>
            {
                entity.HasKey(e => e.AppointmentId)
                    .HasName("PK_Apmnt_Id");

                entity.Property(e => e.AppointmentId)
                    .HasColumnName("Appointment_Id")
                    .HasMaxLength(50);

                entity.Property(e => e.Id).ValueGeneratedOnAdd();

                entity.Property(e => e.PatientId)
                    .IsRequired()
                    .HasColumnName("Patient_Id")
                    .HasMaxLength(50);

                entity.Property(e => e.PhysicianCheckupDate)
                    .HasColumnName("Physician_Checkup_Date")
                    .HasColumnType("date");

                entity.Property(e => e.ProcedureCode)
                    .IsRequired()
                    .HasColumnName("Procedure_Code");

                entity.HasOne(d => d.Patient)
                    .WithMany(p => p.PatientVisitProcedureDetails)
                    .HasForeignKey(d => d.PatientId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PatientVisitProcedureDetails_Patient");
            });

            modelBuilder.Entity<PatientVitalDetails>(entity =>
            {
                entity.HasKey(e => e.AppointmentId)
                    .HasName("PK_AppId");

                entity.Property(e => e.AppointmentId)
                    .HasColumnName("Appointment_Id")
                    .HasMaxLength(50);

                entity.Property(e => e.BodyTemp)
                    .HasColumnName("Body_Temp")
                    .HasColumnType("decimal(18, 0)");

                entity.Property(e => e.Bp)
                    .HasColumnName("BP")
                    .HasMaxLength(50);

                entity.Property(e => e.Height).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.Id).ValueGeneratedOnAdd();

                entity.Property(e => e.PatientId)
                    .IsRequired()
                    .HasColumnName("Patient_Id")
                    .HasMaxLength(50);

                entity.Property(e => e.RecordedDate)
                    .HasColumnName("Recorded_date")
                    .HasColumnType("date");

                entity.Property(e => e.RespirationRate)
                    .HasColumnName("Respiration_Rate")
                    .HasColumnType("decimal(18, 0)");

                entity.Property(e => e.Weight).HasColumnType("decimal(18, 0)");

                entity.HasOne(d => d.Appointment)
                    .WithOne(p => p.PatientVitalDetails)
                    .HasForeignKey<PatientVitalDetails>(d => d.AppointmentId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PatientVitalDetails_Appointment");
            });

            modelBuilder.Entity<Physician>(entity =>
            {
                entity.HasKey(e => e.PhysicianId);

                entity.Property(e => e.PhysicianId)
                    .HasColumnName("Physician_Id")
                    .HasMaxLength(50);

                entity.Property(e => e.Id).ValueGeneratedOnAdd();

                entity.Property(e => e.LastUpdatedOn)
                    .HasColumnName("Last_updated_on")
                    .HasColumnType("date");

                entity.Property(e => e.PhysicianName)
                    .HasColumnName("Physician_Name")
                    .HasMaxLength(50);

                entity.Property(e => e.Ssn)
                    .HasColumnName("SSN")
                    .HasMaxLength(50);

                entity.Property(e => e.Title).HasMaxLength(50);

                entity.HasOne(d => d.PhysicianNavigation)
                    .WithOne(p => p.Physician)
                    .HasForeignKey<Physician>(d => d.PhysicianId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Physician_Login");
            });

            modelBuilder.Entity<Procedure>(entity =>
            {
                entity.Property(e => e.ProcedureId).HasColumnName("Procedure_Id");

                entity.Property(e => e.ProcedureCode)
                    .HasColumnName("Procedure_Code")
                    .HasMaxLength(50);

                entity.Property(e => e.ProcedureDescription).HasColumnName("Procedure_Description");

                entity.Property(e => e.ProcedureIsDepricated).HasColumnName("Procedure_Is_Depricated");
            });

            modelBuilder.Entity<Role>(entity =>
            {
                entity.Property(e => e.RoleId).HasColumnName("Role_Id");

                entity.Property(e => e.RoleType)
                    .HasColumnName("Role_Type")
                    .HasMaxLength(50);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
