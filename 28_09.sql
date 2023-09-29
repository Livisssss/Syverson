CREATE DATABASE FERRAGEM2
GO

USE FERRAGEM2
GO

CREATE TABLE Cidades (
	id_cidade INT IDENTITY(1,1),
	nome NVARCHAR(50) NOT NULL,
	uf NVARCHAR(2) NOT NULL,
	CONSTRAINT PK_CIDADES PRIMARY KEY (id_cidade)
	);
GO

INSERT INTO Cidades (nome, uf)
VALUES ('Erechim', 'RS'),
		('Campinas do Sul', 'RS'),
		('Jacutinga', 'RS'),
		('Concórdia', 'SC'),
		('Florianópolis', 'SC'),
		('Palhoça', 'SC'),
		('Chapecó', 'SC'),
		('Sananduva', 'RS'),
		('Xanxerê', 'SC'),
		('Curitiba', 'PR'),
		('Pinhalzinho', 'SC'),
		('Campinas', 'SP'),
		('Porto Alegre', 'RS'),
		('Caxias do Sul', 'RS'),
		('Lajeado', 'RS'),
		('Blumenau', 'SC'),
		('Joinville', 'SC'),
		('Itajaí', 'SC'),
		('Lages', 'SC'),
		('Pato Branco', 'PR'),
		('Maringá', 'PR'),
		('Cascavel', 'PR'),
		('Foz do Iguaçu', 'PR'),
		('Criciúma', 'SC'),
		('São Joaquim', 'SC'),
		('Ponta Grossa', 'PR'),
		('Guarapuava', 'PR'),
		('Londrina', 'PR');
GO
--INSERT INTO Cidades (nome, uf)
--VALUES ('Campinas', 'SP');

CREATE TABLE Usuarios (
	nome_user NVARCHAR(50) UNIQUE NOT NULL,
	senha_user NVARCHAR(50) NOT NULL,
	data_modificacao DATETIME CONSTRAINT DF_MODIFICUSUARIOS DEFAULT GETDATE(),
	data_criacao DATETIME  CONSTRAINT DF_DATACRIACUSUARIOS DEFAULT GETDATE(),
	CONSTRAINT PK_USUARIOS PRIMARY KEY (nome_user)
	);
GO

INSERT INTO Usuarios (nome_user, senha_user)
VALUES  ('syverson', 'sy'),
		('1', '1');
GO


CREATE TABLE Produtos (
	id_produto INT IDENTITY(1,1),
	nome NVARCHAR(50) UNIQUE NOT NULL,
	descricao NVARCHAR(175),
	custo_medio DECIMAL(10, 2),
	data_modificacao DATETIME CONSTRAINT DF_MODIFICPRODUTOS DEFAULT GETDATE(),
	CONSTRAINT PK_PRODUTOS PRIMARY KEY (id_produto)
	);
GO

INSERT INTO Produtos (nome, descricao)
VALUES  ('Jogo de chaves',	'Possui 12 unidades'),
		('Furadeira', 'Acompanha 3 brocas de tamanhos diferentes'),
	    ('Cerrote', 'Tipo 2');
GO

CREATE TABLE Clientes (
	id_cliente INT IDENTITY(1,1),
	nome NVARCHAR(100) NOT NULL,
	data_nascimento DATE NOT NULL CONSTRAINT DF_DATANASC DEFAULT GETDATE(),
	idade INT,
	data_modificacao DATETIME CONSTRAINT DF_DATAMODIFICCLIENTES DEFAULT GETDATE(),
	cpf NVARCHAR(14) NOT NULL UNIQUE DEFAULT '000.000.000-00',
	email NVARCHAR(100) NOT NULL,
	telefone NVARCHAR(15) NOT NULL,
	id_cidade INT NOT NULL,
	CONSTRAINT PK_CLIENTES PRIMARY KEY (id_cliente),
	CONSTRAINT FK_CLIENTES_CIDADES FOREIGN KEY (id_cidade) REFERENCES Cidades(id_cidade)
	ON DELETE CASCADE
	);
GO

