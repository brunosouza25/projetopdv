CREATE TABLE cst(
	id INT,
	descricao VARCHAR(100)
)

INSERT INTO cst VALUES
(00, 'Tributada integralmente'),
(10, 'Tributada e com cobran�a do ICMS por substitui��o tribut�ria'),
(20, 'Com redu��o da BC'),
(30, 'Isenta / n�o tributada e com cobran�a do ICMS por substitui��o tribut�ria'),
(40, 'Isenta'),
(41, 'N�o tributada'),
(50, 'Com suspens�o'),
(51, 'Com deferimento'),
(60, 'ICMS cobrado anteriormente por substitui��o tribut�ria'),
(70, 'Com redu��o da BC e cobran�a do ICMS por substitui��o tribut�ria'),
(90, 'Outras');

