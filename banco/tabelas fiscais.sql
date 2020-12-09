create table Pis_Cofins(
	id INT,
	descricao VARCHAR(150)
)

INSERT INTO Pis_Cofins VALUES
(01,'Opera��o Tribut�vel com Al�quota B�sica'),
(02,'Opera��o Tribut�vel com Al�quota Diferenciada'),
(03,'Opera��o Tribut�vel com Al�quota por Unidade de Medida de Produto'),
(04,'Opera��o Tribut�vel Monof�sica � Revenda a Al�quota Zero'),
(05,'Opera��o Tribut�vel por Substitui��o Tribut�ria'),
(06,'Opera��o Tribut�vel a Al�quota Zero'),
(07,'Opera��o Isenta da Contribui��o'),
(08,'Opera��o sem Incid�ncia da Contribui��o'),
(09,'Opera��o com Suspens�o da Contribui��o'),
(49, 'Outras Opera��es de Sa�da'),
(50, 'Opera��o com Direito a Cr�dito � Vinculada Exclusivamente a Receita Tributada no Mercado Interno'),
(51, 'Opera��o com Direito a Cr�dito � Vinculada Exclusivamente a Receita N�o-Tributada no Mercado Interno'),
(52, 'Opera��o com Direito a Cr�dito � Vinculada Exclusivamente a Receita de Exporta��o'),
(53, 'Opera��o com Direito a Cr�dito � Vinculada a Receitas Tributadas e N�o-Tributadas no Mercado Interno'),
(54, 'Opera��o com Direito a Cr�dito � Vinculada a Receitas Tributadas no Mercado Interno e de Exporta��o'),
(55, 'Opera��o com Direito a Cr�dito � Vinculada a Receitas N�o Tributadas no Mercado Interno e de Exporta��o'),
(56, 'Opera��o com Direito a Cr�dito � Vinculada a Receitas Tributadas e N�o-Tributadas no Mercado Interno e de Exporta��o'),
(60, 'Cr�dito Presumido � Opera��o de Aquisi��o Vinculada Exclusivamente a Receita Tributada no Mercado Interno'),
(61, 'Cr�dito Presumido � Opera��o de Aquisi��o Vinculada Exclusivamente a Receita N�o-Tributada no Mercado Interno'),
(62, 'Cr�dito Presumido � Opera��o de Aquisi��o Vinculada Exclusivamente a Receita de Exporta��o'),
(63, 'Cr�dito Presumido � Opera��o de Aquisi��o Vinculada a Receitas Tributadas e N�o-Tributadas no Mercado Interno'),
(64, 'Cr�dito Presumido � Opera��o de Aquisi��o Vinculada a Receitas Tributadas no Mercado Interno e de Exporta��o'),
(65, 'Cr�dito Presumido � Opera��o de Aquisi��o Vinculada a Receitas N�o-Tributadas no Mercado Interno e de Exporta��o'),
(66, 'Cr�dito Presumido � Opera��o de Aquisi��o Vinculada a Receitas Tributadas e N�o-Tributadas no Mercado Interno e de Exporta��o'),
(67, 'Cr�dito Presumido � Outras Opera��es'),
(70, 'Opera��o de Aquisi��o sem Direito a Cr�dito'),
(71, 'Opera��o de Aquisi��o com Isen��o'),
(72, 'Opera��o de Aquisi��o com Suspens�o'),
(73, 'Opera��o de Aquisi��o a Al�quota Zero'),
(74, 'Opera��o de Aquisi��o sem Incid�ncia da Contribui��o'),
(75, 'Opera��o de Aquisi��o por Substitui��o Tribut�ria'),
(98, 'Outras Opera��es de Entrada'),
(99, 'Outras Opera��es');


CREATE TABLE icms(
	id INT,
	descricao VARCHAR(100)

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
(90, 'Outras')





CREATE TABLE origem(
	id INT,
	descricao VARCHAR(100)
)

INSERT INTO origem 	VALUES
(0, 'Nacional, exceto as indicadas nos c�digos 3, 4, 5 e 8'),
(1, 'Estrangeira - Importa��o direta, exceto a indicada no c�digo 6'),
(2, 'Estrangeira - Adquirida no mercado interno, exceto a indicada no c�digo 7'),
(3, 'Nacional, mercadoria ou bem com Conte�do de Importa��o superior a 40% (quarenta por cento) e inferior ou igual a 70% (setenta por cento)'),
(4, 'Nacional, cuja produ��o tenha sido feita em conformidade com os processos produtivos b�sicos de que tratam o Decreto-Lei n� 288/67, e as Leis n�s 8.248/91, 8.387/91, 10.176/01 e 11.484/07'),
(5, 'Nacional, mercadoria ou bem com Conte�do de Importa��o inferior ou igual a 40% (quarenta por cento)'),
(6, 'Estrangeira - Importa��o direta, sem similar nacional, constante em lista de Resolu��o CAMEX e g�s natural'),
(7, 'Estrangeira - Adquirida no mercado interno, sem similar nacional, constante em lista de Resolu��o CAMEX e g�s natura'),
(8, 'Nacional, mercadoria ou bem com Conte�do de Importa��o superior a 70% (setenta por cento)')



