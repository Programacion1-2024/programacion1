﻿// <auto-generated />
using System;
using CDatos.Contexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace CDatos.Migrations
{
    [DbContext(typeof(LibreriaContext))]
    partial class LibreriaContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseCollation("en_US.UTF-8")
                .HasAnnotation("ProductVersion", "8.0.6")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("CEntidades.Entidades.Autor", b =>
                {
                    b.Property<int>("IdAutor")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdAutor"));

                    b.Property<string>("Biografia")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("IdPersona")
                        .HasColumnType("int");

                    b.HasKey("IdAutor")
                        .HasName("PK_ID_AUTOR");

                    b.HasIndex("IdPersona")
                        .IsUnique()
                        .HasFilter("[IdPersona] IS NOT NULL");

                    b.ToTable("Autor");
                });

            modelBuilder.Entity("CEntidades.Entidades.AutorLibro", b =>
                {
                    b.Property<int>("IdAutorLibro")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdAutorLibro"));

                    b.Property<int>("IdAutor")
                        .HasColumnType("int");

                    b.Property<int>("IdLibro")
                        .HasColumnType("int");

                    b.HasKey("IdAutorLibro")
                        .HasName("PK_ID_AUTORLIBRO");

                    b.HasIndex("IdAutor");

                    b.HasIndex("IdLibro");

                    b.ToTable("AutorLibro");
                });

            modelBuilder.Entity("CEntidades.Entidades.Cliente", b =>
                {
                    b.Property<int>("IdCliente")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdCliente"));

                    b.Property<int?>("IdPersona")
                        .HasColumnType("int");

                    b.Property<bool>("Iva")
                        .HasColumnType("bit");

                    b.Property<bool>("Membrecia")
                        .HasColumnType("bit");

                    b.HasKey("IdCliente")
                        .HasName("PK_ID_CLIENTE");

                    b.HasIndex("IdPersona")
                        .IsUnique()
                        .HasFilter("[IdPersona] IS NOT NULL");

                    b.ToTable("Cliente");
                });

            modelBuilder.Entity("CEntidades.Entidades.CopiaLibro", b =>
                {
                    b.Property<int>("IdCopiaLibro")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdCopiaLibro"));

                    b.Property<int>("IdLibro")
                        .HasColumnType("int");

                    b.Property<long>("PrecioPrestamo")
                        .HasColumnType("bigint");

                    b.HasKey("IdCopiaLibro")
                        .HasName("PK_ID_COPIALIBRO");

                    b.HasIndex("IdLibro");

                    b.ToTable("CopiaLibro");
                });

            modelBuilder.Entity("CEntidades.Entidades.Editorial", b =>
                {
                    b.Property<int>("IdEditorial")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdEditorial"));

                    b.Property<string>("Contacto")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Descripcion")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Direccion")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("IdEditorial")
                        .HasName("PK_ID_EDITORIAL");

                    b.ToTable("Editorial");
                });

            modelBuilder.Entity("CEntidades.Entidades.Empleado", b =>
                {
                    b.Property<int>("IdEmpleado")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdEmpleado"));

                    b.Property<DateTime>("FechaIngreso")
                        .HasColumnType("datetime2");

                    b.Property<int?>("IdPersona")
                        .HasColumnType("int");

                    b.Property<string>("Puesto")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<long>("Sueldo")
                        .HasColumnType("bigint");

                    b.HasKey("IdEmpleado")
                        .HasName("PK_ID_EMPLEADO");

                    b.HasIndex("IdPersona")
                        .IsUnique()
                        .HasFilter("[IdPersona] IS NOT NULL");

                    b.ToTable("Empleado");
                });

            modelBuilder.Entity("CEntidades.Entidades.FormaDePago", b =>
                {
                    b.Property<int>("IdFormaDePago")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdFormaDePago"));

                    b.Property<string>("Descripcion")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("IdFormaDePago")
                        .HasName("PK_ID_FORMADEPAGO");

                    b.ToTable("FormaDePago");
                });

            modelBuilder.Entity("CEntidades.Entidades.Genero", b =>
                {
                    b.Property<int>("IdGenero")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdGenero"));

                    b.Property<string>("Descripcion")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("IdGenero")
                        .HasName("PK_ID_GENERO");

                    b.ToTable("Genero");
                });

            modelBuilder.Entity("CEntidades.Entidades.GeneroLibro", b =>
                {
                    b.Property<int>("IdGeneroLibro")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdGeneroLibro"));

                    b.Property<int>("IdGenero")
                        .HasColumnType("int");

                    b.Property<int>("IdLibro")
                        .HasColumnType("int");

                    b.HasKey("IdGeneroLibro")
                        .HasName("PK_ID_GENEROLIBRO");

                    b.HasIndex("IdGenero");

                    b.HasIndex("IdLibro");

                    b.ToTable("GeneroLibro");
                });

            modelBuilder.Entity("CEntidades.Entidades.Imagen", b =>
                {
                    b.Property<int>("IdImagen")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdImagen"));

                    b.Property<string>("FormularioOrigen")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<long>("Tamanio")
                        .HasColumnType("bigint");

                    b.Property<string>("TipoMime")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("URL")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("IdImagen")
                        .HasName("PK_ID_IMAGEN");

                    b.ToTable("Imagen");
                });

            modelBuilder.Entity("CEntidades.Entidades.Libro", b =>
                {
                    b.Property<int>("IdLibro")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdLibro"));

                    b.Property<string>("Descripcion")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("FechaPublicacion")
                        .HasColumnType("datetime2");

                    b.Property<string>("ISBN")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("IdEditorial")
                        .HasColumnType("int");

                    b.Property<float>("PrecioVenta")
                        .HasColumnType("real");

                    b.Property<string>("Titulo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("IdLibro")
                        .HasName("PK_ID_LIBRO");

                    b.HasIndex("IdEditorial");

                    b.ToTable("Libro");
                });

            modelBuilder.Entity("CEntidades.Entidades.Persona", b =>
                {
                    b.Property<int>("IdPersona")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdPersona"));

                    b.Property<string>("Apellido")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Documento")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nacionalidad")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Telefono")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TipoDocumento")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("IdPersona")
                        .HasName("PK_ID_PERSONA");

                    b.ToTable("Persona");
                });

            modelBuilder.Entity("CEntidades.Entidades.Prestamo", b =>
                {
                    b.Property<int>("IdPrestamo")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdPrestamo"));

                    b.Property<DateTime?>("FechaDevolucion")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("FechaLimite")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("FechaPrestamo")
                        .HasColumnType("datetime2");

                    b.Property<int>("IdCliente")
                        .HasColumnType("int");

                    b.Property<int>("IdCopia")
                        .HasColumnType("int");

                    b.Property<int>("IdEmpleado")
                        .HasColumnType("int");

                    b.Property<int>("IdFormaDePago")
                        .HasColumnType("int");

                    b.HasKey("IdPrestamo")
                        .HasName("PK_ID_PRESTAMO");

                    b.HasIndex("IdCliente");

                    b.HasIndex("IdCopia");

                    b.HasIndex("IdEmpleado");

                    b.HasIndex("IdFormaDePago");

                    b.ToTable("Prestamo");
                });

            modelBuilder.Entity("CEntidades.Entidades.Venta", b =>
                {
                    b.Property<int>("IdVenta")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdVenta"));

                    b.Property<DateTime>("FechaVenta")
                        .HasColumnType("datetime2");

                    b.Property<int>("IdCliente")
                        .HasColumnType("int");

                    b.Property<int>("IdEmpleado")
                        .HasColumnType("int");

                    b.Property<int>("IdFormaDePago")
                        .HasColumnType("int");

                    b.Property<int>("IdLibro")
                        .HasColumnType("int");

                    b.HasKey("IdVenta")
                        .HasName("PK_ID_VENTA");

                    b.HasIndex("IdCliente");

                    b.HasIndex("IdEmpleado");

                    b.HasIndex("IdFormaDePago");

                    b.HasIndex("IdLibro");

                    b.ToTable("Venta");
                });

            modelBuilder.Entity("CEntidades.Entidades.Autor", b =>
                {
                    b.HasOne("CEntidades.Entidades.Persona", "Persona")
                        .WithOne("Autor")
                        .HasForeignKey("CEntidades.Entidades.Autor", "IdPersona");

                    b.Navigation("Persona");
                });

            modelBuilder.Entity("CEntidades.Entidades.AutorLibro", b =>
                {
                    b.HasOne("CEntidades.Entidades.Autor", null)
                        .WithMany()
                        .HasForeignKey("IdAutor")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("CEntidades.Entidades.Libro", null)
                        .WithMany()
                        .HasForeignKey("IdLibro")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();
                });

            modelBuilder.Entity("CEntidades.Entidades.Cliente", b =>
                {
                    b.HasOne("CEntidades.Entidades.Persona", "Persona")
                        .WithOne("Cliente")
                        .HasForeignKey("CEntidades.Entidades.Cliente", "IdPersona");

                    b.Navigation("Persona");
                });

            modelBuilder.Entity("CEntidades.Entidades.CopiaLibro", b =>
                {
                    b.HasOne("CEntidades.Entidades.Libro", "Libro")
                        .WithMany("CopiasLibro")
                        .HasForeignKey("IdLibro")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("Libro");
                });

            modelBuilder.Entity("CEntidades.Entidades.Empleado", b =>
                {
                    b.HasOne("CEntidades.Entidades.Persona", "Persona")
                        .WithOne("Empleado")
                        .HasForeignKey("CEntidades.Entidades.Empleado", "IdPersona");

                    b.Navigation("Persona");
                });

            modelBuilder.Entity("CEntidades.Entidades.GeneroLibro", b =>
                {
                    b.HasOne("CEntidades.Entidades.Genero", null)
                        .WithMany()
                        .HasForeignKey("IdGenero")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("CEntidades.Entidades.Libro", null)
                        .WithMany()
                        .HasForeignKey("IdLibro")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("CEntidades.Entidades.Libro", b =>
                {
                    b.HasOne("CEntidades.Entidades.Editorial", "Editorial")
                        .WithMany("Libros")
                        .HasForeignKey("IdEditorial")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Editorial");
                });

            modelBuilder.Entity("CEntidades.Entidades.Prestamo", b =>
                {
                    b.HasOne("CEntidades.Entidades.Cliente", "Cliente")
                        .WithMany("Prestamos")
                        .HasForeignKey("IdCliente")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("CEntidades.Entidades.CopiaLibro", "CopiaLibro")
                        .WithMany("Prestamos")
                        .HasForeignKey("IdCopia")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("CEntidades.Entidades.Empleado", "Empleado")
                        .WithMany("Prestamos")
                        .HasForeignKey("IdEmpleado")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("CEntidades.Entidades.FormaDePago", "FormaDePago")
                        .WithMany("Prestamo")
                        .HasForeignKey("IdFormaDePago")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Cliente");

                    b.Navigation("CopiaLibro");

                    b.Navigation("Empleado");

                    b.Navigation("FormaDePago");
                });

            modelBuilder.Entity("CEntidades.Entidades.Venta", b =>
                {
                    b.HasOne("CEntidades.Entidades.Cliente", "Cliente")
                        .WithMany("Ventas")
                        .HasForeignKey("IdCliente")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("CEntidades.Entidades.Empleado", "Empleado")
                        .WithMany("Ventas")
                        .HasForeignKey("IdEmpleado")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("CEntidades.Entidades.FormaDePago", "FormaDePago")
                        .WithMany("Venta")
                        .HasForeignKey("IdFormaDePago")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("CEntidades.Entidades.Libro", "Libro")
                        .WithMany("Venta")
                        .HasForeignKey("IdLibro")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Cliente");

                    b.Navigation("Empleado");

                    b.Navigation("FormaDePago");

                    b.Navigation("Libro");
                });

            modelBuilder.Entity("CEntidades.Entidades.Cliente", b =>
                {
                    b.Navigation("Prestamos");

                    b.Navigation("Ventas");
                });

            modelBuilder.Entity("CEntidades.Entidades.CopiaLibro", b =>
                {
                    b.Navigation("Prestamos");
                });

            modelBuilder.Entity("CEntidades.Entidades.Editorial", b =>
                {
                    b.Navigation("Libros");
                });

            modelBuilder.Entity("CEntidades.Entidades.Empleado", b =>
                {
                    b.Navigation("Prestamos");

                    b.Navigation("Ventas");
                });

            modelBuilder.Entity("CEntidades.Entidades.FormaDePago", b =>
                {
                    b.Navigation("Prestamo");

                    b.Navigation("Venta");
                });

            modelBuilder.Entity("CEntidades.Entidades.Libro", b =>
                {
                    b.Navigation("CopiasLibro");

                    b.Navigation("Venta");
                });

            modelBuilder.Entity("CEntidades.Entidades.Persona", b =>
                {
                    b.Navigation("Autor");

                    b.Navigation("Cliente");

                    b.Navigation("Empleado");
                });
#pragma warning restore 612, 618
        }
    }
}
