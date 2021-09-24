create database db_games;

use db_games;

create table tb_cliente(

CliNome varchar(150) not null,
CliCPF varchar(150) PRIMARY KEY,
CliDtNasc datetime not null,
CliEmail varchar(150) not null,
CliTel varchar(150) not null,
CliEnd varchar(150) not null

);

create table tb_funcionário(

FuncCod decimal(0,4) PRIMARY KEY,
FuncNome varchar(150) not null,
FuncCPF varchar(150) not null,
FuncRG varchar(150) not null,
FuncDtNasc datetime not null,
FuncEnd varchar(150) not null,
FuncTel varchar(150) not null,
FuncEmail varchar(150) not null,
FuncCargo varchar(150) not null

);

create table tb_jogo(

JogoCod decimal (0,10) PRIMARY KEY,
JogoNome varchar(150) not null,
JogoVers varchar(150) not null,
JogoDes varchar(150) not null,
JogoGender varchar(50) not null,
JogoFaixa varchar(150) not null,
JogoPlat varchar(50) not null,
JogoDtLanc datetime not null,
JogoSinopse varchar(300) not null

);
