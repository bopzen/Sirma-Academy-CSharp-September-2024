SELECT
	*
FROM
	Transactions
WHERE
	supplier_id = 3


SELECT TOP 3
	*
FROM
	Employees
ORDER BY salary DESC


SELECT
	*
FROM
	Employees
WHERE
	hire_date >= DATEADD(YEAR, -3, GETDATE());


SELECT 
	SUM(Amount) AS TotalExpenses
FROM
	Transactions
WHERE
	transaction_type = 'Expense'
	AND
	transaction_date BETWEEN '2024-01-01' AND '2024-01-31';


SELECT
	MAX(Amount) AS MaxAmount,
	MIN(Amount) AS MinAmount
FROM
	Invoices