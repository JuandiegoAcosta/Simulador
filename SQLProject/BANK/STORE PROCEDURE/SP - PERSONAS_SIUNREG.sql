USE [Bank]
GO

CREATE PROCEDURE PERSONAS_SIUNREG
	@CORREO VARCHAR(150)
	,@ESTADO BIT
	,@NOMBRE VARCHAR(50)
	,@APELLIDOS VARCHAR(100)
	,@FECHA_NACIMIENTO DATE
	,@TELEFONO VARCHAR(15)
	,@NRO_DOCUMENTO INT
	,@TIPO_DOCUMENTO INT
	,@AUDI_USERCREADOR VARCHAR(50)
AS

DECLARE @PERSONAID INT = ISNULL((SELECT MAX(PERSONAID) FROM PERSONAS), 0) + 1

INSERT INTO [dbo].[PERSONAS]
           (PERSONAID
		   ,[CORREO]
           ,[ESTADO]
           ,[NOMBRE]
           ,[APELLIDOS]
           ,[FECHA_NACIMIENTO]
           ,[TELEFONO]
           ,[NRO_DOCUMENTO]
           ,[TIPO_DOCUMENTO]
           ,[AUDI_USERCREADOR])
     VALUES
           ( @PERSONAID
			,@CORREO
			,@ESTADO
			,@NOMBRE
			,@APELLIDOS
			,@FECHA_NACIMIENTO
			,@TELEFONO
			,@NRO_DOCUMENTO
			,@TIPO_DOCUMENTO
			,@AUDI_USERCREADOR)
GO
