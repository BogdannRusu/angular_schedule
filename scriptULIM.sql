CREATE DATABASE schedule_ulim;
  USE schedule_ulim

CREATE TABLE profesori(
  id_prof int AUTO_INCREMENT,
  nume varchar(100) NOT NULL,
  prenume varchar(100) NOT NULL,
  patronimic varchar(100),
  data_activarii date NOT NULL,
  end_data_activarii date,
  is_active tinyint NOT NULL,
  PRIMARY KEY (id_prof)
);

CREATE TABLE grupe(
  id_grupa int AUTO_INCREMENT,
  nume_grupa varchar(50) NOT NULL,
  is_active tinyint NOT NULL,
  PRIMARY KEY(id_grupa)
  );

CREATE TABLE cabinete(
  id_cabinet int AUTO_INCREMENT,
  nr_cabinet int NOT NULL,
  is_active tinyint NOT NULL,
  PRIMARY KEY (id_cabinet)
  );

CREATE TABLE links(
  id_link int AUTO_INCREMENT,
  id_profesor int NOT NULL,
  id_grupa int NOT NULL,
  id_cabinet int NOT NULL,
  PRIMARY KEY(id_link),
  FOREIGN KEY(id_profesor) REFERENCES profesori(id_prof),
  FOREIGN KEY(id_grupa) REFERENCES grupe(id_grupa),
  FOREIGN KEY(id_cabinet) REFERENCES cabinete(id_cabinet)
  );

SELECT * FROM profesori p;
SELECT * FROM grupe g;
SELECT * FROM cabinete c;

  ALTER TABLE profesori
    ADD COLUMN functia varchar(100) NOT NULL;

   ALTER TABLE grupe
     ADD COLUMN anul int NOT NULL;


