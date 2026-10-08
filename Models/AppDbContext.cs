using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace VAapiPng.Models;

public partial class AppDbContext : DbContext
{
    public AppDbContext()
    {
    }

    public AppDbContext(DbContextOptions<AppDbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<CatalogTblenquirydetail> CatalogTblenquirydetails { get; set; }

    public virtual DbSet<EbLiveFeed> EbLiveFeeds { get; set; }

    public virtual DbSet<EbTblPauseExtend> EbTblPauseExtends { get; set; }

    public virtual DbSet<EbtblJobStatus> EbtblJobStatuses { get; set; }

    public virtual DbSet<TblAgencyUser> TblAgencyUsers { get; set; }

    public virtual DbSet<TblAttachment> TblAttachments { get; set; }

    public virtual DbSet<TblBrief> TblBriefs { get; set; }

    public virtual DbSet<TblCatalogMailDraft> TblCatalogMailDrafts { get; set; }

    public virtual DbSet<TblCatalogueUsage> TblCatalogueUsages { get; set; }

    public virtual DbSet<TblCategoryField> TblCategoryFields { get; set; }

    public virtual DbSet<TblCategoryGroup> TblCategoryGroups { get; set; }

    public virtual DbSet<TblClient> TblClients { get; set; }

    public virtual DbSet<TblClientDepartment> TblClientDepartments { get; set; }

    public virtual DbSet<TblClientDetail> TblClientDetails { get; set; }

    public virtual DbSet<TblClientValue> TblClientValues { get; set; }

    public virtual DbSet<TblClintDeliveryAddress> TblClintDeliveryAddresses { get; set; }

    public virtual DbSet<TblCountry> TblCountries { get; set; }

    public virtual DbSet<TblDivision> TblDivisions { get; set; }

    public virtual DbSet<TblDivisionBrandsorproduct> TblDivisionBrandsorproducts { get; set; }

    public virtual DbSet<TblEnquiryDetail> TblEnquiryDetails { get; set; }

    public virtual DbSet<TblEnquiryMaster> TblEnquiryMasters { get; set; }

    public virtual DbSet<TblEnquirySpecification> TblEnquirySpecifications { get; set; }

    public virtual DbSet<TblEnvironmentEmission> TblEnvironmentEmissions { get; set; }

    public virtual DbSet<TblFieldType> TblFieldTypes { get; set; }

    public virtual DbSet<TblFieldValue> TblFieldValues { get; set; }

    public virtual DbSet<TblJobHistory> TblJobHistories { get; set; }

    public virtual DbSet<TblJobStatus> TblJobStatuses { get; set; }

    public virtual DbSet<TblLineitemsHistory> TblLineitemsHistories { get; set; }

    public virtual DbSet<TblLog> TblLogs { get; set; }

    public virtual DbSet<TblMaterialused> TblMaterialuseds { get; set; }

    public virtual DbSet<TblMessage> TblMessages { get; set; }

    public virtual DbSet<TblMfee> TblMfees { get; set; }

    public virtual DbSet<TblMfeeph> TblMfeephs { get; set; }

    public virtual DbSet<TblNetSaving> TblNetSavings { get; set; }

    public virtual DbSet<TblNetSavingsPh> TblNetSavingsPhs { get; set; }

    public virtual DbSet<TblNewmfee> TblNewmfees { get; set; }

    public virtual DbSet<TblNewnetSaving> TblNewnetSavings { get; set; }

    public virtual DbSet<TblNewsavingsMfee> TblNewsavingsMfees { get; set; }

    public virtual DbSet<TblNewshortfall> TblNewshortfalls { get; set; }

    public virtual DbSet<TblPrintCapability> TblPrintCapabilities { get; set; }

    public virtual DbSet<TblPrintCapability1> TblPrintCapabilities1 { get; set; }

    public virtual DbSet<TblProductCatalogue> TblProductCatalogues { get; set; }

    public virtual DbSet<TblProductCatalogueNew> TblProductCatalogueNews { get; set; }

    public virtual DbSet<TblProductCategory> TblProductCategories { get; set; }

    public virtual DbSet<TblProductSpecification> TblProductSpecifications { get; set; }

    public virtual DbSet<TblProductionMethod> TblProductionMethods { get; set; }

    public virtual DbSet<TblProductionMethodGroup> TblProductionMethodGroups { get; set; }

    public virtual DbSet<TblSavingsDetail> TblSavingsDetails { get; set; }

    public virtual DbSet<TblShortfall> TblShortfalls { get; set; }

    public virtual DbSet<TblSla> TblSlas { get; set; }

    public virtual DbSet<TblSupplierQuote> TblSupplierQuotes { get; set; }

    public virtual DbSet<TblSupplierQuoteHistory> TblSupplierQuoteHistories { get; set; }

    public virtual DbSet<TblSupplierUser> TblSupplierUsers { get; set; }

    public virtual DbSet<TblSuppliersList> TblSuppliersLists { get; set; }

    public virtual DbSet<TblSurvey> TblSurveys { get; set; }

    public virtual DbSet<TblTemp> TblTemps { get; set; }

    public virtual DbSet<TblUser> TblUsers { get; set; }

    public virtual DbSet<TblWebAdmin> TblWebAdmins { get; set; }

    public virtual DbSet<TblcatalogUser> TblcatalogUsers { get; set; }

    public virtual DbSet<Tblcataloglogindetail> Tblcataloglogindetails { get; set; }

    public virtual DbSet<Tblcurrency> Tblcurrencies { get; set; }

    public virtual DbSet<Tblenvironmentalimpact> Tblenvironmentalimpacts { get; set; }

    public virtual DbSet<Tblenvironmentcomparison> Tblenvironmentcomparisons { get; set; }

    public virtual DbSet<Tblmanagmenttype> Tblmanagmenttypes { get; set; }

    public virtual DbSet<Tblpwdhistory> Tblpwdhistories { get; set; }

    public virtual DbSet<ViewLogonHistory> ViewLogonHistories { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=10.0.3.12;Database=dbvapng;User Id=pmgvirtualagency;Password=pmgvirtualagency@1;TrustServerCertificate=True;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<CatalogTblenquirydetail>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("catalog_tblenquirydetails");

            entity.Property(e => e.Actualfilecopies).HasColumnName("ACTUALFILECOPIES");
            entity.Property(e => e.Actualinvoicing).HasColumnName("ACTUALINVOICING");
            entity.Property(e => e.Actualproduction).HasColumnName("ACTUALPRODUCTION");
            entity.Property(e => e.Actualproof).HasColumnName("ACTUALPROOF");
            entity.Property(e => e.Actualquote).HasColumnName("ACTUALQUOTE");
            entity.Property(e => e.BaseLinePrice).HasColumnType("decimal(24, 2)");
            entity.Property(e => e.BenchmarkPrice).HasColumnType("decimal(24, 2)");
            entity.Property(e => e.CatalogCategory)
                .HasMaxLength(100)
                .HasColumnName("catalog_Category");
            entity.Property(e => e.Cgst)
                .HasColumnType("decimal(5, 2)")
                .HasColumnName("CGST");
            entity.Property(e => e.Cgstamount)
                .HasColumnType("decimal(24, 2)")
                .HasColumnName("CGSTAmount");
            entity.Property(e => e.ClientItemSellPrice).HasColumnType("decimal(24, 2)");
            entity.Property(e => e.Dictated).HasMaxLength(10);
            entity.Property(e => e.EnquiryId).HasColumnName("EnquiryID");
            entity.Property(e => e.Entriesstatus).HasColumnName("entriesstatus");
            entity.Property(e => e.Harmonizedorder)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.Hsncode)
                .HasMaxLength(10)
                .HasColumnName("HSNCode");
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
            entity.Property(e => e.Igst)
                .HasColumnType("decimal(5, 2)")
                .HasColumnName("IGST");
            entity.Property(e => e.Igstamount)
                .HasColumnType("decimal(24, 2)")
                .HasColumnName("IGSTAmount");
            entity.Property(e => e.ItemSellPrice).HasColumnType("decimal(24, 2)");
            entity.Property(e => e.ItemSellPricedis).HasColumnType("decimal(24, 2)");
            entity.Property(e => e.ManagementFeeUnit).HasColumnType("decimal(5, 2)");
            entity.Property(e => e.PmggainShare)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("PMGGainShare");
            entity.Property(e => e.Pmgshare).HasColumnName("PMGshare");
            entity.Property(e => e.Podate).HasColumnName("PODate");
            entity.Property(e => e.PrintedorproducedonFscmeterial).HasColumnName("printedorproducedonFSCmeterial");
            entity.Property(e => e.PrintingMethod).HasMaxLength(50);
            entity.Property(e => e.PrintingOther).HasMaxLength(50);
            entity.Property(e => e.Printornonprint).HasMaxLength(50);
            entity.Property(e => e.Printornonprintother).HasMaxLength(50);
            entity.Property(e => e.ProductCode)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Product_code");
            entity.Property(e => e.ProductType).HasMaxLength(50);
            entity.Property(e => e.ProductionMethod).HasMaxLength(50);
            entity.Property(e => e.QuotePrice).HasColumnType("decimal(24, 2)");
            entity.Property(e => e.RateCard).HasMaxLength(10);
            entity.Property(e => e.SavingsCal).HasMaxLength(50);
            entity.Property(e => e.ServerTime).HasColumnType("datetime");
            entity.Property(e => e.Sgpaccredited).HasColumnName("SGPAccredited");
            entity.Property(e => e.Sgst)
                .HasColumnType("decimal(5, 2)")
                .HasColumnName("SGST");
            entity.Property(e => e.Sgstamount)
                .HasColumnType("decimal(24, 2)")
                .HasColumnName("SGSTAmount");
            entity.Property(e => e.Smetaaccredited).HasColumnName("SMETAAccredited");
            entity.Property(e => e.Snote).HasColumnName("SNote");
            entity.Property(e => e.Sst)
                .HasColumnType("decimal(5, 2)")
                .HasColumnName("SST");
            entity.Property(e => e.Suplier)
                .HasMaxLength(50)
                .HasColumnName("suplier");
            entity.Property(e => e.Supplier1Intilamount)
                .HasMaxLength(50)
                .HasColumnName("supplier1Intilamount");
            entity.Property(e => e.Supplier1amount)
                .HasMaxLength(50)
                .HasColumnName("supplier1amount");
            entity.Property(e => e.Supplier2Intilamount)
                .HasMaxLength(50)
                .HasColumnName("supplier2Intilamount");
            entity.Property(e => e.Supplier2Name).HasMaxLength(50);
            entity.Property(e => e.Supplier2amount)
                .HasMaxLength(50)
                .HasColumnName("supplier2amount");
            entity.Property(e => e.Supplier3Intilamount)
                .HasMaxLength(50)
                .HasColumnName("supplier3Intilamount");
            entity.Property(e => e.Supplier3Name)
                .HasMaxLength(50)
                .HasColumnName("supplier3Name");
            entity.Property(e => e.Supplier3amount)
                .HasMaxLength(50)
                .HasColumnName("supplier3amount");
            entity.Property(e => e.Supplier4Intilamount).HasColumnName("supplier4Intilamount");
            entity.Property(e => e.Supplier4Name).HasColumnName("supplier4Name");
            entity.Property(e => e.Supplier4amount).HasColumnName("supplier4amount");
            entity.Property(e => e.Supplier5Intilamount).HasColumnName("supplier5Intilamount");
            entity.Property(e => e.Supplier5Name).HasColumnName("supplier5Name");
            entity.Property(e => e.Supplier5amount).HasColumnName("supplier5amount");
            entity.Property(e => e.SupplierIdprive).HasColumnName("SupplierIDprive");
            entity.Property(e => e.TaxPercentage).HasColumnType("decimal(5, 2)");
            entity.Property(e => e.TotalManagementFee).HasColumnType("decimal(24, 2)");
            entity.Property(e => e.TotalQuoteAmount).HasColumnType("decimal(24, 2)");
            entity.Property(e => e.TotalTaxAmount).HasColumnType("decimal(24, 2)");
            entity.Property(e => e.Ugst)
                .HasColumnType("decimal(5, 2)")
                .HasColumnName("UGST");
            entity.Property(e => e.Ugstamount)
                .HasColumnType("decimal(24, 2)")
                .HasColumnName("UGSTAmount");
            entity.Property(e => e.Unitbudget)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("unitbudget");
            entity.Property(e => e.Urgent).HasMaxLength(50);
        });

        modelBuilder.Entity<EbLiveFeed>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("EB_LiveFeed");

            entity.Property(e => e.CreatedDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.FeedType).HasMaxLength(50);
        });

        modelBuilder.Entity<EbTblPauseExtend>(entity =>
        {
            entity.ToTable("EB_tblPauseExtend");

            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.Type).HasMaxLength(50);
        });

        modelBuilder.Entity<EbtblJobStatus>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("EBtblJobStatus");

            entity.Property(e => e.StatusName).HasMaxLength(50);
            entity.Property(e => e.VisibleSuppliersStatus).HasMaxLength(255);
        });

        modelBuilder.Entity<TblAgencyUser>(entity =>
        {
            entity.ToTable("tblAgencyUsers");

            entity.Property(e => e.Country).HasMaxLength(255);
            entity.Property(e => e.Email).HasMaxLength(255);
            entity.Property(e => e.FirstName).HasMaxLength(255);
            entity.Property(e => e.JobPosition).HasMaxLength(255);
            entity.Property(e => e.JobRole).HasMaxLength(255);
            entity.Property(e => e.JobTitle).HasMaxLength(255);
            entity.Property(e => e.LastName).HasMaxLength(255);
            entity.Property(e => e.Phone).HasMaxLength(255);
            entity.Property(e => e.Userid).HasColumnName("userid");
        });

        modelBuilder.Entity<TblAttachment>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("tblAttachments");

            entity.Property(e => e.Createdby).HasMaxLength(10);
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
            entity.Property(e => e.Size).HasMaxLength(50);
            entity.Property(e => e.Status).HasMaxLength(50);
            entity.Property(e => e.Type).HasMaxLength(50);
            entity.Property(e => e.UploadDate).HasColumnType("datetime");
            entity.Property(e => e.UserId)
                .HasMaxLength(50)
                .HasColumnName("UserID");
        });

        modelBuilder.Entity<TblBrief>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("tblBrief");

            entity.Property(e => e.BriefId).HasColumnName("BriefID");
            entity.Property(e => e.ClientId).HasColumnName("ClientID");
            entity.Property(e => e.Createdate).HasColumnType("datetime");
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
            entity.Property(e => e.ProjectName).HasMaxLength(50);
            entity.Property(e => e.Status).HasMaxLength(50);
        });

        modelBuilder.Entity<TblCatalogMailDraft>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("tblCatalog_MailDraft");

            entity.Property(e => e.Entity).HasMaxLength(250);
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
            entity.Property(e => e.JobType)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Market)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ProjectManager).HasMaxLength(250);
            entity.Property(e => e.TeamLead).HasMaxLength(250);
        });

        modelBuilder.Entity<TblCatalogueUsage>(entity =>
        {
            entity.ToTable("tblCatalogueUsage");

            entity.Property(e => e.Status)
                .HasDefaultValue(true)
                .HasColumnName("status");
        });

        modelBuilder.Entity<TblCategoryField>(entity =>
        {
            entity.HasKey(e => e.FieldId);

            entity.ToTable("tblCategoryFields");

            entity.Property(e => e.FieldId).HasColumnName("FieldID");
            entity.Property(e => e.GroupId).HasColumnName("GroupID");
        });

        modelBuilder.Entity<TblCategoryGroup>(entity =>
        {
            entity.HasKey(e => e.GroupId).HasName("PK_Sheet1$_2");

            entity.ToTable("tblCategoryGroups");

            entity.Property(e => e.GroupId).HasColumnName("GroupID");
            entity.Property(e => e.ProductCategoryId).HasColumnName("ProductCategoryID");
        });

        modelBuilder.Entity<TblClient>(entity =>
        {
            entity.ToTable("tblClient");

            entity.Property(e => e.Bu).HasMaxLength(250);
            entity.Property(e => e.CatalogEntity).HasColumnName("Catalog_Entity");
            entity.Property(e => e.Email).HasMaxLength(50);
            entity.Property(e => e.FirstName).HasMaxLength(50);
            entity.Property(e => e.Gbui).HasColumnName("GBUI");
            entity.Property(e => e.JobTitle).HasMaxLength(50);
            entity.Property(e => e.Jobposition).HasMaxLength(50);
            entity.Property(e => e.LastName).HasMaxLength(50);
            entity.Property(e => e.Phone).HasMaxLength(50);
            entity.Property(e => e.Status).HasDefaultValue(true);
            entity.Property(e => e.Userid).HasColumnName("userid");
        });

        modelBuilder.Entity<TblClientDepartment>(entity =>
        {
            entity.ToTable("tblClientDepartment");
        });

        modelBuilder.Entity<TblClientDetail>(entity =>
        {
            entity.ToTable("tblClientDetails");

            entity.Property(e => e.City).HasMaxLength(50);
            entity.Property(e => e.Clientcode)
                .HasMaxLength(200)
                .HasColumnName("clientcode");
            entity.Property(e => e.Currency).HasMaxLength(50);
            entity.Property(e => e.DefaultSalesPercentage).HasMaxLength(50);
            entity.Property(e => e.Language).HasMaxLength(50);
            entity.Property(e => e.PaymentTermcode).HasMaxLength(200);
            entity.Property(e => e.SalesPercentage).HasMaxLength(50);
            entity.Property(e => e.Sst)
                .HasMaxLength(50)
                .HasColumnName("SST");
        });

        modelBuilder.Entity<TblClientValue>(entity =>
        {
            entity.HasKey(e => e.ClientId).HasName("PK_tblclientvalues");

            entity.ToTable("tblClientValues");

            entity.Property(e => e.ClientId)
                .ValueGeneratedNever()
                .HasColumnName("ClientID");
            entity.Property(e => e.ClientName).HasMaxLength(50);
        });

        modelBuilder.Entity<TblClintDeliveryAddress>(entity =>
        {
            entity.ToTable("tblClintDeliveryAddress");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.ContactNo).HasColumnName("ContactNO");
            entity.Property(e => e.Currency)
                .HasMaxLength(15)
                .IsUnicode(false);
            entity.Property(e => e.EchoLocid).HasColumnName("Echo_Locid");
            entity.Property(e => e.Frightcharges).HasColumnType("numeric(18, 2)");
            entity.Property(e => e.Frighttaxamount)
                .HasColumnType("numeric(15, 2)")
                .HasColumnName("frighttaxamount");
            entity.Property(e => e.Frighttaxpercentage)
                .HasColumnType("numeric(15, 2)")
                .HasColumnName("frighttaxpercentage");
            entity.Property(e => e.Itemname).HasMaxLength(250);
            entity.Property(e => e.Unitcharges).HasColumnType("numeric(18, 2)");
        });

        modelBuilder.Entity<TblCountry>(entity =>
        {
            entity.ToTable("tblCountry");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.Code).HasMaxLength(10);
            entity.Property(e => e.Country).HasMaxLength(50);
            entity.Property(e => e.Currency).HasMaxLength(50);
            entity.Property(e => e.Language).HasMaxLength(50);
            entity.Property(e => e.RegionalSetting).HasMaxLength(50);
            entity.Property(e => e.Sapneeded)
                .HasDefaultValue(false)
                .HasColumnName("SAPNeeded");
            entity.Property(e => e.TaxPercentage).HasMaxLength(50);
        });

        modelBuilder.Entity<TblDivision>(entity =>
        {
            entity.ToTable("tblDivision");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.BussinessUnit)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ClientId).HasColumnName("ClientID");
            entity.Property(e => e.ClientName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Clientcode)
                .HasMaxLength(15)
                .IsUnicode(false);
            entity.Property(e => e.Country)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.DepartmentOrProduct)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.EntityName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.GlobalBumapping).HasColumnName("GlobalBUMapping");
            entity.Property(e => e.Status).HasDefaultValue(true);
        });

        modelBuilder.Entity<TblDivisionBrandsorproduct>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("tblDivisionBrandsorproducts");

            entity.Property(e => e.Brandorproduct)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Country)
                .HasMaxLength(25)
                .IsUnicode(false);
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<TblEnquiryDetail>(entity =>
        {
            entity.ToTable("tblEnquiryDetails", tb =>
                {
                    tb.HasTrigger("trgOnStatusChange");
                    tb.HasTrigger("trg_StatusUpdate_APIQueue");
                });

            entity.HasIndex(e => new { e.SupplierId, e.Status }, "<Name of Missing Index, sysname,>");

            entity.Property(e => e.Actualfilecopies).HasColumnName("ACTUALFILECOPIES");
            entity.Property(e => e.Actualinvoicing).HasColumnName("ACTUALINVOICING");
            entity.Property(e => e.Actualproduction).HasColumnName("ACTUALPRODUCTION");
            entity.Property(e => e.Actualproof).HasColumnName("ACTUALPROOF");
            entity.Property(e => e.Actualquote).HasColumnName("ACTUALQUOTE");
            entity.Property(e => e.BaseLinePrice).HasColumnType("decimal(24, 2)");
            entity.Property(e => e.BenchmarkPrice).HasColumnType("decimal(24, 2)");
            entity.Property(e => e.CatalogCategory)
                .HasMaxLength(100)
                .HasColumnName("catalog_Category");
            entity.Property(e => e.Cgst)
                .HasColumnType("decimal(5, 2)")
                .HasColumnName("CGST");
            entity.Property(e => e.Cgstamount)
                .HasColumnType("decimal(24, 2)")
                .HasColumnName("CGSTAmount");
            entity.Property(e => e.ClientItemSellPrice).HasColumnType("decimal(24, 2)");
            entity.Property(e => e.CompareEnvReason).HasMaxLength(250);
            entity.Property(e => e.CompareEnvironmentalEnergy).HasMaxLength(50);
            entity.Property(e => e.CompareEnvironmentalGhg).HasMaxLength(50);
            entity.Property(e => e.CompareEnvironmentalPaperGrade).HasMaxLength(50);
            entity.Property(e => e.CompareEnvironmentalPaperName).HasMaxLength(50);
            entity.Property(e => e.CompareEnvironmentalPaperQuantity).HasMaxLength(50);
            entity.Property(e => e.CompareEnvironmentalPaperRecycled).HasMaxLength(50);
            entity.Property(e => e.CompareEnvironmentalPaperUnit).HasMaxLength(50);
            entity.Property(e => e.CompareEnvironmentalWater).HasMaxLength(50);
            entity.Property(e => e.CompareEnvironmentalWood).HasMaxLength(50);
            entity.Property(e => e.ContainplasticNew)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("containplastic_new");
            entity.Property(e => e.Designforrecycle)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("designforrecycle");
            entity.Property(e => e.Designreused)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.Dictated).HasMaxLength(10);
            entity.Property(e => e.EchoProductcode).HasColumnName("Echo_productcode");
            entity.Property(e => e.EnquiryId).HasColumnName("EnquiryID");
            entity.Property(e => e.Entriesstatus).HasColumnName("entriesstatus");
            entity.Property(e => e.EnvironmentalEnergy).HasMaxLength(50);
            entity.Property(e => e.EnvironmentalGhg).HasMaxLength(50);
            entity.Property(e => e.EnvironmentalPaperGrade).HasMaxLength(50);
            entity.Property(e => e.EnvironmentalPaperName).HasMaxLength(50);
            entity.Property(e => e.EnvironmentalPaperQuantity).HasMaxLength(50);
            entity.Property(e => e.EnvironmentalPaperRecycled).HasMaxLength(50);
            entity.Property(e => e.EnvironmentalPaperUnit).HasMaxLength(50);
            entity.Property(e => e.EnvironmentalWater).HasMaxLength(50);
            entity.Property(e => e.EnvironmentalWood).HasMaxLength(50);
            entity.Property(e => e.EnvironmentalWooddensity).HasMaxLength(50);
            entity.Property(e => e.Fscpefcmaterial)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("FSCPEFCmaterial");
            entity.Property(e => e.Harmonizedorder)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.Hsncode)
                .HasMaxLength(10)
                .HasColumnName("HSNCode");
            entity.Property(e => e.Igst)
                .HasColumnType("decimal(5, 2)")
                .HasColumnName("IGST");
            entity.Property(e => e.Igstamount)
                .HasColumnType("decimal(24, 2)")
                .HasColumnName("IGSTAmount");
            entity.Property(e => e.IsCustomize).HasColumnName("is_customize");
            entity.Property(e => e.ItemSellPrice).HasColumnType("decimal(24, 2)");
            entity.Property(e => e.ItemSellPricedis).HasColumnType("decimal(24, 2)");
            entity.Property(e => e.Itemsellpriceedit).HasDefaultValue(false);
            entity.Property(e => e.ManagementFeeUnit).HasColumnType("decimal(5, 2)");
            entity.Property(e => e.Materialused)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Plasticweightage)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("plasticweightage");
            entity.Property(e => e.PmggainShare)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("PMGGainShare");
            entity.Property(e => e.Pmgshare).HasColumnName("PMGshare");
            entity.Property(e => e.Podate).HasColumnName("PODate");
            entity.Property(e => e.PrintedorproducedonFscmeterial).HasColumnName("printedorproducedonFSCmeterial");
            entity.Property(e => e.PrintingMethod).HasMaxLength(50);
            entity.Property(e => e.PrintingOther).HasMaxLength(50);
            entity.Property(e => e.Printornonprint).HasMaxLength(50);
            entity.Property(e => e.Printornonprintother).HasMaxLength(50);
            entity.Property(e => e.ProductType).HasMaxLength(50);
            entity.Property(e => e.ProductionMethod).HasMaxLength(50);
            entity.Property(e => e.Proposedsustain)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("proposedsustain");
            entity.Property(e => e.QuotePrice).HasColumnType("decimal(24, 2)");
            entity.Property(e => e.RateCard).HasMaxLength(10);
            entity.Property(e => e.RatecardDeclined)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.Recycledmaterial)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("recycledmaterial");
            entity.Property(e => e.Recycledmaterialweightage)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("recycledmaterialweightage");
            entity.Property(e => e.RecycledplasticNew)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("recycledplastic_new");
            entity.Property(e => e.Recycledplasticweightage)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("recycledplasticweightage");
            entity.Property(e => e.SapLineItem).HasColumnName("SAP_LineItem");
            entity.Property(e => e.SapSync).HasColumnName("SAP_Sync");
            entity.Property(e => e.SavingsCal).HasMaxLength(50);
            entity.Property(e => e.ServerTime)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.Sgpaccredited).HasColumnName("SGPAccredited");
            entity.Property(e => e.Sgst)
                .HasColumnType("decimal(5, 2)")
                .HasColumnName("SGST");
            entity.Property(e => e.Sgstamount)
                .HasColumnType("decimal(24, 2)")
                .HasColumnName("SGSTAmount");
            entity.Property(e => e.Smetaaccredited).HasColumnName("SMETAAccredited");
            entity.Property(e => e.Snote).HasColumnName("SNote");
            entity.Property(e => e.Sst)
                .HasColumnType("decimal(5, 2)")
                .HasColumnName("SST");
            entity.Property(e => e.SubCategory).HasColumnName("subCategory");
            entity.Property(e => e.SubcatId).HasColumnName("SubcatID");
            entity.Property(e => e.Suplier)
                .HasMaxLength(50)
                .HasColumnName("suplier");
            entity.Property(e => e.Supplier1Intilamount)
                .HasMaxLength(50)
                .HasColumnName("supplier1Intilamount");
            entity.Property(e => e.Supplier1amount)
                .HasMaxLength(50)
                .HasColumnName("supplier1amount");
            entity.Property(e => e.Supplier2Intilamount)
                .HasMaxLength(50)
                .HasColumnName("supplier2Intilamount");
            entity.Property(e => e.Supplier2Name).HasMaxLength(50);
            entity.Property(e => e.Supplier2amount)
                .HasMaxLength(50)
                .HasColumnName("supplier2amount");
            entity.Property(e => e.Supplier3Intilamount)
                .HasMaxLength(50)
                .HasColumnName("supplier3Intilamount");
            entity.Property(e => e.Supplier3Name)
                .HasMaxLength(50)
                .HasColumnName("supplier3Name");
            entity.Property(e => e.Supplier3amount)
                .HasMaxLength(50)
                .HasColumnName("supplier3amount");
            entity.Property(e => e.Supplier4Intilamount).HasColumnName("supplier4Intilamount");
            entity.Property(e => e.Supplier4Name).HasColumnName("supplier4Name");
            entity.Property(e => e.Supplier4amount).HasColumnName("supplier4amount");
            entity.Property(e => e.Supplier5Intilamount).HasColumnName("supplier5Intilamount");
            entity.Property(e => e.Supplier5Name).HasColumnName("supplier5Name");
            entity.Property(e => e.Supplier5amount).HasColumnName("supplier5amount");
            entity.Property(e => e.SupplierIdprive).HasColumnName("SupplierIDprive");
            entity.Property(e => e.TaxPercentage).HasColumnType("decimal(5, 2)");
            entity.Property(e => e.TotalManagementFee).HasColumnType("decimal(24, 2)");
            entity.Property(e => e.TotalQuoteAmount).HasColumnType("decimal(24, 2)");
            entity.Property(e => e.TotalTaxAmount).HasColumnType("decimal(24, 2)");
            entity.Property(e => e.Ugst)
                .HasColumnType("decimal(5, 2)")
                .HasColumnName("UGST");
            entity.Property(e => e.Ugstamount)
                .HasColumnType("decimal(24, 2)")
                .HasColumnName("UGSTAmount");
            entity.Property(e => e.Unitbudget)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("unitbudget");
            entity.Property(e => e.Urgent).HasMaxLength(50);
        });

        modelBuilder.Entity<TblEnquiryMaster>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_tblEnquiry");

            entity.ToTable("tblEnquiryMaster", tb => tb.HasTrigger("trgOnJobUpdate"));

            entity.HasIndex(e => new { e.PmgEntity, e.ServerTime }, "<Name of Missing Index, sysname,>");

            entity.Property(e => e.Actualdeliverydate).HasMaxLength(50);
            entity.Property(e => e.BiddingEndDate).HasColumnType("datetime");
            entity.Property(e => e.BiddingStartDate).HasColumnType("datetime");
            entity.Property(e => e.Brandorproduct)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("brandorproduct");
            entity.Property(e => e.Briefdate).HasColumnName("BRIEFDATE");
            entity.Property(e => e.Campaign)
                .HasMaxLength(150)
                .IsUnicode(false);
            entity.Property(e => e.CancelDate).HasColumnType("datetime");
            entity.Property(e => e.CatalogEntity).HasColumnName("CATALOG_ENTITY");
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.DeletDate).HasColumnType("datetime");
            entity.Property(e => e.DeletReason).HasMaxLength(50);
            entity.Property(e => e.DeleteDate).HasColumnType("datetime");
            entity.Property(e => e.Deletreasontext).HasMaxLength(50);
            entity.Property(e => e.EnqUid)
                .HasMaxLength(50)
                .HasColumnName("EnqUId");
            entity.Property(e => e.EstDate).HasMaxLength(50);
            entity.Property(e => e.Extendduration).HasMaxLength(50);
            entity.Property(e => e.Gbui).HasColumnName("GBUI");
            entity.Property(e => e.InvoiceNumber)
                .HasMaxLength(50)
                .HasColumnName("invoiceNumber");
            entity.Property(e => e.IsFirstRemainderSent).HasDefaultValue(false);
            entity.Property(e => e.IsSecondRemainderSent).HasDefaultValue(false);
            entity.Property(e => e.JobType).HasMaxLength(50);
            entity.Property(e => e.Managementfeetypeid).HasColumnName("MANAGEMENTFEETYPEID");
            entity.Property(e => e.Orderid)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Ponumber)
                .HasMaxLength(250)
                .HasColumnName("PONumber");
            entity.Property(e => e.PoorderraisedDate).HasColumnName("POOrderraisedDate");
            entity.Property(e => e.Portal)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ProjectDesc).HasMaxLength(250);
            entity.Property(e => e.ProjectNo).HasMaxLength(50);
            entity.Property(e => e.SapSync).HasColumnName("SAP_Sync");
            entity.Property(e => e.SapelementUuid).HasColumnName("SAPElementUUID");
            entity.Property(e => e.Sapneeded).HasColumnName("SAPNeeded");
            entity.Property(e => e.SapprojectNo).HasColumnName("SAPProjectNo");
            entity.Property(e => e.Sapuuid).HasColumnName("SAPUUID");
            entity.Property(e => e.Savingreson).HasMaxLength(50);
            entity.Property(e => e.ServerTime)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.Status).HasDefaultValue(true);
            entity.Property(e => e.Surveysentdate).HasColumnType("smalldatetime");
        });

        modelBuilder.Entity<TblEnquirySpecification>(entity =>
        {
            entity.ToTable("tblEnquirySpecification");

            entity.Property(e => e.EnqDetailsId).HasColumnName("EnqDetailsID");
            entity.Property(e => e.EnquiryId).HasColumnName("EnquiryID");
            entity.Property(e => e.FieldId).HasColumnName("FieldID");
            entity.Property(e => e.GroupId).HasColumnName("GroupID");
        });

        modelBuilder.Entity<TblEnvironmentEmission>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("tblEnvironmentEmission");

            entity.Property(e => e.Country)
                .HasMaxLength(150)
                .IsUnicode(false);
            entity.Property(e => e.Gef).HasMaxLength(250);
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
            entity.Property(e => e.Status).HasColumnName("status");
        });

        modelBuilder.Entity<TblFieldType>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("tblFieldTypes");

            entity.Property(e => e.FieldTypeId)
                .ValueGeneratedOnAdd()
                .HasColumnName("FieldTypeID");
            entity.Property(e => e.Status).HasDefaultValue(true);
        });

        modelBuilder.Entity<TblFieldValue>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("tblFieldValues");

            entity.Property(e => e.FieldId).HasColumnName("FieldID");
            entity.Property(e => e.FieldValueId).HasColumnName("FieldValueID");
        });

        modelBuilder.Entity<TblJobHistory>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_tblJobHistory1");

            entity.ToTable("tblJobHistory");

            entity.HasIndex(e => e.EnqId, "<Name of Missing Index, sysname,>");

            entity.Property(e => e.ModifiedDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
        });

        modelBuilder.Entity<TblJobStatus>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("tblJobStatus");

            entity.Property(e => e.StatusName).HasMaxLength(255);
            entity.Property(e => e.VisibleSuppliersStatus).HasMaxLength(255);
        });

        modelBuilder.Entity<TblLineitemsHistory>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__tblLinei__3213E83F06AA3CCB");

            entity.ToTable("tblLineitemsHistory");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Field).HasColumnName("field");
            entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<TblLog>(entity =>
        {
            entity.ToTable("tblLog");

            entity.Property(e => e.Ipaddress)
                .HasMaxLength(50)
                .HasColumnName("IPAddress");
            entity.Property(e => e.Location).HasMaxLength(50);
            entity.Property(e => e.LoginDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<TblMaterialused>(entity =>
        {
            entity.ToTable("tblMaterialused");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Status)
                .HasDefaultValue(true)
                .HasColumnName("status");
        });

        modelBuilder.Entity<TblMessage>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("tblMessage");

            entity.Property(e => e.FromId).HasColumnName("From_id");
            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("id");
            entity.Property(e => e.Message)
                .HasColumnType("text")
                .HasColumnName("message");
            entity.Property(e => e.ReadStatus).HasColumnName("read_status");
            entity.Property(e => e.Received)
                .HasColumnType("datetime")
                .HasColumnName("received");
            entity.Property(e => e.Sent)
                .HasColumnType("datetime")
                .HasColumnName("sent");
            entity.Property(e => e.Status).HasColumnName("status");
            entity.Property(e => e.ToId).HasColumnName("To_id");
            entity.Property(e => e.UserId).HasColumnName("user_id");
        });

        modelBuilder.Entity<TblMfee>(entity =>
        {
            entity.ToTable("tblMFEE");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Mfee)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("MFEE");
            entity.Property(e => e.ShortfallMfee)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("ShortfallMFEE");
        });

        modelBuilder.Entity<TblMfeeph>(entity =>
        {
            entity.ToTable("tblMFEEPH");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Mfee)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("MFEE");
            entity.Property(e => e.ShortfallMfee)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("ShortfallMFEE");
        });

        modelBuilder.Entity<TblNetSaving>(entity =>
        {
            entity.ToTable("tblNetSavings");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.NetSavingsNonRecuring).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.NetSavingsRecuring).HasColumnType("decimal(18, 2)");
        });

        modelBuilder.Entity<TblNetSavingsPh>(entity =>
        {
            entity.ToTable("tblNetSavingsPH");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.NetSavingsNonRecuring).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.NetSavingsRecuring).HasColumnType("decimal(18, 2)");
        });

        modelBuilder.Entity<TblNewmfee>(entity =>
        {
            entity.ToTable("tblNEWMFEE");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Country).HasMaxLength(50);
            entity.Property(e => e.Mfee)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("MFEE");
            entity.Property(e => e.ShortfallMfee)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("ShortfallMFEE");
        });

        modelBuilder.Entity<TblNewnetSaving>(entity =>
        {
            entity.ToTable("tblNEWNetSavings");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Country).HasMaxLength(50);
            entity.Property(e => e.NetSavingsNonRecuring).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.NetSavingsRecuring).HasColumnType("decimal(18, 2)");
        });

        modelBuilder.Entity<TblNewsavingsMfee>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("tblNewsavingsMfee");

            entity.Property(e => e.BrandedDictatedMf)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("BrandedDictatedMF");
            entity.Property(e => e.Country)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("country");
            entity.Property(e => e.EntityName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("ID");
            entity.Property(e => e.Mfee)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("MFEE");
            entity.Property(e => e.NetSavingsNonRecuring).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.NetSavingsRecuring).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.ShortfallMfee)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("ShortfallMFEE");
            entity.Property(e => e.Year).HasMaxLength(25);
        });

        modelBuilder.Entity<TblNewshortfall>(entity =>
        {
            entity.ToTable("tblNEWShortfall");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Country).HasMaxLength(50);
            entity.Property(e => e.Shortfall).HasColumnType("decimal(18, 2)");
        });

        modelBuilder.Entity<TblPrintCapability>(entity =>
        {
            entity.HasKey(e => e.CapabilityId).HasName("PK__tblPrint__9A6A78D621551483");

            entity.ToTable("tblPrintCapabilities");

            entity.Property(e => e.CapabilityId).ValueGeneratedNever();
            entity.Property(e => e.Capability).HasMaxLength(50);
            entity.Property(e => e.ChineseSimplified).HasMaxLength(50);
            entity.Property(e => e.ChineseTraditional).HasMaxLength(50);
            entity.Property(e => e.Indonesia).HasMaxLength(50);
            entity.Property(e => e.Japanese).HasMaxLength(50);
            entity.Property(e => e.Korean).HasMaxLength(50);
        });

        modelBuilder.Entity<TblPrintCapability1>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_tblPrintCategory");

            entity.ToTable("tblPrintCapability");

            entity.Property(e => e._10Digital)
                .HasMaxLength(255)
                .HasColumnName("10-Digital");
            entity.Property(e => e._10SheetfedLitho)
                .HasMaxLength(255)
                .HasColumnName("10-SheetfedLitho");
            entity.Property(e => e._11All)
                .HasMaxLength(255)
                .HasColumnName("11-All");
            entity.Property(e => e._12All)
                .HasMaxLength(255)
                .HasColumnName("12-All");
            entity.Property(e => e._13All)
                .HasMaxLength(255)
                .HasColumnName("13-All");
            entity.Property(e => e._14All)
                .HasMaxLength(255)
                .HasColumnName("14-All");
            entity.Property(e => e._15All)
                .HasMaxLength(255)
                .HasColumnName("15-All");
            entity.Property(e => e._16Digital)
                .HasMaxLength(255)
                .HasColumnName("16-Digital");
            entity.Property(e => e._16SheetfedLitho)
                .HasMaxLength(255)
                .HasColumnName("16-SheetfedLitho");
            entity.Property(e => e._16Web)
                .HasMaxLength(255)
                .HasColumnName("16-Web");
            entity.Property(e => e._17All)
                .HasMaxLength(255)
                .HasColumnName("17-All");
            entity.Property(e => e._18All)
                .HasMaxLength(255)
                .HasColumnName("18-All");
            entity.Property(e => e._19All)
                .HasMaxLength(255)
                .HasColumnName("19-All");
            entity.Property(e => e._1All)
                .HasMaxLength(255)
                .HasColumnName("1-All");
            entity.Property(e => e._20All)
                .HasMaxLength(255)
                .HasColumnName("20-All");
            entity.Property(e => e._21All)
                .HasMaxLength(255)
                .HasColumnName("21-All");
            entity.Property(e => e._22All)
                .HasMaxLength(255)
                .HasColumnName("22-All");
            entity.Property(e => e._23All)
                .HasMaxLength(255)
                .HasColumnName("23-All");
            entity.Property(e => e._2Digital)
                .HasMaxLength(255)
                .HasColumnName("2-Digital");
            entity.Property(e => e._2SheetfedLitho)
                .HasMaxLength(255)
                .HasColumnName("2-SheetfedLitho");
            entity.Property(e => e._3Digital)
                .HasMaxLength(255)
                .HasColumnName("3-Digital");
            entity.Property(e => e._3SheetfedLitho)
                .HasMaxLength(255)
                .HasColumnName("3-SheetfedLitho");
            entity.Property(e => e._3Web)
                .HasMaxLength(255)
                .HasColumnName("3-Web");
            entity.Property(e => e._4Continuous)
                .HasMaxLength(255)
                .HasColumnName("4-Continuous");
            entity.Property(e => e._4Digital)
                .HasMaxLength(255)
                .HasColumnName("4-Digital");
            entity.Property(e => e._4SheetfedLitho)
                .HasMaxLength(255)
                .HasColumnName("4-SheetfedLitho");
            entity.Property(e => e._4Web)
                .HasMaxLength(255)
                .HasColumnName("4-Web");
            entity.Property(e => e._5FlexoEnvelopes)
                .HasMaxLength(255)
                .HasColumnName("5-FlexoEnvelopes");
            entity.Property(e => e._5LithoEnvelopes)
                .HasMaxLength(255)
                .HasColumnName("5-LithoEnvelopes");
            entity.Property(e => e._6Continuous)
                .HasMaxLength(255)
                .HasColumnName("6-Continuous");
            entity.Property(e => e._6Digital)
                .HasMaxLength(255)
                .HasColumnName("6-Digital");
            entity.Property(e => e._6Flexo)
                .HasMaxLength(255)
                .HasColumnName("6-Flexo");
            entity.Property(e => e._6Screen)
                .HasMaxLength(255)
                .HasColumnName("6-Screen");
            entity.Property(e => e._6SheetfedLitho)
                .HasMaxLength(255)
                .HasColumnName("6-SheetfedLitho");
            entity.Property(e => e._7Continuous)
                .HasMaxLength(255)
                .HasColumnName("7-Continuous");
            entity.Property(e => e._8Digital)
                .HasMaxLength(255)
                .HasColumnName("8-Digital");
            entity.Property(e => e._8SheetfedLitho)
                .HasMaxLength(255)
                .HasColumnName("8-SheetfedLitho");
            entity.Property(e => e._9Continuous)
                .HasMaxLength(255)
                .HasColumnName("9-Continuous");
            entity.Property(e => e._9Digital)
                .HasMaxLength(255)
                .HasColumnName("9-Digital");
            entity.Property(e => e._9SheetfedLitho)
                .HasMaxLength(255)
                .HasColumnName("9-SheetfedLitho");
        });

        modelBuilder.Entity<TblProductCatalogue>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("tblProductCatalogue");

            entity.Property(e => e.FinishedSize).HasMaxLength(255);
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
            entity.Property(e => e.PrintingProcess).HasMaxLength(50);
            entity.Property(e => e.ProductName).HasMaxLength(255);
            entity.Property(e => e.ProductSpecification).HasMaxLength(255);
            entity.Property(e => e.Quote).HasMaxLength(50);
            entity.Property(e => e.Thickness).HasMaxLength(255);
            entity.Property(e => e.Weight).HasMaxLength(255);
        });

        modelBuilder.Entity<TblProductCatalogueNew>(entity =>
        {
            entity.ToTable("tblProductCatalogueNew");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.ProductCategoryId).HasColumnName("ProductCategoryID");
            entity.Property(e => e.Savings).HasMaxLength(50);
            entity.Property(e => e.Supllier)
                .HasMaxLength(50)
                .HasColumnName("supllier");
        });

        modelBuilder.Entity<TblProductCategory>(entity =>
        {
            entity.ToTable("tblProductCategory");

            entity.Property(e => e.Category).HasMaxLength(50);
            entity.Property(e => e.CategoryJob)
                .HasMaxLength(25)
                .IsUnicode(false);
            entity.Property(e => e.Categorytype)
                .HasMaxLength(25)
                .IsUnicode(false);
            entity.Property(e => e.ChineseSimplified).HasMaxLength(50);
            entity.Property(e => e.ChineseTraditional).HasMaxLength(50);
            entity.Property(e => e.Indonesia).HasMaxLength(50);
            entity.Property(e => e.Japanese).HasMaxLength(50);
            entity.Property(e => e.Korean).HasMaxLength(50);
        });

        modelBuilder.Entity<TblProductSpecification>(entity =>
        {
            entity.ToTable("tblProductSpecification");

            entity.Property(e => e.CatalogueId).HasColumnName("CatalogueID");
            entity.Property(e => e.FieldId).HasColumnName("FieldID");
            entity.Property(e => e.GroupId).HasColumnName("GroupID");
        });

        modelBuilder.Entity<TblProductionMethod>(entity =>
        {
            entity.ToTable("tblProductionMethod");

            entity.Property(e => e.ChineseSimplified).HasMaxLength(50);
            entity.Property(e => e.ChineseTraditional).HasMaxLength(50);
            entity.Property(e => e.Indonesia).HasMaxLength(50);
            entity.Property(e => e.Japanese).HasMaxLength(50);
            entity.Property(e => e.Korean).HasMaxLength(50);
            entity.Property(e => e.ProductCatecoryId).HasMaxLength(50);
            entity.Property(e => e.ProductionMethod).HasMaxLength(50);
        });

        modelBuilder.Entity<TblProductionMethodGroup>(entity =>
        {
            entity.ToTable("tblProductionMethodGroup");

            entity.Property(e => e.ChineseSimplified).HasMaxLength(50);
            entity.Property(e => e.ChineseTraditional).HasMaxLength(50);
            entity.Property(e => e.GroupName).HasMaxLength(50);
            entity.Property(e => e.Indonesia).HasMaxLength(50);
            entity.Property(e => e.Japanese).HasMaxLength(50);
            entity.Property(e => e.Korean).HasMaxLength(50);
        });

        modelBuilder.Entity<TblSavingsDetail>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_tblSavingsDetails_1");

            entity.ToTable("tblSavingsDetails");

            entity.HasIndex(e => e.EnquiryDetailsId, "IX_tblSavingsDetails").IsUnique();

            entity.Property(e => e.ItemSellPrice).HasColumnType("decimal(24, 2)");
            entity.Property(e => e.ManagementFee).HasColumnType("decimal(24, 2)");
            entity.Property(e => e.ServerTime)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
        });

        modelBuilder.Entity<TblShortfall>(entity =>
        {
            entity.ToTable("tblShortfall");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Shortfall).HasColumnType("decimal(18, 2)");
        });

        modelBuilder.Entity<TblSla>(entity =>
        {
            entity.ToTable("tblSLA");

            entity.Property(e => e.Country)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("country");
            entity.Property(e => e.ServerTime)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
        });

        modelBuilder.Entity<TblSupplierQuote>(entity =>
        {
            entity.ToTable("tblSupplierQuotes", tb => tb.HasTrigger("trgOnQuotePriceChange"));

            entity.Property(e => e.Amount).HasColumnType("numeric(18, 2)");
            entity.Property(e => e.EnquiryDetailsId).HasColumnName("EnquiryDetailsID");
            entity.Property(e => e.EnquiryId).HasColumnName("EnquiryID");
            entity.Property(e => e.InitAmount).HasColumnType("numeric(18, 2)");
            entity.Property(e => e.QuoteStatus).HasDefaultValue(1);
            entity.Property(e => e.ResponseDate).HasColumnType("datetime");
            entity.Property(e => e.SaveAmount).HasColumnType("numeric(18, 2)");
            entity.Property(e => e.ServerTime)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.SupplierId).HasColumnName("SupplierID");
            entity.Property(e => e.SupplierNotes).HasMaxLength(250);
            entity.Property(e => e.SupplierUserId).HasColumnName("SupplierUserID");
        });

        modelBuilder.Entity<TblSupplierQuoteHistory>(entity =>
        {
            entity.ToTable("tblSupplierQuoteHistory");

            entity.Property(e => e.Amount).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.EnquiryDetailsId).HasColumnName("EnquiryDetailsID");
            entity.Property(e => e.EnquiryId).HasColumnName("EnquiryID");
            entity.Property(e => e.QuoteStatus).HasDefaultValue(1);
            entity.Property(e => e.ServerTime)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.Status).HasDefaultValue(1);
            entity.Property(e => e.SupplierId).HasColumnName("SupplierID");
            entity.Property(e => e.SupplierNotes).HasMaxLength(250);
            entity.Property(e => e.SupplierUserId).HasColumnName("SupplierUserID");
        });

        modelBuilder.Entity<TblSupplierUser>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_Sheet1$");

            entity.ToTable("tblSupplierUsers");

            entity.Property(e => e.EmailAddressLive)
                .HasMaxLength(255)
                .HasColumnName("EmailAddressLIVE");
            entity.Property(e => e.EmailAddressUat)
                .HasMaxLength(255)
                .HasColumnName("EmailAddressUAT");
            entity.Property(e => e.FirstName).HasMaxLength(255);
            entity.Property(e => e.JobTitle).HasMaxLength(255);
            entity.Property(e => e.LastName).HasMaxLength(255);
            entity.Property(e => e.PhoneNumber).HasMaxLength(255);
            entity.Property(e => e.Servertime)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
        });

        modelBuilder.Entity<TblSuppliersList>(entity =>
        {
            entity.ToTable("tblSuppliersList");

            entity.Property(e => e.AddressLine1).HasMaxLength(250);
            entity.Property(e => e.AddressLine2).HasMaxLength(250);
            entity.Property(e => e.AddressLine3).HasMaxLength(250);
            entity.Property(e => e.AddressLine4).HasMaxLength(250);
            entity.Property(e => e.City).HasMaxLength(50);
            entity.Property(e => e.ClientName).HasMaxLength(50);
            entity.Property(e => e.Country).HasMaxLength(50);
            entity.Property(e => e.Currency).HasMaxLength(50);
            entity.Property(e => e.Gmpaccredited).HasColumnName("GMPAccredited");
            entity.Property(e => e.Language).HasMaxLength(50);
            entity.Property(e => e.Productioncapability).HasDefaultValue(1);
            entity.Property(e => e.Sgpaccredited).HasColumnName("SGPAccredited");
            entity.Property(e => e.Smetaaccredited).HasColumnName("SMETAAccredited");
            entity.Property(e => e.Status).HasDefaultValue(true);
            entity.Property(e => e.SupplierName).HasMaxLength(250);
            entity.Property(e => e.SupplierNameEn)
                .HasMaxLength(250)
                .HasColumnName("SupplierNameEN");
            entity.Property(e => e.Suppliercode).HasMaxLength(200);
        });

        modelBuilder.Entity<TblSurvey>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("tblSurvey");

            entity.Property(e => e.Accuracy).HasMaxLength(10);
            entity.Property(e => e.Country).HasMaxLength(50);
            entity.Property(e => e.Dot)
                .HasMaxLength(10)
                .HasColumnName("DOT");
            entity.Property(e => e.EnqUid).HasMaxLength(50);
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
            entity.Property(e => e.Issues).HasMaxLength(10);
            entity.Property(e => e.Name).HasMaxLength(50);
            entity.Property(e => e.Otr)
                .HasMaxLength(10)
                .HasColumnName("OTR");
            entity.Property(e => e.OvarallExp).HasMaxLength(10);
            entity.Property(e => e.Pmp)
                .HasMaxLength(10)
                .HasColumnName("PMP");
            entity.Property(e => e.Pov)
                .HasMaxLength(10)
                .HasColumnName("POV");
            entity.Property(e => e.Qom)
                .HasMaxLength(10)
                .HasColumnName("QOM");
            entity.Property(e => e.Qos)
                .HasMaxLength(10)
                .HasColumnName("QOS");
            entity.Property(e => e.Quality).HasMaxLength(10);
            entity.Property(e => e.Responsive).HasMaxLength(10);
            entity.Property(e => e.SurveyDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<TblTemp>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("tblTemp");

            entity.Property(e => e.EndDateTime)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.StartDateTime)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
        });

        modelBuilder.Entity<TblUser>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_tblUser_1");

            entity.ToTable("tblUser", tb => tb.HasTrigger("TR_IUD_UserInsert"));

            entity.Property(e => e.ClientMembers).HasMaxLength(50);
            entity.Property(e => e.Ip).HasMaxLength(255);
            entity.Property(e => e.It).HasColumnName("IT");
            entity.Property(e => e.LastLogon).HasMaxLength(255);
            entity.Property(e => e.Papm).HasColumnName("PAPM");
            entity.Property(e => e.PapmToken).HasColumnName("PAPM_Token");
            entity.Property(e => e.Password).HasMaxLength(255);
            entity.Property(e => e.Portal)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Status).HasDefaultValue(true);
            entity.Property(e => e.UniqueId)
                .HasMaxLength(255)
                .HasColumnName("UniqueID");
            entity.Property(e => e.UserName).HasMaxLength(255);
            entity.Property(e => e.UserType).HasMaxLength(255);
        });

        modelBuilder.Entity<TblWebAdmin>(entity =>
        {
            entity.ToTable("tblWebAdmin");
        });

        modelBuilder.Entity<TblcatalogUser>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("tblcatalogUsers");

            entity.Property(e => e.Country)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.Currency)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.Entity)
                .HasMaxLength(250)
                .IsUnicode(false);
            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("id");
            entity.Property(e => e.Username)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("username");
        });

        modelBuilder.Entity<Tblcataloglogindetail>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("TBLCATALOGLOGINDETAILS");

            entity.Property(e => e.Crdate)
                .HasColumnType("smalldatetime")
                .HasColumnName("CRDATE");
            entity.Property(e => e.Emailid)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("EMAILID");
            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("ID");
            entity.Property(e => e.Password)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("PASSWORD");
            entity.Property(e => e.Type)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("TYPE");
            entity.Property(e => e.Uniquetoken)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("UNIQUETOKEN");
            entity.Property(e => e.Username)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("USERNAME");
        });

        modelBuilder.Entity<Tblcurrency>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("tblcurrency");

            entity.Property(e => e.Crdate)
                .HasColumnType("smalldatetime")
                .HasColumnName("crdate");
            entity.Property(e => e.Currency)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("ID");
            entity.Property(e => e.Value).HasColumnType("numeric(15, 2)");
        });

        modelBuilder.Entity<Tblenvironmentalimpact>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("tblenvironmentalimpact");

            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("id");
            entity.Property(e => e.MaterialUsed).HasMaxLength(200);
            entity.Property(e => e.Status).HasColumnName("status");
        });

        modelBuilder.Entity<Tblenvironmentcomparison>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("tblenvironmentcomparison");

            entity.Property(e => e.CEmbodiedCarbon).HasColumnName("C_EmbodiedCarbon");
            entity.Property(e => e.CEnergyConsumption).HasColumnName("C_EnergyConsumption");
            entity.Property(e => e.CWaterUsage).HasColumnName("C_WaterUsage");
            entity.Property(e => e.CWoodUse).HasColumnName("C_WoodUse");
            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("id");
        });

        modelBuilder.Entity<Tblmanagmenttype>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("TBLMANAGMENTTYPE");

            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("ID");
            entity.Property(e => e.Managementfeetypename)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("MANAGEMENTFEETYPENAME");
            entity.Property(e => e.Managementtypevalue)
                .HasColumnType("numeric(15, 2)")
                .HasColumnName("MANAGEMENTTYPEVALUE");
            entity.Property(e => e.Servertime)
                .HasColumnType("smalldatetime")
                .HasColumnName("SERVERTIME");
            entity.Property(e => e.Status)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("STATUS");
        });

        modelBuilder.Entity<Tblpwdhistory>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("tblpwdhistory", tb => tb.HasTrigger("trg_user_password_histories_insert"));

            entity.HasIndex(e => new { e.Userid, e.Password }, "pwd_is_not_reused").IsUnique();

            entity.Property(e => e.Createddate)
                .HasColumnType("smalldatetime")
                .HasColumnName("createddate");
            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("id");
            entity.Property(e => e.Ip).HasMaxLength(50);
            entity.Property(e => e.Password)
                .HasMaxLength(100)
                .HasColumnName("password");
            entity.Property(e => e.Portal)
                .HasMaxLength(20)
                .HasColumnName("portal");
            entity.Property(e => e.Userid).HasColumnName("userid");
            entity.Property(e => e.Username)
                .HasMaxLength(100)
                .HasColumnName("username");
            entity.Property(e => e.Usertype)
                .HasMaxLength(20)
                .HasColumnName("usertype");
        });

        modelBuilder.Entity<ViewLogonHistory>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("ViewLogonHistory");

            entity.Property(e => e.Ipaddress)
                .HasMaxLength(50)
                .HasColumnName("IPAddress");
            entity.Property(e => e.Location).HasMaxLength(50);
            entity.Property(e => e.LoginDate).HasColumnType("datetime");
            entity.Property(e => e.UserName).HasMaxLength(255);
            entity.Property(e => e.UserType).HasMaxLength(255);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
