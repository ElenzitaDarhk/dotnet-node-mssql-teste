USE EscolaDB
CREATE TABLE Alunos (
    Id INT PRIMARY KEY IDENTITY(1,1),
    Matricula NVARCHAR(20) NOT NULL UNIQUE,
    Nome NVARCHAR(100) NOT NULL,
    DataNascimento DATE NOT NULL,
    Email NVARCHAR(100) NOT NULL UNIQUE
);