INSERT INTO Clientes (nome, data_nascimento, idade, cpf, email, telefone, ID_Cidade)
VALUES  ('Joao Victor',	'1979/12/08',	39, '251.365.456-85', 'jv@gmail.com', '(49) 98634-9034', 9),
		('Samuel',		'1998/03/11',	30, '112.233.432-11', 'samuca@gmail.com', '(49) 98448-5613', 5),
		('Manuel',	'2000/6/12',	19, '368.111.325-55', 'manikas@gmail.com', '(54) 99191-5283', 1),
		('Jair',	'2011/02/08',	 8, '112.123.444-12', 'comanjairb@gmail.com', '(49) 92468-3700', 8),
		('Marcelo',	'2002/03/04',	17, '124.663.876-85', 'marcelao@gmail.com', '(49) 95481-1898', 7);
GO


CREATE TABLE Fornecedores (
	id_fornecedor INT IDENTITY(1,1),
	nome NVARCHAR(100) NOT NULL,
	ie NVARCHAR(15) UNIQUE NOT NULL,
	cnpj NVARCHAR(18) UNIQUE NOT NULL,
	email NVARCHAR(100) NOT NULL,
	telefone NVARCHAR(15) NOT NULL,
	id_cidade INT NOT NULL,
	data_modificacao DATETIME CONSTRAINT DF_DATAMODIFICFORNECEDORES DEFAULT GETDATE(),
	CONSTRAINT PK_FORNECEDORES PRIMARY KEY (id_fornecedor),
	CONSTRAINT FK_FORNECEDORES_CIDADES FOREIGN KEY (id_cidade) REFERENCES Cidades(id_cidade)
	ON DELETE CASCADE
	);
GO

INSERT INTO Fornecedores (nome, ie, cnpj, email, telefone, ID_Cidade)
VALUES  ('DeWalt', '254611630',	'09.380.849/0001-02', 'alessandro@tecniconsc.com.br', '(49) 98634-9034', 11),
		('Bosch', '244007410115', '45.990.181/0001-89', 'centro.memoria@institutorobertbosch.org.br', '(19) 2103-1294', 12),
	    ('Belzer', '2389904637', '44.256.691/0001-64', 'belzerferragens@gmail.com.br', '(19) 3116-4040', 12);
GO


CREATE TABLE Nota_Entrada (
	id_nota_e INT IDENTITY(1,1),
	id_fornecedor INT NOT NULL,
	n_nota INT NOT NULL,
	id_produto INT NOT NULL,
	data_modificacao DATETIME CONSTRAINT DF_MODIFICENTRADA DEFAULT GETDATE(),
	qtde INT NOT NULL,
	valor_un_compra DECIMAL(10, 2) NOT NULL,
	CONSTRAINT PK_NOTA_ENTRADA PRIMARY KEY (id_nota_e),
	CONSTRAINT FK_NOTA_ENTRADA_FORNECEDORES FOREIGN KEY (id_fornecedor) REFERENCES Fornecedores(id_fornecedor),
	CONSTRAINT FK_NOTA_ENTRADA_PRODUTOS FOREIGN KEY (id_produto) REFERENCES PRODUTOS(id_produto)
	ON DELETE CASCADE
	);
GO

INSERT INTO Nota_Entrada (id_fornecedor, n_nota, id_produto, qtde, valor_un_compra)
VALUES  (1, 2345, 1, 4, 120.55),
		(2, 1056, 2, 3, 566.70),
	    (3, 7389, 3, 5, 55.60);
GO


CREATE TABLE Nota_Saida (
	id_nota_s INT IDENTITY(1,1),
	n_nota INT NOT NULL,
	id_cliente INT NOT NULL,
	id_produto INT NOT NULL,
	qtde INT NOT NULL,
	data_modificacao DATETIME CONSTRAINT DF_MODIFICNOTASAIDA DEFAULT GETDATE(),
	valor_un_venda DECIMAL(10, 2) NOT NULL,
	CONSTRAINT PK_NOTA_SAIDA PRIMARY KEY (id_nota_s),
	CONSTRAINT FK_NOTA_SAIDA_CLIENTES FOREIGN KEY (id_cliente) REFERENCES Clientes(id_cliente),
	CONSTRAINT FK_NOTA_SAIDA_PRODUTOS FOREIGN KEY (id_produto) REFERENCES PRODUTOS(id_produto)
	ON DELETE CASCADE
	);
