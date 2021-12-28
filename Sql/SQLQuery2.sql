select * from Customers -- *'ın olduğu kısma istediğimiz tabloları yazabiliriz, şu anda bütün tabloları listeler.
select CompanyName,CustomerID from Customers

select * from Customers where City = 'London' -- Where komutu ile koşulumuzu yazabiliriz.

select * from Products where categoryID=1 or categoryID=3 -- YA DA 
select * from Products where categoryID=1 and UnitPrice>=10 -- VE

select * from Products order by ProductName -- Ürün ismine göre sırala
select * from Products order by UnitPrice -- Default değeri asc yani ascending(ARTAN)'dir.
select * from Products order by UnitPrice desc -- Ddescending = AZALAN

select count(*) Adet from Products where CategoryID=1 --Tablonun tamamnında kaç adet ürün olduğunu yazdırır.


select CategoryID,count(*) from Products group by CategoryID --Kategrosine göre gruplandırıp kaçar ürün olduğunu yazdırır.

select CategoryID,count(*) from Products group by CategoryID having count(*)<10 -- 10'dan az çeşide sahip kategorileri yazdırır.

select CategoryID,count(*) from Products where UnitPrice>20  group by CategoryID having count(*)<10 -- Fiyatı 20'den fazla ve 10'dan az çeşide sahip kategorileri yazdırır.


----------------------- İNNER JOİN İKİ TABLOMUZDA DA EŞLEŞENLERİ BİR ARAYA GETİRİR. EŞLEŞMEYEN DATALARI GETİRMEZ ---------------------------------------------
select Products.ProductID,Products.ProductName,Products.UnitPrice,Categories.CategoryName -- Kolonlarımızı seçtik.
from Products inner join Categories -- İnner Join ile istediğimiz tabloları seçtik.
on Products.CategoryID=Categories.CategoryID -- On ile seçtiğimiz tablolarda istediğimiz şartımızı yazdık.
where Products.UnitPrice>10 -- Gibi bir şart ya da Group By da ekleyebiliriz sonuna.

select * from Products p inner join [Order Details] od on p.ProductID=od.ProductID
inner join Orders o -- Şeklinde bir inner join daha da eklenebilir..
on o.OrderID=od.OrderID
------------------------ LEFT JOİN SOLDAKİ TABLODA OLAN AMA SAĞDAKİNDE OLMAYANLARI GETİRİR ----------------------------------------------------------------------
select * from Customers c left join Orders o on c.CustomerID=o.CustomerID
where o.CustomerID is null -- Müşteriler arasında sipariş vermemiş kişileri listeler..




