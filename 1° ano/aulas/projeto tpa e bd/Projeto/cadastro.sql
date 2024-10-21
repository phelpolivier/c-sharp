create database dsn;
use dsn;
create table produto(
id int primary key auto_increment,
produto varchar(50),
descricao varchar(50),
tipo varchar(50),
valor decimal(10,2)
);

create table cliente(
id int primary key auto_increment,
nome varchar(50),
telefone varchar(50),
endereco varchar(50),
email varchar(50)
);

create table login(
id int primary key auto_increment,
nome varchar(50),
usuario varchar(50),
senha varchar(10)
);
insert into login(nome,usuario,senha)values('phelipe estevam','phelipe','root');