-- Criação da tabela
CREATE TABLE [dbo].[Clientes](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Nome] [varchar](255) NULL,
	[Sobrenome] [varchar](255) NULL,
	[Email] [varchar](255) NULL,
	[AceitaComunicados] [bit] NULL,
	[DataCadastro] [datetime2](7) NULL
) ON [PRIMARY]
GO

-- Inserção de dados
INSERT INTO Clientes VALUES ('Ken','Sánchez','email@email.com',0,'Jan  7 2009 12:00AM')
INSERT INTO Clientes VALUES ('Terri','Duffy','email@email.com',1,'Jan 24 2008 12:00AM')
INSERT INTO Clientes VALUES ('Gigi','Matthew','email@email.com',0,'Jan  9 2009 12:00AM')
INSERT INTO Clientes VALUES ('Sharon','Salavaria','email@email.com',2,'Jan 11 2011 12:00AM')
INSERT INTO Clientes VALUES ('John','Wood','email@email.com',2,'Jan 31 2011 12:00AM')
INSERT INTO Clientes VALUES ('Mary','Gibson','email@email.com',0,'Jan  5 2009 12:00AM')
INSERT INTO Clientes VALUES ('Jill','Williams','email@email.com',0,'Jan 11 2009 12:00AM')
INSERT INTO Clientes VALUES ('James','Hamilton','email@email.com',0,'Jan 27 2009 12:00AM')

INSERT INTO Clientes VALUES ('Dylan','Miller','email@email.com',2,'Fev  1 2009 12:00AM')
INSERT INTO Clientes VALUES ('Mary','Dempsey','email@email.com',1,'Fev  7 2011 12:00AM')
INSERT INTO Clientes VALUES ('Terry','Eminhizer','email@email.com',2,'Fev 23 2009 12:00AM')
INSERT INTO Clientes VALUES ('Suchitra','Mohan','email@email.com',2,'Fev  9 2009 12:00AM')
INSERT INTO Clientes VALUES ('Brandon','Heidepriem','email@email.com',1,'Fev  1 2009 12:00AM')
INSERT INTO Clientes VALUES ('Jose','Lugo','email@email.com',2,'Fev  3 2009 12:00AM')
INSERT INTO Clientes VALUES ('Chris','Okelberry','email@email.com',0,'Fev 28 2009 12:00AM')
INSERT INTO Clientes VALUES ('Jo','Brown','email@email.com',0,'Fev 20 2008 12:00AM')

INSERT INTO Clientes VALUES ('Diane','Glimp','email@email.com',2,'Mar 21 2008 12:00AM')
INSERT INTO Clientes VALUES ('Tom','Vande Velde','email@email.com',0,'Mar  3 2010 12:00AM')
INSERT INTO Clientes VALUES ('Mike','Seamans','email@email.com',2,'Mar  1 2009 12:00AM')
INSERT INTO Clientes VALUES ('Syed','Abbas','email@email.com',0,'Mar  7 2013 12:00AM')
INSERT INTO Clientes VALUES ('Michelle','Alexander','email@email.com',2,'Mar 30 2013 12:00AM')
INSERT INTO Clientes VALUES ('Richard','Bentley','email@email.com',0,'Mar 30 2013 12:00AM')
INSERT INTO Clientes VALUES ('Dorothy','Robinson','email@email.com',2,'Mar  6 2012 12:00AM')
INSERT INTO Clientes VALUES ('Scott','Rodgers','email@email.com',0,'Mar 17 2012 12:00AM')

INSERT INTO Clientes VALUES ('Gustavo','Achong','email@email.com',2,'Abr 15 2015  4:33PM')
INSERT INTO Clientes VALUES ('Catherine','Abel','email@email.com',1,'Abr 15 2015  4:33PM')
INSERT INTO Clientes VALUES ('Kim','Abercrombie','email@email.com',0,'Abr 15 2015  4:33PM')
INSERT INTO Clientes VALUES ('Humberto','Acevedo','email@email.com',2,'Abr 15 2015  4:33PM')
INSERT INTO Clientes VALUES ('Pilar','Ackerman','email@email.com',0,'Abr 15 2015  4:33PM')
INSERT INTO Clientes VALUES ('Frances','Adams','email@email.com',1,'Abr 15 2015  4:33PM')
INSERT INTO Clientes VALUES ('Margaret','Smith','email@email.com',0,'Abr 15 2015  4:33PM')
INSERT INTO Clientes VALUES ('Carla','Adams','email@email.com',0,'Abr 15 2015  4:33PM')

