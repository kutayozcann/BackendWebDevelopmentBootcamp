--1
CREATE TABLE employee(
	id SERIAL PRIMARY KEY,
	name VARCHAR(50) NOT NULL,
	birthday DATE,
	email VARCHAR(100)
);

--2
insert into employee (name, birthday, email) values ('Thurstan', '1979-05-15', 'tshurville0@typepad.com');
insert into employee (name, birthday, email) values ('Doralyn', '2018-07-16', 'dcastelin1@qq.com');
insert into employee (name, birthday, email) values ('Allyn', '1950-03-01', 'amaccallester2@sciencedaily.com');
insert into employee (name, birthday, email) values ('Fara', '2019-03-08', 'fleither3@ucoz.ru');
insert into employee (name, birthday, email) values ('Neille', '1995-10-22', 'nlindelof4@wired.com');
insert into employee (name, birthday, email) values ('Wendi', '1984-08-11', 'whallas5@who.int');
insert into employee (name, birthday, email) values ('Hyacintha', '1963-05-17', 'hrau6@is.gd');
insert into employee (name, birthday, email) values ('Rusty', '1981-09-21', 'rdanes7@slate.com');
insert into employee (name, birthday, email) values ('Hill', null, 'hdavidovicz8@amazon.co.jp');
insert into employee (name, birthday, email) values ('Sydney', '1984-01-05', 'sblackey9@ezinearticles.com');
insert into employee (name, birthday, email) values ('Ebony', '1984-02-01', 'ewasielewicza@canalblog.com');
insert into employee (name, birthday, email) values ('Son', '1988-03-20', 'sschooleyb@reuters.com');
insert into employee (name, birthday, email) values ('Liam', '1973-05-29', 'lyashaevc@woothemes.com');
insert into employee (name, birthday, email) values ('Mendel', '2007-12-26', 'mlevetd@apache.org');
insert into employee (name, birthday, email) values ('Bunny', '1993-06-25', 'bhabgoode@npr.org');
insert into employee (name, birthday, email) values ('Shirlene', '2002-06-30', 'skendrewf@yelp.com');
insert into employee (name, birthday, email) values ('Johnathan', null, null);
insert into employee (name, birthday, email) values ('Giustina', '1974-09-12', 'gpeaurth@discovery.com');
insert into employee (name, birthday, email) values ('Faydra', '2013-03-22', 'fsimeneli@elpais.com');
insert into employee (name, birthday, email) values ('Kirsti', '2011-02-11', 'kroblouj@adobe.com');
insert into employee (name, birthday, email) values ('Gilberta', null, null);
insert into employee (name, birthday, email) values ('Thatcher', '1993-09-13', 'tkennallyl@blog.com');
insert into employee (name, birthday, email) values ('Crista', '1955-05-08', 'cmawmanm@examiner.com');
insert into employee (name, birthday, email) values ('Lorrayne', '1964-10-15', 'lzecchin@youtube.com');
insert into employee (name, birthday, email) values ('Bridgette', '1972-04-02', null);
insert into employee (name, birthday, email) values ('Asa', '2005-11-18', 'anuttingp@yale.edu');
insert into employee (name, birthday, email) values ('Averyl', '1978-04-30', 'agorlerq@nationalgeographic.com');
insert into employee (name, birthday, email) values ('Toddie', '1966-05-25', null);
insert into employee (name, birthday, email) values ('Suzy', '1955-08-15', 'shousecrafts@yellowpages.com');
insert into employee (name, birthday, email) values ('Franny', '1983-04-04', 'fwhaitest@last.fm');
insert into employee (name, birthday, email) values ('Delmor', null, 'detherseyu@nih.gov');
insert into employee (name, birthday, email) values ('Frankie', '1982-04-18', 'fgerrellv@vimeo.com');
insert into employee (name, birthday, email) values ('Sullivan', '1997-10-05', 'sdysonw@issuu.com');
insert into employee (name, birthday, email) values ('Raleigh', '2018-01-31', 'rpeetersx@zdnet.com');
insert into employee (name, birthday, email) values ('Catherin', '2016-09-27', 'ctwelvesy@webeden.co.uk');
insert into employee (name, birthday, email) values ('Shirl', '2000-12-19', null);
insert into employee (name, birthday, email) values ('Zak', '1961-05-27', null);
insert into employee (name, birthday, email) values ('Aigneis', '1989-02-28', 'ahamblyn11@github.io');
insert into employee (name, birthday, email) values ('Brigg', '2014-04-24', 'bharris12@slashdot.org');
insert into employee (name, birthday, email) values ('Drucill', '1958-11-10', null);
insert into employee (name, birthday, email) values ('Isabelle', '1999-09-06', 'icottee14@nyu.edu');
insert into employee (name, birthday, email) values ('Fulton', null, 'fpatillo15@ucla.edu');
insert into employee (name, birthday, email) values ('Spence', '2017-06-19', 'sbacks16@webs.com');
insert into employee (name, birthday, email) values ('Katrina', '1951-11-03', 'kkeppe17@seesaa.net');
insert into employee (name, birthday, email) values ('Conrade', '1955-11-19', 'cdearth18@sphinn.com');
insert into employee (name, birthday, email) values ('Melvin', '1976-07-19', null);
insert into employee (name, birthday, email) values ('Standford', '1982-10-17', 'sdelacoste1a@tmall.com');
insert into employee (name, birthday, email) values ('Giselle', '1989-03-17', null);
insert into employee (name, birthday, email) values ('Netti', '2002-10-07', null);
insert into employee (name, birthday, email) values ('Marissa', '1992-04-21', 'mkingman1d@ovh.net');

--3
UPDATE employee
SET name = 'UPDATE',
	birthday = NULL,
	email = 'UPDATE'
WHERE id IN(1,2,3,4,5);

--4
DELETE FROM employee
WHERE id IN(6,7,8,9,10);
