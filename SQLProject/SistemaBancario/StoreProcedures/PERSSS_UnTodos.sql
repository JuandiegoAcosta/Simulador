
CREATE PROCEDURE PERSSS_UnTodos
@NRO_DOCUMENTO VARCHAR(15) = NULL
AS 
SELECT NroDocumento, Apellidos, Nombres
FROM Persona
WHERE NroDocumento LIKE ISNULL(@NRO_DOCUMENTO + '%', NroDocumento)

