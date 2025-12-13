-- ============================================================
-- SCRIPT 2: INSERTION DES DONNÉES DE BASE
-- VisionFlix - Données initiales
-- ============================================================

USE VisionFlixDB;
GO

-- ============================================================
-- ÉTAPE 1: PLANS D'ABONNEMENT
-- ============================================================

INSERT INTO PlansAbonnement (Nom, Prix, Description, EstActif)
VALUES 
    ('Basique', 9.99, 'Accès limité aux films', 1),
    ('Standard', 14.99, 'Accès illimité aux films, 1 écran', 1),
    ('Premium', 19.99, 'Accès illimité aux films, 4 écrans, HD', 1);
GO

PRINT 'Plans d''abonnement insérés: ' + CAST(@@ROWCOUNT AS VARCHAR);
GO

-- ============================================================
-- ÉTAPE 2: CATÉGORIES
-- ============================================================

INSERT INTO Categories (Nom, Description, EstActive)
VALUES 
    ('Action', 'Films d''action et d''aventure', 1),
    ('Comédie', 'Films humoristiques', 1),
    ('Drame', 'Films dramatiques', 1),
    ('Science-Fiction', 'Films de science-fiction', 1),
    ('Thriller', 'Films à suspense', 1),
    ('Horreur', 'Films d''horreur', 1),
    ('Romance', 'Films romantiques', 1),
    ('Documentaire', 'Documentaires', 1),
    ('Crime', 'Films policiers et criminels', 1),
    ('Animation', 'Films d''animation', 1);
GO

PRINT 'Catégories insérées: ' + CAST(@@ROWCOUNT AS VARCHAR);
GO

-- ============================================================
-- ÉTAPE 3: LANGUES
-- ============================================================

INSERT INTO Langues (Nom, Code, EstActive)
VALUES 
    ('Français', 'fr', 1),
    ('Anglais', 'en', 1)
GO

PRINT 'Langues insérées: ' + CAST(@@ROWCOUNT AS VARCHAR);
GO

-- ============================================================
-- ÉTAPE 4: UTILISATEUR ADMINISTRATEUR PAR DÉFAUT
-- ============================================================

INSERT INTO Utilisateurs (
    NomUtilisateur,
    Nom, 
    Prenom, 
    Email, 
    Telephone, 
    Adresse, 
    MotDePasse, 
    EstAdministrateur, 
    DateInscription,
    Langue,
    NotificationsActivees
)
VALUES (
    'admin',
    'admin',
    'admin',
    'admin@visionflix.com',
    '514-000-0000',
    '123 Rue Admin, Montréal, QC',
    'admin123', 
    1, 
    GETDATE(),
    'fr',
    0
);
GO

PRINT 'Administrateur créé: ' + CAST(@@ROWCOUNT AS VARCHAR);
GO

-- ============================================================
-- ÉTAPE 5: FILMS DE DÉMONSTRATION
-- ============================================================

INSERT INTO Films (Titre, Realisateur, Annee, Genre, Duree, Langue, Synopsis, ImageUrl, Prix, Note, EstDisponible, DateAjout)
VALUES 
(
    'Pulp Fiction', 
    'Quentin Tarantino', 
    1994, 
    'Crime', 
    154, 
    'Anglais',
    'L''histoire entrelace les destins de deux tueurs à gage philosophes, d''un boxeur endetté, de la femme d''un gangster, et d''un couple de braqueurs...', 
    'pulp_fiction.jpg', 
    9.99, 
    4.5, 
    1, 
    GETDATE()
),
(
    'Le Fabuleux Destin d''Amélie Poulain', 
    'Jean-Pierre Jeunet', 
    2001, 
    'Romance', 
    122, 
    'Français',
    'Amélie Poulain, une jeune serveuse à Montmartre à l''imagination fertile, décide de consacrer sa vie à semer le bonheur...', 
    'amelie_poulain.jpg', 
    9.99, 
    4.2,
    1, 
    GETDATE()
),
(
    'Inception', 
    'Christopher Nolan', 
    2010, 
    'Science-Fiction', 
    148, 
    'Anglais',
    'Dom Cobb est un voleur expérimenté, le meilleur dans l''art dangereux de l''extraction : voler les secrets...', 
    'inception.jpg', 
    11.99, 
    4.8,
    1, 
    GETDATE()
),
(
    'La La Land', 
    'Damien Chazelle', 
    2016, 
    'Romance', 
    128, 
    'Anglais',
    'À Los Angeles, Mia, une actrice en devenir, et Sebastian, un passionné de jazz, tombent amoureux...', 
    'la_la_land.png', 
    9.99, 
    4.0,
    1, 
    GETDATE()
),
(
    'Parasite', 
    'Bong Joon-ho', 
    2019, 
    'Thriller', 
    132, 
    'Coréen',
    'La famille Ki-taek, sans emploi, s''intéresse au train de vie de la riche famille Park et élabore un stratagème...', 
    'parasite.jpg', 
    10.99, 
    4.6,
    1, 
    GETDATE()
),
(
    'The Shawshank Redemption', 
    'Frank Darabont', 
    1994, 
    'Drame', 
    142, 
    'Anglais',
    'Accusé du meurtre de sa femme et de son amant, le banquier Andy Dufresne est condamné à la prison à vie à Shawshank...', 
    'the_shawshank_redemption.jpg', 
    8.99, 
    4.9, 
    1, 
    GETDATE()
),
(
    'Interstellar', 
    'Christopher Nolan', 
    2014, 
    'Science-Fiction', 
    169, 
    'Anglais',
    'Alors que la Terre est dévastée par la sécheresse et les tempêtes de poussière, un groupe d''explorateurs...', 
    'interstellar.jpg', 
    10.99, 
    4.5,
    1, 
    GETDATE()
),
(
    'The Godfather', 
    'Francis Ford Coppola', 
    1972, 
    'Crime', 
    175, 
    'Anglais',
    'Ce chef-d''œuvre épique suit le patriarche vieillissant d''une famille de la mafia new-yorkaise...', 
    'the_godfather.jpg', 
    14.99, 
    5.0,
    1, 
    GETDATE()
);
GO

