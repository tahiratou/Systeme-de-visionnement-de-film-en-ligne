-- ============================================================
-- SCRIPT 1 CORRIGÉ: CRÉATION BASE DE DONNÉES ET TABLES
-- VisionFlix - SQL Server - AVEC NomUtilisateur
-- ============================================================

-- ÉTAPE 1: Créer la base de données
USE master;
GO

IF EXISTS (SELECT * FROM sys.databases WHERE name = 'VisionFlixDb')
BEGIN
    ALTER DATABASE VisionFlixDb SET SINGLE_USER WITH ROLLBACK IMMEDIATE;
    DROP DATABASE VisionFlixDb;
    PRINT 'Base de données VisionFlixDb supprimée';
END
GO

CREATE DATABASE VisionFlixDb;
GO

PRINT 'Base de données VisionFlixDb créée avec succès';
GO

USE VisionFlixDb;
GO

-- ============================================================
-- ÉTAPE 2: CRÉATION DES TABLES
-- ============================================================

-- Table PlansAbonnement (DOIT être créée en premier car référencée par Utilisateurs)
CREATE TABLE PlansAbonnement (
    Id INT PRIMARY KEY IDENTITY(1,1),
    Nom NVARCHAR(100) NOT NULL,
    Prix DECIMAL(10,2) NOT NULL,
    Description NVARCHAR(500),
    EstActif BIT NOT NULL DEFAULT 1
);
GO

-- Table Utilisateurs - 
CREATE TABLE Utilisateurs (
    Id INT PRIMARY KEY IDENTITY(1,1),
    NomUtilisateur NVARCHAR(50) NOT NULL UNIQUE, 
    Nom NVARCHAR(100) NOT NULL,
    Prenom NVARCHAR(100) NOT NULL,
    Email NVARCHAR(150) NOT NULL UNIQUE,
    Telephone NVARCHAR(20),
    Adresse NVARCHAR(200),
    MotDePasse NVARCHAR(255) NOT NULL,
    Solde DECIMAL(10,2) DEFAULT 0,
    EstAdministrateur BIT NOT NULL DEFAULT 0,
    EstAbonne BIT NOT NULL DEFAULT 0,
    PlanAbonnementId INT NULL,
    DateInscription DATETIME NOT NULL DEFAULT GETDATE(),
    DateExpirationAbonnement DATETIME NULL,
    DerniereConnexion DATETIME NULL,
    CONSTRAINT FK_Utilisateurs_PlansAbonnement 
        FOREIGN KEY (PlanAbonnementId) 
        REFERENCES PlansAbonnement(Id) 
        ON DELETE SET NULL
);
GO

CREATE INDEX IX_Utilisateurs_Email ON Utilisateurs(Email);
CREATE INDEX IX_Utilisateurs_NomUtilisateur ON Utilisateurs(NomUtilisateur);
GO

-- Table Categories
CREATE TABLE Categories (
    Id INT PRIMARY KEY IDENTITY(1,1),
    Nom NVARCHAR(100) NOT NULL UNIQUE,
    Description NVARCHAR(500),
    EstActive BIT NOT NULL DEFAULT 1
);
GO

CREATE INDEX IX_Categories_Nom ON Categories(Nom);
GO

-- Table Langues
CREATE TABLE Langues (
    Id INT PRIMARY KEY IDENTITY(1,1),
    Nom NVARCHAR(100) NOT NULL,
    Code NVARCHAR(10) NOT NULL UNIQUE,
    EstActive BIT NOT NULL DEFAULT 1
);
GO

CREATE INDEX IX_Langues_Code ON Langues(Code);
GO

-- Table Films
CREATE TABLE Films (
    Id INT PRIMARY KEY IDENTITY(1,1),
    Titre NVARCHAR(200) NOT NULL,
    Realisateur NVARCHAR(150) NOT NULL,
    Annee INT NOT NULL,
    Genre NVARCHAR(50) NOT NULL,
    Duree INT NOT NULL, 
    Synopsis NVARCHAR(MAX),
    ImageUrl NVARCHAR(500),
    Prix DECIMAL(10,2) NOT NULL,
    Note DECIMAL(3,1) DEFAULT 0,
    EstDisponible BIT NOT NULL DEFAULT 1,
    DateAjout DATETIME NOT NULL DEFAULT GETDATE()
);
GO
 
