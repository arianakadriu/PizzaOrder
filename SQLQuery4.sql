USE [PizzaOrderDB]
GO

DECLARE	@return_value Int

EXEC	@return_value = [dbo].[GetCustByAddress]

SELECT	@return_value as 'Return Value'

GO
