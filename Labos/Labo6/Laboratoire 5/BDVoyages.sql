-- ===========================================================================
-- cette base de données est tirée du document Développeur 2000 Forms 5.0 de Jean-Yves Papillon
-- fichier : DBVoyages.sql				
--  projet : Agence de voyage Tototour
-- ==-----------------------------------------------------------------------==
--  
--==-----------------------------------------------------------------------==
--   Script de création de la base de données de l'agence de voyage
--   table créées :
--    client, employe, hotel, voyage, contrat, faitLeVoyage
--
-- ==-----------------------------------------------------------------------==


-- remplacer BDVoyages par le nom de votre base de données
use BDVoyagesMarrero  

Print  'Création de la base de données de l''agence de voyage Tototour.'
print  'Dernière modification, 16 août 2019.'
print ''
Print  'destruction des tables...'
DROP TABLE faitLeVoyage;
DROP TABLE voyage;
DROP TABLE contrat;
DROP TABLE hotel;
DROP TABLE employe;
DROP TABLE client;


print 'Création des tables ========================================================'
print ''
Print  'Création de la TABLE client...' 
CREATE TABLE client (
   cliNo		NUMERIC(6) ,
   cliPrenom		VARCHAR(20),
   cliNom		VARCHAR(15),
   cliRue		VARCHAR(30),
   cliVille		VARCHAR(12) DEFAULT 'Totoville',
   cliTelephone	CHAR(12),
   CONSTRAINT pk_client  PRIMARY KEY(cliNo)
   );

print 'Création de la TABLE employe...'
CREATE TABLE employe (
  empNo			NUMERIC(4),
  empPrenom		VARCHAR(20),
  empNom		VARCHAR(15),
  empEmploi		CHAR(2),   
  empSal		NUMERIC(5,2),
  empComm		NUMERIC(3,3),
  empSup		NUMERIC(4),
  empBureau		CHAR(3),    
 CONSTRAINT pk_employe PRIMARY KEY(empNo),
 CONSTRAINT check_empEmploi CHECK  (empEmploi IN('DI', 'GR', 'VD', 'SC', 'AN')),
 CONSTRAINT check_empBureau CHECK (empBureau IN ('stf', 'lév', 'bpt'))
  );

Print  'Création de la TABLE hotel...'
CREATE TABLE hotel (
  hotNo			NUMERIC(5),  
  hotNom		CHAR(25),
  hotCote		NUMERIC(1), 
  hotPiscine		CHAR(1),   
  hotNbChambreTot 	NUMERIC(3),
  CONSTRAINT pk_hotel PRIMARY KEY(hotNo),
  CONSTRAINT check_hotCote CHECK (hotCote BETWEEN 1 AND 5),
  CONSTRAINT check_hotPiscine CHECK (hotPiscine IN ('A','E','I')),
  );

Print  'Création de la TABLE voyage...'
CREATE TABLE voyage (
  voyNo				NUMERIC(4),  
  voyDestination 		CHAR(20),
  voyDateDepart			DATETIME,
  voyDateArrive			DATETIME,
  voyRepas			NUMERIC(1),
  voyNbPlace        		NUMERIC(3),
  voyActivite 			CHAR(76),
  empNo             		NUMERIC(4), 
  hotno				NUMERIC(5),
  tarifSimple			NUMERIC(6,2),
  tarifDouble			NUMERIC(6,2),
  tarifTriple			NUMERIC(6,2),
  tarifQuadruple    		NUMERIC(6,2),
  NbChambreRes      		NUMERIC(3),
  CONSTRAINT pk_voyage PRIMARY KEY(voyNo),
  CONSTRAINT check_voyRepas CHECK (voyRepas IN(0,1,2)),
  CONSTRAINT fk_animateur FOREIGN KEY(empNo) references employe(empNo),
  CONSTRAINT fk_inclus FOREIGN KEY(hotno) references  hotel(hotNo)
);

Print  'Création de la TABLE contrat...'
CREATE TABLE contrat (
 conNo			NUMERIC(6),    
 conDate        	DATETIME,
 conAcompte     	NUMERIC(6,2),
 conMontant     	NUMERIC(6,2),
 ConPaye       		NUMERIC(6,2) DEFAULT 0,
 conTypeOcc     	NUMERIC(1), 
 empNo			NUMERIC(4),
 voyNo 			NUMERIC(4),
 cliNo 			NUMERIC(6)
 CONSTRAINT pk_contrat PRIMARY KEY(conNo),
 CONSTRAINT check_contypeoc CHECK (conTypeOcc IN (1,2,3,4)),
 CONSTRAINT fk_vendeur FOREIGN KEY( empNo)  REFERENCES employe(empNo),
 CONSTRAINT fk_choixVoyage FOREIGN KEY(voyNo) REFERENCES voyage(voyNo),
 CONSTRAINT fk_clientPayeur FOREIGN KEY(cliNo) REFERENCES client(cliNo)
);


print  'Création de la TABLE faitleVoyage...'
CREATE TABLE faitLeVoyage(
  conNo   NUMERIC(6),
  cliNo   NUMERIC(6),
  CONSTRAINT pk_faitLeVoyage PRIMARY KEY(conNo, cliNo),
  CONSTRAINT fk_faitVoyageContrat FOREIGN KEY(conNo) REFERENCES contrat(conNo),
  CONSTRAINT fk_faitVoyageClient FOREIGN KEY(cliNo) REFERENCES client(cliNo)
 );



                                                                                  

		