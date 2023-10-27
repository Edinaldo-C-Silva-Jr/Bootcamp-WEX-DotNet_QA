USE Filmes

-- Exercicio 01

SELECT Nome, Ano 
FROM Filmes

-- Exercicio 02

SELECT Nome, Ano, Duracao 
FROM Filmes
ORDER BY Ano

-- Exercicio 03

SELECT Nome, Ano, Duracao 
FROM Filmes
WHERE Nome = 'De Volta para o Futuro'

-- Exercicio 04

SELECT Nome, Ano, Duracao
FROM Filmes
WHERE Ano = 1997

-- Exercicio 05

SELECT Nome, Ano, Duracao
FROM Filmes
WHERE Ano > 2000

-- Exercicio 06

SELECT Nome, Ano, Duracao
FROM Filmes
WHERE Duracao > 100 AND Duracao < 150
ORDER BY Duracao

-- Exercicio 07

SELECT Ano, COUNT(Ano) AS Quantidade
FROM Filmes
GROUP BY Ano
ORDER BY Quantidade DESC

-- Exercicio 08

SELECT * FROM Atores
WHERE Genero = 'M'

-- Exercicio 09

SELECT * FROM Atores
WHERE Genero = 'F'
ORDER BY PrimeiroNome

-- Exercicio 10

SELECT F.Nome, G.Genero
FROM Filmes F
INNER JOIN FilmesGenero R ON R.IdFilme = F.Id
INNER JOIN Generos G ON R.IdGenero = G.Id

-- Exercicio 11

SELECT F.Nome, G.Genero
FROM Filmes F
INNER JOIN FilmesGenero R ON R.IdFilme = F.Id
INNER JOIN Generos G ON R.IdGenero = G.Id
WHERE G.Genero = 'Mistério'

-- Exercicio 12

SELECT F.Nome, A.PrimeiroNome, A.UltimoNome, E.Papel
FROM Filmes F
INNER JOIN ElencoFilme E ON E.IdFilme = F.Id
INNER JOIN Atores A ON E.IdAtor = A.Id
