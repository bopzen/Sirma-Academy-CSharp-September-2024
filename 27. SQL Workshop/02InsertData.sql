INSERT INTO Clients (name, contact_email, phone, address) VALUES
('Client A', 'clientA@example.com', '123-456-7890', '123 Main St'),
('Client B', 'clientB@example.com', '987-654-3210', '456 Elm St'),
('Client C', 'clientC@example.com', '555-666-7777', '789 Oak St'),
('Client D', 'clientD@example.com', '111-222-3333', '234 Pine St'),
('Client E', 'clientE@example.com', '444-555-6666', '567 Cedar St'),
('Client F', 'clientF@example.com', '777-888-9999', '890 Birch St'),
('Client G', 'clientG@example.com', '222-333-4444', '123 Spruce St'),
('Client H', 'clientH@example.com', '555-666-7777', '456 Maple St'),
('Client I', 'clientI@example.com', '999-000-1111', '789 Walnut St'),
('Client J', 'clientJ@example.com', '321-654-9870', '101 Oakwood St');
GO

INSERT INTO Suppliers (name, contact_email, phone, address) VALUES
('Supplier A', 'supplierA@example.com', '123-456-7890', '123 Supply St'),
('Supplier B', 'supplierB@example.com', '987-654-3210', '456 Distribution St'),
('Supplier C', 'supplierC@example.com', '555-666-7777', '789 Warehouse St'),
('Supplier D', 'supplierD@example.com', '111-222-3333', '234 Logistics St'),
('Supplier E', 'supplierE@example.com', '444-555-6666', '567 Depot St'),
('Supplier F', 'supplierF@example.com', '777-888-9999', '890 Transport St'),
('Supplier G', 'supplierG@example.com', '222-333-4444', '123 Trade St'),
('Supplier H', 'supplierH@example.com', '555-666-7777', '456 Vendor St'),
('Supplier I', 'supplierI@example.com', '999-000-1111', '789 Merchant St'),
('Supplier J', 'supplierJ@example.com', '321-654-9870', '101 Business St');
GO

INSERT INTO Employees (name, position, salary, hire_date, department) VALUES
('John Doe', 'Accountant', 55000, '2022-05-01', 'Finance'),
('Jane Smith', 'Senior Accountant', 75000, '2019-08-15', 'Finance'),
('Bob Johnson', 'HR Manager', 62000, '2020-10-10', 'HR'),
('Alice White', 'Clerk', 40000, '2021-03-05', 'Finance'),
('Gary Brown', 'Administrator', 50000, '2018-07-20', 'Admin'),
('Susan Black', 'Sales Manager', 65000, '2017-11-25', 'Sales'),
('Charlie Green', 'Procurement Officer', 60000, '2022-02-15', 'Procurement'),
('Nancy Blue', 'Operations Manager', 80000, '2016-12-01', 'Operations'),
('Michael Grey', 'Financial Analyst', 72000, '2019-06-10', 'Finance'),
('Emma Red', 'Bookkeeper', 45000, '2021-09-30', 'Finance');
GO