INSERT INTO Clientes VALUES ('Carolee','Brown','email@email.com',0,'Mai 30 2013 12:00AM')
INSERT INTO Clientes VALUES ('Robert','Brown','email@email.com',0,'Mai 30 2013 12:00AM')
INSERT INTO Clientes VALUES ('John','Brooks','email@email.com',0,'Mai 30 2012 12:00AM')
INSERT INTO Clientes VALUES ('Dave','Browning','email@email.com',0,'Mai 30 2012 12:00AM')
INSERT INTO Clientes VALUES ('Bridget','Browqett','email@email.com',1,'Mai 30 2013 12:00AM')
INSERT INTO Clientes VALUES ('Eric','Brumfield','email@email.com',0,'Mai 31 2011 12:00AM')
INSERT INTO Clientes VALUES ('Edward','Buensalido','email@email.com',0,'Mai 30 2012 12:00AM')
INSERT INTO Clientes VALUES ('Megan','Burke','email@email.com',2,'Mai 30 2012 12:00AM')

INSERT INTO Clientes VALUES ('Gregory','Alderson','email@email.com',0,'Jun 30 2012 12:00AM')
INSERT INTO Clientes VALUES ('James','Aguilar','email@email.com',1,'Jun 30 2013 12:00AM')
INSERT INTO Clientes VALUES ('Sean','Jacobson','email@email.com',2,'Jun 30 2013 12:00AM')
INSERT INTO Clientes VALUES ('Mae','Anderson','email@email.com',0,'Jun 30 2013 12:00AM')
INSERT INTO Clientes VALUES ('Ramona','Antrim','email@email.com',0,'Jun 30 2013 12:00AM')
INSERT INTO Clientes VALUES ('Hannah','Arakawa','email@email.com',0,'Jun 30 2013 12:00AM')
INSERT INTO Clientes VALUES ('Chris','Ashton','email@email.com',1,'Jun 30 2013 12:00AM')
INSERT INTO Clientes VALUES ('John','Ault','email@email.com',0,'Jun 30 2013 12:00AM')

INSERT INTO Clientes VALUES ('June','Brunner','email@email.com',0,'Jul 31 2012 12:00AM')
INSERT INTO Clientes VALUES ('Janaina Barreiro Gambaro','Bueno','email@email.com',1,'Jul 31 2013 12:00AM')
INSERT INTO Clientes VALUES ('Ingrid','Burkhardt','email@email.com',0,'Jul  1 2011 12:00AM')
INSERT INTO Clientes VALUES ('Ovidiu','Burlacu','email@email.com',0,'Jul 31 2012 12:00AM')
INSERT INTO Clientes VALUES ('Dana','Burnell','email@email.com',0,'Jul 31 2013 12:00AM')
INSERT INTO Clientes VALUES ('Corinna','Bolender','email@email.com',0,'Jul 31 2013 12:00AM')
INSERT INTO Clientes VALUES ('Luis','Bonifaz','email@email.com',2,'Jul 31 2012 12:00AM')
INSERT INTO Clientes VALUES ('Randall','Boseman','email@email.com',2,'Jul 31 2012 12:00AM')

INSERT INTO Clientes VALUES ('Aidan','Delaney','email@email.com',0,'Ago  1 2011 12:00AM')
INSERT INTO Clientes VALUES ('Prashanth','Desai','email@email.com',2,'Ago  1 2011 12:00AM')
INSERT INTO Clientes VALUES ('Brenda','Diaz','email@email.com',0,'Ago  1 2011 12:00AM')
INSERT INTO Clientes VALUES ('Gabriele','Dickmann','email@email.com',0,'Ago  1 2011 12:00AM')
INSERT INTO Clientes VALUES ('Rudolph','Dillon','email@email.com',0,'Ago  1 2011 12:00AM')
INSERT INTO Clientes VALUES ('Andrew','Dixon','email@email.com',0,'Ago  1 2011 12:00AM')
INSERT INTO Clientes VALUES ('Gary','Drury','email@email.com',1,'Ago  1 2011 12:00AM')
INSERT INTO Clientes VALUES ('Reuben','Dsa','email@email.com',0,'Ago  1 2011 12:00AM')

