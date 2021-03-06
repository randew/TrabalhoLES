-- SCRIPT DE CRIAÇÃO DO BANCO
USE [master]

-- COMANDO QUE DERRUBA O BANCO
IF  EXISTS (
SELECT name 
FROM sys.databases 
WHERE name = 'padariaBD')
DROP DATABASE padariaBD
GO
-- COMANDO QUE DERRUBA O BANCO
USE master
GO
--COMANDO DE CRIAÇÃO DE BANCO DE DADOS: CREATE DATABASE
--Criação do Banco de Dados da padaria
--Mudem o filename de ambos se quiserem testar em casa.
CREATE DATABASE padariaBD ON 
(	
	NAME = padariaBD_db, --nome lógico
	FILENAME = "C:\Users\DELL\Documents\banco\padariaBD.mdf", --nome físico
	SIZE = 5 Mb, --tamanho
	MAXSIZE = 10 Mb, --tamanho máximo
	FILEGROWTH = 1 Mb --taxa de crescimento
) 
LOG ON -- criação do log, continuação do create database
( 
	NAME = padariaBD_log, 
	FILENAME = "C:\Users\DELL\Documents\banco\padariaBD.ldf",
	SIZE = 1 Mb,
	MAXSIZE = 5 Mb,
	FILEGROWTH = 1 Mb
)
GO
--use padariaBD
--go
CREATE TABLE padariaBD.dbo.Produto
(
	ID_Produto INT NOT NULL UNIQUE,
	Prod_Nome VARCHAR(50) NOT NULL,
	Prod_Valor MONEY NOT NULL,
	PRIMARY KEY (ID_Produto ASC)
)
create table padariaBD.dbo.Fornecedores(
	ID_CNPJ VARCHAR(16) NOT NULL,
	ID_Endereco INT NOT NULL,
	PRIMARY KEY(ID_CNPJ),
	FOREIGN KEY (ID_Endereco) REFERENCES padariaBD.dbo.Endereco

)
create table padariaBD.dbo.Forn_Prod(
	ID_FornProd INT NOT NULL,
	PRIMARY KEY(ID_FornProd ASC)
)
create table padariaBD.dbo.Locais(
	ID_Locais INT NOT NULL,
	PRIMARY KEY (ID_Locais ASC)
)
create table padariaBD.dbo.Consumidores(
	ID_CPF VARCHAR(11) NOT NULL,
	PRIMARY KEY (ID_CPF ASC)
)
create table padariaBD.dbo.Consumo_Prod(
	ID_ConsumoProd INT NOT NULL,
	PRIMARY KEY(ID_ConsumoProd ASC)
)
create table padariaBD.dbo.Lote(
	ID_Lote INT NOT NULL,
	PRIMARY KEY(ID_Lote ASC)
)
create table padariaBD.dbo.NFS(
	ID_NFS INT NOT NULL,
	PRIMARY KEY(ID_NFS ASC)
)
create table padariaBD.dbo.Endereco(
	ID_Endereco INT NOT NULL,
	PRIMARY KEY(ID_Endereco ASC)
)
