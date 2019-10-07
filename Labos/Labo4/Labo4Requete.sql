use BDVoyagesMarrero


select conNo from employe e inner join contrat c on e.empNo = c.empNo where empNom = 'Sergio' and empPrenom = 'Jean'

select * from  employe


SELECT        voyage.voyNo, voyage.voyDateDepart, voyage.voyDateArrive, employe.empPrenom +' '+ employe.empNom as 'Animateur', voyage.voyDestination, hotel.hotNom
FROM            employe INNER JOIN
                         voyage ON employe.empNo = voyage.empNo INNER JOIN
                         hotel ON voyage.hotno = hotel.hotNo