/* Lógico 2 versão: */


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
	valorPago FLOAT,
	idCaixa INT,
	observacoes VARCHAR(300),
	vendaEstado TINYINT,
	idColaborador INT
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
	prodEstado tinyint,
	prodFiscal BIT,
	pPis FLOAT,
	pCofins FLOAT
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
    log_in VARCHAR(54),
    senha VARCHAR(54),
	email varchar(64),
    dataCriacao DATE,
	horaCriacao TIME,
    funcEstado TINYINT,
	idConta_Banc TINYINT,
	idEndereco TINYINT,
);


CREATE TABLE Cargo (
    idCargo INT PRIMARY KEY IDENTITY (0,1),
    cargoNome VARCHAR(54),
    estadoCargo BIT,
	adm BIT
);


CREATE TABLE Permissoes_Vendas(
	lancar_vendas BIT,
	cancelar_vendas BIT,
	sangria BIT,
	devolucoes BIT,
	idCargo INT
)

CREATE TABLE Permissoes_Estoque(
	criacao_produtos BIT,
	editar_produtos BIT,
	entrada_produtos BIT,
	saida_produtos BIT,
	idCargo INT
)

CREATE TABLE Observacoes_Saida_Prod (
	idSecundarioItensSaida INT,
    observacoes VARCHAR(300)
);

CREATE TABLE Observacoes_Venda (
    idVenda INT,
    observacoes VARCHAR(300)
);

CREATE TABLE Observacoes_Sangria (
	idSangria INT PRIMARY KEY IDENTITY (1,1),
    idCaixa INT,
    observacoes VARCHAR(300),
	dataSangria DATE,
	horaSangria TIME,
	idColaborador INT
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
	valorProduto FLOAT
);

CREATE TABLE Vendas_Canceladas(
	idVendaCancelada INT PRIMARY KEY IDENTITY (1,1),
	idVenda INT,
	dataVenda DATE,
	dataCancelamento DATE,
	horaCancelamento TIME,
	valorDaVenda FLOAT,
);

CREATE TABLE Config_Sistema(
	idConfig TINYINT,
	a_Bloquear TINYINT,
	bloqueado TINYINT,
	senha VARCHAR(20),
	dataUltimoBloqueio DATE,
	cnpjEmpresa VARCHAR(14),
	inscricaoEstadual VARCHAR(12),
	cnpjSoftwareHouse VARCHAR(14),
	senhaSat varchar(32),
	assinaturaAC VARCHAR(344)

);

CREATE TABLE Endereco(
	idFuncionario INT,
	endereco VARCHAR(120),
	bairro VARCHAR(120),
	numero INT
);

CREATE TABLE Conta_Bancaria(
	idFuncionario INT,
	banco VARCHAR(120),
	agencia int,
	conta int
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
ALTER TABLE Itens_Devolucao ADD FOREIGN KEY (idVenda) REFERENCES Venda(idVenda)
ALTER TABLE Vendas_Canceladas ADD FOREIGN KEY (idVenda) REFERENCES Venda(idVenda)
ALTER TABLE Permissoes_Vendas ADD FOREIGN KEY (idCargo) REFERENCES Cargo(idCargo)
ALTER TABLE Permissoes_Estoque ADD FOREIGN KEY (idCargo) REFERENCES Cargo(idCargo)

INSERT INTO MetodoDePagamento VALUES (1,'DINHEIRO')
INSERT INTO Caixa VALUES (0, 0, 250, '01/12/2019', 0)

INSERT INTO MetodoDePagamento VALUES (2,'CREDITO A VISTA')
INSERT INTO MetodoDePagamento VALUES (3,'CREDITO PARCELADO')
INSERT INTO MetodoDePagamento VALUES (4,'DEBITO')

INSERT INTO ItensDeEntrada VALUES(0, null, 0, 0, null, null, 'primeira linha para retorno de 0')
INSERT INTO ItensDeSaida VALUES(0, null, 0, 0, null, null, 'primeira linha para retorno de 0')

INSERT INTO Itens_Devolucao VALUES(0, null, null, null, null, null,null)


INSERT INTO Config_Sistema VALUES(1, null, 0, 'pontodevenda', '01/01/2020', '11111111111111','111111111111', '11111111111111','12345678','KjsdhfkjshfjkahufisjsdhfkjshfjkahufisjsdhfkjshfjkahufisjsdhfkjshfjkahufisjsdhfkjshfjkahufisjsdhfkjshfjkahufisKjsdhfkjshfjkahufisjsdhfkjshfjkahufisjsdhfkjshfjkahufisjsdhfkjshfjkahufisjsdhfkjshfjkahufisjsdhfkjshfjkahufisKjsdhfkjshfjkahufisjsdhfkjshfjkahufisjsdhfkjshfjkahufisjsdhfkjshfjkahufisjsdhfkjshfjkahufisjsdhfkjshfjkahufisasdasdasdasdasdsa')


INSERT INTO Cargo VALUES ('Nenhum', 0,0)
INSERT INTO Cargo VALUES ('adm', 1,1)
insert into Funcionario values(1,'bruno','1111/11/11','1','bruno','1','sdasdasda','2020/06/04','23:23:00' , 1, null, null)
insert into Funcionario values(1,'Cybele','1111/11/11','1','Cybele','1','sdasdasda','2020/06/04','23:23:00' , 1, null, null)


insert into Permissoes_Estoque values (1,1,1,1,1)
insert into Permissoes_Vendas values (1,1,1,1,1)
