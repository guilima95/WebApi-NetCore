
create database Teste;


create table usuario (
id int primary key not null,
email varchar(200) not null, 
password varchar (30) not null

);

create table empresa (
id int primary key not null,
nome varchar(50) not null, 
tipo int  not null

);


insert into usuario (email, password)
values ('testeapple@ioasys.com.br','12341234');

insert into empresa (nome, tipo)
values ('aQm', 1);



