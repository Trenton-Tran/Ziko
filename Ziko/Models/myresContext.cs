using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Ziko.Models
{
    public partial class myresContext : DbContext
    {
        public myresContext()
        {
        }

        public myresContext(DbContextOptions<myresContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Account> Account { get; set; }
        public virtual DbSet<AppConfig> AppConfig { get; set; }
        public virtual DbSet<Bank> Bank { get; set; }
        public virtual DbSet<Branch> Branch { get; set; }
        public virtual DbSet<Customer> Customer { get; set; }
        public virtual DbSet<Districts> Districts { get; set; }
        public virtual DbSet<ExportInvoid> ExportInvoid { get; set; }
        public virtual DbSet<ExportInvoidDetail> ExportInvoidDetail { get; set; }
        public virtual DbSet<ExportReceipt> ExportReceipt { get; set; }
        public virtual DbSet<ImportInvoid> ImportInvoid { get; set; }
        public virtual DbSet<ImportInvoidDetail> ImportInvoidDetail { get; set; }
        public virtual DbSet<ImportPayment> ImportPayment { get; set; }
        public virtual DbSet<Invoid> Invoid { get; set; }
        public virtual DbSet<InvoidCode> InvoidCode { get; set; }
        public virtual DbSet<InvoidDetail> InvoidDetail { get; set; }
        public virtual DbSet<InvoidReceipt> InvoidReceipt { get; set; }
        public virtual DbSet<PaymentCategory> PaymentCategory { get; set; }
        public virtual DbSet<Payments> Payments { get; set; }
        public virtual DbSet<PrincipleGroup> PrincipleGroup { get; set; }
        public virtual DbSet<Principles> Principles { get; set; }
        public virtual DbSet<Product> Product { get; set; }
        public virtual DbSet<ProductGroup> ProductGroup { get; set; }
        public virtual DbSet<ProductPrice> ProductPrice { get; set; }
        public virtual DbSet<Province> Province { get; set; }
        public virtual DbSet<Receipts> Receipts { get; set; }
        public virtual DbSet<Roles> Roles { get; set; }
        public virtual DbSet<TableRoom> TableRoom { get; set; }
        public virtual DbSet<TableRoomGroup> TableRoomGroup { get; set; }
        public virtual DbSet<Wards> Wards { get; set; }
        public virtual DbSet<WareHouse> WareHouse { get; set; }

        // Unable to generate entity type for table 'dbo.Corporation'. Please see the warning messages.

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server=.\\SQLEXPRESS;Database=myres;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Account>(entity =>
            {
                entity.Property(e => e.AccName).HasMaxLength(50);

                entity.Property(e => e.Email)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Password)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Phone)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TokenString)
                    .HasMaxLength(32)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<AppConfig>(entity =>
            {
                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.Explain).HasMaxLength(250);

                entity.Property(e => e.Value).HasMaxLength(500);
            });

            modelBuilder.Entity<Bank>(entity =>
            {
                entity.Property(e => e.AccNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.BankName).HasMaxLength(250);

                entity.Property(e => e.OwnerName).HasMaxLength(250);
            });

            modelBuilder.Entity<Branch>(entity =>
            {
                entity.Property(e => e.BranchAdd).HasMaxLength(250);

                entity.Property(e => e.BranchName).HasMaxLength(250);

                entity.Property(e => e.BranchPhone)
                    .HasMaxLength(250)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Customer>(entity =>
            {
                entity.Property(e => e.CustomerId)
                    .HasColumnType("numeric(18, 0)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Birdthday).HasColumnType("date");

                entity.Property(e => e.CustomerAdd).HasMaxLength(250);

                entity.Property(e => e.CustomerMail)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.CustomerName)
                    .IsRequired()
                    .HasMaxLength(250);

                entity.Property(e => e.CustomerPhone)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Offline).HasColumnName("offline");
            });

            modelBuilder.Entity<Districts>(entity =>
            {
                entity.HasKey(e => e.DistrictId);

                entity.Property(e => e.DistrictId)
                    .HasColumnName("DISTRICT_ID")
                    .ValueGeneratedNever();

                entity.Property(e => e.DistrictName)
                    .HasColumnName("DISTRICT_NAME")
                    .HasMaxLength(250);

                entity.Property(e => e.ProvinceId).HasColumnName("PROVINCE_ID");
            });

            modelBuilder.Entity<ExportInvoid>(entity =>
            {
                entity.HasKey(e => e.InvoidId);

                entity.Property(e => e.InvoidId)
                    .HasColumnType("numeric(18, 0)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.AccCreate)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.CustomerId).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.DateCreate).HasColumnType("datetime");

                entity.Property(e => e.InvoidCode)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.InvoidDate).HasColumnType("date");
            });

            modelBuilder.Entity<ExportInvoidDetail>(entity =>
            {
                entity.HasKey(e => e.RowId);

                entity.Property(e => e.RowId)
                    .HasColumnType("numeric(18, 0)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Amount).HasColumnType("decimal(10, 3)");

                entity.Property(e => e.Discount).HasColumnType("decimal(8, 3)");

                entity.Property(e => e.InvoidId).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.Price).HasColumnType("decimal(10, 0)");

                entity.Property(e => e.ProductId).HasColumnType("numeric(18, 0)");
            });

            modelBuilder.Entity<ExportReceipt>(entity =>
            {
                entity.HasKey(e => new { e.ExportId, e.ReceiptId });

                entity.ToTable("Export_Receipt");

                entity.Property(e => e.ExportId).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.ReceiptId).HasColumnType("numeric(18, 0)");
            });

            modelBuilder.Entity<ImportInvoid>(entity =>
            {
                entity.HasKey(e => e.InvoidId);

                entity.Property(e => e.InvoidId)
                    .HasColumnType("numeric(18, 0)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.AccCreate)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.CustomerId).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.DateCreate).HasColumnType("datetime");

                entity.Property(e => e.InvoidCode)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.InvoidDate).HasColumnType("date");
            });

            modelBuilder.Entity<ImportInvoidDetail>(entity =>
            {
                entity.HasKey(e => e.RowId);

                entity.Property(e => e.RowId)
                    .HasColumnType("numeric(18, 0)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Amount).HasColumnType("decimal(10, 3)");

                entity.Property(e => e.Cost).HasColumnType("decimal(8, 2)");

                entity.Property(e => e.Discount).HasColumnType("decimal(8, 3)");

                entity.Property(e => e.InvoidId).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.Price).HasColumnType("decimal(10, 0)");

                entity.Property(e => e.ProductId).HasColumnType("numeric(18, 0)");
            });

            modelBuilder.Entity<ImportPayment>(entity =>
            {
                entity.HasKey(e => new { e.ImportId, e.PaymentId });

                entity.ToTable("Import_Payment");

                entity.Property(e => e.ImportId).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.PaymentId).HasColumnType("numeric(18, 0)");
            });

            modelBuilder.Entity<Invoid>(entity =>
            {
                entity.Property(e => e.InvoidId)
                    .HasColumnType("numeric(18, 0)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.AccCreate)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.CustomerId).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.DateCreate).HasColumnType("datetime");

                entity.Property(e => e.DateEnd).HasColumnType("datetime");

                entity.Property(e => e.InvoidCode)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.InvoidDate).HasColumnType("date");
            });

            modelBuilder.Entity<InvoidCode>(entity =>
            {
                entity.HasKey(e => new { e.BranchId, e.InvoidCode1 });

                entity.Property(e => e.InvoidCode1)
                    .HasColumnName("InvoidCode")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<InvoidDetail>(entity =>
            {
                entity.HasKey(e => e.RowId);

                entity.Property(e => e.RowId)
                    .HasColumnType("numeric(18, 0)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Amount).HasColumnType("decimal(10, 3)");

                entity.Property(e => e.InvoidId).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.ProductId).HasColumnType("numeric(18, 0)");
            });

            modelBuilder.Entity<InvoidReceipt>(entity =>
            {
                entity.HasKey(e => new { e.InvoidId, e.ReceiptId });

                entity.ToTable("Invoid_Receipt");

                entity.Property(e => e.InvoidId).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.ReceiptId).HasColumnType("numeric(18, 0)");
            });

            modelBuilder.Entity<PaymentCategory>(entity =>
            {
                entity.HasKey(e => e.CatId);

                entity.Property(e => e.AccountDebt).HasDefaultValueSql("((1))");

                entity.Property(e => e.Code)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Explain).HasMaxLength(250);

                entity.Property(e => e.Kind)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.ProfitAccounting).HasDefaultValueSql("((1))");
            });

            modelBuilder.Entity<Payments>(entity =>
            {
                entity.HasKey(e => e.PaymentId);

                entity.Property(e => e.PaymentId)
                    .HasColumnType("numeric(18, 0)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.AccCreate).HasMaxLength(50);

                entity.Property(e => e.CatId).HasColumnName("CatID");

                entity.Property(e => e.CustomerId).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.DateCreate).HasColumnType("datetime");

                entity.Property(e => e.Explain).HasMaxLength(250);

                entity.Property(e => e.PayForm)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.PaymentCode)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PaymentDate).HasColumnType("date");
            });

            modelBuilder.Entity<PrincipleGroup>(entity =>
            {
                entity.Property(e => e.GroupName).HasMaxLength(50);
            });

            modelBuilder.Entity<Principles>(entity =>
            {
                entity.HasKey(e => e.PrincipleCode);

                entity.Property(e => e.PrincipleCode)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.Explain).HasMaxLength(250);
            });

            modelBuilder.Entity<Product>(entity =>
            {
                entity.Property(e => e.ProductId)
                    .HasColumnType("numeric(18, 0)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Img)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Offline)
                    .HasColumnName("offline")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.ProductBarcode)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.ProductCode).HasMaxLength(250);

                entity.Property(e => e.ProductName).HasMaxLength(250);

                entity.Property(e => e.Unit).HasMaxLength(50);
            });

            modelBuilder.Entity<ProductGroup>(entity =>
            {
                entity.HasKey(e => e.GroupId);

                entity.Property(e => e.GroupName).HasMaxLength(250);

                entity.Property(e => e.Img)
                    .HasMaxLength(250)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ProductPrice>(entity =>
            {
                entity.HasKey(e => new { e.ProductId, e.BranchId });

                entity.Property(e => e.ProductId).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.ImportPrice).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.OldImportPrice).HasColumnType("decimal(10, 2)");
            });

            modelBuilder.Entity<Province>(entity =>
            {
                entity.Property(e => e.ProvinceId)
                    .HasColumnName("PROVINCE_ID")
                    .ValueGeneratedNever();

                entity.Property(e => e.ProvinceCode)
                    .HasColumnName("PROVINCE_CODE")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.ProvinceName)
                    .HasColumnName("PROVINCE_NAME")
                    .HasMaxLength(250);
            });

            modelBuilder.Entity<Receipts>(entity =>
            {
                entity.HasKey(e => e.ReceiptId);

                entity.Property(e => e.ReceiptId)
                    .HasColumnType("numeric(18, 0)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.AccCreate).HasMaxLength(50);

                entity.Property(e => e.CatId).HasColumnName("CatID");

                entity.Property(e => e.CustomerId).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.DateCreate).HasColumnType("datetime");

                entity.Property(e => e.Explain).HasMaxLength(250);

                entity.Property(e => e.PayForm)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.ReceiptCode)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ReceiptDate).HasColumnType("date");
            });

            modelBuilder.Entity<Roles>(entity =>
            {
                entity.HasKey(e => new { e.AccId, e.PrincipleCode, e.BranchId });

                entity.Property(e => e.PrincipleCode)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TableRoom>(entity =>
            {
                entity.HasKey(e => e.TableId);

                entity.ToTable("Table_Room");

                entity.Property(e => e.Offline)
                    .HasColumnName("offline")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.TableName).HasMaxLength(50);
            });

            modelBuilder.Entity<TableRoomGroup>(entity =>
            {
                entity.HasKey(e => e.TableGroupId);

                entity.ToTable("Table_Room_Group");

                entity.Property(e => e.TableGroupName).HasMaxLength(50);
            });

            modelBuilder.Entity<Wards>(entity =>
            {
                entity.ToTable("WARDS");

                entity.Property(e => e.WardsId)
                    .HasColumnName("WARDS_ID")
                    .ValueGeneratedNever();

                entity.Property(e => e.DistrictId).HasColumnName("DISTRICT_ID");

                entity.Property(e => e.WardsName)
                    .HasColumnName("WARDS_NAME")
                    .HasMaxLength(250);
            });

            modelBuilder.Entity<WareHouse>(entity =>
            {
                entity.HasKey(e => new { e.BranchId, e.ProductId });

                entity.Property(e => e.BranchId).ValueGeneratedOnAdd();

                entity.Property(e => e.ProductId).HasColumnType("numeric(18, 0)");
            });
        }
    }
}
