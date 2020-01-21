/* Lógico 2 versão: */
drop DATABASE BD_PDV
create database BD_PDV
use BD_PDV

CREATE TABLE MetodoDePagamento (
    idMPagamento INT PRIMARY KEY,
    pagamentoTipo VARCHAR(20)
);

CREATE TABLE Pagamento (
    PagValor FLOAT ,
    idPagamento INT,
    idVenda INT,
    idMPagamento INT,
	valorDesconto FLOAT
);

CREATE TABLE Venda (
    idVenda INT PRIMARY KEY IDENTITY (1,1),
    vendData DATE,
	vendHora TIME,
    valorCompra FLOAT,
	idCaixa INT,
	observacoes VARCHAR(300),
	vendaEstado TINYINT
);

CREATE TABLE ItensDaVenda (
    idItens INT PRIMARY KEY IDENTITY (1,1),
    idVenda INT,
    idProduto INT,
    itensQtd INT,
    ItensTotal FLOAT,
	estadoDevolucao TINYINT,
	quantidadeRetirada INT,
	valorDeVenda FLOAT,
	valorDeCusto FLOAT,
	codBarras VARCHAR(13)
);

CREATE TABLE Produto (
    idProduto INT PRIMARY KEY IDENTITY (1,1),
    prodNome VARCHAR(50),
    prodValor FLOAT,
    prodCusto FLOAT,
    prodQuantidade INT,
    prodCodBarras VARCHAR(13),
	prodEstado tinyint
);

CREATE TABLE Caixa (
    idCaixa INT PRIMARY KEY IDENTITY (1,1),
    aberturaCaixa FLOAT,
    fechamentoCaixa FLOAT,
    valorAtual FLOAT,
    dataCaixa DATETIME,
    estadoCaixa TINYINT
);

CREATE TABLE ItensDeEntrada (
    /*idPrimarioItensEntrada INT PRIMARY KEY IDENTITY (1,1),*/
	idSecundarioItensEntrada INT,
    idProduto INT,
    entradaEstado TINYINT,
    qntItem INT,
    dataEntrada DATE,
	horaEntrada TIME,
    observacoes VARCHAR(300),
	/*itemEstado TINYINT,
	qntCancelado int*/
);

CREATE TABLE ItensDeSaida (
    /*idPrimarioItensSaida INT PRIMARY KEY IDENTITY (1,1),*/
    idSecundarioItensSaida INT,
	idProduto INT,
    saidaEstado INT,
    qntItem INT,
    dataSaida DATE,
	horaSaida TIME,
    observacoes VARCHAR(300),

);

CREATE TABLE Funcionario (
    idFuncionario INT PRIMARY KEY IDENTITY (1,1),
    idCargo INT,
    nomeFunc VARCHAR(54),
    dataNasc DATE,
    sexo TINYINT,
    login VARCHAR(54),
    senha VARCHAR(54),
    dataCriacao DATETIME,
    funcEstado TINYINT
);

CREATE TABLE Cargo (
    idCargo INT PRIMARY KEY IDENTITY (1,1),
    cargoNome VARCHAR(54),
    estadoCargo TINYINT
);


CREATE TABLE Observacoes_Saida_Prod (
	idSecundarioItensSaida INT,
    observacoes VARCHAR(300)
);

CREATE TABLE Observacoes_Venda (
    idVenda INT,
    observacoes VARCHAR(300)
);

CREATE TABLE Observacoes_Sangria (
    idCaixa INT,
    observacoes VARCHAR(300)
);

CREATE TABLE Observacoes_Entrada_Prod (
    idSecundarioItensEntrada INT,
    observacoes VARCHAR(300)
);

CREATE TABLE Itens_Devolucao (
    idItensDevolucao INT,
    idVenda INT,
    idProduto INT,
	quantidadeDevolucao INT,
    observacoes VARCHAR(300),
	dataDevolucao DATE,
	/*valorDevolucao FLOAT*/
);
 
 /*verificar sobre as fk
 CREATE TABLE Vale_Troca (
    idValeTroca INT PRIMARY KEY,
    idItensDevolucao INT,
    idProduto INT,
    valorValeTroca FLOAT
);*/

ALTER TABLE Pagamento ADD FOREIGN KEY(idMPagamento) REFERENCES MetodoDePagamento (idMPagamento)
ALTER TABLE Pagamento ADD FOREIGN KEY(idVenda) REFERENCES Venda (idVenda)
ALTER TABLE ItensDaVenda ADD FOREIGN KEY(idProduto) REFERENCES Produto (idProduto)
ALTER TABLE ItensDaVenda ADD FOREIGN KEY(idVenda) REFERENCES Venda (idVenda)
ALTER TABLE Venda ADD FOREIGN KEY (idCaixa) REFERENCES Caixa(idCaixa)
ALTER TABLE ItensDeEntrada ADD FOREIGN KEY (idProduto) REFERENCES Produto(idProduto)
ALTER TABLE ItensDeSaida ADD FOREIGN KEY (idProduto) REFERENCES Produto(idProduto)
ALTER TABLE Funcionario ADD FOREIGN KEY (idCargo) REFERENCES Cargo(idCargo)
ALTER TABLE Observacoes_Sangria ADD FOREIGN KEY (idCaixa) REFERENCES Caixa(idCaixa)
ALTER TABLE Itens_Devolucao ADD FOREIGN KEY (idVenda) REFERENCES Venda(idVenda)

