using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Unipet.Migrations
{
    public partial class criarbanco : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterDatabase()
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Blog",
                columns: table => new
                {
                    IdPublicacao = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Titulo = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Texto = table.Column<string>(type: "varchar(1000)", maxLength: 1000, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    DataPublicacao = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    Foto = table.Column<string>(type: "varchar(200)", maxLength: 200, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ExibirHome = table.Column<bool>(type: "tinyint(1)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Blog", x => x.IdPublicacao);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Contato",
                columns: table => new
                {
                    IdContato = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Nome = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Assunto = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Email = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Telefone = table.Column<string>(type: "varchar(20)", maxLength: 20, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Celular = table.Column<string>(type: "varchar(20)", maxLength: 20, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Mensagem = table.Column<string>(type: "varchar(1000)", maxLength: 1000, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Contato", x => x.IdContato);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Especialidade",
                columns: table => new
                {
                    IdEspecialidade = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    NomeEspecialidade = table.Column<string>(type: "varchar(20)", maxLength: 20, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Especialidade", x => x.IdEspecialidade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Especie",
                columns: table => new
                {
                    IdEspecie = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    NomeEspecie = table.Column<string>(type: "varchar(20)", maxLength: 20, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Especie", x => x.IdEspecie);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Perfil",
                columns: table => new
                {
                    Id = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Name = table.Column<string>(type: "varchar(256)", maxLength: 256, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    NormalizedName = table.Column<string>(type: "varchar(256)", maxLength: 256, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ConcurrencyStamp = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Perfil", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Porte",
                columns: table => new
                {
                    IdPorte = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    NomePorte = table.Column<string>(type: "varchar(1)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Porte", x => x.IdPorte);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Relato",
                columns: table => new
                {
                    IdRelato = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Nome = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Texto = table.Column<string>(type: "varchar(1000)", maxLength: 1000, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Foto = table.Column<string>(type: "varchar(200)", maxLength: 200, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ExibirHome = table.Column<bool>(type: "tinyint(1)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Relato", x => x.IdRelato);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "UF",
                columns: table => new
                {
                    IdUF = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Sigla = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    NomeEstado = table.Column<string>(type: "varchar(64)", maxLength: 64, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UF", x => x.IdUF);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Usuario",
                columns: table => new
                {
                    Id = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Nome = table.Column<string>(type: "varchar(60)", maxLength: 60, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    LimiteAlteracaoNomeUsuario = table.Column<int>(type: "int", nullable: false),
                    Avatar = table.Column<byte[]>(type: "longblob", nullable: true),
                    DataNascimento = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    UserName = table.Column<string>(type: "varchar(256)", maxLength: 256, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    NormalizedUserName = table.Column<string>(type: "varchar(256)", maxLength: 256, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Email = table.Column<string>(type: "varchar(256)", maxLength: 256, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    NormalizedEmail = table.Column<string>(type: "varchar(256)", maxLength: 256, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    EmailConfirmed = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    PasswordHash = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    SecurityStamp = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ConcurrencyStamp = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    PhoneNumber = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    PhoneNumberConfirmed = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetime(6)", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Usuario", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Raca",
                columns: table => new
                {
                    IdRaca = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    NomeRaca = table.Column<string>(type: "varchar(30)", maxLength: 30, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    IdEspecie = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Raca", x => x.IdRaca);
                    table.ForeignKey(
                        name: "FK_Raca_Especie_IdEspecie",
                        column: x => x.IdEspecie,
                        principalTable: "Especie",
                        principalColumn: "IdEspecie",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "PerfilClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    RoleId = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ClaimType = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ClaimValue = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PerfilClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PerfilClaims_Perfil_RoleId",
                        column: x => x.RoleId,
                        principalTable: "Perfil",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Municipio",
                columns: table => new
                {
                    IdMunicipio = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    NomeMunicipio = table.Column<string>(type: "varchar(64)", maxLength: 64, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    IdUF = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Municipio", x => x.IdMunicipio);
                    table.ForeignKey(
                        name: "FK_Municipio_UF_IdUF",
                        column: x => x.IdUF,
                        principalTable: "UF",
                        principalColumn: "IdUF",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    UserId = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ClaimType = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ClaimValue = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_Usuario_UserId",
                        column: x => x.UserId,
                        principalTable: "Usuario",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "UsuarioLogin",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ProviderKey = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ProviderDisplayName = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    UserId = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UsuarioLogin", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_UsuarioLogin_Usuario_UserId",
                        column: x => x.UserId,
                        principalTable: "Usuario",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "UsuarioPerfil",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    RoleId = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UsuarioPerfil", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_UsuarioPerfil_Perfil_RoleId",
                        column: x => x.RoleId,
                        principalTable: "Perfil",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UsuarioPerfil_Usuario_UserId",
                        column: x => x.UserId,
                        principalTable: "Usuario",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "UsuarioTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    LoginProvider = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Name = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Value = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UsuarioTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_UsuarioTokens_Usuario_UserId",
                        column: x => x.UserId,
                        principalTable: "Usuario",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Endereco",
                columns: table => new
                {
                    IdEndereco = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Logradouro = table.Column<string>(type: "varchar(60)", maxLength: 60, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    NumeroCasa = table.Column<int>(type: "int", maxLength: 9, nullable: false),
                    CEP = table.Column<string>(type: "varchar(9)", maxLength: 9, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Bairro = table.Column<string>(type: "varchar(60)", maxLength: 60, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    IdMunicipio = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Endereco", x => x.IdEndereco);
                    table.ForeignKey(
                        name: "FK_Endereco_Municipio_IdMunicipio",
                        column: x => x.IdMunicipio,
                        principalTable: "Municipio",
                        principalColumn: "IdMunicipio",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Empresa",
                columns: table => new
                {
                    IdEmpresa = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    RazaoSocial = table.Column<string>(type: "varchar(60)", maxLength: 60, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    CNPJ = table.Column<string>(type: "varchar(14)", maxLength: 14, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Email = table.Column<string>(type: "varchar(60)", maxLength: 60, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Fone = table.Column<string>(type: "varchar(20)", maxLength: 20, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Logotipo = table.Column<string>(type: "varchar(200)", maxLength: 200, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ExibirHome = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    IdEndereco = table.Column<int>(type: "int", nullable: false),
                    IdUsuario = table.Column<string>(type: "varchar(255)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Empresa", x => x.IdEmpresa);
                    table.ForeignKey(
                        name: "FK_Empresa_Endereco_IdEndereco",
                        column: x => x.IdEndereco,
                        principalTable: "Endereco",
                        principalColumn: "IdEndereco",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Empresa_Usuario_IdUsuario",
                        column: x => x.IdUsuario,
                        principalTable: "Usuario",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Prestador",
                columns: table => new
                {
                    IdPrestador = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    RazaoSocial = table.Column<string>(type: "varchar(60)", maxLength: 60, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    CNPJ = table.Column<string>(type: "varchar(14)", maxLength: 14, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Email = table.Column<string>(type: "varchar(60)", maxLength: 60, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Fone = table.Column<string>(type: "varchar(20)", maxLength: 20, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Logotipo = table.Column<string>(type: "varchar(200)", maxLength: 200, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    IdEndereco = table.Column<int>(type: "int", nullable: false),
                    IdUsuario = table.Column<string>(type: "varchar(255)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ExibirHome = table.Column<bool>(type: "tinyint(1)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Prestador", x => x.IdPrestador);
                    table.ForeignKey(
                        name: "FK_Prestador_Endereco_IdEndereco",
                        column: x => x.IdEndereco,
                        principalTable: "Endereco",
                        principalColumn: "IdEndereco",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Prestador_Usuario_IdUsuario",
                        column: x => x.IdUsuario,
                        principalTable: "Usuario",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Tutor",
                columns: table => new
                {
                    IdTutor = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    NomeTutor = table.Column<string>(type: "varchar(60)", maxLength: 60, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Email = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    CPF = table.Column<string>(type: "varchar(11)", maxLength: 11, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    RG = table.Column<string>(type: "varchar(20)", maxLength: 20, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Sexo = table.Column<string>(type: "varchar(1)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Foto = table.Column<string>(type: "varchar(200)", maxLength: 200, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Fone = table.Column<string>(type: "varchar(20)", maxLength: 20, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Celular = table.Column<string>(type: "varchar(20)", maxLength: 20, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    IdEndereco = table.Column<int>(type: "int", nullable: false),
                    IdUsuario = table.Column<string>(type: "varchar(255)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ExibirHome = table.Column<bool>(type: "tinyint(1)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tutor", x => x.IdTutor);
                    table.ForeignKey(
                        name: "FK_Tutor_Endereco_IdEndereco",
                        column: x => x.IdEndereco,
                        principalTable: "Endereco",
                        principalColumn: "IdEndereco",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Tutor_Usuario_IdUsuario",
                        column: x => x.IdUsuario,
                        principalTable: "Usuario",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "AreaCobertura",
                columns: table => new
                {
                    IdArea = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    NomeArea = table.Column<string>(type: "varchar(30)", maxLength: 30, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    IdMunicipio = table.Column<int>(type: "int", nullable: false),
                    IdEmpresa = table.Column<int>(type: "int", nullable: false),
                    ExibirHome = table.Column<bool>(type: "tinyint(1)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AreaCobertura", x => x.IdArea);
                    table.ForeignKey(
                        name: "FK_AreaCobertura_Empresa_IdEmpresa",
                        column: x => x.IdEmpresa,
                        principalTable: "Empresa",
                        principalColumn: "IdEmpresa",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AreaCobertura_Municipio_IdMunicipio",
                        column: x => x.IdMunicipio,
                        principalTable: "Municipio",
                        principalColumn: "IdMunicipio",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "PrestadorEmpresa",
                columns: table => new
                {
                    IdEmpresa = table.Column<int>(type: "int", nullable: false),
                    IdPrestador = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PrestadorEmpresa", x => new { x.IdEmpresa, x.IdPrestador });
                    table.ForeignKey(
                        name: "FK_PrestadorEmpresa_Empresa_IdEmpresa",
                        column: x => x.IdEmpresa,
                        principalTable: "Empresa",
                        principalColumn: "IdEmpresa",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PrestadorEmpresa_Prestador_IdPrestador",
                        column: x => x.IdPrestador,
                        principalTable: "Prestador",
                        principalColumn: "IdPrestador",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Pet",
                columns: table => new
                {
                    IdPet = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    NomePet = table.Column<string>(type: "varchar(60)", maxLength: 60, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    DataNascimento = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    Sexo = table.Column<string>(type: "varchar(1)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Foto = table.Column<string>(type: "varchar(200)", maxLength: 200, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    IdTutor = table.Column<int>(type: "int", nullable: false),
                    IdEspecie = table.Column<int>(type: "int", nullable: false),
                    IdRaca = table.Column<int>(type: "int", nullable: false),
                    IdPorte = table.Column<int>(type: "int", nullable: false),
                    ExibirHome = table.Column<bool>(type: "tinyint(1)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pet", x => x.IdPet);
                    table.ForeignKey(
                        name: "FK_Pet_Especie_IdEspecie",
                        column: x => x.IdEspecie,
                        principalTable: "Especie",
                        principalColumn: "IdEspecie",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Pet_Porte_IdPorte",
                        column: x => x.IdPorte,
                        principalTable: "Porte",
                        principalColumn: "IdPorte",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Pet_Raca_IdRaca",
                        column: x => x.IdRaca,
                        principalTable: "Raca",
                        principalColumn: "IdRaca",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Pet_Tutor_IdTutor",
                        column: x => x.IdTutor,
                        principalTable: "Tutor",
                        principalColumn: "IdTutor",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Plano",
                columns: table => new
                {
                    IdPlano = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    NomePlano = table.Column<string>(type: "varchar(20)", maxLength: 20, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Descricao = table.Column<string>(type: "varchar(500)", maxLength: 500, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Valor = table.Column<decimal>(type: "decimal(65,30)", nullable: false),
                    IdArea = table.Column<int>(type: "int", nullable: false),
                    IdEmpresa = table.Column<int>(type: "int", nullable: false),
                    ExibirHome = table.Column<bool>(type: "tinyint(1)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Plano", x => x.IdPlano);
                    table.ForeignKey(
                        name: "FK_Plano_AreaCobertura_IdArea",
                        column: x => x.IdArea,
                        principalTable: "AreaCobertura",
                        principalColumn: "IdArea",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Plano_Empresa_IdEmpresa",
                        column: x => x.IdEmpresa,
                        principalTable: "Empresa",
                        principalColumn: "IdEmpresa",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Contrato",
                columns: table => new
                {
                    IdContrato = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    DataInicio = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    DataTermino = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    ValorCombinado = table.Column<decimal>(type: "decimal(65,30)", nullable: false),
                    IdPlano = table.Column<int>(type: "int", nullable: false),
                    IdTutor = table.Column<int>(type: "int", nullable: false),
                    IdPet = table.Column<int>(type: "int", nullable: false),
                    IdEmpresa = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Contrato", x => x.IdContrato);
                    table.ForeignKey(
                        name: "FK_Contrato_Empresa_IdEmpresa",
                        column: x => x.IdEmpresa,
                        principalTable: "Empresa",
                        principalColumn: "IdEmpresa",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Contrato_Pet_IdPet",
                        column: x => x.IdPet,
                        principalTable: "Pet",
                        principalColumn: "IdPet",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Contrato_Plano_IdPlano",
                        column: x => x.IdPlano,
                        principalTable: "Plano",
                        principalColumn: "IdPlano",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Contrato_Tutor_IdTutor",
                        column: x => x.IdTutor,
                        principalTable: "Tutor",
                        principalColumn: "IdTutor",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "EspecialidadePlano",
                columns: table => new
                {
                    IdEspecialidade = table.Column<int>(type: "int", nullable: false),
                    IdPlano = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EspecialidadePlano", x => new { x.IdPlano, x.IdEspecialidade });
                    table.ForeignKey(
                        name: "FK_EspecialidadePlano_Especialidade_IdEspecialidade",
                        column: x => x.IdEspecialidade,
                        principalTable: "Especialidade",
                        principalColumn: "IdEspecialidade",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_EspecialidadePlano_Plano_IdPlano",
                        column: x => x.IdPlano,
                        principalTable: "Plano",
                        principalColumn: "IdPlano",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.InsertData(
                table: "Blog",
                columns: new[] { "IdPublicacao", "DataPublicacao", "ExibirHome", "Foto", "Texto", "Titulo" },
                values: new object[,]
                {
                    { 1, new DateTime(2021, 11, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), true, "img/blog/blog-1.png", "Cães, gatos, gorilas, tigres e ursos estão entre os protegidos. De recompensa, eles ganham marshmallows e sorvete", "EUA e Rússia dão largada à imunização de animais contra a Covid-19" },
                    { 2, new DateTime(2021, 11, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), true, "img/blog/blog-2.png", "Empresas apostam na internet e adotam modelo de assinatura para a venda de ração de animais de estimação, segmento que faturou para o setor quase 10 bilhões em 2012", "No mercado de pets, a moda agora é vender por assinatura" },
                    { 3, new DateTime(2021, 11, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), true, "img/blog/blog-3.png", "Serviço estará disponível no aplicativo Meu Vivo inicialmente para clientes das capitais São Paulo, Rio de Janeiro, Belo Horizonte e regiões metropolitanas", "Vivo terá canal para clientes que quiserem adotar pets" }
                });

            migrationBuilder.InsertData(
                table: "Contato",
                columns: new[] { "IdContato", "Assunto", "Celular", "Email", "Mensagem", "Nome", "Telefone" },
                values: new object[,]
                {
                    { 1, "Elogio", "(16) 98910-7852", "laura.ribeiro@hotmail.com", "Eu agradeço a Unipet , porque no momento que mais precisei a Unipet me ajudou muito. Me sinto feliz e aliviada porque tenho o plano de saúde e sempre contei com ele. Estou muito satisfeita e a equipe Unipet sempre esteve disposta a satisfazer o cliente.", "Laura Analu Carla Ribeiro", "(16) 3968-6516" },
                    { 2, "Elogio", "(16) 99195-8396", "daniel.mata@gmail.com", "A Unipet é perfeita!!! O site e o atendimento são maravilhosos e os profissionais muito atenciosos. Fiquei muito feliz com o atendimento dado ao meu cãozinho.", "Daniel André Francisco da Mata", "(16) 3792-9234" },
                    { 3, "Depoimento", "(11) 98991-8021", "eduardo.nunes@gmail.com", "O atendimento da Unipet é indescritível!!! Total carinho e cuidado com meu filhote. O pessoal da clínica, como um todo, é muito atencioso.", "Eduardo Yago Nunes", "(11) 2726-0341" }
                });

            migrationBuilder.InsertData(
                table: "Especialidade",
                columns: new[] { "IdEspecialidade", "NomeEspecialidade" },
                values: new object[,]
                {
                    { 8, "Cirurgia" },
                    { 7, "Ortopedia" },
                    { 6, "Fisioterapia" },
                    { 5, "Exames de imagem" },
                    { 9, "Internação" },
                    { 3, "Urgência/emergência" },
                    { 2, "Vacinas" },
                    { 1, "Consulta geral" },
                    { 4, "Exames laboratoriais" }
                });

            migrationBuilder.InsertData(
                table: "Especie",
                columns: new[] { "IdEspecie", "NomeEspecie" },
                values: new object[,]
                {
                    { 1, "Cachorro" },
                    { 2, "Gato" },
                    { 3, "Pássaro" }
                });

            migrationBuilder.InsertData(
                table: "Porte",
                columns: new[] { "IdPorte", "NomePorte" },
                values: new object[,]
                {
                    { 3, "G" },
                    { 2, "M" },
                    { 1, "P" }
                });

            migrationBuilder.InsertData(
                table: "Relato",
                columns: new[] { "IdRelato", "ExibirHome", "Foto", "Nome", "Texto" },
                values: new object[,]
                {
                    { 1, true, "img/testimonial/testimonial-1.png", "Laura Analu Carla Ribeiro", "Eu agradeço a Unipet , porque no momento que mais precisei a Unipet me ajudou muito. Me sinto feliz e aliviada porque tenho o plano de saúde e sempre contei com ele. Estou muito satisfeita e a equipe Unipet sempre esteve disposta a satisfazer o cliente." },
                    { 2, true, "img/testimonial/testimonial-2.png", "Daniel André Francisco da Mata", "A Unipet é perfeita!!! O site e o atendimento são maravilhosos e os profissionais muito atenciosos. Fiquei muito feliz com o atendimento dado ao meu cãozinho." },
                    { 3, true, "img/testimonial/testimonial-3.png", "Eduardo Yago Nunes", "O atendimento da Unipet é indescritível!!! Total carinho e cuidado com meu filhote. O pessoal da clínica, como um todo, é muito atencioso." }
                });

            migrationBuilder.InsertData(
                table: "UF",
                columns: new[] { "IdUF", "NomeEstado", "Sigla" },
                values: new object[,]
                {
                    { 4, "São Paulo", "SP" },
                    { 1, "São Paulo", "SP" },
                    { 2, "São Paulo", "SP" },
                    { 3, "São Paulo", "SP" },
                    { 5, "São Paulo", "SP" }
                });

            migrationBuilder.InsertData(
                table: "Municipio",
                columns: new[] { "IdMunicipio", "IdUF", "NomeMunicipio" },
                values: new object[,]
                {
                    { 1, 1, "Ribeirão Preto" },
                    { 2, 2, "São Paulo" },
                    { 3, 3, "Rincão" },
                    { 4, 4, "Barra Bonita" },
                    { 5, 5, "Bauru" }
                });

            migrationBuilder.InsertData(
                table: "Raca",
                columns: new[] { "IdRaca", "IdEspecie", "NomeRaca" },
                values: new object[,]
                {
                    { 1, 1, "Raça Indefinida" },
                    { 2, 1, "Pastor Alemão" },
                    { 4, 2, "Persa" },
                    { 5, 3, "Papagaio" }
                });

            migrationBuilder.InsertData(
                table: "Endereco",
                columns: new[] { "IdEndereco", "Bairro", "CEP", "IdMunicipio", "Logradouro", "NumeroCasa" },
                values: new object[,]
                {
                    { 1, "Quintino Facci II", "14070280", 1, "Rua Deputado Orlando Jurca", 243 },
                    { 6, "Vila Mariana", "14140280", 1, "Rua Colômbia", 142 },
                    { 11, "Campos Elíseos", "14080220", 1, "Rua Luiz Gama", 952 },
                    { 2, "Centro", "03960000", 2, "Avenida Paulista", 542 },
                    { 7, "Ipiranga", "03965000", 2, "Rua Porto Seguro", 403 },
                    { 12, "Jardim Santa Terezinha (Parelheiros)", "04896030", 2, "Rua Plácido Rutini", 741 },
                    { 3, "Jardim dos Bosques", "14830970", 3, "Rua Quinze de Novembro 152", 586 },
                    { 8, "Vila Monte Alegre", "14844970", 3, "Travessa Atíllio Poli", 785 },
                    { 13, "Centro", "14830970", 3, "Rua Quinze de Novembro 152", 241 },
                    { 4, "Centro", "17340970", 4, "Rua Winifrida", 270 },
                    { 9, "Jardim da Barra", "17350000", 4, "Rua Santo Gatto", 25 },
                    { 14, "Centro", "17340970", 4, "Rua Winifrida 270", 648 },
                    { 5, "Altos da Cidade", "17064853", 5, "Rua Treze de Maio", 564 },
                    { 10, "Centro", "17064853", 5, "Rua Virgilio Marta", 245 },
                    { 15, "Vila Aviação", "17018650", 5, "Avenida Alcindo Dias Soares", 974 }
                });

            migrationBuilder.InsertData(
                table: "Empresa",
                columns: new[] { "IdEmpresa", "CNPJ", "Email", "ExibirHome", "Fone", "IdEndereco", "IdUsuario", "Logotipo", "RazaoSocial" },
                values: new object[,]
                {
                    { 1, "75727887000113", "contato@estimapet.com.br", true, "(16) 2733-7453", 1, null, "img/empresas/estima-pet.png", "Estima Pet" },
                    { 2, "46070005000191", "suporte@petsepeople.com", true, "(11) 2584-5154", 2, null, "img/empresas/pets&people.png", "Pets&People" },
                    { 3, "94117416000138", "contato@animalclub.com.br", true, "(16) 2740-8918", 3, null, "img/empresas/animalclub.png", "Animal Club" },
                    { 4, "51013786000112", "faleconosco@chiquinho.com.br", true, "(14) 3845-1744", 4, null, "img/empresas/saochiquinho.png", "São Chiquinho" },
                    { 5, "358307421340", "petdoctor@petdoctor.com", true, "(14) 2595-9878", 5, null, "img/empresas/petdoctor.png", "Pet doctor" }
                });

            migrationBuilder.InsertData(
                table: "Prestador",
                columns: new[] { "IdPrestador", "CNPJ", "Email", "ExibirHome", "Fone", "IdEndereco", "IdUsuario", "Logotipo", "RazaoSocial" },
                values: new object[,]
                {
                    { 1, "34107012000131", "contato@petmais.com.br", true, "(16) 2849-9496", 11, null, "", "Clínica Pet+" },
                    { 2, "05457918000188", "comercial@vetsaofrancisco.com.br", true, "(11) 3623-5462", 12, null, "", "Clínica Veterinária São Francisco" },
                    { 3, "75511709000150", "comercial@centrovet.com.br", true, "(16) 3623-5462", 13, null, "", "Centro Veterinário" },
                    { 4, "42874432000171", "contato@proanalys.com.br", true, "(14) 3675-4544", 14, null, "", "ProAnalysy PET" },
                    { 5, "87134850000160", "comercial@sopet.com.br", true, "(14) 3234-7888", 15, null, "", "Centro Veterinário SÓPET" }
                });

            migrationBuilder.InsertData(
                table: "Tutor",
                columns: new[] { "IdTutor", "CPF", "Celular", "Email", "ExibirHome", "Fone", "Foto", "IdEndereco", "IdUsuario", "NomeTutor", "RG", "Sexo" },
                values: new object[,]
                {
                    { 1, "49474113840", "(16) 99195-8396", "daniel.mata@gmail.com", true, "(16) 3792-9234", "img/tutor/tutor-1.png", 6, null, "Daniel André Francisco da Mata", "424854752", "M" },
                    { 2, "65838512881", "(11) 98991-8021", "eduardo.nunes@gmail.com", true, "(11) 2726-0341", "img/tutor/tutor-2.png", 7, null, "Eduardo Yago Nunes", "312398669", "M" },
                    { 3, "46180447802", "(16) 98910-7852", "laura.ribeiro@hotmail.com", true, "(16) 3968-6516", "img/tutor/tutor-3.png", 8, null, "Laura Analu Carla Ribeiro", "473961702", "F" },
                    { 4, "80503642835", "(14) 98783-6149", "fernando.rodrigues@hotmail.com", true, "(14) 3964-2127", "img/tutor/tutor-4.png", 9, null, "Fernando Lorenzo Rodrigues", "318776066", "M" },
                    { 5, "64446567888", "(14) 99952-7294", "liz.rodrigues@gmail.com", true, "(14) 3733-2834", "img/tutor/tutor-5.png", 10, null, "Liz Evelyn Alice Rodrigues", "434533622", "F" }
                });

            migrationBuilder.InsertData(
                table: "AreaCobertura",
                columns: new[] { "IdArea", "ExibirHome", "IdEmpresa", "IdMunicipio", "NomeArea" },
                values: new object[,]
                {
                    { 4, true, 1, 4, "Area 4" },
                    { 5, true, 1, 5, "Area 5" },
                    { 1, true, 2, 1, "Area 1" },
                    { 3, true, 2, 3, "Area 3" },
                    { 2, true, 3, 2, "Area 2" }
                });

            migrationBuilder.InsertData(
                table: "Pet",
                columns: new[] { "IdPet", "DataNascimento", "ExibirHome", "Foto", "IdEspecie", "IdPorte", "IdRaca", "IdTutor", "NomePet", "Sexo" },
                values: new object[,]
                {
                    { 1, new DateTime(2018, 5, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), true, "", 1, 1, 1, 1, "Xulico", "M" },
                    { 2, new DateTime(2018, 10, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), true, "", 2, 1, 4, 2, "Safira", "F" },
                    { 3, new DateTime(2015, 3, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), true, "", 3, 1, 5, 3, "Loro", "F" },
                    { 4, new DateTime(2000, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, "", 1, 3, 2, 4, "Thor", "M" },
                    { 5, new DateTime(2014, 12, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), true, "", 2, 1, 1, 5, "Nino", "M" }
                });

            migrationBuilder.InsertData(
                table: "PrestadorEmpresa",
                columns: new[] { "IdEmpresa", "IdPrestador" },
                values: new object[,]
                {
                    { 1, 1 },
                    { 2, 2 },
                    { 3, 3 },
                    { 4, 4 },
                    { 5, 5 }
                });

            migrationBuilder.InsertData(
                table: "Plano",
                columns: new[] { "IdPlano", "Descricao", "ExibirHome", "IdArea", "IdEmpresa", "NomePlano", "Valor" },
                values: new object[,]
                {
                    { 1, "Um plano de saúde básico, acessível para você e essencial para o seu melhor amigo.", true, 4, 1, "Pet Bronze", 49m },
                    { 2, "Um plano de saúde essencial, acessível e abrangente para você e o melhor para o seu melhor amigo.", true, 4, 1, "Pet Silver", 79m },
                    { 9, "O plano de saúde mais econômico do mercado e básico para seu pet.", true, 4, 4, "Simples", 55m },
                    { 3, "Um plano de saúde completo, abrangente e robusto para você e para o seu melhor amigo.", true, 5, 1, "Pet Golden", 120m },
                    { 10, "O plano de saúde completo e de melhor custo/benefício para você.", true, 5, 4, "Completo", 99m },
                    { 11, "O melhor plano de saúde para você e para seu pet.", true, 5, 4, "Especial", 150m },
                    { 12, "PET I é para quem procura tranquilidade, atendimento e não quer tem imprevistos com a saúde do seu pet", true, 5, 5, "Pet I", 99m },
                    { 13, "PET II é para quem procura cobertura total e o melhor em se tratando de saúde pet", true, 5, 5, "Pet II", 250m },
                    { 4, "O Basic é o nosso plano focado em assistência preventiva para o seu melhor amigo!", true, 1, 2, "Basic", 59m },
                    { 5, "O Plus é o nosso plano ideal para assegurar a saúde do seu pet sem ter surpresas no seu bolso!", true, 1, 2, "Plus", 89m },
                    { 6, "O Advanced é o nosso plano top, sinta-se seguro, com ele seu pet tem acesso ao que há de melhor!", true, 3, 2, "Advanced ", 220m },
                    { 7, "Um plano que oferece os cuidados básicos com a saúde do seu pet.", true, 2, 3, "Essencial", 59m },
                    { 8, "Um plano para surpreender. Oferece uma rede premium e tratamentos complementares ao seu melhor amigo. Além de contemplar todas as coberturas do plano Essencial.", true, 2, 3, "Completo", 200m }
                });

            migrationBuilder.InsertData(
                table: "Contrato",
                columns: new[] { "IdContrato", "DataInicio", "DataTermino", "IdEmpresa", "IdPet", "IdPlano", "IdTutor", "ValorCombinado" },
                values: new object[,]
                {
                    { 1, new DateTime(2021, 11, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 1, 1, 1, 49m },
                    { 2, new DateTime(2021, 11, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 2, 2, 2, 79m },
                    { 3, new DateTime(2021, 11, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, 3, 3, 3, 120m },
                    { 5, new DateTime(2021, 11, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), 5, 5, 5, 5, 49m },
                    { 4, new DateTime(2021, 11, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, 4, 4, 4, 55m }
                });

            migrationBuilder.InsertData(
                table: "EspecialidadePlano",
                columns: new[] { "IdEspecialidade", "IdPlano" },
                values: new object[,]
                {
                    { 4, 5 },
                    { 3, 5 },
                    { 2, 5 },
                    { 1, 5 },
                    { 3, 4 },
                    { 2, 4 },
                    { 1, 4 },
                    { 9, 13 },
                    { 8, 13 },
                    { 7, 13 },
                    { 6, 13 },
                    { 5, 13 },
                    { 4, 13 },
                    { 3, 13 },
                    { 5, 5 },
                    { 6, 5 },
                    { 2, 6 },
                    { 2, 13 },
                    { 7, 8 },
                    { 6, 8 },
                    { 5, 8 },
                    { 4, 8 },
                    { 3, 8 },
                    { 2, 8 },
                    { 1, 8 },
                    { 3, 7 },
                    { 2, 7 },
                    { 1, 7 },
                    { 9, 6 },
                    { 8, 6 },
                    { 7, 6 },
                    { 6, 6 },
                    { 5, 6 },
                    { 4, 6 },
                    { 3, 6 },
                    { 1, 6 },
                    { 1, 13 },
                    { 3, 12 },
                    { 2, 12 },
                    { 4, 3 },
                    { 3, 3 },
                    { 2, 3 },
                    { 1, 3 },
                    { 3, 9 },
                    { 2, 9 },
                    { 1, 9 },
                    { 5, 3 },
                    { 6, 2 },
                    { 4, 2 },
                    { 3, 2 },
                    { 2, 2 },
                    { 1, 2 },
                    { 3, 1 },
                    { 2, 1 },
                    { 1, 1 },
                    { 5, 2 },
                    { 6, 3 },
                    { 7, 3 },
                    { 8, 3 },
                    { 1, 12 },
                    { 9, 11 },
                    { 8, 11 },
                    { 7, 11 },
                    { 6, 11 },
                    { 5, 11 },
                    { 4, 11 },
                    { 3, 11 },
                    { 2, 11 },
                    { 1, 11 },
                    { 6, 10 },
                    { 5, 10 },
                    { 4, 10 },
                    { 3, 10 },
                    { 2, 10 },
                    { 1, 10 },
                    { 9, 3 },
                    { 8, 8 },
                    { 9, 8 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_AreaCobertura_IdEmpresa",
                table: "AreaCobertura",
                column: "IdEmpresa");

            migrationBuilder.CreateIndex(
                name: "IX_AreaCobertura_IdMunicipio",
                table: "AreaCobertura",
                column: "IdMunicipio");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Contrato_IdEmpresa",
                table: "Contrato",
                column: "IdEmpresa");

            migrationBuilder.CreateIndex(
                name: "IX_Contrato_IdPet",
                table: "Contrato",
                column: "IdPet");

            migrationBuilder.CreateIndex(
                name: "IX_Contrato_IdPlano",
                table: "Contrato",
                column: "IdPlano");

            migrationBuilder.CreateIndex(
                name: "IX_Contrato_IdTutor",
                table: "Contrato",
                column: "IdTutor");

            migrationBuilder.CreateIndex(
                name: "IX_Empresa_IdEndereco",
                table: "Empresa",
                column: "IdEndereco");

            migrationBuilder.CreateIndex(
                name: "IX_Empresa_IdUsuario",
                table: "Empresa",
                column: "IdUsuario");

            migrationBuilder.CreateIndex(
                name: "IX_Endereco_IdMunicipio",
                table: "Endereco",
                column: "IdMunicipio");

            migrationBuilder.CreateIndex(
                name: "IX_EspecialidadePlano_IdEspecialidade",
                table: "EspecialidadePlano",
                column: "IdEspecialidade");

            migrationBuilder.CreateIndex(
                name: "IX_Municipio_IdUF",
                table: "Municipio",
                column: "IdUF");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "Perfil",
                column: "NormalizedName",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_PerfilClaims_RoleId",
                table: "PerfilClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "IX_Pet_IdEspecie",
                table: "Pet",
                column: "IdEspecie");

            migrationBuilder.CreateIndex(
                name: "IX_Pet_IdPorte",
                table: "Pet",
                column: "IdPorte");

            migrationBuilder.CreateIndex(
                name: "IX_Pet_IdRaca",
                table: "Pet",
                column: "IdRaca");

            migrationBuilder.CreateIndex(
                name: "IX_Pet_IdTutor",
                table: "Pet",
                column: "IdTutor");

            migrationBuilder.CreateIndex(
                name: "IX_Plano_IdArea",
                table: "Plano",
                column: "IdArea");

            migrationBuilder.CreateIndex(
                name: "IX_Plano_IdEmpresa",
                table: "Plano",
                column: "IdEmpresa");

            migrationBuilder.CreateIndex(
                name: "IX_Prestador_IdEndereco",
                table: "Prestador",
                column: "IdEndereco");

            migrationBuilder.CreateIndex(
                name: "IX_Prestador_IdUsuario",
                table: "Prestador",
                column: "IdUsuario");

            migrationBuilder.CreateIndex(
                name: "IX_PrestadorEmpresa_IdPrestador",
                table: "PrestadorEmpresa",
                column: "IdPrestador");

            migrationBuilder.CreateIndex(
                name: "IX_Raca_IdEspecie",
                table: "Raca",
                column: "IdEspecie");

            migrationBuilder.CreateIndex(
                name: "IX_Tutor_IdEndereco",
                table: "Tutor",
                column: "IdEndereco");

            migrationBuilder.CreateIndex(
                name: "IX_Tutor_IdUsuario",
                table: "Tutor",
                column: "IdUsuario");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "Usuario",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "Usuario",
                column: "NormalizedUserName",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_UsuarioLogin_UserId",
                table: "UsuarioLogin",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_UsuarioPerfil_RoleId",
                table: "UsuarioPerfil",
                column: "RoleId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "Blog");

            migrationBuilder.DropTable(
                name: "Contato");

            migrationBuilder.DropTable(
                name: "Contrato");

            migrationBuilder.DropTable(
                name: "EspecialidadePlano");

            migrationBuilder.DropTable(
                name: "PerfilClaims");

            migrationBuilder.DropTable(
                name: "PrestadorEmpresa");

            migrationBuilder.DropTable(
                name: "Relato");

            migrationBuilder.DropTable(
                name: "UsuarioLogin");

            migrationBuilder.DropTable(
                name: "UsuarioPerfil");

            migrationBuilder.DropTable(
                name: "UsuarioTokens");

            migrationBuilder.DropTable(
                name: "Pet");

            migrationBuilder.DropTable(
                name: "Especialidade");

            migrationBuilder.DropTable(
                name: "Plano");

            migrationBuilder.DropTable(
                name: "Prestador");

            migrationBuilder.DropTable(
                name: "Perfil");

            migrationBuilder.DropTable(
                name: "Porte");

            migrationBuilder.DropTable(
                name: "Raca");

            migrationBuilder.DropTable(
                name: "Tutor");

            migrationBuilder.DropTable(
                name: "AreaCobertura");

            migrationBuilder.DropTable(
                name: "Especie");

            migrationBuilder.DropTable(
                name: "Empresa");

            migrationBuilder.DropTable(
                name: "Endereco");

            migrationBuilder.DropTable(
                name: "Usuario");

            migrationBuilder.DropTable(
                name: "Municipio");

            migrationBuilder.DropTable(
                name: "UF");
        }
    }
}
