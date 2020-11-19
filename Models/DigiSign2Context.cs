using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.Extensions.Configuration;

#nullable disable

namespace QRChecker.Models
{
    public partial class DigiSign2Context : DbContext
    {
        public DigiSign2Context()
        {
        }

        public DigiSign2Context(DbContextOptions<DigiSign2Context> options)
            : base(options)
        {
        }

        public virtual DbSet<CertificatePfx> CertificatePfxes { get; set; }
        public virtual DbSet<PplmapmasterDepartmentTm> PplmapmasterDepartmentTms { get; set; }
        public virtual DbSet<PplmapmasterWorkflowTm> PplmapmasterWorkflowTms { get; set; }
        public virtual DbSet<SignerApiFace> SignerApiFaces { get; set; }
        public virtual DbSet<SignerDelegationHistory> SignerDelegationHistories { get; set; }
        public virtual DbSet<SignerEmployee> SignerEmployees { get; set; }
        public virtual DbSet<SignerFile> SignerFiles { get; set; }
        public virtual DbSet<SignerFilesShare> SignerFilesShares { get; set; }
        public virtual DbSet<SignerHistory> SignerHistories { get; set; }
        public virtual DbSet<SignerLog> SignerLogs { get; set; }
        public virtual DbSet<SignerMClassification> SignerMClassifications { get; set; }
        public virtual DbSet<SignerMDepartment> SignerMDepartments { get; set; }
        public virtual DbSet<SignerMDocsCategory> SignerMDocsCategories { get; set; }
        public virtual DbSet<SignerMenu> SignerMenus { get; set; }
        public virtual DbSet<SignerNotification> SignerNotifications { get; set; }
        public virtual DbSet<SignerNotificationsTest> SignerNotificationsTests { get; set; }
        public virtual DbSet<SignerPayload> SignerPayloads { get; set; }
        public virtual DbSet<SignerPayloadCallback> SignerPayloadCallbacks { get; set; }
        public virtual DbSet<SignerQr> SignerQrs { get; set; }
        public virtual DbSet<SignerRequest> SignerRequests { get; set; }
        public virtual DbSet<SignerRole> SignerRoles { get; set; }
        public virtual DbSet<SignerStatus> SignerStatuses { get; set; }
        public virtual DbSet<SignerWorkflow> SignerWorkflows { get; set; }
        public virtual DbSet<TempSignerFile> TempSignerFiles { get; set; }
        public virtual DbSet<TempSignerRequest> TempSignerRequests { get; set; }
        public virtual DbSet<TempSignerWorkflow> TempSignerWorkflows { get; set; }
        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<ViewWorkflow> ViewWorkflows { get; set; }
        public virtual DbSet<ViewWorkflowById> ViewWorkflowByIds { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                //#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                IConfigurationRoot configuration = new ConfigurationBuilder()
                    .SetBasePath(AppDomain.CurrentDomain.BaseDirectory)
                    .AddJsonFile("appsettings.json")
                    .Build();
                optionsBuilder.UseSqlServer(configuration.GetConnectionString("DefaultConnection"));
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CertificatePfx>(entity =>
            {
                entity.HasKey(e => e.CertId)
                    .HasName("PK__certific__024B46EC58963D0A");

                entity.ToTable("certificate_pfx");

                entity.Property(e => e.CertId).HasColumnName("cert_id");

                entity.Property(e => e.CertFile)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("cert_file");

                entity.Property(e => e.CertPassword)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("cert_password");

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("created_by");

                entity.Property(e => e.CreatedTime)
                    .HasColumnName("created_time")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.EmployeeId)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("employee_id");

                entity.Property(e => e.ExpiredFrom)
                    .HasColumnType("date")
                    .HasColumnName("expired_from");

                entity.Property(e => e.ExpiredTo)
                    .HasColumnType("date")
                    .HasColumnName("expired_to");
            });

