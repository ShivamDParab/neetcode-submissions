-- Write your query below
WITH customerIds AS ( SELECT customer_id FROM orders)

SELECT name from customers
WHERE id NOT IN (SELECT customer_id FROM customerIds)