/* Lógico 2 versão: */
create database BD_PDV
use BD_PDV
CREATE TABLE MetodoDePagamento (
    idMPagamento INT PRIMARY KEY,
    pagamentoTipo VARCHAR(20)
);

CREATE TABLE Pagamento (
    PagValor FLOAT ,
    idPagamento INT PRIMARY KEY IDENTITY (1,1),
    idVenda INT,
    idMPagamento INT
);

CREATE TABLE Venda (
    idVenda INT PRIMARY KEY IDENTITY (1,1),
    vendData DATETIME,
    valorCompra FLOAT,
	idCaixa INT
);

CREATE TABLE ItensDaVenda (
    idItens INT PRIMARY KEY IDENTITY (1,1),
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
    dataCaixa DATE,
    estadoCaixa TINYINT
);
 
ALTER TABLE Pagamento ADD FOREIGN KEY(idMPagamento) REFERENCES MetodoDePagamento (idMPagamento)
ALTER TABLE Pagamento ADD FOREIGN KEY(idVenda) REFERENCES Venda (idVenda)
ALTER TABLE ItensDaVenda ADD FOREIGN KEY(idProduto) REFERENCES Produto (idProduto)
ALTER TABLE ItensDaVenda ADD FOREIGN KEY(idVenda) REFERENCES Venda (idVenda)
ALTER TABLE Venda ADD FOREIGN KEY (idCaixa) REFERENCES Caixa(idCaixa)

INSERT INTO MetodoDePagamento VALUES (1,'DINHEIRO')
INSERT INTO Caixa VALUES (200, 0, 0, '01/12/2019', 0)

INSERT INTO MetodoDePagamento VALUES (2,'CREDITO A VISTA')
INSERT INTO MetodoDePagamento VALUES (3,'CREDITO PARCELADO')
INSERT INTO MetodoDePagamento VALUES (4,'DEBITO')

DELETE FROM Venda

select * from ItensDaVenda

SELECT        Produto.prodNome, Produto.prodValor, Produto.prodCodBarras, ItensDaVenda.idVenda, ItensDaVenda.itensQtd, ItensDaVenda.ItensTotal, Venda.vendData, MetodoDePagamento.pagamentoTipo, Pagamento.PagValor
FROM            MetodoDePagamento INNER JOIN
                         Pagamento ON MetodoDePagamento.idMPagamento = Pagamento.idMPagamento INNER JOIN
                         Venda ON Pagamento.idVenda = Venda.idVenda INNER JOIN
                         ItensDaVenda INNER JOIN
                         Produto ON ItensDaVenda.idProduto = Produto.idProduto ON Venda.idVenda = ItensDaVenda.idVenda
WHERE Pagamento.idVenda = 172

SELECT        Produto.prodNome, Produto.prodValor, Produto.prodCodBarras, ItensDaVenda.itensQtd, ItensDaVenda.ItensTotal, Venda.vendData, MetodoDePagamento.pagamentoTipo, Pagamento.PagValor, Venda.idVenda
FROM            MetodoDePagamento INNER JOIN
                         Pagamento ON MetodoDePagamento.idMPagamento = Pagamento.idMPagamento INNER JOIN
                         Venda ON Pagamento.idVenda = Venda.idVenda INNER JOIN
                         ItensDaVenda INNER JOIN
                         Produto ON ItensDaVenda.idProduto = Produto.idProduto ON Venda.idVenda = ItensDaVenda.idVenda
WHERE        (Pagamento.idVenda = 172)

SELECT        Produto.prodNome, Produto.prodValor, Produto.prodCodBarras, ItensDaVenda.itensQtd, ItensDaVenda.ItensTotal, Venda.vendData, MetodoDePagamento.pagamentoTipo, Pagamento.PagValor, 
                         ItensDaVenda.idVenda AS idVenda
FROM            MetodoDePagamento INNER JOIN
                         Pagamento ON MetodoDePagamento.idMPagamento = Pagamento.idMPagamento INNER JOIN
                         Venda ON Pagamento.idVenda = Venda.idVenda INNER JOIN
                         ItensDaVenda INNER JOIN
                         Produto ON ItensDaVenda.idProduto = Produto.idProduto ON Venda.idVenda = ItensDaVenda.idVenda
WHERE        (ItensDaVenda.idVenda = 174)

select * from Caixa