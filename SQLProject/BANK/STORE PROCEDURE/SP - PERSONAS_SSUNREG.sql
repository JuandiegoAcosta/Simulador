USE [Bank]
GO

CREATE PROCEDURE PERSONAS_SUUNREG
	 @PERSONAID INT = NULL
	,@NOMBRE VARCHAR(50) = NULL
	,@APELLIDOS VARCHAR(100) = NULL
	,@NRO_DOCUMENTO INT = NULL
AS

SELECT [PERSONAID]
      ,[CORREO]
      ,[ESTADO]
      ,[NOMBRE]
      ,[APELLIDOS]
      ,[FECHA_NACIMIENTO]
      ,[TELEFONO]
      ,[NRO_DOCUMENTO]
      ,[TIPO_DOCUMENTO]
      ,[AUDI_FECHCREACION]
      ,[AUDI_USERCREADOR]
      ,[AUDI_FECHMODIFICACION]
      ,[AUDI_USERMODIFICADOR]
  FROM [dbo].[PERSONAS]
  WHERE [PERSONAID] = ISNULL(@PERSONAID,[PERSONAID])
	AND [NOMBRE] = ISNULL(CONCAT(@NOMBRE,'%'),[NOMBRE])
	AND [APELLIDOS] = ISNULL(CONCAT(@APELLIDOS,'%'),[APELLIDOS])
	AND [NRO_DOCUMENTO] = ISNULL(CONCAT(@NRO_DOCUMENTO,'%'),[NRO_DOCUMENTO])
GO



