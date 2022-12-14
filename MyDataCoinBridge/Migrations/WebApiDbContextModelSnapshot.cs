﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using MyDataCoinBridge.DataAccess;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace MyDataCoinBridge.Migrations
{
    [DbContext(typeof(WebApiDbContext))]
    partial class WebApiDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("CountryDataProvider", b =>
                {
                    b.Property<Guid>("CountriesId")
                        .HasColumnType("uuid");

                    b.Property<Guid>("DataProvidersId")
                        .HasColumnType("uuid");

                    b.HasKey("CountriesId", "DataProvidersId");

                    b.HasIndex("DataProvidersId");

                    b.ToTable("CountryDataProvider");
                });

            modelBuilder.Entity("DataProviderRewardCategory", b =>
                {
                    b.Property<Guid>("DataProvidersId")
                        .HasColumnType("uuid");

                    b.Property<Guid>("RewardCategoriesId")
                        .HasColumnType("uuid");

                    b.HasKey("DataProvidersId", "RewardCategoriesId");

                    b.HasIndex("RewardCategoriesId");

                    b.ToTable("DataProviderRewardCategory");
                });

            modelBuilder.Entity("MyDataCoinBridge.Entities.BridgeUser", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("Email")
                        .HasColumnType("text");

                    b.Property<int>("Role")
                        .HasColumnType("integer");

                    b.Property<string>("VerificationCode")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("BridgeUsers");
                });

            modelBuilder.Entity("MyDataCoinBridge.Entities.Country", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<string>("CountryCode")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("CountryName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("PhoneCode")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Countries");
                });

            modelBuilder.Entity("MyDataCoinBridge.Entities.DataProvider", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<string>("Address")
                        .HasColumnType("text");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("Email")
                        .HasColumnType("text");

                    b.Property<string>("Icon")
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Phone")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("DataProviders");
                });

            modelBuilder.Entity("MyDataCoinBridge.Entities.RewardCategory", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<string>("Description")
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("RewardCategories");
                });

            modelBuilder.Entity("MyDataCoinBridge.Entities.Transaction", b =>
                {
                    b.Property<Guid>("TxId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<decimal>("Amount")
                        .HasColumnType("numeric");

                    b.Property<string>("From")
                        .HasColumnType("text");

                    b.Property<string>("To")
                        .HasColumnType("text");

                    b.Property<DateTime>("TxDate")
                        .HasColumnType("timestamp with time zone");

                    b.Property<int>("Type")
                        .HasColumnType("integer");

                    b.HasKey("TxId");

                    b.ToTable("Transactions");
                });

            modelBuilder.Entity("MyDataCoinBridge.Entities.UserRefreshToken", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<bool>("IsActive")
                        .HasColumnType("boolean");

                    b.Property<string>("RefreshToken")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("UserRefreshTokens");
                });

            modelBuilder.Entity("MyDataCoinBridge.Entities.UserTermsOfUse", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<Guid>("DataProviderId")
                        .HasColumnType("uuid");

                    b.Property<bool>("IsRegistered")
                        .HasColumnType("boolean");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uuid");

                    b.HasKey("Id");

                    b.HasIndex("DataProviderId");

                    b.ToTable("UserTermsOfUses");
                });

            modelBuilder.Entity("CountryDataProvider", b =>
                {
                    b.HasOne("MyDataCoinBridge.Entities.Country", null)
                        .WithMany()
                        .HasForeignKey("CountriesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("MyDataCoinBridge.Entities.DataProvider", null)
                        .WithMany()
                        .HasForeignKey("DataProvidersId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("DataProviderRewardCategory", b =>
                {
                    b.HasOne("MyDataCoinBridge.Entities.DataProvider", null)
                        .WithMany()
                        .HasForeignKey("DataProvidersId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("MyDataCoinBridge.Entities.RewardCategory", null)
                        .WithMany()
                        .HasForeignKey("RewardCategoriesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("MyDataCoinBridge.Entities.UserTermsOfUse", b =>
                {
                    b.HasOne("MyDataCoinBridge.Entities.DataProvider", "DataProvider")
                        .WithMany()
                        .HasForeignKey("DataProviderId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("DataProvider");
                });
#pragma warning restore 612, 618
        }
    }
}
