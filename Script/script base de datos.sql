create database Hipstagram;
 
 use Hipstagram;
 create table User (
 	username varchar(30) primary key, 
 	name varchar(40) not null,
 	lastname varchar(30) not null,
 	birthday date not null,
 	password_	binary not null,
 	mail varchar(50) not null unique,
 	status_ int not null
 );


create table Post(
 ref_image varchar(200)primary key,
 decripcion text not null,
 username varchar(30),
 FOREIGN KEY (username) REFERENCES user(username) 
);

create table Comment (
	date_ dateTime ,
	value text not null,
	username varchar(30) ,
 	ref_image varchar(200),
 	foreign key (username) references user (username),
 	foreign key (ref_image) references post (ref_image),
 	primary key (date_, username,ref_image)
 	
);


create table Ranking (
	date_ dateTime ,
	value int not null,
	username varchar(30) ,
 	ref_image varchar(200),
 	foreign key (username) references user (username),
 	foreign key (ref_image) references post (ref_image),
 	primary key (date_, username,ref_image)
 	
);

insert into ranking (date_,value,username,ref_image)

create table hashtag(
	tag varchar(100) primary key
);




create table post_hashtag(
	ref_image varchar(200) not null,
	tag varchar(100) not null,
	foreign key (ref_image) references POST (ref_image),
	foreign key (tag)  references hashtag (tag),
	primary key (ref_image,tag)
);




 select * from user

insert into user (username, name,lastname,birthday,password_,mail,status_) 
values ('user1','nombre1','apellido1','1988/10/20','p1','user1@servidor.com',1);
 select * from user
insert into user (username, name,lastname,birthday,password_,mail,status_) 
values ('user2','nombre2','apellido2','1978/11/3','a','user2@servidor.com',1);
insert into user (username, name,lastname,birthday,password_,mail,status_) 
values ('user3','nombre3','apellido3','1998/10/16','b','user3@servidor.com',0); 
insert into user (username, name,lastname,birthday,password_,mail,status_) 
values ('user4','nombre4','apellido4','1992/9/29','c','user4@servidor.com',1); 
insert into user (username, name,lastname,birthday,password_,mail,status_) 
values ('user5','nombre5','apellido5','1993/12/23','d','user5@servidor.com',1);

select * from post
insert into post (ref_image,decripcion,username) values ('repositorio/imagen1','esta es la imagen 1','user1');
insert into post (ref_image,decripcion,username) values ('repositorio/imagen2','esta es la imagen 2','user3');
insert into post (ref_image,decripcion,username) values ('repositorio/imagen3','esta es la imagen 3','user2');
insert into post (ref_image,decripcion,username) values ('repositorio/imagen4','esta es la imagen 4','user2');
insert into post (ref_image,decripcion,username) values ('repositorio/imagen5','esta es la imagen 5','user1');
insert into post (ref_image,decripcion,username) values ('repositorio/imagen6','esta es la imagen 6','user5');

select * from comment;
insert into comment (date_,value,username,ref_image) values 
('2018-10-19 22:08:22','comentario 1','user1','repositorio/imagen2'),
('2018-10-19 21:08:22','comentario 2','user2','repositorio/imagen1'),
('2018-9-19 11:08:22','comentario 3','user4','repositorio/imagen2'),
('2018-10-19 12:08:22','comentario 4','user3','repositorio/imagen5'),
('2018-10-19 1:08:22','comentario 5','user2','repositorio/imagen6'),
('2018-10-19 12:08:22','comentario 6','user5','repositorio/imagen4'),
('2018-10-19 15:08:22','comentario 7','user1','repositorio/imagen2');

select * from ranking;
insert into ranking (date_,value,username,ref_image) values
('2018-10-19 22:08:22',1,'user1','repositorio/imagen2'),
('2018-10-19 21:08:22',-1,'user2','repositorio/imagen1'),
('2018-9-19 11:08:22',-1,'user4','repositorio/imagen2'),
('2018-10-19 12:08:22',-1,'user3','repositorio/imagen5'),
('2018-10-19 1:08:22',1,'user2','repositorio/imagen6'),
('2018-10-19 12:08:22',1,'user5','repositorio/imagen4'),
('2018-10-19 15:08:22',-1,'user1','repositorio/imagen2');

select * from hashtag;
insert into hashtag (tag) values
('tag1'),
('tag2'),
('tag3'),
('tag4'),
('tag5'),
('tag6'),
('tag7');


select * from post_hashtag;

insert into post_hashtag (ref_image,tag) values
('repositorio/imagen1','tag1'),
('repositorio/imagen2','tag7'),
('repositorio/imagen2','tag4'),
('repositorio/imagen3','tag5'),
('repositorio/imagen6','tag1'),
('repositorio/imagen5','tag2'),
('repositorio/imagen1','tag2'),
('repositorio/imagen2','tag3');











