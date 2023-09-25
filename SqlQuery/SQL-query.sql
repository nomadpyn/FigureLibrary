Select "ProductName", "CategoryName"
From Products AS PR
LEFT JOIN ProductCategories AS PC ON PC.ProductId = PR.Id
LEFT JOIN Categories AS CT ON CT.Id = PC.CategoryId