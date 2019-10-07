use BDVoyagesMarrero

SELECT        empNo, empNom +', ' +empPrenom as 'Nom complet'
FROM            employe
order by empNom,empPrenom

select convert(varchar,voyNo) +' ('+convert(varchar,trim(voyDestination))+')'  as 'Nom et Destination' from voyage order by voyDestination,voyNo


select cliNom+', '+cliPrenom from client order by cliNom,cliPrenom