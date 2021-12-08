-- phpMyAdmin SQL Dump
-- version 5.1.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Tempo de geração: 24-Out-2021 às 15:10
-- Versão do servidor: 10.4.21-MariaDB
-- versão do PHP: 8.0.10

create database unipet;

use unipet;
--
-- Banco de dados: `unipetdb`
--

-- --------------------------------------------------------

--
-- Estrutura da tabela `areacobertura`
--

CREATE TABLE `areacobertura` (
  `IdArea` int(11) NOT NULL,
  `NomeArea` varchar(30) NOT NULL,
  `IdMunicipio` int(11) NOT NULL,
  `MunicipioIdMunicipio` int(11) DEFAULT NULL,
  `IdEmpresa` int(11) NOT NULL,
  `EmpresaIdEmpresa` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Estrutura da tabela `aspnetuserclaims`
--

CREATE TABLE `aspnetuserclaims` (
  `Id` int(11) NOT NULL,
  `UserId` varchar(255) NOT NULL,
  `ClaimType` longtext DEFAULT NULL,
  `ClaimValue` longtext DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Estrutura da tabela `empresa`
--

CREATE TABLE `empresa` (
  `IdEmpresa` int(11) NOT NULL,
  `RazaoSocial` varchar(60) NOT NULL,
  `CNPJ` int(11) NOT NULL,
  `Email` varchar(60) NOT NULL,
  `Fone` varchar(20) NOT NULL,
  `Logotipo` varchar(200) NOT NULL,
  `IdEndereco` int(11) NOT NULL,
  `EnderecoIdEndereco` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Estrutura da tabela `endereco`
--

CREATE TABLE `endereco` (
  `IdEndereco` int(11) NOT NULL,
  `Logradouro` varchar(60) NOT NULL,
  `NumeroCasa` int(11) NOT NULL,
  `CEP` int(11) NOT NULL,
  `Bairro` varchar(60) NOT NULL,
  `IdMunicipio` int(11) NOT NULL,
  `MunicipioIdMunicipio` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Estrutura da tabela `especialidade`
--

CREATE TABLE `especialidade` (
  `IdEspecialidade` int(11) NOT NULL,
  `NomeEspecialidade` varchar(20) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Estrutura da tabela `especialidadeplano`
--

CREATE TABLE `especialidadeplano` (
  `IdEspecialidade` int(11) NOT NULL,
  `IdPlano` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Estrutura da tabela `municipio`
--

CREATE TABLE `municipio` (
  `IdMunicipio` int(11) NOT NULL,
  `NomeMunicipio` varchar(64) NOT NULL,
  `IdUF` int(11) NOT NULL,
  `UFIdUF` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Estrutura da tabela `perfil`
--

CREATE TABLE `perfil` (
  `Id` varchar(255) NOT NULL,
  `Name` varchar(256) DEFAULT NULL,
  `NormalizedName` varchar(256) DEFAULT NULL,
  `ConcurrencyStamp` longtext DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Estrutura da tabela `perfilclaims`
--

CREATE TABLE `perfilclaims` (
  `Id` int(11) NOT NULL,
  `RoleId` varchar(255) NOT NULL,
  `ClaimType` longtext DEFAULT NULL,
  `ClaimValue` longtext DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Estrutura da tabela `plano`
--

CREATE TABLE `plano` (
  `IdPlano` int(11) NOT NULL,
  `NomePlano` varchar(20) NOT NULL,
  `Descricao` varchar(500) NOT NULL,
  `Valor` decimal(65,30) NOT NULL,
  `IdArea` int(11) NOT NULL,
  `AreaCoberturaIdArea` int(11) DEFAULT NULL,
  `IdEmpresa` int(11) NOT NULL,
  `EmpresaIdEmpresa` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Estrutura da tabela `prestador`
--

CREATE TABLE `prestador` (
  `IdPrestador` int(11) NOT NULL,
  `RazaoSocial` varchar(60) NOT NULL,
  `CNPJ` int(11) NOT NULL,
  `Email` varchar(60) NOT NULL,
  `Fone` varchar(20) NOT NULL,
  `Logotipo` varchar(200) NOT NULL,
  `IdEndereco` int(11) NOT NULL,
  `EnderecoIdEndereco` int(11) DEFAULT NULL,
  `IdUsuario` longtext NOT NULL,
  `UsuarioId` varchar(255) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Estrutura da tabela `prestadorempresa`
--

CREATE TABLE `prestadorempresa` (
  `IdEmpresa` int(11) NOT NULL,
  `IdPrestador` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Estrutura da tabela `uf`
--

CREATE TABLE `uf` (
  `IdUF` int(11) NOT NULL,
  `Sigla` longtext NOT NULL,
  `NomeEstado` varchar(64) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Estrutura da tabela `usuario`
--

CREATE TABLE `usuario` (
  `Id` varchar(255) NOT NULL,
  `Nome` varchar(60) DEFAULT NULL,
  `LimiteAlteracaoNomeUsuario` int(11) NOT NULL,
  `Avatar` longblob DEFAULT NULL,
  `DataNascimento` datetime(6) NOT NULL,
  `UserName` varchar(256) DEFAULT NULL,
  `NormalizedUserName` varchar(256) DEFAULT NULL,
  `Email` varchar(256) DEFAULT NULL,
  `NormalizedEmail` varchar(256) DEFAULT NULL,
  `EmailConfirmed` tinyint(1) NOT NULL,
  `PasswordHash` longtext DEFAULT NULL,
  `SecurityStamp` longtext DEFAULT NULL,
  `ConcurrencyStamp` longtext DEFAULT NULL,
  `PhoneNumber` longtext DEFAULT NULL,
  `PhoneNumberConfirmed` tinyint(1) NOT NULL,
  `TwoFactorEnabled` tinyint(1) NOT NULL,
  `LockoutEnd` datetime(6) DEFAULT NULL,
  `LockoutEnabled` tinyint(1) NOT NULL,
  `AccessFailedCount` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Estrutura da tabela `usuariologin`
--

CREATE TABLE `usuariologin` (
  `LoginProvider` varchar(255) NOT NULL,
  `ProviderKey` varchar(255) NOT NULL,
  `ProviderDisplayName` longtext DEFAULT NULL,
  `UserId` varchar(255) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Estrutura da tabela `usuarioperfil`
--

CREATE TABLE `usuarioperfil` (
  `UserId` varchar(255) NOT NULL,
  `RoleId` varchar(255) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Estrutura da tabela `usuariotokens`
--

CREATE TABLE `usuariotokens` (
  `UserId` varchar(255) NOT NULL,
  `LoginProvider` varchar(255) NOT NULL,
  `Name` varchar(255) NOT NULL,
  `Value` longtext DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Estrutura da tabela `__efmigrationshistory`
--

CREATE TABLE `__efmigrationshistory` (
  `MigrationId` varchar(150) NOT NULL,
  `ProductVersion` varchar(32) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Extraindo dados da tabela `__efmigrationshistory`
--

INSERT INTO `__efmigrationshistory` (`MigrationId`, `ProductVersion`) VALUES
('20211024125913_criar-banco', '5.0.11');

--
-- Índices para tabelas despejadas
--

--
-- Índices para tabela `areacobertura`
--
ALTER TABLE `areacobertura`
  ADD PRIMARY KEY (`IdArea`),
  ADD KEY `IX_AreaCobertura_EmpresaIdEmpresa` (`EmpresaIdEmpresa`),
  ADD KEY `IX_AreaCobertura_MunicipioIdMunicipio` (`MunicipioIdMunicipio`);

--
-- Índices para tabela `aspnetuserclaims`
--
ALTER TABLE `aspnetuserclaims`
  ADD PRIMARY KEY (`Id`),
  ADD KEY `IX_AspNetUserClaims_UserId` (`UserId`);

--
-- Índices para tabela `empresa`
--
ALTER TABLE `empresa`
  ADD PRIMARY KEY (`IdEmpresa`),
  ADD KEY `IX_Empresa_EnderecoIdEndereco` (`EnderecoIdEndereco`);

--
-- Índices para tabela `endereco`
--
ALTER TABLE `endereco`
  ADD PRIMARY KEY (`IdEndereco`),
  ADD KEY `IX_Endereco_MunicipioIdMunicipio` (`MunicipioIdMunicipio`);

--
-- Índices para tabela `especialidade`
--
ALTER TABLE `especialidade`
  ADD PRIMARY KEY (`IdEspecialidade`);

--
-- Índices para tabela `especialidadeplano`
--
ALTER TABLE `especialidadeplano`
  ADD PRIMARY KEY (`IdPlano`,`IdEspecialidade`),
  ADD KEY `IX_EspecialidadePlano_IdEspecialidade` (`IdEspecialidade`);

--
-- Índices para tabela `municipio`
--
ALTER TABLE `municipio`
  ADD PRIMARY KEY (`IdMunicipio`),
  ADD KEY `IX_Municipio_UFIdUF` (`UFIdUF`);

--
-- Índices para tabela `perfil`
--
ALTER TABLE `perfil`
  ADD PRIMARY KEY (`Id`),
  ADD UNIQUE KEY `RoleNameIndex` (`NormalizedName`);

--
-- Índices para tabela `perfilclaims`
--
ALTER TABLE `perfilclaims`
  ADD PRIMARY KEY (`Id`),
  ADD KEY `IX_PerfilClaims_RoleId` (`RoleId`);

--
-- Índices para tabela `plano`
--
ALTER TABLE `plano`
  ADD PRIMARY KEY (`IdPlano`),
  ADD KEY `IX_Plano_AreaCoberturaIdArea` (`AreaCoberturaIdArea`),
  ADD KEY `IX_Plano_EmpresaIdEmpresa` (`EmpresaIdEmpresa`);

--
-- Índices para tabela `prestador`
--
ALTER TABLE `prestador`
  ADD PRIMARY KEY (`IdPrestador`),
  ADD KEY `IX_Prestador_EnderecoIdEndereco` (`EnderecoIdEndereco`),
  ADD KEY `IX_Prestador_UsuarioId` (`UsuarioId`);

--
-- Índices para tabela `prestadorempresa`
--
ALTER TABLE `prestadorempresa`
  ADD PRIMARY KEY (`IdEmpresa`,`IdPrestador`),
  ADD KEY `IX_PrestadorEmpresa_IdPrestador` (`IdPrestador`);

--
-- Índices para tabela `uf`
--
ALTER TABLE `uf`
  ADD PRIMARY KEY (`IdUF`);

--
-- Índices para tabela `usuario`
--
ALTER TABLE `usuario`
  ADD PRIMARY KEY (`Id`),
  ADD UNIQUE KEY `UserNameIndex` (`NormalizedUserName`),
  ADD KEY `EmailIndex` (`NormalizedEmail`);

--
-- Índices para tabela `usuariologin`
--
ALTER TABLE `usuariologin`
  ADD PRIMARY KEY (`LoginProvider`,`ProviderKey`),
  ADD KEY `IX_UsuarioLogin_UserId` (`UserId`);

--
-- Índices para tabela `usuarioperfil`
--
ALTER TABLE `usuarioperfil`
  ADD PRIMARY KEY (`UserId`,`RoleId`),
  ADD KEY `IX_UsuarioPerfil_RoleId` (`RoleId`);

--
-- Índices para tabela `usuariotokens`
--
ALTER TABLE `usuariotokens`
  ADD PRIMARY KEY (`UserId`,`LoginProvider`,`Name`);

--
-- Índices para tabela `__efmigrationshistory`
--
ALTER TABLE `__efmigrationshistory`
  ADD PRIMARY KEY (`MigrationId`);

--
-- AUTO_INCREMENT de tabelas despejadas
--

--
-- AUTO_INCREMENT de tabela `areacobertura`
--
ALTER TABLE `areacobertura`
  MODIFY `IdArea` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT de tabela `aspnetuserclaims`
--
ALTER TABLE `aspnetuserclaims`
  MODIFY `Id` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT de tabela `empresa`
--
ALTER TABLE `empresa`
  MODIFY `IdEmpresa` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT de tabela `endereco`
--
ALTER TABLE `endereco`
  MODIFY `IdEndereco` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT de tabela `especialidade`
--
ALTER TABLE `especialidade`
  MODIFY `IdEspecialidade` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT de tabela `municipio`
--
ALTER TABLE `municipio`
  MODIFY `IdMunicipio` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT de tabela `perfilclaims`
--
ALTER TABLE `perfilclaims`
  MODIFY `Id` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT de tabela `plano`
--
ALTER TABLE `plano`
  MODIFY `IdPlano` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT de tabela `prestador`
--
ALTER TABLE `prestador`
  MODIFY `IdPrestador` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT de tabela `uf`
--
ALTER TABLE `uf`
  MODIFY `IdUF` int(11) NOT NULL AUTO_INCREMENT;

--
-- Restrições para despejos de tabelas
--

--
-- Limitadores para a tabela `areacobertura`
--
ALTER TABLE `areacobertura`
  ADD CONSTRAINT `FK_AreaCobertura_Empresa_EmpresaIdEmpresa` FOREIGN KEY (`EmpresaIdEmpresa`) REFERENCES `empresa` (`IdEmpresa`),
  ADD CONSTRAINT `FK_AreaCobertura_Municipio_MunicipioIdMunicipio` FOREIGN KEY (`MunicipioIdMunicipio`) REFERENCES `municipio` (`IdMunicipio`);

--
-- Limitadores para a tabela `aspnetuserclaims`
--
ALTER TABLE `aspnetuserclaims`
  ADD CONSTRAINT `FK_AspNetUserClaims_Usuario_UserId` FOREIGN KEY (`UserId`) REFERENCES `usuario` (`Id`) ON DELETE CASCADE;

--
-- Limitadores para a tabela `empresa`
--
ALTER TABLE `empresa`
  ADD CONSTRAINT `FK_Empresa_Endereco_EnderecoIdEndereco` FOREIGN KEY (`EnderecoIdEndereco`) REFERENCES `endereco` (`IdEndereco`);

--
-- Limitadores para a tabela `endereco`
--
ALTER TABLE `endereco`
  ADD CONSTRAINT `FK_Endereco_Municipio_MunicipioIdMunicipio` FOREIGN KEY (`MunicipioIdMunicipio`) REFERENCES `municipio` (`IdMunicipio`);

--
-- Limitadores para a tabela `especialidadeplano`
--
ALTER TABLE `especialidadeplano`
  ADD CONSTRAINT `FK_EspecialidadePlano_Especialidade_IdEspecialidade` FOREIGN KEY (`IdEspecialidade`) REFERENCES `especialidade` (`IdEspecialidade`) ON DELETE CASCADE,
  ADD CONSTRAINT `FK_EspecialidadePlano_Plano_IdPlano` FOREIGN KEY (`IdPlano`) REFERENCES `plano` (`IdPlano`) ON DELETE CASCADE;

--
-- Limitadores para a tabela `municipio`
--
ALTER TABLE `municipio`
  ADD CONSTRAINT `FK_Municipio_UF_UFIdUF` FOREIGN KEY (`UFIdUF`) REFERENCES `uf` (`IdUF`);

--
-- Limitadores para a tabela `perfilclaims`
--
ALTER TABLE `perfilclaims`
  ADD CONSTRAINT `FK_PerfilClaims_Perfil_RoleId` FOREIGN KEY (`RoleId`) REFERENCES `perfil` (`Id`) ON DELETE CASCADE;

--
-- Limitadores para a tabela `plano`
--
ALTER TABLE `plano`
  ADD CONSTRAINT `FK_Plano_AreaCobertura_AreaCoberturaIdArea` FOREIGN KEY (`AreaCoberturaIdArea`) REFERENCES `areacobertura` (`IdArea`),
  ADD CONSTRAINT `FK_Plano_Empresa_EmpresaIdEmpresa` FOREIGN KEY (`EmpresaIdEmpresa`) REFERENCES `empresa` (`IdEmpresa`);

--
-- Limitadores para a tabela `prestador`
--
ALTER TABLE `prestador`
  ADD CONSTRAINT `FK_Prestador_Endereco_EnderecoIdEndereco` FOREIGN KEY (`EnderecoIdEndereco`) REFERENCES `endereco` (`IdEndereco`),
  ADD CONSTRAINT `FK_Prestador_Usuario_UsuarioId` FOREIGN KEY (`UsuarioId`) REFERENCES `usuario` (`Id`);

--
-- Limitadores para a tabela `prestadorempresa`
--
ALTER TABLE `prestadorempresa`
  ADD CONSTRAINT `FK_PrestadorEmpresa_Empresa_IdEmpresa` FOREIGN KEY (`IdEmpresa`) REFERENCES `empresa` (`IdEmpresa`) ON DELETE CASCADE,
  ADD CONSTRAINT `FK_PrestadorEmpresa_Prestador_IdPrestador` FOREIGN KEY (`IdPrestador`) REFERENCES `prestador` (`IdPrestador`) ON DELETE CASCADE;

--
-- Limitadores para a tabela `usuariologin`
--
ALTER TABLE `usuariologin`
  ADD CONSTRAINT `FK_UsuarioLogin_Usuario_UserId` FOREIGN KEY (`UserId`) REFERENCES `usuario` (`Id`) ON DELETE CASCADE;

--
-- Limitadores para a tabela `usuarioperfil`
--
ALTER TABLE `usuarioperfil`
  ADD CONSTRAINT `FK_UsuarioPerfil_Perfil_RoleId` FOREIGN KEY (`RoleId`) REFERENCES `perfil` (`Id`) ON DELETE CASCADE,
  ADD CONSTRAINT `FK_UsuarioPerfil_Usuario_UserId` FOREIGN KEY (`UserId`) REFERENCES `usuario` (`Id`) ON DELETE CASCADE;

--
-- Limitadores para a tabela `usuariotokens`
--
ALTER TABLE `usuariotokens`
  ADD CONSTRAINT `FK_UsuarioTokens_Usuario_UserId` FOREIGN KEY (`UserId`) REFERENCES `usuario` (`Id`) ON DELETE CASCADE;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