GO


INSERT INTO Nota_Saida (id_cliente, n_nota, id_produto, qtde, valor_un_venda)
VALUES  (1, 2322, 1, 1, 149.90),
		(2, 5677, 2, 1, 599.90),
	    (3, 7904, 3, 1, 99.90);
GO


--USUARIOS--
CREATE OR ALTER TRIGGER tbiu_atualiza_data_modificacao_usuarios
ON Usuarios
AFTER INSERT, UPDATE
AS
BEGIN
    UPDATE Usuarios
    SET Usuarios.data_modificacao = GETDATE()
    FROM Usuarios
    INNER JOIN inserted i ON Usuarios.nome_user = i.nome_user;
END;
GO



CREATE OR ALTER TRIGGER tbi_gera_data_criacao_usuario
ON Usuarios
AFTER INSERT
AS
BEGIN
    UPDATE Usuarios
    SET Usuarios.data_criacao = GETDATE()
    FROM Usuarios
    INNER JOIN inserted i ON Usuarios.nome_user = i.nome_user;
END;
GO


--CLIENTES--


CREATE OR ALTER TRIGGER tbiu_atualiza_data_modificacacao_clientes
ON Clientes
AFTER INSERT, UPDATE
AS
BEGIN
    UPDATE Clientes
    SET Clientes.data_modificacao = GETDATE()
    FROM Clientes
    INNER JOIN inserted i ON Clientes.id_cliente = i.id_cliente;
END;
GO

CREATE PROCEDURE IncluirCliente
	@nome NVARCHAR(100),
	@data_nasc DATE,
	@idade INT,
	@cpf NVARCHAR(14),
	@email NVARCHAR(100),
	@telefone NVARCHAR(15),
	@cidade_nome NVARCHAR(50)
AS
BEGIN
	DECLARE @cidade_id INT;
	SELECT @cidade_id = id_cidade FROM Cidades WHERE nome = @cidade_nome;
	INSERT INTO Clientes (nome, data_nascimento, idade, cpf, email, telefone, ID_Cidade)
    VALUES (@nome, @data_nasc, @idade, @cpf, @email, @telefone, @cidade_id);
END;
GO





CREATE PROCEDURE ConsultarCliente
    @nome NVARCHAR(100),
    @cpf NVARCHAR(14)
AS
BEGIN
    SELECT CL.*, CI.nome AS cidade_nome
    FROM Clientes CL
    INNER JOIN Cidades CI ON CL.id_cidade = CI.id_cidade
    WHERE (@nome IS NOT NULL AND CL.nome = @nome)
       OR (@cpf IS NOT NULL AND CL.cpf = @cpf);
END;
GO





CREATE PROCEDURE AtualizarCliente
	@id_cliente INT,
    @nome NVARCHAR(100),
	@data_nasc DATE,
	@idade INT,
	@cpf NVARCHAR(14),
	@email NVARCHAR(100),
	@telefone NVARCHAR(15),
	@cidade_nome NVARCHAR(50)
AS
BEGIN
	DECLARE @cidade_id INT;
	SELECT @cidade_id = id_cidade FROM Cidades WHERE nome = @cidade_nome;

    UPDATE Clientes
		SET nome = @nome,
			data_nascimento = @data_nasc,
			idade = @idade,
			cpf = @cpf,
			email = @email,
			telefone = @telefone,
			id_cidade = @cidade_id
		WHERE id_cliente = @id_cliente;
END;
GO





CREATE PROCEDURE ExcluirCliente
    @id_cliente INT
AS
BEGIN
    DELETE FROM Clientes WHERE id_cliente = @id_cliente;
END;
GO






CREATE FUNCTION CalculaIdade (@Date DATE)
RETURNS INT
AS
BEGIN
	DECLARE @idade INT = 0
	SET @idade = DATEDIFF(YEAR, @Date, GETDATE())
	RETURN @idade
END
GO






