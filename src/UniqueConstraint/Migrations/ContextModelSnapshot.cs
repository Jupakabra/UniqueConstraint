using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using UniqueConstraint;

namespace UniqueConstraint.Migrations
{
    [DbContext(typeof(Context))]
    partial class ContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "1.1.0-rtm-22752")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("UniqueConstraint.Models.Model", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int?>("RelationId");

                    b.HasKey("Id");

                    b.HasIndex("RelationId");

                    b.ToTable("Models");
                });

            modelBuilder.Entity("UniqueConstraint.Models.Relation", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(128);

                    b.HasKey("Id");

                    b.HasIndex("Title")
                        .IsUnique();

                    b.ToTable("Relations");
                });

            modelBuilder.Entity("UniqueConstraint.Models.Model", b =>
                {
                    b.HasOne("UniqueConstraint.Models.Relation", "Relation")
                        .WithMany()
                        .HasForeignKey("RelationId");
                });
        }
    }
}
