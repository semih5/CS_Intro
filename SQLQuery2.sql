--select
--Select * from Customers
--Select ContactName Adi, CompanyName Sirket, City Sehir from Customers
--(asc)ascending:Artana göre, (desc)descending:Azalana göre

--Select * from Customers where City = 'London'
--select * from Products where CategoryID=1 or CategoryID=3

--select count(*) from Products
--select categoryID, count(*) from products group by CategoryID
select categoryID, count(*) from products group by CategoryID having count(*)<10
