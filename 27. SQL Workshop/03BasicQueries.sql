SELECT
	c.name,
	c.contact_email
FROM
	Clients c


SELECT
	invoice_id,
	c.name,
	issue_date,
	due_date,
	amount,
	tax_rate,
	vat,
	discount,
	currency,
	status
FROM
	Invoices i
JOIN
	Clients c ON c.client_id = i.client_id
WHERE
	i.status = 'Overdue'


SELECT
	*
FROM
	Payments
WHERE
	payment_method = 'Bank Transfer'


SELECT
	SUM(amount) AS TotalRevenue
FROM
	Invoices
WHERE
	status = 'Paid'


SELECT
	status,
	COUNT(invoice_id) AS Invoices
FROM
	Invoices
GROUP BY status