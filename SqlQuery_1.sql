

SELECT p.Name as 'Имя продукта', c.Name as 'Имя категории'
FROM [dbo].[Products] as p
LEFT JOIN [dbo].[Category] as c on c.ID = p.CategoryID