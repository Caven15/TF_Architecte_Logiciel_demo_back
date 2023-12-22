CREATE PROCEDURE [dbo].[SPUtilisateurRegister]
	@Nom NVARCHAR(80),
	@Prenom NVARCHAR(80),
	@Email NVARCHAR(100),
	@DateNAissance DATE
AS

BEGIN
	INSERT INTO [Utilisateur] (Nom, Prenom, Email, DateNaissance)
	VALUES (TRIM(@Nom), TRIM(@Prenom), TRIM(@Email), @DateNaissance)
END