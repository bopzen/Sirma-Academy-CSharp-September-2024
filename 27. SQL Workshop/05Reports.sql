CREATE VIEW InvoicePayments AS
SELECT 
    i.invoice_id,
    i.client_id,
    i.issue_date,
    i.due_date,
    i.amount AS invoice_amount,
    i.tax_rate,
    i.vat,
    i.discount,
    i.currency,
    i.status,
    p.payment_id,
    p.payment_date,
    p.amount AS payment_amount,
    p.payment_method,
    p.bank_name,
    p.transaction_id
FROM Invoices i
LEFT JOIN Payments p ON i.invoice_id = p.invoice_id

SELECT * FROM InvoicePayments


SELECT 
	MONTH(payment_date) AS [Month],
	SUM(amount) AS TotalRevenue
FROM
	Payments
WHERE
	YEAR(payment_date) = 2024
GROUP BY MONTH(payment_date)
ORDER BY [Month]


SELECT
	c.client_id,
	c.Name,
	SUM(p.Amount) AS TotalAmountPaid
FROM
	Payments p
JOIN Invoices i ON i.invoice_id = p.invoice_id
JOIN Clients c ON c.client_id = i.client_id
GROUP BY c.client_id, c.Name


SELECT
	invoice_id,
	client_id,
	issue_date,
	due_date,
	amount,
	tax_rate,
	amount * tax_rate / 100 as VAT,
	discount,
	currency,
	status
FROM
	Invoices


SELECT
	payment_method,
	SUM(Amount) as TotalAmounts
FROM
	Payments
GROUP BY payment_method


CREATE PROCEDURE GetInvoicesByClient
	@Id INT
AS
BEGIN
	SELECT *
	FROM
		Invoices
	WHERE
		client_id = @Id
END;

EXEC GetInvoicesByClient 1


SELECT
	(SELECT COUNT(invoice_id) FROM Invoices WHERE status = 'Overdue') * 100.0 / COUNT(invoice_id) AS PercentageOverdueInvoices
FROM
	Invoices


SELECT TOP 3
	c.client_id,
	c.name,
	SUM(p.amount) AS TotalAmount
FROM
	Payments p
JOIN
	Invoices i ON i.invoice_id = p.invoice_id
JOIN
	Clients c on c.client_id = i.client_id
GROUP BY c.client_id, c.name
ORDER BY TotalAmount DESC


CREATE INDEX idx_invoice_id ON Payments(invoice_id)