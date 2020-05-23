﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace AQBooking.Admin.Infrastructure.Databases.EvisaEntities
{
    public partial class AQEvisaContext : DbContext
    {
        public AQEvisaContext()
        {
        }

        public AQEvisaContext(DbContextOptions<AQEvisaContext> options)
            : base(options)
        {
        }

        public virtual DbSet<CountryArrivalPorts> CountryArrivalPorts { get; set; }
        public virtual DbSet<CountryEmbassyInformations> CountryEmbassyInformations { get; set; }
        public virtual DbSet<CountryList> CountryList { get; set; }
        public virtual DbSet<CountryVisaCosts> CountryVisaCosts { get; set; }
        public virtual DbSet<CountryVisaProcessOptionFees> CountryVisaProcessOptionFees { get; set; }
        public virtual DbSet<CountryVisaProcessOptions> CountryVisaProcessOptions { get; set; }
        public virtual DbSet<CountryVisaProcesses> CountryVisaProcesses { get; set; }
        public virtual DbSet<CountryVisaServices> CountryVisaServices { get; set; }
        public virtual DbSet<CountryVisaTypes> CountryVisaTypes { get; set; }
        public virtual DbSet<VisaApplicationDetails> VisaApplicationDetails { get; set; }
        public virtual DbSet<VisaApplicationDocumentDatas> VisaApplicationDocumentDatas { get; set; }
        public virtual DbSet<VisaApplicationDocuments> VisaApplicationDocuments { get; set; }
        public virtual DbSet<VisaApplicationPaymentLogs> VisaApplicationPaymentLogs { get; set; }
        public virtual DbSet<VisaApplicationProcesses> VisaApplicationProcesses { get; set; }
        public virtual DbSet<VisaApplications> VisaApplications { get; set; }
        public virtual DbSet<VisaMerchantUsers> VisaMerchantUsers { get; set; }
        public virtual DbSet<VisaMerchants> VisaMerchants { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CountryArrivalPorts>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CountryCode)
                    .IsRequired()
                    .HasMaxLength(10);

                entity.Property(e => e.CountryResKey).HasMaxLength(150);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.LastModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.PortName)
                    .IsRequired()
                    .HasMaxLength(456);
            });

            modelBuilder.Entity<CountryEmbassyInformations>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CountryLocation)
                    .IsRequired()
                    .HasMaxLength(10);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.Email).HasMaxLength(100);

                entity.Property(e => e.EmbassyAddress).HasMaxLength(1500);

                entity.Property(e => e.EmbassyCountry)
                    .IsRequired()
                    .HasMaxLength(10);

                entity.Property(e => e.EmbassyName).HasMaxLength(1000);

                entity.Property(e => e.HotLine).HasMaxLength(50);

                entity.Property(e => e.LastModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.WebsiteUrl)
                    .HasColumnName("WebsiteURL")
                    .HasMaxLength(200);
            });

            modelBuilder.Entity<CountryList>(entity =>
            {
                entity.HasKey(e => e.CountryCode)
                    .HasName("PK__CountryL__5D9B0D2D67CD725B");

                entity.Property(e => e.CountryCode).HasMaxLength(10);

                entity.Property(e => e.CountryName)
                    .IsRequired()
                    .HasMaxLength(456);

                entity.Property(e => e.CountryResKey).HasMaxLength(150);

                entity.Property(e => e.CssFlag).HasMaxLength(150);
            });

            modelBuilder.Entity<CountryVisaCosts>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CountryVisaTypeFid).HasColumnName("CountryVisaTypeFID");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.CultureCode).HasMaxLength(6);

                entity.Property(e => e.CurrencyCode).HasMaxLength(10);

                entity.Property(e => e.EffectiveDate).HasColumnType("datetime");

                entity.Property(e => e.LastModifiedDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<CountryVisaProcessOptionFees>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CountryVisaProcessOptionFid).HasColumnName("CountryVisaProcessOptionFID");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.CultureCode).HasMaxLength(6);

                entity.Property(e => e.CurrencyCode).HasMaxLength(10);

                entity.Property(e => e.EffectiveDate).HasColumnType("datetime");

                entity.Property(e => e.LastModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.Remark).HasMaxLength(2000);
            });

            modelBuilder.Entity<CountryVisaProcessOptions>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CountryVisaProcesFid).HasColumnName("CountryVisaProcesFID");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.LastModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.ProcessOptionsName).HasMaxLength(456);

                entity.Property(e => e.ProcessingTimeUnitFid).HasColumnName("ProcessingTimeUnitFID");

                entity.Property(e => e.ProcessingTimeUnitResKey).HasMaxLength(150);
            });

            modelBuilder.Entity<CountryVisaProcesses>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CountryVisaTypeFid).HasColumnName("CountryVisaTypeFID");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.DestinationCountry)
                    .IsRequired()
                    .HasMaxLength(10);

                entity.Property(e => e.DestinationCountryResKey).HasMaxLength(150);

                entity.Property(e => e.LastModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.OriginCountry)
                    .IsRequired()
                    .HasMaxLength(10);

                entity.Property(e => e.OriginCountryResKey).HasMaxLength(150);
            });

            modelBuilder.Entity<CountryVisaServices>(entity =>
            {
                entity.HasKey(e => e.CountryCode)
                    .HasName("PK__CountryV__5D9B0D2DF3B103C7");

                entity.Property(e => e.CountryCode).HasMaxLength(10);

                entity.Property(e => e.CountryName)
                    .IsRequired()
                    .HasMaxLength(456);

                entity.Property(e => e.CountryResKey).HasMaxLength(150);

                entity.Property(e => e.CssFlag).HasMaxLength(150);
            });

            modelBuilder.Entity<CountryVisaTypes>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Country)
                    .IsRequired()
                    .HasMaxLength(10);

                entity.Property(e => e.CountryResKey).HasMaxLength(150);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.LastModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.NumberOfEntryFid).HasColumnName("NumberOfEntryFID");

                entity.Property(e => e.NumberOfEntryResKey).HasMaxLength(150);

                entity.Property(e => e.VisaTypeFid).HasColumnName("VisaTypeFID");

                entity.Property(e => e.VisaTypeName)
                    .IsRequired()
                    .HasMaxLength(456);

                entity.Property(e => e.VisaTypeResKey).HasMaxLength(150);
            });

            modelBuilder.Entity<VisaApplicationDetails>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.ApplicationFid).HasColumnName("ApplicationFID");

                entity.Property(e => e.CountryOfBirthCode).HasMaxLength(10);

                entity.Property(e => e.CountryOfBirthName).HasMaxLength(150);

                entity.Property(e => e.CountryOfResidenceCode).HasMaxLength(10);

                entity.Property(e => e.CountryOfResidenceName).HasMaxLength(150);

                entity.Property(e => e.DayOfBirth).HasColumnType("datetime");

                entity.Property(e => e.FirstAndMiddleName).HasMaxLength(456);

                entity.Property(e => e.Gender).HasMaxLength(1);

                entity.Property(e => e.GenderResKey).HasMaxLength(150);

                entity.Property(e => e.LastModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.LastName).HasMaxLength(456);

                entity.Property(e => e.PassportExpirationDate).HasColumnType("datetime");

                entity.Property(e => e.PassportIssuesDate).HasColumnType("datetime");

                entity.Property(e => e.PassportNationalityCode).HasMaxLength(10);

                entity.Property(e => e.PassportNationalityName).HasMaxLength(150);

                entity.Property(e => e.PassportNo).HasMaxLength(456);

                entity.Property(e => e.SubmissionDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<VisaApplicationDocumentDatas>(entity =>
            {
                entity.HasKey(e => e.FileId)
                    .HasName("PK__VisaAppl__6F0F989FF36C499F");

                entity.Property(e => e.FileId)
                    .HasColumnName("FileID")
                    .ValueGeneratedNever();

                entity.Property(e => e.FileData).IsRequired();
            });

            modelBuilder.Entity<VisaApplicationDocuments>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.ApplicationFid).HasColumnName("ApplicationFID");

                entity.Property(e => e.DeletedDate).HasColumnType("datetime");

                entity.Property(e => e.FileExtentions)
                    .IsRequired()
                    .HasMaxLength(10);

                entity.Property(e => e.FileName)
                    .IsRequired()
                    .HasMaxLength(456);

                entity.Property(e => e.HashKey).HasMaxLength(1000);

                entity.Property(e => e.OriginalName)
                    .IsRequired()
                    .HasMaxLength(456);

                entity.Property(e => e.PasswordUnlock).HasMaxLength(1000);

                entity.Property(e => e.UniqueId)
                    .IsRequired()
                    .HasColumnName("UniqueID")
                    .HasMaxLength(12);

                entity.Property(e => e.UploadedBy)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.UploadedDateUtc)
                    .HasColumnName("UploadedDateUTC")
                    .HasColumnType("datetime");
            });

            modelBuilder.Entity<VisaApplicationPaymentLogs>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.ApplicationFid).HasColumnName("ApplicationFID");

                entity.Property(e => e.CultureCode).HasMaxLength(6);

                entity.Property(e => e.CurrencyCode).HasMaxLength(10);

                entity.Property(e => e.PaymentBy).HasMaxLength(100);

                entity.Property(e => e.PaymentDate).HasColumnType("datetime");

                entity.Property(e => e.PaymentMethod).HasMaxLength(100);

                entity.Property(e => e.PaymentRef).HasMaxLength(100);

                entity.Property(e => e.Remark).HasMaxLength(1000);

                entity.Property(e => e.StatusFid).HasColumnName("StatusFID");
            });

            modelBuilder.Entity<VisaApplicationProcesses>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.ApplicationFid).HasColumnName("ApplicationFID");

                entity.Property(e => e.AssignMerchantFid).HasColumnName("AssignMerchantFID");

                entity.Property(e => e.AssignedDate).HasColumnType("datetime");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.EndProcessOn).HasColumnType("datetime");

                entity.Property(e => e.LastModifiedDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<VisaApplications>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.ArrivalDate).HasColumnType("datetime");

                entity.Property(e => e.CountryVisaTypeFid).HasColumnName("CountryVisaTypeFID");

                entity.Property(e => e.CultureCode).HasMaxLength(6);

                entity.Property(e => e.CurrencyCode).HasMaxLength(10);

                entity.Property(e => e.DepartureDate).HasColumnType("datetime");

                entity.Property(e => e.DestinationCountry)
                    .IsRequired()
                    .HasMaxLength(10);

                entity.Property(e => e.EmailAddress)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.LastModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.OriginCountry)
                    .IsRequired()
                    .HasMaxLength(10);

                entity.Property(e => e.PaymentDate).HasColumnType("datetime");

                entity.Property(e => e.PortOfArrivalFid).HasColumnName("PortOfArrivalFID");

                entity.Property(e => e.PortOfArrivalName).HasMaxLength(456);

                entity.Property(e => e.StatusFid).HasColumnName("StatusFID");

                entity.Property(e => e.StatusResKey).HasMaxLength(150);

                entity.Property(e => e.SubmissionDate).HasColumnType("datetime");

                entity.Property(e => e.TotalApplications).HasDefaultValueSql("((1))");

                entity.Property(e => e.UniqueId)
                    .IsRequired()
                    .HasColumnName("UniqueID")
                    .HasMaxLength(12);

                entity.Property(e => e.VisaProcessOptionFid).HasColumnName("VisaProcessOptionFID");
            });

            modelBuilder.Entity<VisaMerchantUsers>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.EffectiveEndDate).HasColumnType("datetime");

                entity.Property(e => e.EffectiveStartDate).HasColumnType("datetime");

                entity.Property(e => e.LastModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.MerchantFid).HasColumnName("MerchantFID");

                entity.Property(e => e.MerchantName).HasMaxLength(100);

                entity.Property(e => e.MerchantUserRoleFid).HasColumnName("MerchantUserRoleFID");

                entity.Property(e => e.MerchantUserRoleResKey).HasMaxLength(150);

                entity.Property(e => e.UserEmail).HasMaxLength(100);

                entity.Property(e => e.UserFid).HasColumnName("UserFID");

                entity.Property(e => e.UserName).HasMaxLength(100);
            });

            modelBuilder.Entity<VisaMerchants>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.AccountSize).HasDefaultValueSql("((5))");

                entity.Property(e => e.Address1).HasMaxLength(456);

                entity.Property(e => e.Address2).HasMaxLength(456);

                entity.Property(e => e.City).HasMaxLength(256);

                entity.Property(e => e.ContactNumber1).HasMaxLength(50);

                entity.Property(e => e.ContactNumber2).HasMaxLength(50);

                entity.Property(e => e.Country).HasMaxLength(256);

                entity.Property(e => e.CountryVisa)
                    .IsRequired()
                    .HasMaxLength(10);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.EmailAddress1).HasMaxLength(100);

                entity.Property(e => e.EmailAddress2).HasMaxLength(100);

                entity.Property(e => e.ExpiredDate).HasColumnType("datetime");

                entity.Property(e => e.LastModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.MerchantName).HasMaxLength(456);

                entity.Property(e => e.MerchantTypeFid)
                    .HasColumnName("MerchantTypeFID")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.MerchantTypeResKey).HasMaxLength(150);

                entity.Property(e => e.Remark).HasMaxLength(2000);

                entity.Property(e => e.State).HasMaxLength(456);

                entity.Property(e => e.UniqueId)
                    .IsRequired()
                    .HasColumnName("UniqueID")
                    .HasMaxLength(12);

                entity.Property(e => e.ZipCode).HasMaxLength(10);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}