CREATE INDEX IX_Films_Titre ON Films(Titre);
CREATE INDEX IX_Films_Genre ON Films(Genre);
CREATE INDEX IX_Films_Annee ON Films(Annee);
GO

-- Table Achats
CREATE TABLE Achats (
    Id INT PRIMARY KEY IDENTITY(1,1),
    UtilisateurId INT NOT NULL,
    FilmId INT NOT NULL,
    DateAchat DATETIME NOT NULL DEFAULT GETDATE(),
    PrixAchat DECIMAL(10,2) NOT NULL,
    
    CONSTRAINT FK_Achats_Utilisateurs 
        FOREIGN KEY (UtilisateurId) 
        REFERENCES Utilisateurs(Id) 
        ON DELETE CASCADE,
    
    CONSTRAINT FK_Achats_Films 
        FOREIGN KEY (FilmId) 
        REFERENCES Films(Id) 
        ON DELETE CASCADE,
    
    CONSTRAINT UQ_Achats_Utilisateur_Film 
        UNIQUE(UtilisateurId, FilmId)
);
GO

CREATE INDEX IX_Achats_UtilisateurId ON Achats(UtilisateurId);
CREATE INDEX IX_Achats_FilmId ON Achats(FilmId);
GO

-- Table Visionnements
CREATE TABLE Visionnements (
    Id INT PRIMARY KEY IDENTITY(1,1),
    UtilisateurId INT NOT NULL,
    FilmId INT NOT NULL,
    DateVisionnement DATETIME NOT NULL DEFAULT GETDATE(),
    
    CONSTRAINT FK_Visionnements_Utilisateurs 
        FOREIGN KEY (UtilisateurId) 
        REFERENCES Utilisateurs(Id) 
        ON DELETE CASCADE,
    
    CONSTRAINT FK_Visionnements_Films 
        FOREIGN KEY (FilmId) 
        REFERENCES Films(Id) 
        ON DELETE CASCADE
);
GO

CREATE INDEX IX_Visionnements_UtilisateurId ON Visionnements(UtilisateurId);
CREATE INDEX IX_Visionnements_FilmId ON Visionnements(FilmId);
GO

-- Table Notations
CREATE TABLE Notations (
    Id INT PRIMARY KEY IDENTITY(1,1),
    UtilisateurId INT NOT NULL,
    FilmId INT NOT NULL,
    Note INT NOT NULL CHECK (Note BETWEEN 1 AND 5),
    DateNotation DATETIME NOT NULL DEFAULT GETDATE(),
    
    CONSTRAINT FK_Notations_Utilisateurs 
        FOREIGN KEY (UtilisateurId) 
        REFERENCES Utilisateurs(Id) 
        ON DELETE CASCADE,
    
    CONSTRAINT FK_Notations_Films 
        FOREIGN KEY (FilmId) 
        REFERENCES Films(Id) 
        ON DELETE CASCADE,
    
    CONSTRAINT UQ_Notations_Utilisateur_Film 
        UNIQUE(UtilisateurId, FilmId)
);
GO

CREATE INDEX IX_Notations_FilmId ON Notations(FilmId);
GO

-- Table Transactions
CREATE TABLE Transactions (
    Id INT PRIMARY KEY IDENTITY(1,1),
    UtilisateurId INT NOT NULL,
    Type NVARCHAR(50) NOT NULL,
    Description NVARCHAR(500),
    Montant DECIMAL(10,2) NOT NULL,
    DateTransaction DATETIME NOT NULL DEFAULT GETDATE(),
    
    CONSTRAINT FK_Transactions_Utilisateurs 
        FOREIGN KEY (UtilisateurId) 
        REFERENCES Utilisateurs(Id) 
        ON DELETE CASCADE
);
GO

CREATE INDEX IX_Transactions_UtilisateurId ON Transactions(UtilisateurId);
CREATE INDEX IX_Transactions_DateTransaction ON Transactions(DateTransaction);
GO

PRINT 'Toutes les tables créées avec succès (avec NomUtilisateur)!';
GO