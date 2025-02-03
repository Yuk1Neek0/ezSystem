CREATE TABLE users
(
	id INT PRIMARY KEY IDENTITY(1,1),
	username VARCHAR(MAX) NULL,
	password VARCHAR(MAX) NULL,
	status VARCHAR(MAX) NULL
);

SELECT * FROM users
WHERE username = 'admin' AND password='admin123' AND status='Active'

INSERT INTO users(username,password,status) VALUES
('admin','admin123','open')

UPDATE users
SET status = 'Active'
WHERE username = 'admin'