CREATE VIEW VW_DGV_CLIENTES
AS
SELECT CL.id_cliente, CL.nome, CL.data_nascimento, CL.idade, CL.cpf, CL.email, CL.telefone, CI.nome AS cidade FROM Clientes CL
	INNER JOIN Cidades CI
	ON CL.id_cidade = CI.id_cidade
GO






--FORNECEDORES--

CREATE OR ALTER TRIGGER tbiu_atualiza_data_modificacacao_fornecedores
ON Fornecedores
AFTER INSERT, UPDATE
AS
BEGIN
    UPDATE Fornecedores
    SET Fornecedores.data_modificacao = GETDATE()
    FROM Fornecedores
    INNER JOIN inserted i ON Fornecedores.id_fornecedor = i.id_fornecedor;
END;
GO

CREATE PROCEDURE IncluirFornecedor
	@nome NVARCHAR(100),
	@ie NVARCHAR(15),
	@cnpj NVARCHAR(18),
	@email NVARCHAR(100),
	@telefone NVARCHAR(15),
	@cidade_nome NVARCHAR(50)
AS
BEGIN
	DECLARE @cidade_id INT;
	SELECT @cidade_id = id_cidade FROM Cidades WHERE nome = @cidade_nome;
	INSERT INTO Fornecedores (nome, ie, cnpj, email, telefone, ID_Cidade)
    VALUES (@nome, @ie, @cnpj, @email, @telefone, @cidade_id);
END;
GO





CREATE PROCEDURE ConsultarFornecedor
    @nome NVARCHAR(100),
	@ie NVARCHAR(15),
    @cnpj NVARCHAR(18)
AS
BEGIN
    SELECT F.*, CI.nome AS cidade_nome
    FROM Fornecedores F
    INNER JOIN Cidades CI ON F.id_cidade = CI.id_cidade
    WHERE (@nome IS NOT NULL AND F.nome = @nome)
       OR (@ie IS NOT NULL AND F.ie = @ie)
	   OR (@cnpj IS NOT NULL AND F.cnpj = @cnpj);
END;
GO






CREATE PROCEDURE AtualizarFornecedor
	@id_fornecedor INT,
	@nome NVARCHAR(100),
	@ie NVARCHAR(15),
	@cnpj NVARCHAR(18),
	@email NVARCHAR(100),
	@telefone NVARCHAR(15),
	@cidade_nome NVARCHAR(50)
AS
BEGIN
	DECLARE @cidade_id INT;
	SELECT @cidade_id = id_cidade FROM Cidades WHERE nome = @cidade_nome;

    UPDATE Fornecedores
		SET nome = @nome,
			ie = @ie,
			cnpj = @cnpj,
			email = @email,
			telefone = @telefone,
			id_cidade = @cidade_id
		WHERE id_fornecedor = @id_fornecedor;
END;
GO






CREATE PROCEDURE ExcluirFornecedor
    @id_fornecedor INT
AS
BEGIN
    DELETE FROM Fornecedores WHERE @id_fornecedor = id_fornecedor;
END;
GO






CREATE VIEW VW_DGV_FORNECEDORES
AS
SELECT F.id_fornecedor, F.nome, F.cnpj, F.ie, F.telefone, F.email, CI.nome AS cidade FROM Fornecedores F
	INNER JOIN Cidades CI
	ON F.id_cidade = CI.id_cidade
GO






--PRODUTOS--

CREATE OR ALTER TRIGGER tbiu_atualiza_data_modificacacao_produto
ON Produtos
AFTER INSERT, UPDATE
AS
BEGIN
    UPDATE Produtos
    SET Produtos.data_modificacao = GETDATE()
    FROM Produtos
    INNER JOIN inserted i ON Produtos.id_produto = i.id_produto;
END;
GO


CREATE PROCEDURE IncluirProduto
	@nome NVARCHAR(50),
	@descricao NVARCHAR(175)
AS
BEGIN
	INSERT INTO Produtos(nome, descricao)
    VALUES (@nome, @descricao);
END;
GO





CREATE PROCEDURE ConsultarProduto
    @nome NVARCHAR(100)
AS
BEGIN
    SELECT * FROM Produtos P
    WHERE (@nome IS NOT NULL AND P.nome = @nome)
