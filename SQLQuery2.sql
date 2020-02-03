
CREATE TABLE Config_Sistema(
	idConfig TINYINT,
	a_Bloquear TINYINT,
	bloqueado TINYINT,
	senha VARCHAR(20),
	dataUltimoBloqueio DATE
);
INSERT INTO Config_Sistema VALUES(1, null, 0, 'pontodevenda', '01/01/2020')

select * from Config_Sistema
