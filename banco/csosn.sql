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