            modelBuilder.Entity<PplmapmasterDepartmentTm>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("PPLMAPMasterDepartment_TM");

                entity.Property(e => e.COfficeId)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("C_OFFICE_ID");

                entity.Property(e => e.CRegion)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("C_REGION");

                entity.Property(e => e.CRegionDescr)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("C_REGION_DESCR");

                entity.Property(e => e.DeptDescr)
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .HasColumnName("DEPT_DESCR");

                entity.Property(e => e.Deptid)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("DEPTID");

                entity.Property(e => e.Effdt)
                    .HasColumnType("datetime")
                    .HasColumnName("EFFDT");

                entity.Property(e => e.Level00Id)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("Level00_ID");

                entity.Property(e => e.Level00Name)
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .HasColumnName("Level00_NAME");

                entity.Property(e => e.Level01Id)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("Level01_ID");

                entity.Property(e => e.Level01Name)
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .HasColumnName("Level01_NAME");

                entity.Property(e => e.Level02Id)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("Level02_ID");

                entity.Property(e => e.Level02Name)
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .HasColumnName("Level02_NAME");

                entity.Property(e => e.Level03Id)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("Level03_ID");

                entity.Property(e => e.Level03Name)
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .HasColumnName("Level03_NAME");

                entity.Property(e => e.Level04Id)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("Level04_ID");

                entity.Property(e => e.Level04Name)
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .HasColumnName("Level04_NAME");

                entity.Property(e => e.Level05Id)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("Level05_ID");

                entity.Property(e => e.Level05Name)
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .HasColumnName("Level05_NAME");

                entity.Property(e => e.Level06Id)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("Level06_ID");

                entity.Property(e => e.Level06Name)
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .HasColumnName("Level06_NAME");

                entity.Property(e => e.Level07Id)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("Level07_ID");

                entity.Property(e => e.Level07Name)
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .HasColumnName("Level07_NAME");

                entity.Property(e => e.Level08Id)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("Level08_ID");

                entity.Property(e => e.Level08Name)
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .HasColumnName("Level08_NAME");

                entity.Property(e => e.LevelDescr)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("LEVEL_DESCR");

                entity.Property(e => e.LevelId).HasColumnName("LEVEL_ID");

                entity.Property(e => e.Location)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("LOCATION");

                entity.Property(e => e.LocationDescr)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("LOCATION_DESCR");

                entity.Property(e => e.ManagerDescr)
                    .IsUnicode(false)
                    .HasColumnName("MANAGER_DESCR");

                entity.Property(e => e.ManagerId)
                    .HasMaxLength(11)
                    .IsUnicode(false)
                    .HasColumnName("MANAGER_ID");

                entity.Property(e => e.ManagerLoop).HasColumnName("MANAGER_LOOP");

                entity.Property(e => e.ManagerName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("MANAGER_NAME");

                entity.Property(e => e.ManagerPosn)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("MANAGER_POSN");
            });

            modelBuilder.Entity<PplmapmasterWorkflowTm>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("PPLMAPMasterWorkflow_TM");

                entity.Property(e => e.ApprovalDottedLine)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("APPROVAL_DOTTED_LINE");

                entity.Property(e => e.ApprovalDottedLineDescr)
                    .IsUnicode(false)
                    .HasColumnName("APPROVAL_DOTTED_LINE_DESCR");

                entity.Property(e => e.ApprovalDottedLineId)
                    .HasMaxLength(11)
                    .IsUnicode(false)
                    .HasColumnName("APPROVAL_DOTTED_LINE_ID");