INSERT INTO Clientes VALUES ('Thomas','Michaels','email@email.com',2,'Set 30 2012 12:00AM')
INSERT INTO Clientes VALUES ('JoSeth','Matthews','email@email.com',0,'Set 30 2012 12:00AM')
INSERT INTO Clientes VALUES ('James','Fine','email@email.com',0,'Set 30 2013 12:00AM')
INSERT INTO Clientes VALUES ('David','Campbell','email@email.com',2,'Set 30 2012 12:00AM')
INSERT INTO Clientes VALUES ('Sylvia','Caldwell','email@email.com',1,'Set 30 2012 12:00AM')
INSERT INTO Clientes VALUES ('Jun','Cao','email@email.com',0,'Set 30 2012 12:00AM')
INSERT INTO Clientes VALUES ('Chris','Maxwell','email@email.com',0,'Set 30 2012 12:00AM')
INSERT INTO Clientes VALUES ('Carol Ann','Rockne','email@email.com',0,'Set 26 2011 12:00AM')

INSERT INTO Clientes VALUES ('Payton','Benson','email@email.com',0,'Out  1 2011 12:00AM')
INSERT INTO Clientes VALUES ('Max','Benson','email@email.com',0,'Out  1 2011 12:00AM')
INSERT INTO Clientes VALUES ('Alan','Brewer','email@email.com',1,'Out  1 2011 12:00AM')
INSERT INTO Clientes VALUES ('Connie','Coffman','email@email.com',0,'Out  1 2011 12:00AM')
INSERT INTO Clientes VALUES ('Jeanette','Cole','email@email.com',2,'Out 31 2011 12:00AM')
INSERT INTO Clientes VALUES ('Scott','Colvin','email@email.com',2,'Out 31 2011 12:00AM')
INSERT INTO Clientes VALUES ('Christopher','Bright','email@email.com',0,'Out  1 2011 12:00AM')
INSERT INTO Clientes VALUES ('Willie','Brooks','email@email.com',2,'Out  1 2011 12:00AM')

INSERT INTO Clientes VALUES ('Roberto','Tamburello','email@email.com',0,'Nov  4 2007 12:00AM')
INSERT INTO Clientes VALUES ('Rob','Walters','email@email.com',0,'Nov 28 2007 12:00AM')
INSERT INTO Clientes VALUES ('Ovidiu','Cracium','email@email.com',0,'Nov 28 2010 12:00AM')
INSERT INTO Clientes VALUES ('Peter','Krebs','email@email.com',0,'Nov 24 2008 12:00AM')
INSERT INTO Clientes VALUES ('Barry','Johnson','email@email.com',0,'Nov 29 2013 12:00AM')
INSERT INTO Clientes VALUES ('Kendall','Keil','email@email.com',2,'Nov 28 2008 12:00AM')
INSERT INTO Clientes VALUES ('Charles','Fitzgerald','email@email.com',2,'Nov 26 2009 12:00AM')
INSERT INTO Clientes VALUES ('Steven','Selikoff','email@email.com',2,'Nov 24 2008 12:00AM')

INSERT INTO Clientes VALUES ('Gail','Erickson','email@email.com',0,'Dez 30 2007 12:00AM')
INSERT INTO Clientes VALUES ('Jossef','Goldberg','email@email.com',0,'Dez 16 2013 12:00AM')
INSERT INTO Clientes VALUES ('Diane','Margheim','email@email.com',0,'Dez 22 2008 12:00AM')
INSERT INTO Clientes VALUES ('Thierry','DHers','email@email.com',2,'Dez  4 2007 12:00AM')
INSERT INTO Clientes VALUES ('Janice','Galvin','email@email.com',2,'Dez 16 2010 12:00AM')
INSERT INTO Clientes VALUES ('Michael','Sullivan','email@email.com',2,'Dez 23 2010 12:00AM')
INSERT INTO Clientes VALUES ('David','Bradley','email@email.com',1,'Dez 13 2007 12:00AM')
INSERT INTO Clientes VALUES ('Wanida','Benshoof','email@email.com',2,'Dez 31 2010 12:00AM')