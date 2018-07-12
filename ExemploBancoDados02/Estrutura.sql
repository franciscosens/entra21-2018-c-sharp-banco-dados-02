CREATE TABLE herois(
	id INT IDENTITY(1,1) PRIMARY KEY,
	nome VARCHAR(100) NOT NULL,
	escuridao BIT NOT NULL,
	nome_pessoa VARCHAR(150) NOT NULL,
	raca VARCHAR(100) NOT NULL,
	conta_bancaria DECIMAL(17,2) NOT NULL,
	data_nascimento DATE NOT NULL,
	sexo CHAR(1) NOT NULL,
	quantidade_filmes TINYINT NOT NULL,
	descricao TEXT
);

SELECT * FROM herois;

-- TOTAL CONTA BANCÁRIA
SELECT SUM(conta_bancaria) FROM herois;

-- Quantidade de mulheres
SELECT COUNT(sexo) FROM herois WHERE sexo = 'm';

-- Quantidade de herois por raça
SELECT raca, COUNT(id) 
FROM herois
GROUP BY raca;

-- Heroi mais velho
SELECT nome, YEAR(GETDATE()) - YEAR(data_nascimento)
FROM herois
WHERE data_nascimento = (SELECT MAX(data_nascimento) FROM herois);
