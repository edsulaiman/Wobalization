﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Wobalization.Database.DatabaseContexts;

#nullable disable

namespace Wobalization.Migrations
{
    [DbContext(typeof(DatabaseContext))]
    [Migration("20230720185518_Rename Culture To Locale")]
    partial class RenameCultureToLocale
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "7.0.5");

            modelBuilder.Entity("Wobalization.Database.Models.App", b =>
                {
                    b.Property<long?>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER")
                        .HasColumnName("id");

                    b.Property<long?>("CreatedAt")
                        .IsRequired()
                        .HasColumnType("INTEGER")
                        .HasColumnName("created_at");

                    b.Property<long?>("DeletedAt")
                        .HasColumnType("INTEGER")
                        .HasColumnName("deleted_at");

                    b.Property<Guid?>("Key")
                        .IsRequired()
                        .HasColumnType("TEXT")
                        .HasColumnName("key");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("TEXT")
                        .HasColumnName("name");

                    b.Property<long?>("UpdatedAt")
                        .HasColumnType("INTEGER")
                        .HasColumnName("updated_at");

                    b.HasKey("Id")
                        .HasName("pk_app");

                    b.ToTable("app", (string)null);
                });

            modelBuilder.Entity("Wobalization.Database.Models.TranslationKey", b =>
                {
                    b.Property<long?>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER")
                        .HasColumnName("id");

                    b.Property<long?>("AppId")
                        .IsRequired()
                        .HasColumnType("INTEGER")
                        .HasColumnName("app_id");

                    b.Property<long?>("CreatedAt")
                        .IsRequired()
                        .HasColumnType("INTEGER")
                        .HasColumnName("created_at");

                    b.Property<long?>("DeletedAt")
                        .HasColumnType("INTEGER")
                        .HasColumnName("deleted_at");

                    b.Property<string>("Key")
                        .IsRequired()
                        .HasColumnType("TEXT")
                        .HasColumnName("key");

                    b.Property<long?>("UpdatedAt")
                        .HasColumnType("INTEGER")
                        .HasColumnName("updated_at");

                    b.HasKey("Id")
                        .HasName("pk_translation_key");

                    b.HasIndex("AppId")
                        .HasDatabaseName("ix_translation_key_app_id");

                    b.ToTable("translation_key", (string)null);
                });

            modelBuilder.Entity("Wobalization.Database.Models.TranslationLanguage", b =>
                {
                    b.Property<long?>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER")
                        .HasColumnName("id");

                    b.Property<long?>("AppId")
                        .IsRequired()
                        .HasColumnType("INTEGER")
                        .HasColumnName("app_id");

                    b.Property<long?>("CreatedAt")
                        .IsRequired()
                        .HasColumnType("INTEGER")
                        .HasColumnName("created_at");

                    b.Property<long?>("DeletedAt")
                        .HasColumnType("INTEGER")
                        .HasColumnName("deleted_at");

                    b.Property<string>("Locale")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("TEXT")
                        .HasColumnName("locale");

                    b.Property<long?>("UpdatedAt")
                        .HasColumnType("INTEGER")
                        .HasColumnName("updated_at");

                    b.HasKey("Id")
                        .HasName("pk_translation_language");

                    b.HasIndex("AppId")
                        .HasDatabaseName("ix_translation_language_app_id");

                    b.ToTable("translation_language", (string)null);
                });

            modelBuilder.Entity("Wobalization.Database.Models.TranslationValue", b =>
                {
                    b.Property<long?>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER")
                        .HasColumnName("id");

                    b.Property<long?>("CreatedAt")
                        .IsRequired()
                        .HasColumnType("INTEGER")
                        .HasColumnName("created_at");

                    b.Property<long?>("DeletedAt")
                        .HasColumnType("INTEGER")
                        .HasColumnName("deleted_at");

                    b.Property<long?>("TranslationKeyId")
                        .HasColumnType("INTEGER")
                        .HasColumnName("translation_key_id");

                    b.Property<long?>("TranslationLanguageId")
                        .IsRequired()
                        .HasColumnType("INTEGER")
                        .HasColumnName("translation_language_id");

                    b.Property<long?>("UpdatedAt")
                        .HasColumnType("INTEGER")
                        .HasColumnName("updated_at");

                    b.Property<string>("Value")
                        .IsRequired()
                        .HasColumnType("TEXT")
                        .HasColumnName("value");

                    b.HasKey("Id")
                        .HasName("pk_translation_value");

                    b.HasIndex("TranslationKeyId")
                        .HasDatabaseName("ix_translation_value_translation_key_id");

                    b.HasIndex("TranslationLanguageId")
                        .HasDatabaseName("ix_translation_value_translation_language_id");

                    b.ToTable("translation_value", (string)null);
                });

            modelBuilder.Entity("Wobalization.Database.Models.User", b =>
                {
                    b.Property<long?>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER")
                        .HasColumnName("id");

                    b.Property<long?>("CreatedAt")
                        .IsRequired()
                        .HasColumnType("INTEGER")
                        .HasColumnName("created_at");

                    b.Property<long?>("DeletedAt")
                        .HasColumnType("INTEGER")
                        .HasColumnName("deleted_at");

                    b.Property<string>("FullName")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("TEXT")
                        .HasColumnName("full_name");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasMaxLength(60)
                        .HasColumnType("TEXT")
                        .HasColumnName("password")
                        .IsFixedLength();

                    b.Property<long?>("UpdatedAt")
                        .HasColumnType("INTEGER")
                        .HasColumnName("updated_at");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("TEXT")
                        .HasColumnName("username");

                    b.HasKey("Id")
                        .HasName("pk_user");

                    b.ToTable("user", (string)null);
                });

            modelBuilder.Entity("Wobalization.Database.Models.TranslationKey", b =>
                {
                    b.HasOne("Wobalization.Database.Models.App", "App")
                        .WithMany()
                        .HasForeignKey("AppId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("fk_translation_key_app_app_id");

                    b.Navigation("App");
                });

            modelBuilder.Entity("Wobalization.Database.Models.TranslationLanguage", b =>
                {
                    b.HasOne("Wobalization.Database.Models.App", "App")
                        .WithMany()
                        .HasForeignKey("AppId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("fk_translation_language_app_app_id");

                    b.Navigation("App");
                });

            modelBuilder.Entity("Wobalization.Database.Models.TranslationValue", b =>
                {
                    b.HasOne("Wobalization.Database.Models.TranslationKey", "TranslationKey")
                        .WithMany("TranslationValues")
                        .HasForeignKey("TranslationKeyId")
                        .HasConstraintName("fk_translation_value_translation_key_translation_key_id");

                    b.HasOne("Wobalization.Database.Models.TranslationLanguage", "TranslationLanguage")
                        .WithMany("TranslationValues")
                        .HasForeignKey("TranslationLanguageId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("fk_translation_value_translation_language_translation_language_id");

                    b.Navigation("TranslationKey");

                    b.Navigation("TranslationLanguage");
                });

            modelBuilder.Entity("Wobalization.Database.Models.TranslationKey", b =>
                {
                    b.Navigation("TranslationValues");
                });

            modelBuilder.Entity("Wobalization.Database.Models.TranslationLanguage", b =>
                {
                    b.Navigation("TranslationValues");
                });
#pragma warning restore 612, 618
        }
    }
}