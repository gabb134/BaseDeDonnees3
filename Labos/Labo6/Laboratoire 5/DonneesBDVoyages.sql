
use BDVoyagesMarrero
print  'Insertion des données d''essai============================================='
 
print 'Insertion des rangées dans le table Client...'
INSERT INTO client  VALUES 
(123005,'Ned','Triton',        '345 Rue Bolindigo',       'TotoVille',   '418-778-2835');
INSERT INTO client  VALUES 
(123006,'Wallace','Sefresti',        '123 Rue Beausite',       'TotoVille',   '514-764-0987');
INSERT INTO client  VALUES 
(123007,'Gromit','Sefresti',        '123 Rue Beausite',       'TotoVille',   '450-764-0987'); 
INSERT INTO client  VALUES 
(123008,'Molton','Sefresti',        '123 Rue Beausite',       'TotoVille',   '514-764-0987'); 
INSERT INTO client  VALUES 
(123009,'Achille','Talon',           '67 Rue de la virgule',   'TataVille',   '514-876-0987');
INSERT INTO client  VALUES 
(123010,'Obelix','Le Gaulois',        '78 Rue Cervoise',       'TotoVille',   '819-956-4753');
INSERT INTO client  VALUES 
(123011,'Hagar','L''horrible',        '23 Av. Brun',       'Charlesbourg',   '418-750-9678'); 
INSERT INTO client  VALUES  
(123012,'Charlie','Brown',           '123 Rue Beausite',       'TotoVille',   '514-764-0987'); 
INSERT INTO client  VALUES 
(123013,'Lucien','Tetebeche',        '55 rue principale',       'TotoVille',   '514-957-0945');  
INSERT INTO client  VALUES 
(123014,'Arthur','Laroche',          '456 Rue rock',       'TataVille',   '450-756-7564');  
INSERT INTO client  VALUES 
(123015,'Délima','Cailloux',        '454 Rue Rock',       'TataVille',   '450-756-7984'); 
INSERT INTO client  VALUES 
(123016,'Bertha','Laroche',        '456 Rue Rock',       'TataVille',  
 '514-756-7564');
INSERT INTO client  VALUES 
(123017,'Poncho','Sanchez',        '123 av du moulin ',       'Sainte-foy',   '418-776-0685');
INSERT INTO client  VALUES 
(123018,'Gaston','Lagaffe',        '13  Rue du gag',       'TotoVille',   '450-857-0987');
INSERT INTO client  VALUES 
(123019,'Bianca','Castafiore',        '7586 Rue Voiclair',       'TotoVille',   '819-567-2030');
INSERT INTO client  VALUES 
(123020,'Capitaine','Hadock',        '12 Rue Moulinsar',       'TotoVille',   '819-786-0945');
INSERT INTO client  VALUES 
(123021,'Red','Ketchup',        '57 Rue Heintz',       'TataVille', 
  '450-884-2299');
INSERT INTO client  VALUES 
(123022,'Bart','Simpson',        '678 Rue Springfield',       'TotoVille',   '418-747-2293');
INSERT INTO client  VALUES 
(123023,'Homer','Simpson',        '678 Rue Springfield',       'TotoVille',   '747-2293');  
INSERT INTO client  VALUES 
(123024,'Fred','Cailloux',        '5 chemin du rock',       'TotoVille',   '514-987-4545');
INSERT INTO client  VALUES 
(123025,'Toto','Lebeau',        '123 Rue Beausite',       'TotoVille',   '418-764-0987');
INSERT INTO client  VALUES 
(123026,'Onesime','Lebeau',        '123 Rue Beausite',       'TotoVille',   '514-764-0987');
INSERT INTO client  VALUES 
(123027,'Titi','Lebeau',        '123 Rue Beausite',       'TotoVille',   '819-764-0987');
INSERT INTO client  VALUES 
(123028,'Retro','Vitiro',        '44 Rue imaginaire',       'TotoVille',   '450-776-7745');
INSERT INTO client  VALUES 
(123029,'Bodormir','Vitiro',        '44 Rue imaginaire',       'TotoVille',   '514-776-7745');
INSERT INTO client  VALUES 
(123999,'Extrèmeeeeeeeeeeeeee',   'Maximummmmmmmmm'   ,  '9876 avenue  des Plus Gros',       
'Charlesbourg',   '999-999-9999');
  


