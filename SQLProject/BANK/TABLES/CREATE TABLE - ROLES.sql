USE [Bank]
GO
CREATE TABLE ROLES
(
	ROLID INT NOT NULL,
	ROLPADREID INT NOT NULL,
	DESCRIPCION VARCHAR(50) NOT NULL,
	ESTADO BIT DEFAULT 1,
	AUDI_FECHCREACION DATETIME DEFAULT GETDATE(),
	AUDI_USERCREADOR VARCHAR(50) NOT NULL,
	AUDI_FECHMODIFICACION DATETIME  NULL,
	AUDI_USERMODIFICADOR VARCHAR(50) NULL
);