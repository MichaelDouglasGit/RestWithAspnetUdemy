CREATE TABLE BOOKS (
  id INT identity(1,1) PRIMARY KEY,
  author varchar(100),
  launch_date datetime NOT NULL,
  price decimal(30,2) NOT NULL,
  title varchar(100)
) 
