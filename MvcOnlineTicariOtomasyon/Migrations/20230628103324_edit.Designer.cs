﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using MvcOnlineTicariOtomasyon.Models.Siniflar;

#nullable disable

namespace MvcOnlineTicariOtomasyon.Migrations
{
    [DbContext(typeof(TicariOtomasyonDbContext))]
    [Migration("20230628103324_edit")]
    partial class edit
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("MvcOnlineTicariOtomasyon.Models.Siniflar.Admin", b =>
                {
                    b.Property<int>("Adminid")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Adminid"));

                    b.Property<string>("KullaniciAd")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("Varchar");

                    b.Property<string>("Sifre")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("Varchar");

                    b.Property<string>("Yetki")
                        .IsRequired()
                        .HasMaxLength(1)
                        .HasColumnType("Char");

                    b.HasKey("Adminid");

                    b.ToTable("Admins");
                });

            modelBuilder.Entity("MvcOnlineTicariOtomasyon.Models.Siniflar.Cariler", b =>
                {
                    b.Property<int>("Cariid")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Cariid"));

                    b.Property<string>("CariAd")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("Varchar");

                    b.Property<string>("CariMail")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("Varchar");

                    b.Property<string>("CariSehir")
                        .IsRequired()
                        .HasMaxLength(13)
                        .HasColumnType("Varchar");

                    b.Property<string>("CariSoyad")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("Varchar");

                    b.HasKey("Cariid");

                    b.ToTable("Carilers");
                });

            modelBuilder.Entity("MvcOnlineTicariOtomasyon.Models.Siniflar.Departman", b =>
                {
                    b.Property<int>("Departmanid")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Departmanid"));

                    b.Property<string>("DepartmanAd")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("Varchar");

                    b.HasKey("Departmanid");

                    b.ToTable("Departmans");
                });