print ' insertion des rangées dans la table employe...'
insert into employe values 
(1001, 'toto', 'Lebeau',      'DI', 777.00,NULL,NULL,'stf');
insert into employe values
(1002, 'France', 'Bedard',      'SC', 14.75,NULL,1001,'bpt');
insert into employe values
(1003, 'Jean', 'Sergio',      'VD', 8.50,0.025,1011,'lév');
insert into employe values
(1004, 'Martin', 'Cochon',      'GR', 18.25,NULL,1001,'stf');
insert into employe values
(1005, 'Martine', 'Lachance',      'VD', 8.50,0.028, 1004,'stf');
insert into employe values
(1006, 'Claude', 'Coté',      'VD', 9.75,0.020,1004,'stf');
insert into employe values
(1007, 'Lise', 'Lavoie',      'VD', 8.75,0.022,1011,'lév');
insert into employe values
(1008, 'Marc', 'Bodormir',      'AN', 125.00,NULL,1002,'bpt');
insert into employe values
(1009, 'Marcel', 'Lebeau',      'SC', 12.75,NULL,1011,'bpt');
insert into employe values
(1010, 'Paul', 'Côté',      'AN', 145.00 ,NULL,1002,'stf');
insert into employe values
(1011, 'Angélique', 'Lavoie',      'GR', 18.25,NULL,1001,'lév');
insert into employe values
(1012, 'Angèle', 'Vitiro',      'AN', 125.00,NULL,1002,'lév');
insert into employe values
(1013, 'Virgule', 'DeGuillemets',      'AN', 115.00,NULL,1002,'stf');
insert into employe values
(1014, 'Ti', 'Bout',      'AN', 115.00,NULL,1002,'lév');



print ' insertion de rangées dans la table hotel...'
INSERT INTO hotel VALUES (22001,  'Ritz, Boston',		5, 'I', 224);
INSERT INTO hotel VALUES (22002,  'Voyageur, Montréal',		3, 'E', 45);
INSERT INTO hotel VALUES (22003,  'Days INN, Boston',		3, 'A', 62);
INSERT INTO hotel VALUES (22004,  'Cocorico, Toronto',		4, 'E', 165);
INSERT INTO hotel VALUES (22005,  'Gouverneur, Tadoussac',	3, 'E', 64);
INSERT INTO hotel VALUES (22006,  'Maison Dufour, Tadoussac',   2, 'E', 53);
INSERT INTO hotel VALUES (22007,  'Universel, Montréal',     	3, 'A', 65);
INSERT INTO hotel VALUES (22008,  'Delta, Montréal',		1, 'I', 155);
INSERT INTO hotel VALUES (22009,  'Delta, Boston',		2, 'I', 130);
INSERT INTO hotel VALUES (22010,  'Delta, Toronto',		3, 'E', 216);
INSERT INTO hotel VALUES (22011,  'Bonaventure, Montréal',	2, 'A', 202);



set DATEFORMAT dmy;

GO
DECLARE @dateRef DATETIME;
SET @dateRef = '23/6/2019';

--SELECT @dateRef AS DateRef;


Print  'insertion de rangées dans la table voyage...'

INSERT INTO voyage VALUES
  (3001, 'Boston', @dateRef-80, @dateRef-76, 1, 34,
   'visite au musée de l''informatique, musée du Boston thea party',
   1008, 22001, 1279, 999, 875, 689, 15);
INSERT INTO voyage VALUES
  (3002, 'Montréal', @dateRef+24, @dateRef+25, 2, 46,
   'Match du dynamo, entrée à la ronde',
   1010, 22002, 115, 105, 99, 95, 16);