END;
GO






CREATE PROCEDURE AtualizarProduto
	@id_produto INT,
	@nome NVARCHAR(50),
	@descricao NVARCHAR(175)
AS
BEGIN
	 UPDATE Produtos
		SET nome = @nome,
			descricao = @descricao
		WHERE id_produto = @id_produto;
END;
GO






CREATE PROCEDURE ExcluirProduto
    @id_produto INT
AS
BEGIN
    DELETE FROM Produtos WHERE @id_produto = id_produto;
END;
GO

CREATE VIEW VW_DGV_PRODUTOS
AS
SELECT P.id_produto, P.nome, P.descricao FROM Produtos P
GO






--NOTA ENTRADA--

CREATE OR ALTER TRIGGER tbiu_atualiza_data_modificacacao_nota_entrada
ON Nota_Entrada
AFTER INSERT, UPDATE
AS
BEGIN
    UPDATE Nota_Entrada
    SET Nota_Entrada.data_modificacao = GETDATE()
    FROM Nota_Entrada
    INNER JOIN inserted i ON Nota_Entrada.id_nota_e = i.id_nota_e;
END;
GO

CREATE TRIGGER tbiu_calcula_custo_medio
ON Nota_Entrada
AFTER INSERT, UPDATE, DELETE
AS
BEGIN
   UPDATE Produto
    SET custo_medio = CASE -- seta o custo medio segundo tais condições
        WHEN i.qtd_total > 0 THEN (i.valor_total / i.qtd_total) -- se maior que 0, calcula o custo medio do item, se não, deixa setado como 0 para evitar divisoes por 0
        ELSE 0
        END
    FROM Produto
    JOIN (
        SELECT
            inserted.id_produto,
            SUM(inserted.qtde) AS qtd_total,
            SUM(inserted.valor_un_compra * inserted.qtde) AS valor_total
        FROM
            inserted
        GROUP BY
            inserted.id_produto
    ) AS i ON Produto.id_produto = i.id_produto;
END;
GO



CREATE PROCEDURE IncluirNotaEntrada
	@fornecedor_nome NVARCHAR(100),
	@produto_nome NVARCHAR(50),
	@n_nota INT,
	@qtde INT,
	@valor_un_compra DECIMAL(10, 2)
AS
BEGIN
	DECLARE @produto_id INT;
	SELECT @produto_id = id_produto FROM Produtos WHERE nome = @produto_nome;
	DECLARE @fornecedor_id INT;
	SELECT @fornecedor_id = id_fornecedor FROM Fornecedores WHERE nome = @fornecedor_nome;

	INSERT INTO Nota_Entrada (id_fornecedor, n_nota, id_produto, qtde, valor_un_compra)
    VALUES (@fornecedor_id, @n_nota, @produto_id, @qtde, @valor_un_compra);
END;
GO

CREATE RULE rl_quantidade AS @qtde >0
GO 

EXECUTE SP_BINDRULE rl_quantidade , 'Nota_Entrada.qtde'
GO



CREATE PROCEDURE ConsultarNotaEntrada
	@n_nota INT
AS
BEGIN
    SELECT E.*, F.nome AS fornecedor_nome, P.nome AS produto_nome
    FROM Nota_Entrada E
    INNER JOIN Fornecedores F ON E.id_fornecedor = F.id_fornecedor
	INNER JOIN Produtos P ON E.id_produto = P.id_produto
    WHERE (@n_nota IS NOT NULL AND E.n_nota = @n_nota);
END;
GO






CREATE PROCEDURE AtualizarNotaEntrada
	@id_nota_e INT,
	@fornecedor_nome NVARCHAR(100),
	@produto_nome NVARCHAR(50),
	@n_nota INT,
	@qtde INT,
	@valor_un_compra DECIMAL(10, 2)
AS
BEGIN
	DECLARE @produto_id INT;
	SELECT @produto_id = id_produto FROM Produtos WHERE nome = @produto_nome;
	DECLARE @fornecedor_id INT;
	SELECT @fornecedor_id = id_fornecedor FROM Fornecedores WHERE nome = @fornecedor_nome;

    UPDATE Nota_Entrada
		SET id_fornecedor = @fornecedor_id,
			id_produto = @produto_id,
			n_nota = @n_nota,
			qtde = @qtde,
			valor_un_compra = @valor_un_compra
		WHERE id_nota_e = @id_nota_e;