INSERT INTO MetodoDePagamento VALUES (1,'DINHEIRO')
INSERT INTO Caixa VALUES (0, 0, 0, '01/12/2019', 0)

INSERT INTO MetodoDePagamento VALUES (2,'CREDITO A VISTA')
INSERT INTO MetodoDePagamento VALUES (3,'CREDITO PARCELADO')
INSERT INTO MetodoDePagamento VALUES (4,'DEBITO')

INSERT INTO ItensDeEntrada VALUES(0, null, 0, 0, null, null, 'primeira linha para retorno de 0')
INSERT INTO ItensDeSaida VALUES(0, null, 0, 0, null, null, 'primeira linha para retorno de 0')

INSERT INTO Itens_Devolucao VALUES(0, null, null, null, null, null)



select * from ItensDeEntrada

/*DELETE FROM Venda*/
/*
delete from Observacoes_Sangria
delete from Caixa
delete from Cargo
delete from Funcionario
delete from ItensDaVenda
delete from ItensDeEntrada
delete from ItensDeSaida
delete from MetodoDePagamento
delete from Pagamento
delete from produto
delete from Venda
*/

drop database BD_PDV

select * from ItensDeEntrada

SELECT        TOP (1) idPrimarioItensEntrada, idSecundarioItensEntrada,idProduto, entradaEstado, qntItem, dataEntrada, observacoes
FROM            ItensDeEntrada
ORDER BY idPrimarioItensEntrada DESC

SELECT dataEntrada, entradaEstado, idPrimarioItensEntrada, idProduto, idSecundarioItensEntrada, observacoes, qntItem 
FROM ItensDeEntrada
WHERE (idSecundarioItensEntrada = 1)





SELECT idSecundarioItensEntrada, dataEntrada
FROM            ItensDeEntrada
group by idSecundarioItensEntrada, dataEntrada
having SUM(idSecundarioItensEntrada) > 0


SELECT idSecundarioItensEntrada, dataEntrada
FROM            ItensDeEntrada
WHERE dataEntrada between '05-01-2020' and '05-01-2020'
group by idSecundarioItensEntrada, dataEntrada
having SUM(idSecundarioItensEntrada) > 0

select * from ItensDeEntrada
where idSecundarioItensEntrada = 5

select * from Pagamento


select * from Produto

SELECT dataEntrada, entradaEstado, horaEntrada, idProduto, idSecundarioItensEntrada, observacoes, qntItem 
FROM ItensDeEntrada 
WHERE (dataEntrada BETWEEN @dataPesquisa1 AND @dataPesquisa2) GROUP BY idSecundarioItensEntrada, dataEntrada 
HAVING (SUM(idSecundarioItensEntrada) > 0)

select * from ItensDeEntrada



select * from ItensDeEntrada

SELECT dataSaida, idSecundarioItensSaida
FROM ItensDeSaida
WHERE (dataSaida BETWEEN '07/01/2020' AND '07/01/2020') 
GROUP BY idSecundarioItensSaida, dataSaida
HAVING (SUM(idSecundarioItensSaida) > 0)

SELECT idProduto, prodNome, prodValor, prodCusto, prodQuantidade, prodCodBarras, prodEstado FROM Produto
WHERE prodNome like '%Blusa%'

select * from Venda

SELECT idVenda, vendData, valorCompra FROM dbo.Venda
WHERE idVenda like '%'+1+'%'


select* from ItensDaVenda

select * from Caixa

select * from Itens_Devolucao


SELECT TOP (1) idItensDevolucao, idProduto, idVenda, quantidadeDevolucao FROM Itens_Devolucao ORDER BY idItensDevolucao

SELECT        MetodoDePagamento.pagamentoTipo, Pagamento.idVenda AS Expr1, Venda.valorCompra, Venda.vendData, Venda.idCaixa, Venda.vendaEstado, Venda.observacoes AS Expr2, Pagamento.PagValor, Pagamento.idPagamento, 
                         Pagamento.idMPagamento, Pagamento.valorDesconto, Venda.vendHora
FROM            Venda INNER JOIN
                         Pagamento ON Venda.idVenda = Pagamento.idVenda INNER JOIN
                         MetodoDePagamento ON Pagamento.idMPagamento = MetodoDePagamento.idMPagamento
						 where pagamentoTipo = @pagamentoTipo and vendData = between @vendData1 and @vendData2
