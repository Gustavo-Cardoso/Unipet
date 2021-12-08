

/*-------------------------PORTE-------------------------*/
/*insert into Porte (NomePorte) values ("P", "M", "G");*/

/*--------------------------ESTADO---------------------
insert into UF (NomeEstado) values ("MG");
insert into UF (NomeEstado) values ("Rj");
insert into UF (NomeEstado) values ("SP");*/

/*-----------------ESPECIE----------------
insert into Especie (NomeEspecie) values ("Cachorro");
insert into Especie (NomeEspecie) values ("Gato");
insert into Especie (NomeEspecie) values ("Pássaro");*/

/*--------------------RACA--------------------
insert into Raca (NomeRaca, IdEspecie) values ("Raça Indefinida", 1);
insert into Raca (NomeRaca, IdEspecie) values ("Fox Paulistinha", 1);
insert into Raca (NomeRaca, IdEspecie) values ("Pastor Alemão", 1);
insert into Raca (NomeRaca, IdEspecie) values ("Labrador Retriever", 1);
insert into Raca (NomeRaca, IdEspecie) values ("Raça Indefinida", 2);
insert into Raca (NomeRaca, IdEspecie) values ("Persa", 2);
insert into Raca (NomeRaca, IdEspecie) values ("Maine Coon", 2);
insert into Raca (NomeRaca, IdEspecie) values ("Periquito", 3);*/

/*--------------------MUNICIPIO-------------------------*/
insert into Municipio (NomeMunicipio, IdUF) values ("Barra Bonita", 3);
insert into Municipio (NomeMunicipio, IdUF) values ("Igaraçu do Tietê", 3);

/*-----------------------ESPECIALIDADE--------------------------*/
insert into Especialidade (NomeEspecialidade) values ("Acupuntura");
insert into Especialidade (NomeEspecialidade) values ("Fisioterapia");
insert into Especialidade (NomeEspecialidade) values ("Ortopedia");

/*----------------------EMPRESA----------------------*/
insert into Empresa (RazaoSocial, CNPJ, Email, Fone) values ();

select * from unipetdb.municipio
