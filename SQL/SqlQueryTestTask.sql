SELECT Products.product_name, productsCategories.category_name
FROM Products LEFT JOIN (
	SELECT Products_Categories.product_id, Categories.category_name
	FROM Products_Categories INNER JOIN  Categories
	ON Products_Categories.category_id = Categories.category_id
) AS productsCategories
ON Products.product_id = productsCategories.product_id