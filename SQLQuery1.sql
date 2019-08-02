create database shop;


create table login (
    username varchar(20),
    password varchar(50),
 );
 
 create table orders(
  order_no numeric (10,0) identity(1,1),
  date varchar(50),
  f_name varchar(50),
  l_name varchar(50),
  p_number varchar(50),
  address varchar(50),
  making_charge numeric(12,5),
  sold_tottal numeric(12,5),
  payment numeric(12,5),
  due numeric(12,5),
  product1 varchar (50),
  quantity1 varchar (50),
  prize1 numeric(12,5),
  product2 varchar (50),
  quantity2 varchar (50),
  prize2   numeric(12,5),
  product3 varchar (50),
  quantity3 varchar (50),
  prize3   numeric(12,5),
  
);

create table employee(
id_no varchar (50),
f_name varchar (50),
l_name varchar (50),
father_name varchar(50),
mother_name varchar(50),
mobail_num1 varchar (50),
mobail_num2 varchar(50),
present_address varchar(50),
parmanent_address varchar(50),
nid_no varchar(50),
blood_group varchar(50),
date_birth varchar(50),
sallery numeric(12,5),
given_sallery numeric(12,5),
due numeric(12,5),
image varchar(50),
primary key(id_no),
);

select* from employee
create table daily_cost(
day varchar(50),
expensed varchar (50),
employee_id varchar(50) foreign key references dbo.employee,
tottal varchar(50),
extra_income numeric(12,5),
due_today numeric(12,5),
sold_today numeric(12,5),
fund_today numeric(12,5)
);


create table monthly_cost(
month varchar(50),
expensed varchar (50),
tottal varchar(50),
employee_id varchar(50) foreign key references dbo.employee,
extra_income numeric(12,5),
due_month numeric(12,5),
sold_month numeric(12,5),
fund_month numeric(12,5)
);

create table yearly_cost(
year varchar(50),
expensed varchar (50),
tottal varchar(50),
employee_id varchar(50) foreign key references dbo.employee,
extra_income numeric(12,5),
due_month numeric(12,5),
sold_month numeric(12,5),
fund_month numeric(12,5)
);



