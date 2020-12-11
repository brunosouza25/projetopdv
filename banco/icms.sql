CREATE TABLE icms(
	id INT,
	descricao VARCHAR(80)

)

INSERT INTO icms VALUES
(00, 'Tributada integralmente'),
(10, 'Tributada e com cobran�a do ICMS por substitui��o tribut�ria'),
(20, 'Com redu��o de base de c�lculo'),
(30, 'Isenta ou n�o tributada e com cobran�a do ICMS por substitui��o tribut�ria'),
(40, 'Isenta'),
(41, 'N�o tributada'),
(50, 'Suspen��o'),
(51, 'Diferimento'),
(60, 'ICMS cobrado anteriormente por substitui��o tribut�ria'),
(70, 'Com redu��o de base de c�lculo e cobran�a do ICMS por substitui��o tribut�ria'),
(90, 'Outras');