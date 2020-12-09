create table Pis_Cofins(
	id INT,
	descricao VARCHAR(150)
)

INSERT INTO Pis_Cofins VALUES
(01,'Operação Tributável com Alíquota Básica'),
(02,'Operação Tributável com Alíquota Diferenciada'),
(03,'Operação Tributável com Alíquota por Unidade de Medida de Produto'),
(04,'Operação Tributável Monofásica – Revenda a Alíquota Zero'),
(05,'Operação Tributável por Substituição Tributária'),
(06,'Operação Tributável a Alíquota Zero'),
(07,'Operação Isenta da Contribuição'),
(08,'Operação sem Incidência da Contribuição'),
(09,'Operação com Suspensão da Contribuição'),
(49, 'Outras Operações de Saída'),
(50, 'Operação com Direito a Crédito – Vinculada Exclusivamente a Receita Tributada no Mercado Interno'),
(51, 'Operação com Direito a Crédito – Vinculada Exclusivamente a Receita Não-Tributada no Mercado Interno'),
(52, 'Operação com Direito a Crédito – Vinculada Exclusivamente a Receita de Exportação'),
(53, 'Operação com Direito a Crédito – Vinculada a Receitas Tributadas e Não-Tributadas no Mercado Interno'),
(54, 'Operação com Direito a Crédito – Vinculada a Receitas Tributadas no Mercado Interno e de Exportação'),
(55, 'Operação com Direito a Crédito – Vinculada a Receitas Não Tributadas no Mercado Interno e de Exportação'),
(56, 'Operação com Direito a Crédito – Vinculada a Receitas Tributadas e Não-Tributadas no Mercado Interno e de Exportação'),
(60, 'Crédito Presumido – Operação de Aquisição Vinculada Exclusivamente a Receita Tributada no Mercado Interno'),
(61, 'Crédito Presumido – Operação de Aquisição Vinculada Exclusivamente a Receita Não-Tributada no Mercado Interno'),
(62, 'Crédito Presumido – Operação de Aquisição Vinculada Exclusivamente a Receita de Exportação'),
(63, 'Crédito Presumido – Operação de Aquisição Vinculada a Receitas Tributadas e Não-Tributadas no Mercado Interno'),
(64, 'Crédito Presumido – Operação de Aquisição Vinculada a Receitas Tributadas no Mercado Interno e de Exportação'),
(65, 'Crédito Presumido – Operação de Aquisição Vinculada a Receitas Não-Tributadas no Mercado Interno e de Exportação'),
(66, 'Crédito Presumido – Operação de Aquisição Vinculada a Receitas Tributadas e Não-Tributadas no Mercado Interno e de Exportação'),
(67, 'Crédito Presumido – Outras Operações'),
(70, 'Operação de Aquisição sem Direito a Crédito'),
(71, 'Operação de Aquisição com Isenção'),
(72, 'Operação de Aquisição com Suspensão'),
(73, 'Operação de Aquisição a Alíquota Zero'),
(74, 'Operação de Aquisição sem Incidência da Contribuição'),
(75, 'Operação de Aquisição por Substituição Tributária'),
(98, 'Outras Operações de Entrada'),
(99, 'Outras Operações');


CREATE TABLE icms(
	id INT,
	descricao VARCHAR(100)

)

INSERT INTO icms VALUES
(00, 'Tributada integralmente'),
(10, 'Tributada e com cobrança do ICMS por substituição tributária'),
(20, 'Com redução de base de cálculo'),
(30, 'Isenta ou não tributada e com cobrança do ICMS por substituição tributária'),
(40, 'Isenta'),
(41, 'Não tributada'),
(50, 'Suspenção'),
(51, 'Diferimento'),
(60, 'ICMS cobrado anteriormente por substituição tributária'),
(70, 'Com redução de base de cálculo e cobrança do ICMS por substituição tributária'),
(90, 'Outras')





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



