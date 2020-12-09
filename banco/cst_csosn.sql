CREATE TABLE csosn(
  id INT
  descricao varchar(128),
)

INSERT INTO csosn VALUES
(101, 'Tributada pelo Simples Nacional com permissão de crédito'),
(102, 'Tributada pelo Simples Nacional sem permissão de crédito'),
(103, 'Isenção do ICMS no Simples Nacional para faixa de receita bruta'),
(201, 'Tributada pelo Simples Nacional com permissão de crédito e com cobrança do ICMS
por substituição tributária'),
(202, 'Tributada pelo Simples Nacional sem permissão de crédito e com cobrança do ICMS
por substituição tributária'),
(203, 'Isenção do ICMS no Simples Nacional para faixa de receita bruta e com cobrança do
ICMS por substituição tributária'),
(300, 'Imune'),
(400, 'Não tributada pelo Simples Nacional'),
(500, 'ICMS cobrado anteriormente por substituição tributária (substituído) ou por
antecipação'),
(900, 'Outros');

CREATE TABLE cst(
	id INT,
	descricao VARCHAR(100)
)

INSERT INTO cst VALUES
(00, 'Tributada integralmente'),
(10, 'Tributada e com cobrança do ICMS por substituição tributária'),
(20, 'Com redução da BC'),
(30, 'Isenta / não tributada e com cobrança do ICMS por substituição tributária'),
(40, 'Isenta'),
(41, 'Não tributada'),
(50, 'Com suspensão'),
(51, 'Com deferimento'),
(60, 'ICMS cobrado anteriormente por substituição tributária'),
(70, 'Com redução da BC e cobrança do ICMS por substituição tributária'),
(90, 'Outras');

