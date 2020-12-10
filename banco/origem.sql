CREATE TABLE origem(
	id INT,
	descricao VARCHAR(100)
)

INSERT INTO origem 	VALUES
(0, 'Nacional, exceto as indicadas nos códigos 3, 4, 5 e 8'),
(1, 'Estrangeira - Importação direta, exceto a indicada no código 6'),
(2, 'Estrangeira - Adquirida no mercado interno, exceto a indicada no código 7'),
(3, 'Nacional, mercadoria ou bem com Conteúdo de Importação superior a 40% (quarenta por cento) e inferior ou igual a 70% (setenta por cento)'),
(4, 'Nacional, cuja produção tenha sido feita em conformidade com os processos produtivos básicos de que tratam o Decreto-Lei n° 288/67, e as Leis n°s 8.248/91, 8.387/91, 10.176/01 e 11.484/07'),
(5, 'Nacional, mercadoria ou bem com Conteúdo de Importação inferior ou igual a 40% (quarenta por cento)'),
(6, 'Estrangeira - Importação direta, sem similar nacional, constante em lista de Resolução CAMEX e gás natural'),
(7, 'Estrangeira - Adquirida no mercado interno, sem similar nacional, constante em lista de Resolução CAMEX e gás natura'),
(8, 'Nacional, mercadoria ou bem com Conteúdo de Importação superior a 70% (setenta por cento)')



