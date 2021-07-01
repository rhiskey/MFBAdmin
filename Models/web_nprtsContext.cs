using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace MFBAdminMBlazorServer.Models
{
    public partial class web_nprtsContext : DbContext
    {
        public web_nprtsContext()
        {
        }

        public web_nprtsContext(DbContextOptions<web_nprtsContext> options)
            : base(options)
        {
        }

        public virtual DbSet<MfbDisclosureFirstPartItem> MfbDisclosureFirstPartItems { get; set; }
        public virtual DbSet<MfbDisclosureFirstPartItemList> MfbDisclosureFirstPartItemLists { get; set; }
        public virtual DbSet<MfbDisclosureSecondPartItem> MfbDisclosureSecondPartItems { get; set; }
        public virtual DbSet<MfbDisclosureSecondPartItemList> MfbDisclosureSecondPartItemLists { get; set; }
        public virtual DbSet<MfbFineRate> MfbFineRates { get; set; }
        public virtual DbSet<MfbFineRateHist> MfbFineRateHists { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Data Source=;Initial Catalog=;User ID=;Password=");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "Cyrillic_General_BIN");


            modelBuilder.Entity<MfbDisclosureFirstPartItem>(entity =>
            {
                entity.ToTable("mfb_disclosure_first_part_item");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.ItemCode)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("item_code");

                entity.Property(e => e.ItemDescription)
                    .HasMaxLength(1024)
                    .IsUnicode(false)
                    .HasColumnName("item_description");

                entity.Property(e => e.ItemShowFlags).HasColumnName("item_show_flags");

                entity.Property(e => e.Now)
                    .HasColumnType("datetime")
                    .HasColumnName("now")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.RegulationCode)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("regulation_code");

                entity.Property(e => e.Seq).HasColumnName("seq");

                entity.Property(e => e.Status).HasColumnName("status");

                entity.Property(e => e.Username)
                    .HasMaxLength(64)
                    .IsUnicode(false)
                    .HasColumnName("username")
                    .HasDefaultValueSql("(suser_sname())");
            });

            modelBuilder.Entity<MfbDisclosureFirstPartItemList>(entity =>
            {
                entity.ToTable("mfb_disclosure_first_part_item_list");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.DateFrom)
                    .HasColumnType("date")
                    .HasColumnName("date_from");

                entity.Property(e => e.DateTo)
                    .HasColumnType("date")
                    .HasColumnName("date_to");

                entity.Property(e => e.Idp).HasColumnName("idp");

                entity.Property(e => e.ItemListCategory)
                    .HasMaxLength(1024)
                    .IsUnicode(false)
                    .HasColumnName("item_list_category");

                entity.Property(e => e.ItemListDesc)
                    .HasMaxLength(2048)
                    .IsUnicode(false)
                    .HasColumnName("item_list_desc");

                entity.Property(e => e.ItemListType).HasColumnName("item_list_type");

                entity.Property(e => e.ItemListValue)
                    .HasMaxLength(4096)
                    .IsUnicode(false)
                    .HasColumnName("item_list_value");

                entity.Property(e => e.Memo)
                    .HasMaxLength(1024)
                    .IsUnicode(false)
                    .HasColumnName("memo");

                entity.Property(e => e.Now)
                    .HasColumnType("datetime")
                    .HasColumnName("now")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.PublishMoment)
                    .HasColumnType("datetime")
                    .HasColumnName("publish_moment");

                entity.Property(e => e.Seq).HasColumnName("seq");

                entity.Property(e => e.Status).HasColumnName("status");

                entity.Property(e => e.Username)
                    .HasMaxLength(64)
                    .IsUnicode(false)
                    .HasColumnName("username")
                    .HasDefaultValueSql("(suser_sname())");

                entity.HasOne(d => d.IdpNavigation)
                    .WithMany(p => p.MfbDisclosureFirstPartItemLists)
                    .HasForeignKey(d => d.Idp)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_mfb_disclosure_first_part_item_list_mfb_disclosure_first_part_item");
            });

            modelBuilder.Entity<MfbDisclosureSecondPartItem>(entity =>
            {
                entity.ToTable("mfb_disclosure_second_part_item");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.DateFrom)
                    .HasColumnType("date")
                    .HasColumnName("date_from");

                entity.Property(e => e.DateTo)
                    .HasColumnType("date")
                    .HasColumnName("date_to");

                entity.Property(e => e.ExtraDetails)
                    .HasMaxLength(4096)
                    .IsUnicode(false)
                    .HasColumnName("extra_details");

                entity.Property(e => e.Frequency).HasColumnName("frequency");

                entity.Property(e => e.ItemCode)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("item_code");

                entity.Property(e => e.ItemDescription)
                    .HasMaxLength(1024)
                    .IsUnicode(false)
                    .HasColumnName("item_description");

                entity.Property(e => e.ItemNumber)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("item_number");

                entity.Property(e => e.ItemType).HasColumnName("item_type");

                entity.Property(e => e.ItemValue)
                    .HasMaxLength(4096)
                    .IsUnicode(false)
                    .HasColumnName("item_value");

                entity.Property(e => e.Now)
                    .HasColumnType("datetime")
                    .HasColumnName("now")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.PublishMoment)
                    .HasColumnType("datetime")
                    .HasColumnName("publish_moment");

                entity.Property(e => e.RegulationCode)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("regulation_code");

                entity.Property(e => e.Seq).HasColumnName("seq");

                entity.Property(e => e.Status).HasColumnName("status");

                entity.Property(e => e.Username)
                    .HasMaxLength(64)
                    .IsUnicode(false)
                    .HasColumnName("username")
                    .HasDefaultValueSql("(suser_sname())");
            });

            modelBuilder.Entity<MfbDisclosureSecondPartItemList>(entity =>
            {
                entity.ToTable("mfb_disclosure_second_part_item_list");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Idp).HasColumnName("idp");

                entity.Property(e => e.ItemListCategory)
                    .HasMaxLength(1024)
                    .IsUnicode(false)
                    .HasColumnName("item_list_category");

                entity.Property(e => e.ItemListDesc)
                    .HasMaxLength(2048)
                    .IsUnicode(false)
                    .HasColumnName("item_list_desc");

                entity.Property(e => e.ItemListType).HasColumnName("item_list_type");

                entity.Property(e => e.ItemListValue)
                    .HasMaxLength(4096)
                    .IsUnicode(false)
                    .HasColumnName("item_list_value");

                entity.Property(e => e.Seq).HasColumnName("seq");

                entity.HasOne(d => d.IdpNavigation)
                    .WithMany(p => p.MfbDisclosureSecondPartItemLists)
                    .HasForeignKey(d => d.Idp)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_mfb_disclosure_second_part_item_list_mfb_disclosure_second_part_item");
            });

            modelBuilder.Entity<MfbFineRate>(entity =>
            {
                entity.ToTable("mfb_fine_rate");

                entity.HasIndex(e => e.ReportDate, "IX_mfb_fine_rate_report_date");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.AssetCode)
                    .HasMaxLength(16)
                    .HasColumnName("asset_code");

                entity.Property(e => e.AssetIsin)
                    .HasMaxLength(16)
                    .HasColumnName("asset_isin");

                entity.Property(e => e.AssetName)
                    .HasMaxLength(256)
                    .HasColumnName("asset_name");

                entity.Property(e => e.BaseLimit)
                    .HasColumnType("numeric(16, 6)")
                    .HasColumnName("base_limit");

                entity.Property(e => e.BaseLimitSurprise)
                    .HasColumnType("numeric(16, 6)")
                    .HasColumnName("base_limit_surprise");

                entity.Property(e => e.CurrencyCode)
                    .HasMaxLength(10)
                    .HasColumnName("currency_code");

                entity.Property(e => e.CurrencyName)
                    .HasMaxLength(32)
                    .HasColumnName("currency_name");

                entity.Property(e => e.FineLongDonor)
                    .HasColumnType("numeric(16, 6)")
                    .HasColumnName("fine_long_donor");

                entity.Property(e => e.FineLongGuilty)
                    .HasColumnType("numeric(16, 6)")
                    .HasColumnName("fine_long_guilty");

                entity.Property(e => e.FineLongVictim)
                    .HasColumnType("numeric(16, 6)")
                    .HasColumnName("fine_long_victim");

                entity.Property(e => e.FineShortDonor)
                    .HasColumnType("numeric(16, 6)")
                    .HasColumnName("fine_short_donor");

                entity.Property(e => e.FineShortGuilty)
                    .HasColumnType("numeric(16, 6)")
                    .HasColumnName("fine_short_guilty");

                entity.Property(e => e.FineShortVictim)
                    .HasColumnType("numeric(16, 6)")
                    .HasColumnName("fine_short_victim");

                entity.Property(e => e.GroupName)
                    .HasMaxLength(256)
                    .HasColumnName("group_name");

                entity.Property(e => e.MrStress)
                    .HasColumnType("numeric(16, 6)")
                    .HasColumnName("mr_stress");

                entity.Property(e => e.ReportDate)
                    .HasColumnType("date")
                    .HasColumnName("report_date");
            });

            modelBuilder.Entity<MfbFineRateHist>(entity =>
            {
                entity.ToTable("mfb_fine_rate_hist");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.AssetCode)
                    .HasMaxLength(16)
                    .HasColumnName("asset_code");

                entity.Property(e => e.AssetIsin)
                    .HasMaxLength(16)
                    .HasColumnName("asset_isin");

                entity.Property(e => e.AssetName)
                    .HasMaxLength(256)
                    .HasColumnName("asset_name");

                entity.Property(e => e.BaseLimit)
                    .HasColumnType("numeric(16, 6)")
                    .HasColumnName("base_limit");

                entity.Property(e => e.BaseLimitSurprise)
                    .HasColumnType("numeric(16, 6)")
                    .HasColumnName("base_limit_surprise");

                entity.Property(e => e.CurrencyCode)
                    .HasMaxLength(10)
                    .HasColumnName("currency_code");

                entity.Property(e => e.CurrencyName)
                    .HasMaxLength(32)
                    .HasColumnName("currency_name");

                entity.Property(e => e.FineLongDonor)
                    .HasColumnType("numeric(16, 6)")
                    .HasColumnName("fine_long_donor");

                entity.Property(e => e.FineLongGuilty)
                    .HasColumnType("numeric(16, 6)")
                    .HasColumnName("fine_long_guilty");

                entity.Property(e => e.FineLongVictim)
                    .HasColumnType("numeric(16, 6)")
                    .HasColumnName("fine_long_victim");

                entity.Property(e => e.FineShortDonor)
                    .HasColumnType("numeric(16, 6)")
                    .HasColumnName("fine_short_donor");

                entity.Property(e => e.FineShortGuilty)
                    .HasColumnType("numeric(16, 6)")
                    .HasColumnName("fine_short_guilty");

                entity.Property(e => e.FineShortVictim)
                    .HasColumnType("numeric(16, 6)")
                    .HasColumnName("fine_short_victim");

                entity.Property(e => e.GroupName)
                    .HasMaxLength(256)
                    .HasColumnName("group_name");

                entity.Property(e => e.MrStress)
                    .HasColumnType("numeric(16, 6)")
                    .HasColumnName("mr_stress");

                entity.Property(e => e.ReportDate)
                    .HasColumnType("date")
                    .HasColumnName("report_date");
            });

 

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