            modelBuilder.Entity("MvcOnlineTicariOtomasyon.Models.Siniflar.FaturaKalem", b =>
                {
                    b.Property<int>("FaturaKalemid")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("FaturaKalemid"));

                    b.Property<string>("Aciklama")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("Varchar");

                    b.Property<decimal>("BirimFiyat")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("FaturalarFaturaid")
                        .HasColumnType("int");

                    b.Property<int>("Miktar")
                        .HasColumnType("int");

                    b.Property<decimal>("Tutar")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("FaturaKalemid");

                    b.HasIndex("FaturalarFaturaid");

                    b.ToTable("FaturaKalems");
                });

            modelBuilder.Entity("MvcOnlineTicariOtomasyon.Models.Siniflar.Faturalar", b =>
                {
                    b.Property<int>("Faturaid")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Faturaid"));

                    b.Property<string>("FaturaSeriNo")
                        .IsRequired()
                        .HasMaxLength(1)
                        .HasColumnType("Char");

                    b.Property<string>("FaturaSiraNo")
                        .IsRequired()
                        .HasMaxLength(6)
                        .HasColumnType("Varchar");

                    b.Property<DateTime>("Saat")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("Tarih")
                        .HasColumnType("datetime2");

                    b.Property<string>("TeslimAlan")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("Varchar");

                    b.Property<string>("TeslimEden")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("Varchar");

                    b.Property<string>("VergiDairesi")
                        .IsRequired()
                        .HasMaxLength(60)
                        .HasColumnType("Varchar");

                    b.HasKey("Faturaid");

                    b.ToTable("Faturalars");
                });

            modelBuilder.Entity("MvcOnlineTicariOtomasyon.Models.Siniflar.Gider", b =>
                {
                    b.Property<int>("Giderid")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Giderid"));

                    b.Property<string>("Aciklama")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("Varchar");

                    b.Property<DateTime>("Tarih")
                        .HasColumnType("datetime2");

                    b.Property<decimal>("Tutar")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("Giderid");

                    b.ToTable("Giders");
                });

            modelBuilder.Entity("MvcOnlineTicariOtomasyon.Models.Siniflar.Kategori", b =>
                {
                    b.Property<int>("KategoriID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("KategoriID"));

                    b.Property<string>("KategoriAd")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("Varchar");

                    b.HasKey("KategoriID");

                    b.ToTable("Kategoris");
                });

            modelBuilder.Entity("MvcOnlineTicariOtomasyon.Models.Siniflar.Personel", b =>
                {
                    b.Property<int>("Personelid")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Personelid"));

                    b.Property<int>("Departmanid")
                        .HasColumnType("int");

                    b.Property<string>("PersonelAd")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("Varchar");

                    b.Property<string>("PersonelGorsel")
                        .IsRequired()
                        .HasMaxLength(250)
                        .HasColumnType("Varchar");

                    b.Property<string>("PersonelSoyad")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("Varchar");

                    b.HasKey("Personelid");

                    b.HasIndex("Departmanid");

                    b.ToTable("Personels");
                });

            modelBuilder.Entity("MvcOnlineTicariOtomasyon.Models.Siniflar.SatisHareket", b =>
                {
                    b.Property<int>("Satisid")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Satisid"));

                    b.Property<int>("Adet")
                        .HasColumnType("int");

                    b.Property<int>("CarilerCariid")
                        .HasColumnType("int");

                    b.Property<decimal>("Fiyat")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("Personelid")
                        .HasColumnType("int");

                    b.Property<DateTime>("Tarih")
                        .HasColumnType("datetime2");

                    b.Property<decimal>("ToplamTutar")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("UrunId")
                        .HasColumnType("int");

                    b.HasKey("Satisid");

                    b.HasIndex("CarilerCariid");

                    b.HasIndex("Personelid");

                    b.HasIndex("UrunId");

                    b.ToTable("SatisHarekets");
                });

            modelBuilder.Entity("MvcOnlineTicariOtomasyon.Models.Siniflar.Urun", b =>
                {
                    b.Property<int>("UrunId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("UrunId"));

                    b.Property<decimal>("AlisFiyat")
                        .HasColumnType("decimal(18,2)");

                    b.Property<bool>("Durum")
                        .HasColumnType("bit");

                    b.Property<int>("KategoriID")
                        .HasColumnType("int");

                    b.Property<string>("Marka")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("Varchar");

                    b.Property<decimal>("SatisFiyat")
                        .HasColumnType("decimal(18,2)");

                    b.Property<short>("Stok")
                        .HasColumnType("smallint");

                    b.Property<string>("UrunAd")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("Varchar");

                    b.Property<string>("UrunGorsel")
                        .IsRequired()
                        .HasMaxLength(250)
                        .HasColumnType("Varchar");

                    b.HasKey("UrunId");

                    b.HasIndex("KategoriID");

                    b.ToTable("Uruns");
                });

            modelBuilder.Entity("MvcOnlineTicariOtomasyon.Models.Siniflar.FaturaKalem", b =>
                {
                    b.HasOne("MvcOnlineTicariOtomasyon.Models.Siniflar.Faturalar", "Faturalar")
                        .WithMany("FaturaKalems")
                        .HasForeignKey("FaturalarFaturaid")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Faturalar");
                });

            modelBuilder.Entity("MvcOnlineTicariOtomasyon.Models.Siniflar.Personel", b =>
                {
                    b.HasOne("MvcOnlineTicariOtomasyon.Models.Siniflar.Departman", "Departman")
                        .WithMany("Personels")
                        .HasForeignKey("Departmanid")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Departman");
                });

            modelBuilder.Entity("MvcOnlineTicariOtomasyon.Models.Siniflar.SatisHareket", b =>
                {
                    b.HasOne("MvcOnlineTicariOtomasyon.Models.Siniflar.Cariler", "Cariler")
                        .WithMany("SatisHarekets")
                        .HasForeignKey("CarilerCariid")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("MvcOnlineTicariOtomasyon.Models.Siniflar.Personel", "Personel")
                        .WithMany("SatisHarekets")
                        .HasForeignKey("Personelid")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("MvcOnlineTicariOtomasyon.Models.Siniflar.Urun", "Urun")
                        .WithMany("SatisHarekets")
                        .HasForeignKey("UrunId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Cariler");

                    b.Navigation("Personel");

                    b.Navigation("Urun");
                });

            modelBuilder.Entity("MvcOnlineTicariOtomasyon.Models.Siniflar.Urun", b =>
                {
                    b.HasOne("MvcOnlineTicariOtomasyon.Models.Siniflar.Kategori", "Kategori")
                        .WithMany("Uruns")
                        .HasForeignKey("KategoriID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Kategori");
                });

            modelBuilder.Entity("MvcOnlineTicariOtomasyon.Models.Siniflar.Cariler", b =>
                {
                    b.Navigation("SatisHarekets");
                });

            modelBuilder.Entity("MvcOnlineTicariOtomasyon.Models.Siniflar.Departman", b =>
                {
                    b.Navigation("Personels");
                });

            modelBuilder.Entity("MvcOnlineTicariOtomasyon.Models.Siniflar.Faturalar", b =>
                {
                    b.Navigation("FaturaKalems");
                });

            modelBuilder.Entity("MvcOnlineTicariOtomasyon.Models.Siniflar.Kategori", b =>
                {
                    b.Navigation("Uruns");
                });

            modelBuilder.Entity("MvcOnlineTicariOtomasyon.Models.Siniflar.Personel", b =>
                {
                    b.Navigation("SatisHarekets");
                });

            modelBuilder.Entity("MvcOnlineTicariOtomasyon.Models.Siniflar.Urun", b =>
                {
                    b.Navigation("SatisHarekets");
                });
#pragma warning restore 612, 618
        }
    }
}
