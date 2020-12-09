CREATE TABLE csosn(
  id INT
  descricao varchar(128),
)

INSERT INTO csosn VALUES
(101, 'Tributada pelo Simples Nacional com permiss�o de cr�dito'),
(102, 'Tributada pelo Simples Nacional sem permiss�o de cr�dito'),
(103, 'Isen��o do ICMS no Simples Nacional para faixa de receita bruta'),
(201, 'Tributada pelo Simples Nacional com permiss�o de cr�dito e com cobran�a do ICMS
por substitui��o tribut�ria'),
(202, 'Tributada pelo Simples Nacional sem permiss�o de cr�dito e com cobran�a do ICMS
por substitui��o tribut�ria'),
(203, 'Isen��o do ICMS no Simples Nacional para faixa de receita bruta e com cobran�a do
ICMS por substitui��o tribut�ria'),
(300, 'Imune'),
(400, 'N�o tributada pelo Simples Nacional'),
(500, 'ICMS cobrado anteriormente por substitui��o tribut�ria (substitu�do) ou por
antecipa��o'),
(900, 'Outros');

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

