/* Lógico 2 versão: */
create database BD_PDV
use BD_PDV
CREATE TABLE MetodoDePagamento (
    idMPagamento INT PRIMARY KEY,
    pagamentoTipo VARCHAR(20)
);

CREATE TABLE Pagamento (
    PagValor FLOAT,
    idPagamento INT PRIMARY KEY IDENTITY(1,1),
    idVenda INT,
    idMPagamento INT
);

CREATE TABLE Venda (
    idVenda INT PRIMARY KEY IDENTITY(1,1),
    vendData DATE,
    valorCompra FLOAT
);

CREATE TABLE ItensDaVenda (
    idItens INT PRIMARY KEY IDENTITY(1,1),
    idVenda INT,
    idProduto INT,
    itensQtd INT,
    ItensTotal FLOAT
);

CREATE TABLE Produto (
    idProduto INT PRIMARY KEY IDENTITY(1,1),
    prodNome VARCHAR(50),
    prodValor FLOAT,
    prodCusto FLOAT,
    prodQuantidade INT,
    prodCodBarras VARCHAR(13)
);
 
ALTER TABLE Pagamento ADD FOREIGN KEY(idMPagamento) REFERENCES MetodoDePagamento (idMPagamento)
ALTER TABLE Pagamento ADD FOREIGN KEY(idVenda) REFERENCES Venda (idVenda)
ALTER TABLE ItensDaVenda ADD FOREIGN KEY(idProduto) REFERENCES Produto (idProduto)
ALTER TABLE ItensDaVenda ADD FOREIGN KEY(idVenda) REFERENCES Venda (idVenda)

select * from Venda

SELECT prodQuantidade 
FROM Produto
WHERE  (idProduto = 1)

drop database BD_PDV

insert into MetodoDePagamento VALUES (1, 'DINHEIRO')

select * from Pagamento

select * from MetodoDePagamento