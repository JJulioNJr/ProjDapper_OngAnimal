Using ONG_ANIMAL;

CREATE DATABASE ONG_ANIMAL;

CREATE TABLE PESSOA(

CPF varchar(11) NOT NULL,
NOME varchar(50)NOT NULL,
SEXO char (1),
DATANASCIMENTO varchar(10),
LOGRADOURO varchar (50),
NUMERO varchar(4),
CEP varchar(9) NOT NULL,
BAIRRO varchar (50),
UF char (2),
CIDADE varchar (50),
COMPLEMENTO varchar (30),

CONSTRAINT PK_CPF_Pessoa PRIMARY KEY (CPF));


CREATE TABLE ANIMAL(

CHIP int identity NOT NULL,
ESPECIE varchar(50) NOT NULL,
RACA varchar(20),
SEXO char(1),

CONSTRAINT PK_CHIP_ANIMAL PRIMARY KEY (CHIP));

CREATE TABLE ADOCOES(

ID int identity NOT NULL,
CPF varchar(11) NOT NULL,
Chip int NOT NULL,
Situacao varchar (12),

CONSTRAINT PK_ID_ADOCOES PRIMARY KEY (ID),

FOREIGN KEY(CPF) REFERENCES PESSOA(CPF),
FOREIGN KEY(CHIP) REFERENCES ANIMAL(CHIP));

Select * From Animal;

Select *from Pessoa;

Select * From ADOCOES;