INSERT INTO voyage VALUES
  (3003, 'Boston', @dateRef+45, @dateRef+50, 1, 34,
   'visite du Vieux-Boston et des musées',
   1008, 22003, 1179, 975, 839, 699, 16);
INSERT INTO voyage VALUES
  (3004, 'Tadoussac', @dateRef+30, @dateRef+32, 2, 6,
   'excursion aux baleines, plongée sous-marine',
   1012, 22005, 399, 349, 329, 319, 2);
INSERT INTO voyage VALUES
  (3005, 'Tadoussac', @dateRef-11, @dateRef, 2, 6,
   'excursion aux baleine, plongée sous-marine',
   1012, 22006, 389, 339, 319, 299, 2);
INSERT INTO voyage VALUES
  (3006, 'Montréal', @dateRef-15, @dateRef-12, 1, 6,
   'Match de Hockey et visite du centre Molson',
   1014, 22007, 199, 149, 129, 109, 2);
INSERT INTO voyage VALUES
  (3007, 'Montréal', @dateRef-20, @dateRef-18, 1, 6,
   'Match de Hockey et visite du centre Molson',
   1014, 22007, 199, 149, 129, 109, 2);
INSERT INTO voyage VALUES
  (3008, 'Boston', @dateRef-16, @dateRef, 2, 6,
   'Match de Hockey et visite du garden',
   1014, 22009, 229, 199, 179, 145, 2);
INSERT INTO voyage VALUES
  (3009, 'Boston', @dateRef-17,@dateRef, 2, 6,
   'Visite des musées et Vieux-Boston',
   1013, 22009, 1529, 1399, 1199, 1089, 2);
INSERT INTO voyage VALUES
  (3010, 'Toronto', @dateRef+50, @dateRef+56, 2, 6,
   'Visite du quartier chinois et tour CN',
   1013, 22010, 2109, 1999, 1799, 1450, 2);

go

set DATEFORMAT dmy;
go
DECLARE @dateRef DATETIME;
SET @dateRef = '23/6/2019';
print  'insertion de rangées dans la table contrat...'

INSERT INTO contrat VALUES
  (444001, @dateRef-50,  200.00,  1140.58,  200.00, 3, 1006, 3004, 123006);
INSERT INTO contrat VALUES
  (444002, @dateRef-42,  100.00,  725.95,   625.95, 2, 1003, 3004, 123016);
INSERT INTO contrat VALUES
  (444003, @dateRef-42,  300.00, 2028.08, 1300.00, 2, 1003, 3003, 123016);
INSERT INTO contrat VALUES
  (444004, @dateRef-28,   50.00,  343.21,   50.00, 3, 1005, 3002, 123015);
INSERT INTO contrat VALUES
  (444005, @dateRef-30,   20.00,  132.90,   20.00, 1, 1003, 3002, 123009);
INSERT INTO contrat VALUES
  (444006, @dateRef-131,  500.00, 3184.84, 3184.84, 4, 1007, 3001, 123005);
INSERT INTO contrat VALUES
  (444007, @dateRef-120, 350.00, 2308.89, 1850.00, 2, 1006, 3001, 123009);
INSERT INTO contrat VALUES
  (444008, @dateRef-47,  117.00,  779.70,  179.70, 2, 1006, 3005, 123999);
INSERT INTO contrat VALUES
  (444009, @dateRef-80,  165.00, 1100.00, 100.00, 3, 1006, 3005, 123009);
INSERT INTO contrat VALUES
  (444010, @dateRef-209,  50.00,  342.70,  200.00, 2, 1005, 3006, 123021);
INSERT INTO contrat VALUES
  (444011, @dateRef-178,  75.00,  501.40,  201.40, 4, 1003, 3006, 123024);
INSERT INTO contrat VALUES
  (444012, @dateRef-178,  50.00,  342.70,  142.70, 2, 1005, 3007, 123024);
