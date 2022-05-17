CREATE DATABASE Beneficiari1
use Beneficiari1



CREATE  TABLE Beneficiar
( ID int primary key not null,
  Nume char(50),
  Prenume char(50),
  Localitatea char(50),
  Mediu char(10),
  Email char(50),
  Telefon int,
  ID_Serviciu int,
  Serviciu char(50),
  ID_Produs int,
  Produs char(50),
  Pret money
  )
  SELECT Count(Mediu)
  From Beneficiar
  where Mediu='Urban'
  
 Select * From Beneficiar