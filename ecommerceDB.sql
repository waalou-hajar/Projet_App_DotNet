Source de données : Microsoft SQL Server
base de donnees  : "ecommerce"
CREATE TABLE Article
(
	[Id] INT NOT NULL PRIMARY KEY, 
    [nom] NVARCHAR(50) NOT NULL, 
    [login] NCHAR(10) NOT NULL, 
    [password] NVARCHAR(50) NOT NULL, 
    [email] NVARCHAR(50) NOT NULL

)
//*********** table Admin**********************//
CREATE TABLE [dbo].[Admin] (
    [Id]         INT           NOT NULL,
    [nomAdmin]   NVARCHAR (50) NULL,
    [emailAdmin] NVARCHAR (50) NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);
//*********** table Client**********************//
CREATE TABLE [dbo].[Client] (
    [Id]       INT           NOT NULL,
    [nom]      NVARCHAR (50) NULL,
    [login]    NCHAR (10)    NULL,
    [password] NVARCHAR (50) NULL,
    [email]    NVARCHAR (50) NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);


//***********table categorie **********************//
CREATE TABLE [dbo].[categorie] (
    [Id]           INT           NOT NULL,
    [nomcategorie] NVARCHAR (50) NULL,
    [nmbrlivre]    INT           NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);
//***********table commande **********************//
CREATE TABLE [dbo].[commande] (
    [Id]           INT           NOT NULL,
    [nomclient]    NVARCHAR (50) NULL,
    [prixcommande] NVARCHAR (50) NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);
//***********table  livers **********************//
CREATE TABLE [dbo].[livres] (
    [Id]        INT           NOT NULL,
    [img]       NVARCHAR (50) NULL,
    [titre]     NVARCHAR (50) NULL,
    [prix]      FLOAT (53)    NULL,
    [quantite]  INT           NULL,
    [categorie] NVARCHAR (50) NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);

//***********table panier **********************//
CREATE TABLE [dbo].[panier] (
    [Id]        INT           NOT NULL,
    [nomcl]     NVARCHAR (50) NULL,
    [prixtotal] REAL          NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);