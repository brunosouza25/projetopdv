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
    dataCaixa DATETIME,
    estadoCaixa TINYINT
);

CREATE TABLE ItensDeEntrada (
    idItensEntrada INT,
    idProduto INT,
    entradaEstado TINYINT,
    qntItem INT,
    dataEntrada DATETIME,
    observacoes VARCHAR(300)
);

CREATE TABLE ItensDeSaida (
    idItensSaida INT,
    idProduto INT,
    saidaEstado INT,
    qntItem INT,
    dataSaida DATETIME,
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
 
ALTER TABLE Pagamento ADD FOREIGN KEY(idMPagamento) REFERENCES MetodoDePagamento (idMPagamento)
ALTER TABLE Pagamento ADD FOREIGN KEY(idVenda) REFERENCES Venda (idVenda)
ALTER TABLE ItensDaVenda ADD FOREIGN KEY(idProduto) REFERENCES Produto (idProduto)
ALTER TABLE ItensDaVenda ADD FOREIGN KEY(idVenda) REFERENCES Venda (idVenda)
ALTER TABLE Venda ADD FOREIGN KEY (idCaixa) REFERENCES Caixa(idCaixa)
ALTER TABLE ItensDeEntrada ADD FOREIGN KEY (idProduto) REFERENCES Produto(idProduto)
ALTER TABLE ItensDeSaida ADD FOREIGN KEY (idProduto) REFERENCES Produto(idProduto)
ALTER TABLE Funcionario ADD FOREIGN KEY (idCargo) REFERENCES Cargo(idCargo)

INSERT INTO MetodoDePagamento VALUES (1,'DINHEIRO')
INSERT INTO Caixa VALUES (0, 0, 0, '01/12/2019', 0)

INSERT INTO MetodoDePagamento VALUES (2,'CREDITO A VISTA')
INSERT INTO MetodoDePagamento VALUES (3,'CREDITO PARCELADO')
INSERT INTO MetodoDePagamento VALUES (4,'DEBITO')

/*DELETE FROM Venda*/

select * from Pagamento

SELECT        MetodoDePagamento.pagamentoTipo, Pagamento.idVenda, Pagamento.PagValor
FROM            MetodoDePagamento INNER JOIN
                         Pagamento ON MetodoDePagamento.idMPagamento = Pagamento.idMPagamento INNER JOIN
                         Venda ON Pagamento.idVenda = Venda.idVenda
WHERE        (Pagamento.idVenda = 3)