using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using Unipet.Models;

namespace Unipet.Data
{
    public class Context : IdentityDbContext<Usuario>
    {
        public Context(DbContextOptions<Context> options): base(options)
        {
        }
        public DbSet<Blog> Blogs { get; set; }
        public DbSet<Empresa> Empresas { get; set; }
        public DbSet<Plano> Planos { get; set; }
        public DbSet<Especialidade> Especialidades { get; set; }
        public DbSet<EspecialidadePlano> EspecialidadePlanos { get; set; }
        public DbSet<Contrato> Contratos { get; set; }
        public DbSet<UF> UFs { get; set; }
        public DbSet<Municipio> Municipios { get; set; }
        public DbSet<Endereco> Enderecos { get; set; }
        public DbSet<Contato> Contatos { get; set; }
        public DbSet<Tutor> Tutores { get; set; }
        public DbSet<Pet> Pets { get; set; }
        public DbSet<Especie> Especies { get; set; }
        public DbSet<Raca> Racas { get; set; }
        public DbSet<Porte> Portes { get; set; }
        public DbSet<Relato> Relatos { get; set; }
        public DbSet<Usuario> Usuarios { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            #region Prestador Empresa
            // Para criar a chave primaria
            builder.Entity<PrestadorEmpresa>().HasKey(pe => new { pe.IdEmpresa, pe.IdPrestador });

            // Relacionamento e chave estrangeria do prestadorempresa com empresa
            builder.Entity<PrestadorEmpresa>().HasOne(pe => pe.Empresa)
                .WithMany(e => e.PrestoresEmpresa)
                .HasForeignKey(pe => pe.IdEmpresa);

            // Relacionamento e chave estrangeira do prestadorempresa com prestador
            builder.Entity<PrestadorEmpresa>().HasOne(pe => pe.Prestador)
                .WithMany(p => p.PrestadorEmpresas)
                .HasForeignKey(pe => pe.IdPrestador);
            #endregion

            #region Especialidade Plano
            // Para criar a chave primaria
            builder.Entity<EspecialidadePlano>().HasKey(ep => new { ep.IdPlano, ep.IdEspecialidade });

            // Relacionamento e chave estrangeira do especialidadeplano com o plano
            builder.Entity<EspecialidadePlano>().HasOne(ep => ep.Plano)
                .WithMany(p => p.EspecialidadesPlanos)
                .HasForeignKey(ep => ep.IdPlano);

            //Relacionamento e chave estrangeira do especialidadeplano com a especialidade
            builder.Entity<EspecialidadePlano>().HasOne(ep => ep.Especialidade)
                .WithMany(e => e.EspecialidadesPlanos)
                .HasForeignKey(ep => ep.IdEspecialidade);
            #endregion

            #region Indentity
            builder.Entity<Usuario>(entity =>
            {
                entity.ToTable(name: "Usuario");
            });
            builder.Entity<IdentityRole>(entity =>
            {
                entity.ToTable(name: "Perfil");
            });
            builder.Entity<IdentityUserRole<string>>(entity =>
            {
                entity.ToTable("UsuarioPerfil");
            });
            builder.Entity<IdentityUserLogin<string>>(entity =>
            {
                entity.ToTable("UsuarioLogin");
            });
            builder.Entity<IdentityRoleClaim<string>>(entity =>
            {
                entity.ToTable("PerfilClaims");
            });
            builder.Entity<IdentityUserToken<string>>(entity =>
            {
                entity.ToTable("UsuarioTokens");
            });
            #endregion

            /*Populando*/

            #region Especialidade Seed
            builder.Entity<Especialidade>().HasData(
                new Especialidade()
                {
                    IdEspecialidade = 1,
                    NomeEspecialidade = "Consulta geral"
                },
                new Especialidade()
                {
                    IdEspecialidade = 2,
                    NomeEspecialidade = "Vacinas"
                },
                new Especialidade()
                {
                    IdEspecialidade = 3,
                    NomeEspecialidade = "Urgência/emergência"
                },
                new Especialidade()
                {
                    IdEspecialidade = 4,
                    NomeEspecialidade = "Exames laboratoriais"
                },
                new Especialidade()
                {
                    IdEspecialidade = 5,
                    NomeEspecialidade = "Exames de imagem"
                },
                new Especialidade()
                {
                    IdEspecialidade = 6,
                    NomeEspecialidade = "Fisioterapia"
                },
                new Especialidade()
                {
                    IdEspecialidade = 7,
                    NomeEspecialidade = "Ortopedia"
                },
                new Especialidade()
                {
                    IdEspecialidade = 8,
                    NomeEspecialidade = "Cirurgia"
                },
                new Especialidade()
                {
                    IdEspecialidade = 9,
                    NomeEspecialidade = "Internação"
                }
            );
            #endregion

            #region Plano Seed
            builder.Entity<Plano>().HasData(
                new Plano()
                {
                    IdPlano= 1,
                    NomePlano= "Pet Bronze",
                    Descricao= "Um plano de saúde básico, acessível para você e essencial para o seu melhor amigo.",
                    Valor= 49,
                    IdArea= 4,
                    IdEmpresa= 1,
                    ExibirHome = true
                },
                new Plano()
                {
                    IdPlano = 2,
                    NomePlano = "Pet Silver",
                    Descricao = "Um plano de saúde essencial, acessível e abrangente para você e o melhor para o seu melhor amigo.",
                    Valor = 79,
                    IdArea = 4,
                    IdEmpresa = 1,
                    ExibirHome = true
                },
                new Plano()
                {
                    IdPlano = 3,
                    NomePlano = "Pet Golden",
                    Descricao = "Um plano de saúde completo, abrangente e robusto para você e para o seu melhor amigo.",
                    Valor = 120,
                    IdArea = 5,
                    IdEmpresa = 1,
                    ExibirHome = true
                },
                new Plano()
                {
                    IdPlano = 4,
                    NomePlano = "Basic",
                    Descricao = "O Basic é o nosso plano focado em assistência preventiva para o seu melhor amigo!",
                    Valor = 59,
                    IdArea = 1,
                    IdEmpresa = 2,
                    ExibirHome = true
                },
                new Plano()
                {
                    IdPlano = 5,
                    NomePlano = "Plus",
                    Descricao = "O Plus é o nosso plano ideal para assegurar a saúde do seu pet sem ter surpresas no seu bolso!",
                    Valor = 89,
                    IdArea = 1,
                    IdEmpresa = 2,
                    ExibirHome = true
                },
                new Plano()
                {
                    IdPlano = 6,
                    NomePlano = "Advanced ",
                    Descricao = "O Advanced é o nosso plano top, sinta-se seguro, com ele seu pet tem acesso ao que há de melhor!",
                    Valor = 220,
                    IdArea = 3,
                    IdEmpresa = 2,
                    ExibirHome = true
                },
                new Plano()
                {
                    IdPlano = 7,
                    NomePlano = "Essencial",
                    Descricao = "Um plano que oferece os cuidados básicos com a saúde do seu pet.",
                    Valor = 59,
                    IdArea = 2,
                    IdEmpresa = 3,
                    ExibirHome = true
                },
                new Plano()
                {
                    IdPlano = 8,
                    NomePlano = "Completo",
                    Descricao = "Um plano para surpreender. Oferece uma rede premium e tratamentos complementares ao seu melhor amigo. Além de contemplar todas as coberturas do plano Essencial.",
                    Valor = 200,
                    IdArea = 2,
                    IdEmpresa = 3,
                    ExibirHome = true
                },
                new Plano()
                {
                    IdPlano = 9,
                    NomePlano = "Simples",
                    Descricao = "O plano de saúde mais econômico do mercado e básico para seu pet.",
                    Valor = 55,
                    IdArea = 4,
                    IdEmpresa = 4,
                    ExibirHome = true
                },
                new Plano()
                {
                    IdPlano = 10,
                    NomePlano = "Completo",
                    Descricao = "O plano de saúde completo e de melhor custo/benefício para você.",
                    Valor = 99,
                    IdArea = 5,
                    IdEmpresa = 4,
                    ExibirHome = true
                },
                new Plano()
                {
                    IdPlano = 11,
                    NomePlano = "Especial",
                    Descricao = "O melhor plano de saúde para você e para seu pet.",
                    Valor = 150,
                    IdArea = 5,
                    IdEmpresa = 4,
                    ExibirHome = true
                },
                new Plano()
                {
                    IdPlano = 12,
                    NomePlano = "Pet I",
                    Descricao = "PET I é para quem procura tranquilidade, atendimento e não quer tem imprevistos com a saúde do seu pet",
                    Valor = 99,
                    IdArea = 5,
                    IdEmpresa = 5,
                    ExibirHome = true
                },
                new Plano()
                {
                    IdPlano = 13,
                    NomePlano = "Pet II",
                    Descricao = "PET II é para quem procura cobertura total e o melhor em se tratando de saúde pet",
                    Valor = 250,
                    IdArea = 5,
                    IdEmpresa = 5,
                    ExibirHome = true
                }
            );
            #endregion

            #region Seed Especialidade Plano
            builder.Entity<EspecialidadePlano>().HasData(
                /*Plano 1*/
                new EspecialidadePlano()
                {
                    IdEspecialidade = 1,
                    IdPlano = 1
                },
                new EspecialidadePlano()
                {
                    IdEspecialidade = 2,
                    IdPlano = 1
                },
                new EspecialidadePlano()
                {
                    IdEspecialidade = 3,
                    IdPlano = 1
                },
                /*Plano 2*/
                new EspecialidadePlano()
                {
                    IdEspecialidade = 1,
                    IdPlano = 2
                },
                new EspecialidadePlano()
                {
                    IdEspecialidade = 2,
                    IdPlano = 2
                },
                new EspecialidadePlano()
                {
                    IdEspecialidade = 3,
                    IdPlano = 2
                },
                new EspecialidadePlano()
                {
                    IdEspecialidade = 4,
                    IdPlano = 2
                },
                new EspecialidadePlano()
                {
                    IdEspecialidade = 5,
                    IdPlano = 2
                },
                new EspecialidadePlano()
                {
                    IdEspecialidade = 6,
                    IdPlano = 2
                },
                /*Plano 3*/
                new EspecialidadePlano()
                {
                    IdEspecialidade = 1,
                    IdPlano = 3
                },
                new EspecialidadePlano()
                {
                    IdEspecialidade = 2,
                    IdPlano = 3
                },
                new EspecialidadePlano()
                {
                    IdEspecialidade = 3,
                    IdPlano = 3
                },
                new EspecialidadePlano()
                {
                    IdEspecialidade = 4,
                    IdPlano = 3
                },
                new EspecialidadePlano()
                {
                    IdEspecialidade = 5,
                    IdPlano = 3
                },
                new EspecialidadePlano()
                {
                    IdEspecialidade = 6,
                    IdPlano = 3
                },
                new EspecialidadePlano()
                {
                    IdEspecialidade = 7,
                    IdPlano = 3
                },
                new EspecialidadePlano()
                {
                    IdEspecialidade = 8,
                    IdPlano = 3
                },
                new EspecialidadePlano()
                {
                    IdEspecialidade = 9,
                    IdPlano = 3
                },
                /*Plano 4*/
                new EspecialidadePlano()
                {
                    IdEspecialidade = 1,
                    IdPlano = 4
                },
                new EspecialidadePlano()
                {
                    IdEspecialidade = 2,
                    IdPlano = 4
                },
                new EspecialidadePlano()
                {
                    IdEspecialidade = 3,
                    IdPlano = 4
                },
                /*Plano 5*/
                new EspecialidadePlano()
                {
                    IdEspecialidade = 1,
                    IdPlano = 5
                },
                new EspecialidadePlano()
                {
                    IdEspecialidade = 2,
                    IdPlano = 5
                },
                new EspecialidadePlano()
                {
                    IdEspecialidade = 3,
                    IdPlano = 5
                },
                new EspecialidadePlano()
                {
                    IdEspecialidade = 4,
                    IdPlano = 5
                },
                new EspecialidadePlano()
                {
                    IdEspecialidade = 5,
                    IdPlano = 5
                },
                new EspecialidadePlano()
                {
                    IdEspecialidade = 6,
                    IdPlano = 5
                },
                /*Plano 6*/
                new EspecialidadePlano()
                {
                    IdEspecialidade = 1,
                    IdPlano = 6
                },
                new EspecialidadePlano()
                {
                    IdEspecialidade = 2,
                    IdPlano = 6
                },
                new EspecialidadePlano()
                {
                    IdEspecialidade = 3,
                    IdPlano = 6
                },
                new EspecialidadePlano()
                {
                    IdEspecialidade = 4,
                    IdPlano = 6
                },
                new EspecialidadePlano()
                {
                    IdEspecialidade = 5,
                    IdPlano = 6
                },
                new EspecialidadePlano()
                {
                    IdEspecialidade = 6,
                    IdPlano = 6
                },
                new EspecialidadePlano()
                {
                    IdEspecialidade = 7,
                    IdPlano = 6
                },
                new EspecialidadePlano()
                {
                    IdEspecialidade = 8,
                    IdPlano = 6
                },
                new EspecialidadePlano()
                {
                    IdEspecialidade = 9,
                    IdPlano = 6
                },
                /*Plano 7*/
                new EspecialidadePlano()
                {
                    IdEspecialidade = 1,
                    IdPlano = 7
                },
                new EspecialidadePlano()
                {
                    IdEspecialidade = 2,
                    IdPlano = 7
                },
                new EspecialidadePlano()
                {
                    IdEspecialidade = 3,
                    IdPlano = 7
                },
                /*Plano 8*/
                new EspecialidadePlano()
                {
                    IdEspecialidade = 1,
                    IdPlano = 8
                },
                new EspecialidadePlano()
                {
                    IdEspecialidade = 2,
                    IdPlano = 8
                },
                new EspecialidadePlano()
                {
                    IdEspecialidade = 3,
                    IdPlano = 8
                },
                new EspecialidadePlano()
                {
                    IdEspecialidade = 4,
                    IdPlano = 8
                },
                new EspecialidadePlano()
                {
                    IdEspecialidade = 5,
                    IdPlano = 8
                },
                new EspecialidadePlano()
                {
                    IdEspecialidade = 6,
                    IdPlano = 8
                },
                new EspecialidadePlano()
                {
                    IdEspecialidade = 7,
                    IdPlano = 8
                },
                new EspecialidadePlano()
                {
                    IdEspecialidade = 8,
                    IdPlano = 8
                },
                new EspecialidadePlano()
                {
                    IdEspecialidade = 9,
                    IdPlano = 8
                },
                /*Plano 9*/
                new EspecialidadePlano()
                {
                    IdEspecialidade = 1,
                    IdPlano = 9
                },
                new EspecialidadePlano()
                {
                    IdEspecialidade = 2,
                    IdPlano = 9
                },
                new EspecialidadePlano()
                {
                    IdEspecialidade = 3,
                    IdPlano = 9
                },
                /*Plano 10*/
                new EspecialidadePlano()
                {
                    IdEspecialidade = 1,
                    IdPlano = 10
                },
                new EspecialidadePlano()
                {
                    IdEspecialidade = 2,
                    IdPlano = 10
                },
                new EspecialidadePlano()
                {
                    IdEspecialidade = 3,
                    IdPlano = 10
                },
                new EspecialidadePlano()
                {
                    IdEspecialidade = 4,
                    IdPlano = 10
                },
                new EspecialidadePlano()
                {
                    IdEspecialidade = 5,
                    IdPlano = 10
                },
                new EspecialidadePlano()
                {
                    IdEspecialidade = 6,
                    IdPlano = 10
                },
                /*Plano 11*/
                new EspecialidadePlano()
                {
                    IdEspecialidade = 1,
                    IdPlano = 11
                },
                new EspecialidadePlano()
                {
                    IdEspecialidade = 2,
                    IdPlano = 11
                },
                new EspecialidadePlano()
                {
                    IdEspecialidade = 3,
                    IdPlano = 11
                },
                new EspecialidadePlano()
                {
                    IdEspecialidade = 4,
                    IdPlano = 11
                },
                new EspecialidadePlano()
                {
                    IdEspecialidade = 5,
                    IdPlano = 11
                },
                new EspecialidadePlano()
                {
                    IdEspecialidade = 6,
                    IdPlano = 11
                },
                new EspecialidadePlano()
                {
                    IdEspecialidade = 7,
                    IdPlano = 11
                },
                new EspecialidadePlano()
                {
                    IdEspecialidade = 8,
                    IdPlano = 11
                },
                new EspecialidadePlano()
                {
                    IdEspecialidade = 9,
                    IdPlano = 11
                },
                /*Plano 12*/
                new EspecialidadePlano()
                {
                    IdEspecialidade = 1,
                    IdPlano = 12
                },
                new EspecialidadePlano()
                {
                    IdEspecialidade = 2,
                    IdPlano = 12
                },
                new EspecialidadePlano()
                {
                    IdEspecialidade = 3,
                    IdPlano = 12
                },
                /*Plano 13*/
                new EspecialidadePlano()
                {
                    IdEspecialidade = 1,
                    IdPlano = 13
                },
                new EspecialidadePlano()
                {
                    IdEspecialidade = 2,
                    IdPlano = 13
                },
                new EspecialidadePlano()
                {
                    IdEspecialidade = 3,
                    IdPlano = 13
                },
                new EspecialidadePlano()
                {
                    IdEspecialidade = 4,
                    IdPlano = 13
                },
                new EspecialidadePlano()
                {
                    IdEspecialidade = 5,
                    IdPlano = 13
                },
                new EspecialidadePlano()
                {
                    IdEspecialidade = 6,
                    IdPlano = 13
                },
                new EspecialidadePlano()
                {
                    IdEspecialidade = 7,
                    IdPlano = 13
                },
                new EspecialidadePlano()
                {
                    IdEspecialidade = 8,
                    IdPlano = 13
                },
                new EspecialidadePlano()
                {
                    IdEspecialidade = 9,
                    IdPlano = 13
                }
            );
            #endregion

            #region Contrato Seed
            builder.Entity<Contrato>().HasData(
                new Contrato()
                {
                    IdContrato = 1,
                    DataInicio = Convert.ToDateTime("19/11/2021"),
                    DataTermino = Convert.ToDateTime("31/12/2022"),
                    ValorCombinado = 49,
                    IdPlano = 1,
                    IdTutor = 1,
                    IdPet = 1,
                    IdEmpresa = 1,
                },
                new Contrato()
                {
                    IdContrato = 2,
                    DataInicio = Convert.ToDateTime("19/11/2021"),
                    DataTermino = Convert.ToDateTime("31/12/2022"),
                    ValorCombinado = 79,
                    IdPlano = 2,
                    IdTutor = 2,
                    IdPet = 2,
                    IdEmpresa = 2,
                },
                new Contrato()
                {
                    IdContrato = 3,
                    DataInicio = Convert.ToDateTime("23/11/2021"),
                    DataTermino = Convert.ToDateTime("31/12/2022"),
                    ValorCombinado = 120,
                    IdPlano = 3,
                    IdTutor = 3,
                    IdPet = 3,
                    IdEmpresa = 3,
                },
                new Contrato()
                {
                    IdContrato = 4,
                    DataInicio = Convert.ToDateTime("25/11/2021"),
                    DataTermino = Convert.ToDateTime("31/12/2022"),
                    ValorCombinado = 55,
                    IdPlano = 4,
                    IdTutor = 4,
                    IdPet = 4,
                    IdEmpresa = 4,
                },
                new Contrato()
                {
                    IdContrato = 5,
                    DataInicio = Convert.ToDateTime("30/11/2021"),
                    DataTermino = Convert.ToDateTime("31/12/2022"),
                    ValorCombinado = 49,
                    IdPlano = 5,
                    IdTutor = 5,
                    IdPet = 5,
                    IdEmpresa = 5,
                }
            );
            #endregion


            #region Empresa Seed
            builder.Entity<Empresa>().HasData(
                new Empresa()
                {
                    IdEmpresa = 1,
                    RazaoSocial = "Estima Pet",
                    CNPJ = "75727887000113",
                    Email = "contato@estimapet.com.br",
                    Fone = "(16) 2733-7453",
                    Logotipo = "img/empresas/estima-pet.png",
                    IdEndereco = 1,
                    ExibirHome = true
                },
                new Empresa()
                {
                    IdEmpresa = 2,
                    RazaoSocial = "Pets&People",
                    CNPJ = "46070005000191",
                    Email = "suporte@petsepeople.com",
                    Fone = "(11) 2584-5154",
                    Logotipo = "img/empresas/pets&people.png",
                    IdEndereco = 2,
                    ExibirHome = true
                },
                new Empresa()
                {
                    IdEmpresa = 3,
                    RazaoSocial = "Animal Club",
                    CNPJ = "94117416000138",
                    Email = "contato@animalclub.com.br",
                    Fone = "(16) 2740-8918",
                    Logotipo = "img/empresas/animalclub.png",
                    IdEndereco = 3,
                    ExibirHome = true
                },
                new Empresa()
                {
                    IdEmpresa = 4,
                    RazaoSocial = "São Chiquinho",
                    CNPJ = "51013786000112",
                    Email = "faleconosco@chiquinho.com.br",
                    Fone = "(14) 3845-1744",
                    Logotipo = "img/empresas/saochiquinho.png",
                    IdEndereco = 4,
                    ExibirHome = true
                },
                new Empresa()
                {
                    IdEmpresa = 5,
                    RazaoSocial = "Pet doctor",
                    CNPJ = "358307421340",
                    Email = "petdoctor@petdoctor.com",
                    Fone = "(14) 2595-9878",
                    Logotipo = "img/empresas/petdoctor.png",
                    IdEndereco = 5,
                    ExibirHome = true
                }
            );
            #endregion

            #region Prestador Seed
            builder.Entity<Prestador>().HasData(
                new Prestador()
                {
                    IdPrestador = 1,
                    RazaoSocial = "Clínica Pet+",
                    CNPJ = "34107012000131",
                    Email = "contato@petmais.com.br",
                    Fone = "(16) 2849-9496",
                    Logotipo = "",
                    IdEndereco = 11,
                    ExibirHome = true
                },
                new Prestador()
                {
                    IdPrestador = 2,
                    RazaoSocial = "Clínica Veterinária São Francisco",
                    CNPJ = "05457918000188",
                    Email = "comercial@vetsaofrancisco.com.br",
                    Fone = "(11) 3623-5462",
                    Logotipo = "",
                    IdEndereco = 12,
                    ExibirHome = true
                },
                new Prestador()
                {
                    IdPrestador = 3,
                    RazaoSocial = "Centro Veterinário",
                    CNPJ = "75511709000150",
                    Email = "comercial@centrovet.com.br",
                    Fone = "(16) 3623-5462",
                    Logotipo = "",
                    IdEndereco = 13,
                    ExibirHome = true
                },
                new Prestador()
                {
                    IdPrestador = 4,
                    RazaoSocial = "ProAnalysy PET",
                    CNPJ = "42874432000171",
                    Email = "contato@proanalys.com.br",
                    Fone = "(14) 3675-4544",
                    Logotipo = "",
                    IdEndereco = 14,
                    ExibirHome = true
                },
                new Prestador()
                {
                    IdPrestador = 5,
                    RazaoSocial = "Centro Veterinário SÓPET",
                    CNPJ = "87134850000160",
                    Email = "comercial@sopet.com.br",
                    Fone = "(14) 3234-7888",
                    Logotipo = "",
                    IdEndereco = 15,
                    ExibirHome = true
                }
            );
            #endregion

            #region Seed Prestador Empresa
            builder.Entity<PrestadorEmpresa>().HasData(
                new PrestadorEmpresa()
                {
                    IdEmpresa = 1,
                    IdPrestador = 1
                },
                new PrestadorEmpresa()
                {
                    IdEmpresa = 2,
                    IdPrestador = 2
                },
                new PrestadorEmpresa()
                {
                    IdEmpresa = 3,
                    IdPrestador = 3
                },
                new PrestadorEmpresa()
                {
                    IdEmpresa = 4,
                    IdPrestador = 4
                },
                new PrestadorEmpresa()
                {
                    IdEmpresa = 5,
                    IdPrestador = 5
                }
            );
            #endregion


            #region AreaCobertura Seed
            builder.Entity<AreaCobertura>().HasData(
                new AreaCobertura()
                {
                    IdArea = 1,
                    NomeArea = "Area 1",
                    IdMunicipio = 1,
                    IdEmpresa = 2,
                    ExibirHome = true
                },
                new AreaCobertura()
                {
                    IdArea= 2,
                    NomeArea= "Area 2",
                    IdMunicipio= 2,
                    IdEmpresa= 3,
                    ExibirHome = true
                },
                new AreaCobertura()
                {
                    IdArea= 3,
                    NomeArea= "Area 3",
                    IdMunicipio= 3,
                    IdEmpresa= 2,
                    ExibirHome = true
                },
                new AreaCobertura()
                {
                    IdArea= 4,
                    NomeArea= "Area 4",
                    IdMunicipio= 4,
                    IdEmpresa= 1,
                    ExibirHome = true
                }, 
                new AreaCobertura()
                {
                    IdArea= 5,
                    NomeArea= "Area 5",
                    IdMunicipio= 5,
                    IdEmpresa= 1,
                    ExibirHome = true
                } 
            );
            #endregion

            #region UF Seed
            builder.Entity<UF>().HasData(
                new UF()
                {
                    IdUF= 1,
                    Sigla= "SP",
                    NomeEstado= "São Paulo",
                },
                new UF()
                {
                    IdUF= 2,
                    Sigla= "SP",
                    NomeEstado= "São Paulo",
                },
                new UF()
                {
                    IdUF= 3,
                    Sigla= "SP",
                    NomeEstado= "São Paulo",
                },
                new UF()
                {
                    IdUF= 4,
                    Sigla= "SP",
                    NomeEstado= "São Paulo",
                },
                new UF()
                {
                    IdUF= 5,
                    Sigla= "SP",
                    NomeEstado= "São Paulo",
                }
            );
            #endregion

            #region Municipio Seed
            builder.Entity<Municipio>().HasData(
                new Municipio()
                {
                    IdMunicipio= 1,
                    NomeMunicipio= "Ribeirão Preto",
                    IdUF= 1,
                },
                new Municipio()
                {
                    IdMunicipio= 2,
                    NomeMunicipio= "São Paulo",
                    IdUF= 2,
                },
                new Municipio()
                {
                    IdMunicipio= 3,
                    NomeMunicipio= "Rincão",
                    IdUF= 3,
                },
                new Municipio()
                {
                    IdMunicipio= 4,
                    NomeMunicipio= "Barra Bonita",
                    IdUF= 4,
                },
                new Municipio()
                {
                    IdMunicipio= 5,
                    NomeMunicipio= "Bauru",
                    IdUF= 5,
                }
            );
            #endregion

            #region Endereco Seed
            builder.Entity<Endereco>().HasData(
                new Endereco()
                {
                    IdEndereco= 1,
                    Logradouro= "Rua Deputado Orlando Jurca",
                    NumeroCasa= 243,
                    CEP= "14070280",
                    Bairro= "Quintino Facci II",
                    IdMunicipio= 1,

                },
                new Endereco()
                {
                    IdEndereco= 2,
                    Logradouro= "Avenida Paulista",
                    NumeroCasa= 542,
                    CEP= "03960000",
                    Bairro= "Centro",
                    IdMunicipio= 2,
                },
                new Endereco()
                {
                    IdEndereco= 3,
                    Logradouro= "Rua Quinze de Novembro 152",
                    NumeroCasa= 586,
                    CEP= "14830970",
                    Bairro= "Jardim dos Bosques",
                    IdMunicipio= 3,
                },
                new Endereco()
                {
                    IdEndereco= 4,
                    Logradouro= "Rua Winifrida",
                    NumeroCasa= 270,
                    CEP= "17340970",
                    Bairro= "Centro",
                    IdMunicipio= 4,
                },
                new Endereco()
                {
                    IdEndereco= 5,
                    Logradouro= "Rua Treze de Maio",
                    NumeroCasa= 564,
                    CEP= "17064853",
                    Bairro= "Altos da Cidade",
                    IdMunicipio= 5,
                },

                new Endereco()
                {
                    IdEndereco = 6,
                    Logradouro = "Rua Colômbia",
                    NumeroCasa = 142,
                    CEP = "14140280",
                    Bairro = "Vila Mariana",
                    IdMunicipio = 1,

                },
                new Endereco()
                {
                    IdEndereco = 7,
                    Logradouro = "Rua Porto Seguro",
                    NumeroCasa = 403,
                    CEP = "03965000",
                    Bairro = "Ipiranga",
                    IdMunicipio = 2,
                },
                new Endereco()
                {
                    IdEndereco = 8,
                    Logradouro = "Travessa Atíllio Poli",
                    NumeroCasa = 785,
                    CEP = "14844970",
                    Bairro = "Vila Monte Alegre",
                    IdMunicipio = 3,
                },
                new Endereco()
                {
                    IdEndereco = 9,
                    Logradouro = "Rua Santo Gatto",
                    NumeroCasa = 25,
                    CEP = "17350000",
                    Bairro = "Jardim da Barra",
                    IdMunicipio = 4,
                },
                new Endereco()
                {
                    IdEndereco = 10,
                    Logradouro = "Rua Virgilio Marta",
                    NumeroCasa = 245,
                    CEP = "17064853",
                    Bairro = "Centro",
                    IdMunicipio = 5,
                },
                new Endereco()
                {
                    IdEndereco = 11,
                    Logradouro = "Rua Luiz Gama",
                    NumeroCasa = 952,
                    CEP = "14080220",
                    Bairro = "Campos Elíseos",
                    IdMunicipio = 1,
                },
                new Endereco()
                {
                    IdEndereco = 12,
                    Logradouro = "Rua Plácido Rutini",
                    NumeroCasa = 741,
                    CEP = "04896030",
                    Bairro = "Jardim Santa Terezinha (Parelheiros)",
                    IdMunicipio = 2,
                },
                new Endereco()
                {
                    IdEndereco = 13,
                    Logradouro = "Rua Quinze de Novembro 152",
                    NumeroCasa = 241,
                    CEP = "14830970",
                    Bairro = "Centro",
                    IdMunicipio = 3,
                },
                new Endereco()
                {
                    IdEndereco = 14,
                    Logradouro = "Rua Winifrida 270",
                    NumeroCasa = 648,
                    CEP = "17340970",
                    Bairro = "Centro",
                    IdMunicipio = 4,
                },
                new Endereco()
                {
                    IdEndereco = 15,
                    Logradouro = "Avenida Alcindo Dias Soares",
                    NumeroCasa = 974,
                    CEP = "17018650",
                    Bairro = "Vila Aviação",
                    IdMunicipio = 5,
                }
            );
            #endregion


            #region Tutor Seed
            builder.Entity<Tutor>().HasData(
                new Tutor()
                {
                    IdTutor = 1,
                    NomeTutor = "Daniel André Francisco da Mata",
                    Email = "daniel.mata@gmail.com",
                    CPF = "49474113840",
                    RG = "424854752",
                    Sexo = 'M',
                    Foto = "img/tutor/tutor-1.png",
                    Fone = "(16) 3792-9234",
                    Celular = "(16) 99195-8396",
                    IdEndereco = 6,
                    ExibirHome = true
                },
                new Tutor()
                {
                    IdTutor = 2,
                    NomeTutor = "Eduardo Yago Nunes",
                    Email = "eduardo.nunes@gmail.com",
                    CPF = "65838512881",
                    RG = "312398669",
                    Sexo = 'M',
                    Foto = "img/tutor/tutor-2.png",
                    Fone = "(11) 2726-0341",
                    Celular = "(11) 98991-8021",
                    IdEndereco = 7,
                    ExibirHome = true
                },
                new Tutor()
                {
                    IdTutor = 3,
                    NomeTutor = "Laura Analu Carla Ribeiro",
                    Email = "laura.ribeiro@hotmail.com",
                    CPF = "46180447802",
                    RG = "473961702",
                    Sexo = 'F',
                    Foto = "img/tutor/tutor-3.png",
                    Fone = "(16) 3968-6516",
                    Celular = "(16) 98910-7852",
                    IdEndereco = 8,
                    ExibirHome = true
                },
                new Tutor()
                {
                    IdTutor = 4,
                    NomeTutor = "Fernando Lorenzo Rodrigues",
                    Email = "fernando.rodrigues@hotmail.com",
                    CPF = "80503642835",
                    RG = "318776066",
                    Sexo = 'M',
                    Foto = "img/tutor/tutor-4.png",
                    Fone = "(14) 3964-2127",
                    Celular = "(14) 98783-6149",
                    IdEndereco = 9,
                    ExibirHome = true
                },
                new Tutor()
                {
                    IdTutor = 5,
                    NomeTutor = "Liz Evelyn Alice Rodrigues",
                    Email = "liz.rodrigues@gmail.com",
                    CPF = "64446567888",
                    RG = "434533622",
                    Sexo = 'F',
                    Foto = "img/tutor/tutor-5.png",
                    Fone = "(14) 3733-2834",
                    Celular = "(14) 99952-7294",
                    IdEndereco = 10,
                    ExibirHome = true
                }
            );
            #endregion

            #region Pet Seed
            builder.Entity<Pet>().HasData(
                new Pet()
                {
                   IdPet= 1,
                   NomePet= "Xulico",
                   DataNascimento= Convert.ToDateTime("10/05/2018"),
                   Sexo= 'M',
                   Foto = "",
                   IdTutor= 1,
                   IdEspecie= 1,
                   IdRaca= 1,
                   IdPorte= 1,
                   ExibirHome = true
                },
                new Pet()
                {
                    IdPet= 2,
                    NomePet= "Safira",
                    DataNascimento = Convert.ToDateTime("05/10/2018"),
                    Sexo= 'F',
                    Foto = "",
                    IdTutor = 2,
                    IdEspecie= 2,
                    IdRaca= 4,
                    IdPorte= 1,
                    ExibirHome = true
                },
                new Pet()
                {
                    IdPet= 3,
                    NomePet= "Loro",
                    DataNascimento= Convert.ToDateTime("31/03/2015"),
                    Sexo= 'F',
                    Foto = "",
                    IdTutor = 3,
                    IdEspecie= 3,
                    IdRaca= 5,
                    IdPorte= 1,
                    ExibirHome = true
                },
                new Pet()
                {
                    IdPet= 4,
                    NomePet= "Thor",
                    DataNascimento= Convert.ToDateTime("01/09/2000"),
                    Sexo= 'M',
                    Foto = "",
                    IdTutor = 4,
                    IdEspecie= 1,
                    IdRaca= 2,
                    IdPorte= 3,
                    ExibirHome = true
                },
                new Pet()
                {
                    IdPet= 5,
                    NomePet= "Nino",
                    DataNascimento= Convert.ToDateTime("20/12/2014"),
                    Sexo= 'M',
                    Foto = "",
                    IdTutor = 5,
                    IdEspecie= 2,
                    IdRaca= 1,
                    IdPorte= 1,
                    ExibirHome = true
                }
            );
            #endregion

            #region Especie Seed
            builder.Entity<Especie>().HasData(
                new Especie()
                {
                    IdEspecie= 1,
                    NomeEspecie= "Cachorro"                    
                },
                new Especie()
                {
                    IdEspecie= 2,
                    NomeEspecie= "Gato"
                },
                new Especie()
                {
                    IdEspecie= 3,
                    NomeEspecie= "Pássaro"
                }
            );
            #endregion

            #region Raca Seed
            builder.Entity<Raca>().HasData(
                new Raca()
                {
                    IdRaca= 1,
                    NomeRaca= "Raça Indefinida",
                    IdEspecie= 1,
                },
                new Raca()
                {
                    IdRaca= 2,
                    NomeRaca= "Pastor Alemão",
                    IdEspecie= 1,
                },
                new Raca()
                {
                    IdRaca= 4,
                    NomeRaca= "Persa",
                    IdEspecie= 2,
                },
                new Raca()
                {
                    IdRaca= 5,
                    NomeRaca= "Papagaio",
                    IdEspecie= 3,
                }
            );
            #endregion

            #region Porte Seed
            builder.Entity<Porte>().HasData(
                new Porte()
                {
                    IdPorte= 1,
                    NomePorte= 'P',                    
                },
                new Porte()
                {
                    IdPorte= 2,
                    NomePorte= 'M',
                },
                new Porte()
                {
                    IdPorte= 3,
                    NomePorte= 'G',
                }

            );
            #endregion         


            #region Contato Seed
            builder.Entity<Contato>().HasData(
                new Contato()
                {
                    IdContato = 1,
                    Nome = "Laura Analu Carla Ribeiro",
                    Assunto = "Elogio",
                    Email = "laura.ribeiro@hotmail.com",
                    Telefone = "(16) 3968-6516",
                    Celular = "(16) 98910-7852",
                    Mensagem = "Eu agradeço a Unipet , porque no momento que mais precisei a Unipet me ajudou muito. Me sinto feliz e aliviada porque tenho o plano de saúde e sempre contei com ele. Estou muito satisfeita e a equipe Unipet sempre esteve disposta a satisfazer o cliente."
                },
                new Contato()
                {
                    IdContato = 2,
                    Nome = "Daniel André Francisco da Mata",
                    Assunto = "Elogio",
                    Email = "daniel.mata@gmail.com",
                    Telefone = "(16) 3792-9234",
                    Celular = "(16) 99195-8396",
                    Mensagem = "A Unipet é perfeita!!! O site e o atendimento são maravilhosos e os profissionais muito atenciosos. Fiquei muito feliz com o atendimento dado ao meu cãozinho."
                },
                new Contato()
                {
                    IdContato = 3,
                    Nome = "Eduardo Yago Nunes",
                    Assunto = "Depoimento",
                    Email = "eduardo.nunes@gmail.com",
                    Telefone = "(11) 2726-0341",
                    Celular = "(11) 98991-8021",
                    Mensagem = "O atendimento da Unipet é indescritível!!! Total carinho e cuidado com meu filhote. O pessoal da clínica, como um todo, é muito atencioso."
                }
            );
            #endregion

            #region Relato Seed
            builder.Entity<Relato>().HasData(
                new Relato()
                {
                    IdRelato = 1,
                    Nome = "Laura Analu Carla Ribeiro",
                    Texto = "Eu agradeço a Unipet , porque no momento que mais precisei a Unipet me ajudou muito. Me sinto feliz e aliviada porque tenho o plano de saúde e sempre contei com ele. Estou muito satisfeita e a equipe Unipet sempre esteve disposta a satisfazer o cliente.",
                    Foto = "img/testimonial/testimonial-1.png",
                    ExibirHome = true
                },
                new Relato()
                {
                    IdRelato = 2,
                    Nome = "Daniel André Francisco da Mata",
                    Texto = "A Unipet é perfeita!!! O site e o atendimento são maravilhosos e os profissionais muito atenciosos. Fiquei muito feliz com o atendimento dado ao meu cãozinho.",
                    Foto = "img/testimonial/testimonial-2.png",
                    ExibirHome = true
                },
                new Relato()
                {
                    IdRelato = 3,
                    Nome = "Eduardo Yago Nunes",
                    Texto = "O atendimento da Unipet é indescritível!!! Total carinho e cuidado com meu filhote. O pessoal da clínica, como um todo, é muito atencioso.",
                    Foto = "img/testimonial/testimonial-3.png",
                    ExibirHome = true
                }
            );
            #endregion

            #region Blog Seed
            builder.Entity<Blog>().HasData(
                new Blog()
                {
                    IdPublicacao = 1,
                    Titulo = "EUA e Rússia dão largada à imunização de animais contra a Covid-19",
                    Texto = "Cães, gatos, gorilas, tigres e ursos estão entre os protegidos. De recompensa, eles ganham marshmallows e sorvete",
                    DataPublicacao = Convert.ToDateTime("19/11/2021"),
                    Foto = "img/blog/blog-1.png",
                    ExibirHome = true
                },
                new Blog()
                {
                    IdPublicacao = 2,
                    Titulo = "No mercado de pets, a moda agora é vender por assinatura",
                    Texto = "Empresas apostam na internet e adotam modelo de assinatura para a venda de ração de animais de estimação, segmento que faturou para o setor quase 10 bilhões em 2012",
                    DataPublicacao = Convert.ToDateTime("19/11/2021"),
                    Foto = "img/blog/blog-2.png",
                    ExibirHome = true
                },
                new Blog()
                {
                    IdPublicacao = 3,
                    Titulo = "Vivo terá canal para clientes que quiserem adotar pets",
                    Texto = "Serviço estará disponível no aplicativo Meu Vivo inicialmente para clientes das capitais São Paulo, Rio de Janeiro, Belo Horizonte e regiões metropolitanas",
                    DataPublicacao = Convert.ToDateTime("19/11/2021"),
                    Foto = "img/blog/blog-3.png",
                    ExibirHome = true
                }
            );
            #endregion

        }

        public DbSet<Unipet.Models.AreaCobertura> AreaCobertura { get; set; }

        public DbSet<Unipet.Models.Prestador> Prestador { get; set; }
    }    
    
}