INSERT INTO Invoices (client_id, issue_date, due_date, amount, tax_rate, vat, discount, currency, status) VALUES
(1, '2024-01-10', '2024-02-10', 1200.50, 10.00, 120.05, 50.00, 'USD', 'Paid'),
(2, '2024-01-15', '2024-02-15', 2500.75, 12.00, 300.09, 100.00, 'EUR', 'Pending'),
(3, '2024-02-01', '2024-03-01', 1800.00, 15.00, 270.00, 80.00, 'USD', 'Overdue'),
(4, '2024-02-10', '2024-03-10', 4500.00, 8.00, 360.00, 200.00, 'GBP', 'Paid'),
(5, '2024-03-05', '2024-04-05', 700.25, 10.00, 70.03, 30.00, 'USD', 'Pending'),
(6, '2024-03-10', '2024-04-10', 1900.00, 12.50, 237.50, 95.00, 'EUR', 'Overdue'),
(7, '2024-04-01', '2024-05-01', 3000.00, 10.00, 300.00, 150.00, 'USD', 'Paid'),
(8, '2024-04-10', '2024-05-10', 850.50, 7.00, 59.54, 25.00, 'GBP', 'Pending'),
(9, '2024-05-05', '2024-06-05', 5000.00, 15.00, 750.00, 250.00, 'EUR', 'Overdue'),
(10, '2024-05-12', '2024-06-12', 1200.00, 10.00, 120.00, 50.00, 'USD', 'Paid'),
(1, '2024-06-01', '2024-07-01', 2300.75, 8.00, 184.06, 85.00, 'EUR', 'Pending'),
(2, '2024-06-15', '2024-07-15', 1750.00, 12.00, 210.00, 95.00, 'GBP', 'Overdue'),
(3, '2024-07-01', '2024-08-01', 2900.00, 10.00, 290.00, 125.00, 'USD', 'Paid'),
(4, '2024-07-08', '2024-08-08', 950.00, 9.00, 85.50, 40.00, 'EUR', 'Pending'),
(5, '2024-08-01', '2024-09-01', 3200.50, 9.00, 288.05, 100.00, 'GBP', 'Overdue'),
(6, '2024-08-10', '2024-09-10', 1400.25, 10.00, 140.03, 60.00, 'USD', 'Paid'),
(7, '2024-09-05', '2024-10-05', 3600.00, 12.00, 432.00, 150.00, 'EUR', 'Pending'),
(8, '2024-09-12', '2024-10-12', 1800.00, 15.00, 270.00, 80.00, 'USD', 'Overdue'),
(9, '2024-10-01', '2024-11-01', 2500.50, 10.00, 250.05, 90.00, 'GBP', 'Paid'),
(10, '2024-10-15', '2024-11-15', 1100.00, 7.00, 77.00, 45.00, 'USD', 'Pending'),
(1, '2024-11-01', '2024-12-01', 4100.75, 12.00, 492.09, 170.00, 'EUR', 'Overdue'),
(2, '2024-11-10', '2024-12-10', 1750.00, 8.00, 140.00, 65.00, 'GBP', 'Paid'),
(3, '2024-12-01', '2025-01-01', 3000.00, 10.00, 300.00, 120.00, 'USD', 'Pending'),
(4, '2024-12-12', '2025-01-12', 850.50, 7.00, 59.54, 25.00, 'GBP', 'Overdue'),
(5, '2025-01-01', '2025-02-01', 2600.00, 15.00, 390.00, 100.00, 'EUR', 'Paid'),
(6, '2025-01-10', '2025-02-10', 1400.25, 10.00, 140.03, 60.00, 'USD', 'Pending'),
(7, '2025-02-05', '2025-03-05', 3300.00, 12.00, 396.00, 140.00, 'GBP', 'Overdue'),
(8, '2025-02-12', '2025-03-12', 1800.00, 15.00, 270.00, 80.00, 'USD', 'Paid'),
(9, '2025-03-01', '2025-04-01', 2800.50, 10.00, 280.05, 110.00, 'EUR', 'Pending'),
(10, '2025-03-15', '2025-04-15', 1000.00, 7.00, 70.00, 35.00, 'GBP', 'Overdue'),
(1, '2025-04-01', '2025-05-01', 3700.75, 9.00, 333.07, 125.00, 'USD', 'Paid'),
(2, '2025-04-10', '2025-05-10', 1950.00, 8.00, 156.00, 70.00, 'EUR', 'Pending'),
(3, '2025-05-01', '2025-06-01', 2400.50, 10.00, 240.05, 90.00, 'GBP', 'Overdue'),
(4, '2025-05-12', '2025-06-12', 1200.00, 12.00, 144.00, 60.00, 'USD', 'Paid'),
(5, '2025-06-01', '2025-07-01', 3500.75, 15.00, 525.09, 175.00, 'EUR', 'Pending'),
(6, '2025-06-15', '2025-07-15', 1750.00, 8.00, 140.00, 65.00, 'GBP', 'Overdue'),
(7, '2025-07-01', '2025-08-01', 2900.00, 10.00, 290.00, 125.00, 'USD', 'Paid'),
(8, '2025-07-08', '2025-08-08', 950.00, 9.00, 85.50, 40.00, 'EUR', 'Pending'),
(9, '2025-08-01', '2025-09-01', 3200.50, 9.00, 288.05, 100.00, 'GBP', 'Overdue'),
(10, '2025-08-10', '2025-09-10', 1400.25, 10.00, 140.03, 60.00, 'USD', 'Paid');


