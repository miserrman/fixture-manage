drop database if exists fixture_manage;
drop user if exists fixture_user;
create database fixture_manage;
create user 'fixture_user'@'%' identified by 'fixture123456';
grant all privileges on fixture.* to 'fixture_user'@'%';
flush privileges;


















