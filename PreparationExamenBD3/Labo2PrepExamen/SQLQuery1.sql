use BDVoyagesMarrero


SELECT        contrat.conNo AS 'Numéro contrat', contrat.conDate AS 'Date contrat', contrat.conMontant AS 'Montant contrat', employe.empPrenom+' '+ employe.empNom AS 'Nom de l''employe'
FROM            employe INNER JOIN
                         contrat ON employe.empNo = contrat.empNo


						 SELECT empNo, empPrenom, empNom, empEmploi, empBureau  FROMemploye WHERE empNom  LIKE  '%'  + @nom +  '%' 