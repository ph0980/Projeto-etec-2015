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
    descricao varchar(20)not null,
    preco decimal(5,2)not null,
    quantidade int(3)not null
);
create table vendas
(
data datetime,
dt_gastos datetime,
valor_gasto decimal (5,2),
valor_venda decimal(5,2),
descricao varchar(50),
preco decimal (5,2),
produto varchar(40),
quantidade int(3)
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

create table pergunta
(
pergunta varchar(50)
);

create table tipo
(
tipo varchar(40) 
);



insert into login(nome,senha)values('root','1234');

insert into tipo(tipo) values('Bebidas');
insert into tipo(tipo) values('Condimentos e conservas');
insert into tipo(tipo) values('Farinhas e Grãos');
insert into tipo(tipo) values('Frios');
insert into tipo(tipo) values('Higiene');
insert into tipo(tipo) values('Massas');
insert into tipo(tipo) values('Limpeza e Utensilios');
insert into tipo(tipo) values('Resfriados');
insert into tipo(tipo) values('Molhos');
insert into tipo(tipo) values('Laticinios');
insert into tipo(tipo) values('Temperos');
insert into tipo(tipo) values('Outros');


insert into pergunta(pergunta) values ('Qual é o seu filme favorito ?');
insert into pergunta(pergunta) values ('Qual é a sua música favorita ?');
insert into pergunta(pergunta) values ('Qual é o nome da cidade que você nasceu ?');
insert into pergunta(pergunta) values ('Qual é o seu livro favorito ?');

drop database bancodedados ;
select * from vendas;
insert into vendas(data_venda,valor_venda,descricao)values('','','');
select sum(preco) * sum(quantidade) - sum(valor_gasto)  from vendas;
select sum(valor_venda),sum(valor_venda) - sum(valor_gasto) from vendas where data between '2016-12-01' and '2016-12-01' and dt_gastos between '"2016-12-01' and ' 2016-12-01 '