                entity.Property(e => e.ApprovalDottedLineName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("APPROVAL_DOTTED_LINE_NAME");

                entity.Property(e => e.CBenefitCostCen)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("C_BENEFIT_COST_CEN");

                entity.Property(e => e.CCostCentre)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("C_COST_CENTRE");

                entity.Property(e => e.Deptid)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("DEPTID");

                entity.Property(e => e.DivDescr)
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .HasColumnName("DIV_DESCR");

                entity.Property(e => e.DivId)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("DIV_ID");

                entity.Property(e => e.Effdt)
                    .HasColumnType("datetime")
                    .HasColumnName("EFFDT");

                entity.Property(e => e.EmailAddr)
                    .HasMaxLength(70)
                    .IsUnicode(false)
                    .HasColumnName("EMAIL_ADDR");

                entity.Property(e => e.Emplid)
                    .HasMaxLength(11)
                    .IsUnicode(false)
                    .HasColumnName("EMPLID");

                entity.Property(e => e.GroupDescr)
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .HasColumnName("GROUP_DESCR");

                entity.Property(e => e.GroupId)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("GROUP_ID");

                entity.Property(e => e.Jobcode)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("JOBCODE");

                entity.Property(e => e.JobcodeDescr)
                    .IsUnicode(false)
                    .HasColumnName("JOBCODE_DESCR");

                entity.Property(e => e.Location)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("LOCATION");

                entity.Property(e => e.MaManagerDescr)
                    .IsUnicode(false)
                    .HasColumnName("MA_MANAGER_DESCR");

                entity.Property(e => e.MaManagerId)
                    .HasMaxLength(11)
                    .IsUnicode(false)
                    .HasColumnName("MA_MANAGER_ID");

                entity.Property(e => e.MaManagerName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("MA_MANAGER_NAME");

                entity.Property(e => e.MaManagerPosn)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("MA_MANAGER_POSN");

                entity.Property(e => e.ManagerDescr)
                    .IsUnicode(false)
                    .HasColumnName("MANAGER_DESCR");

                entity.Property(e => e.ManagerId)
                    .HasMaxLength(11)
                    .IsUnicode(false)
                    .HasColumnName("MANAGER_ID");

                entity.Property(e => e.ManagerName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("MANAGER_NAME");

                entity.Property(e => e.ManagerPosn)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("MANAGER_POSN");

                entity.Property(e => e.MaxEmplRcd).HasColumnName("MAX_EMPL_RCD");

                entity.Property(e => e.NameDisplay)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("NAME_DISPLAY");

                entity.Property(e => e.NameLogin)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("NAME_LOGIN");

                entity.Property(e => e.NdmCstcenDescr)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("NDM_CSTCEN_DESCR");

                entity.Property(e => e.NdmDeptidDescr)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("NDM_DEPTID_DESCR");

                entity.Property(e => e.NdmGroupDescr)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("NDM_GROUP_DESCR");

                entity.Property(e => e.NdmLocatiDescr)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("NDM_LOCATI_DESCR");

                entity.Property(e => e.NdmSubgroupDescr)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("NDM_SUBGROUP_DESCR");

                entity.Property(e => e.PositionNbr)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("POSITION_NBR");

                entity.Property(e => e.ReportDottedLine)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("REPORT_DOTTED_LINE");

                entity.Property(e => e.ReportDottedLineDescr)
                    .IsUnicode(false)
                    .HasColumnName("REPORT_DOTTED_LINE_DESCR");

                entity.Property(e => e.ReportDottedLineId)
                    .HasMaxLength(11)
                    .IsUnicode(false)
                    .HasColumnName("REPORT_DOTTED_LINE_ID");

                entity.Property(e => e.ReportDottedLineName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("REPORT_DOTTED_LINE_NAME");

                entity.Property(e => e.ReportsTo)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("REPORTS_TO");

                entity.Property(e => e.ReportsToDescr)
                    .IsUnicode(false)
                    .HasColumnName("REPORTS_TO_DESCR");

                entity.Property(e => e.ReportsToId)
                    .HasMaxLength(11)
                    .IsUnicode(false)
                    .HasColumnName("REPORTS_TO_ID");

                entity.Property(e => e.ReportsToLoop).HasColumnName("REPORTS_TO_LOOP");

                entity.Property(e => e.ReportsToName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("REPORTS_TO_NAME");

                entity.Property(e => e.UnionCd)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("UNION_CD");
            });

            modelBuilder.Entity<SignerApiFace>(entity =>
            {
                entity.HasKey(e => e.TransactionId)
                    .HasName("PK__signer_a__85C600AFA6E19DD0");

                entity.ToTable("signer_api_face");

                entity.Property(e => e.TransactionId)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("transaction_id")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreatedTime)
                    .HasColumnName("created_time")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ErrorLog)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("error_log");

                entity.Property(e => e.RequestId)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("request_id");

                entity.Property(e => e.StatusFaceapp)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("status_faceapp");

                entity.Property(e => e.UpdatedTime)
                    .HasColumnName("updated_time")
                    .HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<SignerDelegationHistory>(entity =>
            {
                entity.ToTable("signer_delegation_history");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CreatedAt).HasColumnName("created_at");

                entity.Property(e => e.Reason)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("reason");

                entity.Property(e => e.UpdatedBy).HasColumnName("updated_by");

                entity.Property(e => e.UserDelegated).HasColumnName("user_delegated");

                entity.Property(e => e.UserOrigin).HasColumnName("user_origin");
            });

            modelBuilder.Entity<SignerEmployee>(entity =>
            {
                entity.HasKey(e => e.EmployeeId)
                    .HasName("PK__signer_employee_id");

                entity.ToTable("signer_employee");

                entity.Property(e => e.EmployeeId)
                    .HasMaxLength(11)
                    .IsUnicode(false)
                    .HasColumnName("employee_id");

                entity.Property(e => e.DepartmentId)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("department_id");

                entity.Property(e => e.EmployeeEmail)
                    .HasMaxLength(70)
                    .IsUnicode(false)
                    .HasColumnName("employee_email");

                entity.Property(e => e.EmployeeName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("employee_name");

                entity.Property(e => e.LanId)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("lan_id");

                entity.Property(e => e.Lastnotification)
                    .HasColumnName("lastnotification")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.SuperiorId)
                    .HasMaxLength(11)
                    .IsUnicode(false)
                    .HasColumnName("superior_id");
            });

            modelBuilder.Entity<SignerFile>(entity =>
            {
                entity.ToTable("signer_file");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Accessibility)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("accessibility");

                entity.Property(e => e.CategoryId).HasColumnName("category_id");

                entity.Property(e => e.Company).HasColumnName("company");

                entity.Property(e => e.DocumentKey)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("document_key");

                entity.Property(e => e.Editted)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("editted");

                entity.Property(e => e.Extension)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("extension");

                entity.Property(e => e.Filename)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("filename");

                entity.Property(e => e.Guid)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("guid");

                entity.Property(e => e.IsShowQr)
                    .HasColumnName("is_show_qr")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.IsTemplate)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("is_template");

                entity.Property(e => e.Name)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("name");

                entity.Property(e => e.PublicPermissions)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("public_permissions");

                entity.Property(e => e.RequestId).HasColumnName("request_id");

                entity.Property(e => e.SignReason)
                    .HasColumnType("text")
                    .HasColumnName("sign_reason");

                entity.Property(e => e.Size).HasColumnName("size");

                entity.Property(e => e.Status)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("status");

                entity.Property(e => e.TemplateFields)
                    .HasColumnType("text")
                    .HasColumnName("template_fields");

                entity.Property(e => e.UploadedBy).HasColumnName("uploaded_by");

                entity.Property(e => e.UploadedOn)
                    .HasColumnName("uploaded_on")
                    .HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<SignerFilesShare>(entity =>
            {
                entity.HasKey(e => e.ShareId)
                    .HasName("PK__signer_f__C36E8AE521979DDA");

                entity.ToTable("signer_files_share");

                entity.Property(e => e.ShareId).HasColumnName("share_id");

                entity.Property(e => e.EmployeeEmail)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("employee_email");

                entity.Property(e => e.EmployeeId)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("employee_id");

                entity.Property(e => e.RequestId).HasColumnName("request_id");

                entity.Property(e => e.Rules)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("rules");

                entity.Property(e => e.SharedKey)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("shared_key");

                entity.Property(e => e.UpdatedBy)
                    .HasMaxLength(255)
                    .HasColumnName("updated_by");

                entity.Property(e => e.UpdatedTime)
                    .HasColumnName("updated_time")
                    .HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<SignerHistory>(entity =>
            {
                entity.ToTable("signer_history");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Activity)
                    .IsUnicode(false)
                    .HasColumnName("activity");

                entity.Property(e => e.Files)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("files");

                entity.Property(e => e.Time)
                    .HasColumnName("time_")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Type)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("type");
            });

            modelBuilder.Entity<SignerLog>(entity =>
            {
                entity.ToTable("signer_logs");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Activity)
                    .HasColumnType("ntext")
                    .HasColumnName("activity");

                entity.Property(e => e.IpAddress)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("ip_address");

                entity.Property(e => e.Time)
                    .HasColumnName("time_")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Uri)
                    .HasColumnType("ntext")
                    .HasColumnName("uri");

                entity.Property(e => e.Users).HasColumnName("users");
            });