INSERT INTO Transactions (supplier_id, employee_id, transaction_date, amount, transaction_type, category) VALUES
(1, 1, '2024-01-25', 500.00, 'Expense', 'Salary'),
(2, 2, '2024-02-01', 1500.00, 'Expense', 'Office Supplies'),
(3, 3, '2024-02-10', 800.00, 'Expense', 'Software Subscription'),
(4, 4, '2024-03-05', 2500.00, 'Expense', 'Equipment Purchase'),
(5, 5, '2024-03-15', 1000.00, 'Expense', 'Maintenance'),
(6, 6, '2024-04-01', 3200.00, 'Expense', 'Rent'),
(7, 7, '2024-04-10', 450.00, 'Expense', 'Internet Bill'),
(8, 8, '2024-05-05', 2750.00, 'Expense', 'Employee Bonuses'),
(9, 9, '2024-05-12', 1300.00, 'Expense', 'Freelancer Payment'),
(10, 10, '2024-06-01', 2100.00, 'Expense', 'Hardware Upgrade'),
(1, 1, '2024-06-10', 500.00, 'Expense', 'Salary'),
(2, 2, '2024-07-01', 1600.00, 'Expense', 'Office Supplies'),
(3, 3, '2024-07-10', 800.00, 'Expense', 'Software Subscription'),
(4, 4, '2024-08-01', 2500.00, 'Expense', 'Equipment Purchase'),
(5, 5, '2024-08-08', 1000.00, 'Expense', 'Maintenance'),
(6, 6, '2024-09-01', 3200.00, 'Expense', 'Rent'),
(7, 7, '2024-09-10', 450.00, 'Expense', 'Internet Bill'),
(8, 8, '2024-10-05', 2750.00, 'Expense', 'Employee Bonuses'),
(9, 9, '2024-10-12', 1300.00, 'Expense', 'Freelancer Payment'),
(10, 10, '2024-11-01', 2100.00, 'Expense', 'Hardware Upgrade');

INSERT INTO Payments (invoice_id, payment_date, amount, payment_method, bank_name, transaction_id) VALUES
(1, '2024-02-05', 1200.50, 'Bank Transfer', 'Bank A', 1),
(2, '2024-02-12', 2500.75, 'Credit Card', 'Bank B', 2),
(3, '2024-03-05', 1800.00, 'Cash', 'Bank C', 3),
(4, '2024-03-15', 4500.00, 'Bank Transfer', 'Bank A', 4),
(5, '2024-04-05', 700.25, 'Credit Card', 'Bank B', 5),
(6, '2024-04-15', 1900.00, 'Bank Transfer', 'Bank A', 6),
(7, '2024-05-01', 3000.00, 'Cash', 'Bank C', 7),
(8, '2024-05-12', 850.50, 'Bank Transfer', 'Bank A', 8),
(9, '2024-06-01', 5000.00, 'Credit Card', 'Bank B', 9),
(10, '2024-06-10', 1200.00, 'Cash', 'Bank C', 10),
(11, '2024-07-01', 2300.75, 'Bank Transfer', 'Bank A', 11),
(12, '2024-07-10', 1750.00, 'Credit Card', 'Bank B', 12),
(13, '2024-08-01', 2900.00, 'Cash', 'Bank C',13),
(14, '2024-08-08', 950.00, 'Bank Transfer', 'Bank A', 14),
(15, '2024-09-01', 3200.50, 'Credit Card', 'Bank B', 15),
(16, '2024-09-10', 1400.25, 'Bank Transfer', 'Bank A', 16),
(17, '2024-10-05', 3600.00, 'Cash', 'Bank C', 17),
(18, '2024-10-12', 1800.00, 'Bank Transfer', 'Bank A', 18),
(19, '2024-11-01', 2500.50, 'Credit Card', 'Bank B', 19),
(20, '2024-11-10', 1100.00, 'Bank Transfer', 'Bank A', 20);