END;
GO

CREATE PROCEDURE ExcluirNotaEntrada
    @n_nota INT
AS
BEGIN
    DELETE FROM Nota_Entrada WHERE n_nota = @n_nota;
END;
GO

CREATE VIEW VW_DGV_PROD_ENTRADA
AS
    SELECT E.qtde, E.valor_un_compra, P.nome AS produto_nome
    FROM Nota_Entrada E
	INNER JOIN Produtos P ON E.id_produto = P.id_produto
GO






CREATE VIEW VW_DGV_NOTA_ENTRADA
AS
    SELECT E.*, F.nome AS fornecedor_nome, P.nome AS produto_nome,
           SUM(qtde * valor_un_compra) OVER (PARTITION BY E.n_nota) AS valor_total_nota
    FROM Nota_Entrada E
    INNER JOIN Fornecedores F ON E.id_fornecedor = F.id_fornecedor
    INNER JOIN Produtos P ON E.id_produto = P.id_produto;
GO



--NOTA SAIDA--

CREATE OR ALTER TRIGGER tbiu_atualiza_data_modificacacao_nota_saida
ON Nota_Saida
AFTER INSERT, UPDATE
AS
BEGIN
    UPDATE Nota_Saida
    SET Nota_Saida.data_modificacao = GETDATE()
    FROM Nota_Saida
    INNER JOIN inserted i ON Nota_Saida.id_nota_s = i.id_nota_s;
END;
GO


EXECUTE SP_BINDRULE rl_quantidade , 'Nota_Saida.qtde'
GO





CREATE PROCEDURE IncluirNotaSaida
	@cliente_nome NVARCHAR(100),
	@produto_nome NVARCHAR(50),
	@n_nota INT,
	@qtde INT,
	@valor_un_venda DECIMAL(10, 2)
AS
BEGIN
	DECLARE @produto_id INT;
	SELECT @produto_id = id_produto FROM Produtos WHERE nome = @produto_nome;
	DECLARE @cliente_id INT;
	SELECT @cliente_id = id_cliente FROM Clientes WHERE nome = @cliente_nome;

	INSERT INTO Nota_Saida (id_cliente, n_nota, id_produto, qtde, valor_un_venda)
    VALUES (@cliente_id, @n_nota, @produto_id, @qtde, @valor_un_venda);
END;
GO


CREATE PROCEDURE ConsultarNotaSaida
	@n_nota INT
AS
BEGIN
    SELECT S.*, C.nome AS cliente_nome, P.nome AS produto_nome
    FROM Nota_Saida S
    INNER JOIN Clientes C ON S.id_cliente = C.id_cliente
	INNER JOIN Produtos P ON S.id_produto = P.id_produto
    WHERE (@n_nota IS NOT NULL AND S.n_nota = @n_nota);
END;
GO


CREATE PROCEDURE AtualizarNotaSaida
	@id_nota_s INT,
	@cliente_nome NVARCHAR(100),
	@produto_nome NVARCHAR(50),
	@n_nota INT,
	@qtde INT,
	@valor_un_venda DECIMAL(10, 2)
AS
BEGIN
	DECLARE @produto_id INT;
	SELECT @produto_id = id_produto FROM Produtos WHERE nome = @produto_nome;
	DECLARE @cliente_id INT;
	SELECT @cliente_id = id_cliente FROM Clientes WHERE nome = @cliente_nome;

    UPDATE Nota_Saida
		SET id_cliente = @cliente_id,
			id_produto = @produto_id,
			n_nota = @n_nota,
			qtde = @qtde,
			valor_un_venda = @valor_un_venda
		WHERE id_nota_s = @id_nota_s;
END;
GO



CREATE PROCEDURE ExcluirNotaSaida
    @n_nota INT
AS
BEGIN
    DELETE FROM Nota_Saida WHERE n_nota = @n_nota;
END;
GO
