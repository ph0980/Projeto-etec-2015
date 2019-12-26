create database BancoDeDados;
use BancoDeDados;

create table Cliente
(
	 id int not null auto_increment  primary key,
     cpf varchar(15) unique not null,
     nome varchar(90) not null,
     bairro varchar(50)not null,
     endereco varchar(80)not null,
     complemento varchar(50),
     telefone varchar(15),
     divida decimal(5,2)not null
);

create table Produto
(
	idprod int not null auto_increment primary key,
    cod_barras varchar(13)  not null,
    tipo varchar(40)not null,
    produto varchar(40)  not null,
    peso varchar(5)not null,
    preco decimal(5,2)not null,
    quantidade int(3)not null
);
create table vendas
(
valor decimal(5,2),
data_venda datetime
);
create table usuario
(
nome varchar(30) unique,
senha varchar(12),
pergunta varchar(100),
resposta varchar(40)
);
create table login
(
nome varchar(30) unique,
senha varchar(12) unique
);

insert into login(nome,senha)values('root','1234');
drop table produto;
select * from usuario;