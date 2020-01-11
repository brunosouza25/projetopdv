/* Lógico 2 versão: */
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
    vendData DATETIME,
    valorCompra FLOAT,
	idCaixa INT,
	observacoes VARCHAR(300),
	vendaEstado TINYINT
);

CREATE TABLE ItensDaVenda (
    /*idItens INT PRIMARY KEY IDENTITY (1,1),*/
    idVenda INT,
    idProduto INT,
    itensQtd INT,
    ItensTotal FLOAT
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
    observacoes VARCHAR(300)
);

CREATE TABLE ItensDeSaida (
    /*idPrimarioItensSaida INT PRIMARY KEY IDENTITY (1,1),*/
    idSecundarioItensSaida INT,
	idProduto INT,
    saidaEstado INT,
    qntItem INT,
    dataSaida DATE,
	horaSaida TIME,
    observacoes VARCHAR(300)
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
 
 
ALTER TABLE Pagamento ADD FOREIGN KEY(idMPagamento) REFERENCES MetodoDePagamento (idMPagamento)
ALTER TABLE Pagamento ADD FOREIGN KEY(idVenda) REFERENCES Venda (idVenda)
ALTER TABLE ItensDaVenda ADD FOREIGN KEY(idProduto) REFERENCES Produto (idProduto)
ALTER TABLE ItensDaVenda ADD FOREIGN KEY(idVenda) REFERENCES Venda (idVenda)
ALTER TABLE Venda ADD FOREIGN KEY (idCaixa) REFERENCES Caixa(idCaixa)
ALTER TABLE ItensDeEntrada ADD FOREIGN KEY (idProduto) REFERENCES Produto(idProduto)
ALTER TABLE ItensDeSaida ADD FOREIGN KEY (idProduto) REFERENCES Produto(idProduto)
ALTER TABLE Funcionario ADD FOREIGN KEY (idCargo) REFERENCES Cargo(idCargo)
ALTER TABLE Observacoes_Sangria ADD FOREIGN KEY (idCaixa) REFERENCES Caixa(idCaixa)


INSERT INTO MetodoDePagamento VALUES (1,'DINHEIRO')
INSERT INTO Caixa VALUES (0, 0, 0, '01/12/2019', 0)

INSERT INTO MetodoDePagamento VALUES (2,'CREDITO A VISTA')
INSERT INTO MetodoDePagamento VALUES (3,'CREDITO PARCELADO')
INSERT INTO MetodoDePagamento VALUES (4,'DEBITO')

INSERT INTO ItensDeEntrada VALUES(0, null, 0, 0, null, null, 'primeira linha para retorno de 0')
INSERT INTO ItensDeSaida VALUES(0, null, 0, 0, null, null, 'primeira linha para retorno de 0')

/*DELETE FROM Venda*/
/*
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

INSERT INTO ItensDeSaida
                         (idSecundarioItensSaida ,qntItem, dataSaida, horaSaida,idProduto, observacoes, saidaEstado)
VALUES        (2, 15 ,'07/01/2020', '19:42',1, '', 1)

select * from ItensDeEntrada

SELECT dataSaida, idSecundarioItensSaida
FROM ItensDeSaida
WHERE (dataSaida BETWEEN '07/01/2020' AND '07/01/2020') 
GROUP BY idSecundarioItensSaida, dataSaida
HAVING (SUM(idSecundarioItensSaida) > 0)

SELECT idProduto, prodNome, prodValor, prodCusto, prodQuantidade, prodCodBarras, prodEstado FROM Produto
WHERE prodNome like '%Blusa%'

select * from Pagamento

SELECT idVenda, vendData, valorCompra FROM dbo.Venda
WHERE idVenda like '%'+1+'%'


select* from Venda

select * from Caixa

select * from Venda