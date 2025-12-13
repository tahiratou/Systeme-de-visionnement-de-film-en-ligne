IF OBJECT_ID(N'[__EFMigrationsHistory]') IS NULL
BEGIN
    CREATE TABLE [__EFMigrationsHistory] (
        [MigrationId] nvarchar(150) NOT NULL,
        [ProductVersion] nvarchar(32) NOT NULL,
        CONSTRAINT [PK___EFMigrationsHistory] PRIMARY KEY ([MigrationId])
    );
END;
GO

BEGIN TRANSACTION;
GO

CREATE TABLE [Categories] (
    [Id] int NOT NULL IDENTITY,
    [Nom] nvarchar(100) NOT NULL,
    [Description] nvarchar(500) NULL,
    [EstActive] bit NOT NULL DEFAULT CAST(1 AS bit),
    CONSTRAINT [PK_Categories] PRIMARY KEY ([Id])
);
GO

CREATE TABLE [Films] (
    [Id] int NOT NULL IDENTITY,
    [Titre] nvarchar(200) NOT NULL,
    [Realisateur] nvarchar(150) NOT NULL,
    [Annee] int NOT NULL,
    [Note] decimal(3,1) NOT NULL,
    [Langue] nvarchar(50) NOT NULL DEFAULT N'Français',
    [Duree] int NOT NULL,
    [Genre] nvarchar(50) NOT NULL,
    [ImageUrl] nvarchar(500) NULL,
    [Synopsis] nvarchar(2000) NULL,
    [Prix] decimal(10,2) NOT NULL,
    [EstDisponible] bit NOT NULL DEFAULT CAST(1 AS bit),
    [DateAjout] datetime2 NOT NULL,
    CONSTRAINT [PK_Films] PRIMARY KEY ([Id])
);
DECLARE @defaultSchema AS sysname;
SET @defaultSchema = SCHEMA_NAME();
DECLARE @description AS sql_variant;
SET @description = N'Langue du film (Français, Anglais, etc.)';
EXEC sp_addextendedproperty 'MS_Description', @description, 'SCHEMA', @defaultSchema, 'TABLE', N'Films', 'COLUMN', N'Langue';
GO

CREATE TABLE [Langues] (
    [Id] int NOT NULL IDENTITY,
    [Nom] nvarchar(100) NOT NULL,
    [Code] nvarchar(10) NOT NULL,
    [EstActive] bit NOT NULL DEFAULT CAST(1 AS bit),
    CONSTRAINT [PK_Langues] PRIMARY KEY ([Id])
);
GO

CREATE TABLE [PlansAbonnement] (
    [Id] int NOT NULL IDENTITY,
    [Nom] nvarchar(100) NOT NULL,
    [Prix] decimal(10,2) NOT NULL,
    [Description] nvarchar(500) NOT NULL,
    [EstActif] bit NOT NULL DEFAULT CAST(1 AS bit),
    CONSTRAINT [PK_PlansAbonnement] PRIMARY KEY ([Id])
);
GO

CREATE TABLE [Utilisateurs] (
    [Id] int NOT NULL IDENTITY,
    [NomUtilisateur] nvarchar(50) NOT NULL,
    [Nom] nvarchar(100) NOT NULL,
    [Prenom] nvarchar(100) NOT NULL,
    [Email] nvarchar(150) NOT NULL,
    [Telephone] nvarchar(20) NOT NULL,
    [Adresse] nvarchar(200) NOT NULL,
    [MotDePasse] nvarchar(255) NOT NULL,
    [Solde] decimal(10,2) NOT NULL DEFAULT 0.0,
    [EstAdministrateur] bit NOT NULL DEFAULT CAST(0 AS bit),
    [EstAbonne] bit NOT NULL DEFAULT CAST(0 AS bit),
    [PlanAbonnementId] int NULL,
    [Langue] nvarchar(10) NOT NULL DEFAULT N'fr',
    [NotificationsActivees] bit NOT NULL DEFAULT CAST(1 AS bit),
    [DateExpirationAbonnement] datetime2 NULL,
    [DateInscription] datetime2 NOT NULL DEFAULT (GETDATE()),
    [DerniereConnexion] datetime2 NULL,
    CONSTRAINT [PK_Utilisateurs] PRIMARY KEY ([Id]),
    CONSTRAINT [FK_Utilisateurs_PlansAbonnement_PlanAbonnementId] FOREIGN KEY ([PlanAbonnementId]) REFERENCES [PlansAbonnement] ([Id]) ON DELETE SET NULL
);
DECLARE @defaultSchema AS sysname;
SET @defaultSchema = SCHEMA_NAME();
DECLARE @description AS sql_variant;
SET @description = N'Code ISO de la langue de l''utilisateur (fr, en, es, de)';
EXEC sp_addextendedproperty 'MS_Description', @description, 'SCHEMA', @defaultSchema, 'TABLE', N'Utilisateurs', 'COLUMN', N'Langue';
SET @description = N'Indique si l''utilisateur souhaite recevoir des notifications';
EXEC sp_addextendedproperty 'MS_Description', @description, 'SCHEMA', @defaultSchema, 'TABLE', N'Utilisateurs', 'COLUMN', N'NotificationsActivees';
GO