            modelBuilder.Entity<SignerMClassification>(entity =>
            {
                entity.HasKey(e => e.ClassificationId)
                    .HasName("PK__signer_m__C73D9994A6F4A551");

                entity.ToTable("signer_m_classification");

                entity.Property(e => e.ClassificationId).HasColumnName("classification_id");

                entity.Property(e => e.ClassificationName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("classification_name");
            });

            modelBuilder.Entity<SignerMDepartment>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("signer_m_department");

                entity.Property(e => e.Company).HasColumnName("company");

                entity.Property(e => e.Email)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("email");

                entity.Property(e => e.Id)
                    .IsRequired()
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("id");

                entity.Property(e => e.Name)
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .HasColumnName("name");
            });

            modelBuilder.Entity<SignerMDocsCategory>(entity =>
            {
                entity.HasKey(e => e.CategoryId)
                    .HasName("PK__signer_m__D54EE9B41BD064B2");

                entity.ToTable("signer_m_docs_category");

                entity.Property(e => e.CategoryId).HasColumnName("category_id");

                entity.Property(e => e.CategoryName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("category_name");
            });

            modelBuilder.Entity<SignerMenu>(entity =>
            {
                entity.ToTable("signer_menu");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.KeysRoles)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("keys_roles");

                entity.Property(e => e.Menu)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("menu");

                entity.Property(e => e.MenuRoles)
                    .HasColumnType("text")
                    .HasColumnName("menu_roles");
            });

            modelBuilder.Entity<SignerNotification>(entity =>
            {
                entity.ToTable("signer_notifications");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Message)
                    .HasColumnType("ntext")
                    .HasColumnName("message");

                entity.Property(e => e.Time)
                    .HasColumnName("time_")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Type)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("type");

                entity.Property(e => e.Users).HasColumnName("users");
            });

            modelBuilder.Entity<SignerNotificationsTest>(entity =>
            {
                entity.ToTable("signer_notifications_test");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Message)
                    .HasColumnType("ntext")
                    .HasColumnName("message");

                entity.Property(e => e.Time)
                    .HasColumnName("time_")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Type)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("type");

                entity.Property(e => e.User).HasColumnName("user");
            });

            modelBuilder.Entity<SignerPayload>(entity =>
            {
                entity.ToTable("signer_payload");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.TrxBodyRequest)
                    .HasColumnType("text")
                    .HasColumnName("trx_body_request");

                entity.Property(e => e.TrxCode)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("trx_code");

                entity.Property(e => e.TrxDate)
                    .HasColumnName("trx_date")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.TrxReferenceId)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("trx_reference_id");

                entity.Property(e => e.TrxStatus)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("trx_status");
            });

            modelBuilder.Entity<SignerPayloadCallback>(entity =>
            {
                entity.ToTable("signer_payload_callback");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Action)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("action");

                entity.Property(e => e.ActionDate)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("actionDate");

                entity.Property(e => e.ApplicationId)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("applicationId");

                entity.Property(e => e.RefId)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("refId");

                entity.Property(e => e.RequestId)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("requestId");

                entity.Property(e => e.Status)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("status");

                entity.Property(e => e.TargetUserId)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("targetUserId");

                entity.Property(e => e.TransactionCode)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("transactionCode");

                entity.Property(e => e.UserId)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("userId");
            });

            modelBuilder.Entity<SignerQr>(entity =>
            {
                entity.ToTable("signer_qr");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Positions)
                    .HasColumnType("ntext")
                    .HasColumnName("positions");

                entity.Property(e => e.RequestId).HasColumnName("request_id");

                entity.Property(e => e.Qrkey)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("qrkey");
            });

            modelBuilder.Entity<SignerRequest>(entity =>
            {
                entity.ToTable("signer_requests");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.ClassificationId).HasColumnName("classification_id");

                entity.Property(e => e.Company).HasColumnName("company");

                entity.Property(e => e.CreatedTime)
                    .HasColumnName("created_time")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DepartmentId)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("department_id");

                entity.Property(e => e.NextOrder)
                    .HasColumnName("next_order")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.PdfCertified)
                    .HasMaxLength(300)
                    .IsUnicode(false)
                    .HasColumnName("pdf_certified");

                entity.Property(e => e.Reason)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("reason");

                entity.Property(e => e.RequestorEmail)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("requestor_email");

                entity.Property(e => e.SendTime)
                    .HasColumnName("send_time")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Sender)
                    .HasMaxLength(11)
                    .IsUnicode(false)
                    .HasColumnName("sender");

                entity.Property(e => e.SenderNote)
                    .IsUnicode(false)
                    .HasColumnName("sender_note");

                entity.Property(e => e.SenderOld).HasColumnName("sender_old");

                entity.Property(e => e.Status)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("status");

                entity.Property(e => e.WorkflowMethod)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("workflow_method");
            });

            modelBuilder.Entity<SignerRole>(entity =>
            {
                entity.HasKey(e => e.Keys)
                    .HasName("PK__signer_r__2B3B21D0460D10F8");

                entity.ToTable("signer_roles");

                entity.Property(e => e.Keys)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("keys");

                entity.Property(e => e.Roles)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("roles");
            });

            modelBuilder.Entity<SignerStatus>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("signer_status");

                entity.Property(e => e.Description)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("description");

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("id");
            });

            modelBuilder.Entity<SignerWorkflow>(entity =>
            {
                entity.HasKey(e => e.WorkflowId)
                    .HasName("PK__signer_w__64A76B706D6183A0");

                entity.ToTable("signer_workflow");

                entity.Property(e => e.WorkflowId).HasColumnName("workflow_id");

                entity.Property(e => e.ChainEmails)
                    .HasColumnType("ntext")
                    .HasColumnName("chain_emails");

                entity.Property(e => e.ChainPositions)
                    .HasColumnType("ntext")
                    .HasColumnName("chain_positions");

                entity.Property(e => e.Document)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("document");

                entity.Property(e => e.Email)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("email");

                entity.Property(e => e.EmployeeId).HasColumnName("employee_id");

                entity.Property(e => e.FaceAuthId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("face_auth_id");

                entity.Property(e => e.FaceAuthPayload)
                    .HasColumnType("text")
                    .HasColumnName("face_auth_payload");

                entity.Property(e => e.FaceAuthStatus)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("face_auth_status");

                entity.Property(e => e.Notes)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("notes");

                entity.Property(e => e.OrderBy).HasColumnName("order_by");

                entity.Property(e => e.Positions)
                    .HasColumnType("ntext")
                    .HasColumnName("positions");

                entity.Property(e => e.RequestId).HasColumnName("request_id");

                entity.Property(e => e.SenderNote)
                    .IsUnicode(false)
                    .HasColumnName("sender_note");

                entity.Property(e => e.SigningKey)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("signing_key");

                entity.Property(e => e.Status)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("status");

                entity.Property(e => e.UpdatedAt).HasColumnName("updated_at");

                entity.Property(e => e.UpdatedBy).HasColumnName("updated_by");
            });

            modelBuilder.Entity<TempSignerFile>(entity =>
            {
                entity.ToTable("temp_signer_file");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Accessibility)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("accessibility");

                entity.Property(e => e.CategoryId).HasColumnName("category_id");

                entity.Property(e => e.Company).HasColumnName("company");

                entity.Property(e => e.DocumentKey)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("document_key");

                entity.Property(e => e.Editted)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("editted");

                entity.Property(e => e.Extension)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("extension");

                entity.Property(e => e.Filename)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("filename");

                entity.Property(e => e.Guid)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("guid");

                entity.Property(e => e.IsTemplate)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("is_template");

                entity.Property(e => e.Name)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("name");

                entity.Property(e => e.PublicPermissions)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("public_permissions");

                entity.Property(e => e.RequestId).HasColumnName("request_id");

                entity.Property(e => e.SignReason)
                    .HasColumnType("text")
                    .HasColumnName("sign_reason");

                entity.Property(e => e.Size).HasColumnName("size");

                entity.Property(e => e.Status)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("status");

                entity.Property(e => e.TemplateFields)
                    .HasColumnType("text")
                    .HasColumnName("template_fields");

                entity.Property(e => e.UploadedBy).HasColumnName("uploaded_by");

                entity.Property(e => e.UploadedOn)
                    .HasColumnName("uploaded_on")
                    .HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<TempSignerRequest>(entity =>
            {
                entity.ToTable("temp_signer_requests");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.ClassificationId).HasColumnName("classification_id");

                entity.Property(e => e.Company).HasColumnName("company");

                entity.Property(e => e.CreatedTime)
                    .HasColumnName("created_time")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DepartmentId).HasColumnName("department_id");

                entity.Property(e => e.NextOrder).HasColumnName("next_order");

                entity.Property(e => e.PdfCertified)
                    .HasColumnType("ntext")
                    .HasColumnName("pdf_certified");

                entity.Property(e => e.RequestorEmail)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("requestor_email");

                entity.Property(e => e.SendTime)
                    .HasColumnName("send_time")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Sender).HasColumnName("sender");

                entity.Property(e => e.SenderNote)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("sender_note");

                entity.Property(e => e.Status)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("status");

                entity.Property(e => e.WorkflowMethod)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("workflow_method");
            });

            modelBuilder.Entity<TempSignerWorkflow>(entity =>
            {
                entity.HasKey(e => e.WorkflowId)
                    .HasName("PK__signer_w__64A76B706D6183A0_copy1");

                entity.ToTable("temp_signer_workflow");

                entity.Property(e => e.WorkflowId).HasColumnName("workflow_id");

                entity.Property(e => e.ChainEmails)
                    .HasColumnType("ntext")
                    .HasColumnName("chain_emails");

                entity.Property(e => e.ChainPositions)
                    .HasColumnType("ntext")
                    .HasColumnName("chain_positions");

                entity.Property(e => e.Document)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("document");

                entity.Property(e => e.Email)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("email");

                entity.Property(e => e.EmployeeId).HasColumnName("employee_id");

                entity.Property(e => e.Notes)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("notes");

                entity.Property(e => e.OrderBy).HasColumnName("order_by");

                entity.Property(e => e.Positions)
                    .HasColumnType("ntext")
                    .HasColumnName("positions");

                entity.Property(e => e.RequestId).HasColumnName("request_id");

                entity.Property(e => e.SenderNote)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("sender_note");

                entity.Property(e => e.SigningKey)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("signing_key");

                entity.Property(e => e.Status)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("status");

                entity.Property(e => e.UpdatedAt)
                    .HasColumnName("updated_at")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.UpdatedBy).HasColumnName("updated_by");
            });

            modelBuilder.Entity<User>(entity =>
            {
                entity.ToTable("users");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Address)
                    .HasMaxLength(256)
                    .IsUnicode(false)
                    .HasColumnName("address");

                entity.Property(e => e.Avatar)
                    .HasMaxLength(256)
                    .IsUnicode(false)
                    .HasColumnName("avatar");

                entity.Property(e => e.Company).HasColumnName("company");

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasMaxLength(64)
                    .IsUnicode(false)
                    .HasColumnName("email");

                entity.Property(e => e.Fname)
                    .IsRequired()
                    .HasMaxLength(16)
                    .IsUnicode(false)
                    .HasColumnName("fname");

                entity.Property(e => e.Hiddenfiles)
                    .IsUnicode(false)
                    .HasColumnName("hiddenfiles");

                entity.Property(e => e.Lang)
                    .IsRequired()
                    .HasMaxLength(16)
                    .IsUnicode(false)
                    .HasColumnName("lang");

                entity.Property(e => e.Lastnotification).HasColumnName("lastnotification");

                entity.Property(e => e.Lname)
                    .IsRequired()
                    .HasMaxLength(16)
                    .IsUnicode(false)
                    .HasColumnName("lname");

                entity.Property(e => e.Password)
                    .IsRequired()
                    .HasMaxLength(256)
                    .IsUnicode(false)
                    .HasColumnName("password");

                entity.Property(e => e.Permissions)
                    .IsRequired()
                    .HasMaxLength(256)
                    .IsUnicode(false)
                    .HasColumnName("permissions");

                entity.Property(e => e.Phone)
                    .HasMaxLength(16)
                    .IsUnicode(false)
                    .HasColumnName("phone");

                entity.Property(e => e.Role)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("role");

                entity.Property(e => e.Signature)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("signature");

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("status");

                entity.Property(e => e.Timezone)
                    .IsRequired()
                    .HasMaxLength(256)
                    .IsUnicode(false)
                    .HasColumnName("timezone");

                entity.Property(e => e.Token)
                    .HasMaxLength(256)
                    .IsUnicode(false)
                    .HasColumnName("token");
            });

            modelBuilder.Entity<ViewWorkflow>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("viewWorkflow");

                entity.Property(e => e.Email)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("email");

                entity.Property(e => e.EmployeeId).HasColumnName("employee_id");

                entity.Property(e => e.EmployeeName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("employee_name");

                entity.Property(e => e.Filename)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("filename");

                entity.Property(e => e.LanId)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("lan_id");

                entity.Property(e => e.RequestId).HasColumnName("request_id");

                entity.Property(e => e.RequestorEmail)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("requestor_email");

                entity.Property(e => e.RequestorNote)
                    .IsUnicode(false)
                    .HasColumnName("requestor_note");

                entity.Property(e => e.Status)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("status");

                entity.Property(e => e.WorkflowId).HasColumnName("workflow_id");
            });

            modelBuilder.Entity<ViewWorkflowById>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("viewWorkflowById");

                entity.Property(e => e.Filename)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("filename");

                entity.Property(e => e.RequestId).HasColumnName("request_id");

                entity.Property(e => e.RequestorEmail)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("requestor_email");

                entity.Property(e => e.RequestorNote)
                    .IsUnicode(false)
                    .HasColumnName("requestor_note");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