INSERT INTO contrat VALUES
  (444013, @dateRef-193, 342.70,  342.70,  00.0, 2, 1007, 3007, 123007);
INSERT INTO contrat VALUES
  (444018, @dateRef-195,  50.00,  342.70,  142.70, 2, 1003, 3007, 123009);
INSERT INTO contrat VALUES
  (444014, @dateRef-231, 100.00,  667.00,  567.00, 4, 1006, 3008, 123027);
INSERT INTO contrat VALUES
  (444015, @dateRef-95,  300.00, 1758.35, 758.35, 1, 1006, 3009, 123009);
INSERT INTO contrat VALUES
  (444016, @dateRef-52,  450.00, 3000.00, 2800.00, 2, 1003, 3009, 123020);
INSERT INTO contrat VALUES
  (444017, @dateRef-172, 363.80, 2425.35,  363.80, 1, 1006, 3010, 123028);
go

print 'insertion de rangées dans la table faitLeVoyage...'
INSERT INTO faitLeVoyage VALUES (444001, 123006);
INSERT INTO faitLeVoyage VALUES (444001, 123007);
INSERT INTO faitLeVoyage VALUES (444001, 123008);

INSERT INTO faitLeVoyage VALUES (444002, 123016);
INSERT INTO faitLeVoyage VALUES (444002, 123014);

INSERT INTO faitLeVoyage VALUES (444003, 123016);
INSERT INTO faitLeVoyage VALUES (444003, 123015);

INSERT INTO faitLeVoyage VALUES (444004, 123006);
INSERT INTO faitLeVoyage VALUES (444004, 123007);
INSERT INTO faitLeVoyage VALUES (444004, 123017);

INSERT INTO faitLeVoyage VALUES (444005, 123009);

INSERT INTO faitLeVoyage VALUES (444006, 123005);
INSERT INTO faitLeVoyage VALUES (444006, 123010);
INSERT INTO faitLeVoyage VALUES (444006, 123011);
INSERT INTO faitLeVoyage VALUES (444006, 123012);

INSERT INTO faitLeVoyage VALUES (444007, 123009);
INSERT INTO faitLeVoyage VALUES (444007, 123013);

INSERT INTO faitLeVoyage VALUES (444008, 123999);
INSERT INTO faitLeVoyage VALUES (444008, 123029);

INSERT INTO faitLeVoyage VALUES (444009, 123006);
INSERT INTO faitLeVoyage VALUES (444009, 123007);
INSERT INTO faitLeVoyage VALUES (444009, 123008);

INSERT INTO faitLeVoyage VALUES (444010, 123021);
INSERT INTO faitLeVoyage VALUES (444010, 123013);

INSERT INTO faitLeVoyage VALUES (444011, 123024);
INSERT INTO faitLeVoyage VALUES (444011, 123014);
INSERT INTO faitLeVoyage VALUES (444011, 123015);
INSERT INTO faitLeVoyage VALUES (444011, 123016);

INSERT INTO faitLeVoyage VALUES (444012, 123024);
INSERT INTO faitLeVoyage VALUES (444012, 123015);

INSERT INTO faitLeVoyage VALUES (444013, 123006);
INSERT INTO faitLeVoyage VALUES (444013, 123008);

INSERT INTO faitLeVoyage VALUES (444018, 123009);
INSERT INTO faitLeVoyage VALUES (444018, 123022);

INSERT INTO faitLeVoyage VALUES (444014, 123027);
INSERT INTO faitLeVoyage VALUES (444014, 123026);
INSERT INTO faitLeVoyage VALUES (444014, 123023);
INSERT INTO faitLeVoyage VALUES (444014, 123025);

INSERT INTO faitLeVoyage VALUES (444015, 123009);

INSERT INTO faitLeVoyage VALUES (444016, 123020);
INSERT INTO faitLeVoyage VALUES (444016, 123019);

INSERT INTO faitLeVoyage VALUES (444017, 123028);