CREATE TABLE [Achats] (
    [Id] int NOT NULL IDENTITY,
    [UtilisateurId] int NOT NULL,
    [FilmId] int NOT NULL,
    [PrixAchat] decimal(10,2) NOT NULL,
    [DateAchat] datetime2 NOT NULL DEFAULT (GETDATE()),
    CONSTRAINT [PK_Achats] PRIMARY KEY ([Id]),
    CONSTRAINT [FK_Achats_Films_FilmId] FOREIGN KEY ([FilmId]) REFERENCES [Films] ([Id]) ON DELETE CASCADE,
    CONSTRAINT [FK_Achats_Utilisateurs_UtilisateurId] FOREIGN KEY ([UtilisateurId]) REFERENCES [Utilisateurs] ([Id]) ON DELETE CASCADE
);
GO

CREATE TABLE [Notations] (
    [Id] int NOT NULL IDENTITY,
    [UtilisateurId] int NOT NULL,
    [FilmId] int NOT NULL,
    [Note] int NOT NULL,
    [Commentaire] nvarchar(1000) NULL,
    [DateNotation] datetime2 NOT NULL DEFAULT (GETDATE()),
    CONSTRAINT [PK_Notations] PRIMARY KEY ([Id]),
    CONSTRAINT [FK_Notations_Films_FilmId] FOREIGN KEY ([FilmId]) REFERENCES [Films] ([Id]) ON DELETE CASCADE,
    CONSTRAINT [FK_Notations_Utilisateurs_UtilisateurId] FOREIGN KEY ([UtilisateurId]) REFERENCES [Utilisateurs] ([Id]) ON DELETE CASCADE
);
GO

CREATE TABLE [Transactions] (
    [Id] int NOT NULL IDENTITY,
    [UtilisateurId] int NOT NULL,
    [Type] nvarchar(50) NOT NULL,
    [Montant] decimal(10,2) NOT NULL,
    [Description] nvarchar(500) NULL,
    [DateTransaction] datetime2 NOT NULL DEFAULT (GETDATE()),
    CONSTRAINT [PK_Transactions] PRIMARY KEY ([Id]),
    CONSTRAINT [FK_Transactions_Utilisateurs_UtilisateurId] FOREIGN KEY ([UtilisateurId]) REFERENCES [Utilisateurs] ([Id]) ON DELETE CASCADE
);
GO

CREATE TABLE [Visionnements] (
    [Id] int NOT NULL IDENTITY,
    [UtilisateurId] int NOT NULL,
    [FilmId] int NOT NULL,
    [DateVisionnement] datetime2 NOT NULL DEFAULT (GETDATE()),
    [ProgressionEnSecondes] int NULL,
    [EstComplete] bit NOT NULL,
    CONSTRAINT [PK_Visionnements] PRIMARY KEY ([Id]),
    CONSTRAINT [FK_Visionnements_Films_FilmId] FOREIGN KEY ([FilmId]) REFERENCES [Films] ([Id]) ON DELETE CASCADE,
    CONSTRAINT [FK_Visionnements_Utilisateurs_UtilisateurId] FOREIGN KEY ([UtilisateurId]) REFERENCES [Utilisateurs] ([Id]) ON DELETE CASCADE
);
GO

CREATE INDEX [IX_Achats_FilmId] ON [Achats] ([FilmId]);
GO

CREATE INDEX [IX_Achats_UtilisateurId] ON [Achats] ([UtilisateurId]);
GO

CREATE UNIQUE INDEX [IX_Achats_UtilisateurId_FilmId] ON [Achats] ([UtilisateurId], [FilmId]);
GO

CREATE UNIQUE INDEX [IX_Categories_Nom] ON [Categories] ([Nom]);
GO

CREATE INDEX [IX_Films_Annee] ON [Films] ([Annee]);
GO

CREATE INDEX [IX_Films_Genre] ON [Films] ([Genre]);
GO

CREATE INDEX [IX_Films_Titre] ON [Films] ([Titre]);
GO

CREATE UNIQUE INDEX [IX_Langues_Code] ON [Langues] ([Code]);
GO

CREATE INDEX [IX_Notations_FilmId] ON [Notations] ([FilmId]);
GO

CREATE UNIQUE INDEX [IX_Notations_UtilisateurId_FilmId] ON [Notations] ([UtilisateurId], [FilmId]);
GO

CREATE INDEX [IX_Transactions_DateTransaction] ON [Transactions] ([DateTransaction]);
GO

CREATE INDEX [IX_Transactions_UtilisateurId] ON [Transactions] ([UtilisateurId]);
GO

CREATE UNIQUE INDEX [IX_Utilisateurs_Email] ON [Utilisateurs] ([Email]);
GO

CREATE UNIQUE INDEX [IX_Utilisateurs_NomUtilisateur] ON [Utilisateurs] ([NomUtilisateur]);
GO

CREATE INDEX [IX_Utilisateurs_PlanAbonnementId] ON [Utilisateurs] ([PlanAbonnementId]);
GO

CREATE INDEX [IX_Visionnements_FilmId] ON [Visionnements] ([FilmId]);
GO

CREATE INDEX [IX_Visionnements_UtilisateurId] ON [Visionnements] ([UtilisateurId]);
GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20251213002306_InitialCreate', N'8.0.0');
GO

COMMIT;
GO

