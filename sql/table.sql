use fixture_manage;
-- 夹具定义表
drop table if exists fixture_tongs_definition;
create table fixture_tongs_definition (
    id bigint auto_increment primary key,
    workcell_id bigint not null,
    family_id bigint not null,
    code varchar(31) not null,
    name varchar(31) not null,
    model varchar(255) not null,
    part_no varchar(255) not null,
    userd_for varchar(255) default null,
    upl bigint not null,
    owner_id bigint not null,
    remark varchar(255) default null,
    pm_period bigint not null,
    rec_on datetime not null,
    rec_by bigint not null,
    edit_on datetime default null,
    edit_by bigint default null,
    gmt_create datetime default null,
    gmt_modified datetime default null,
    is_deleted tinyint default '0'
);

-- 夹具实体表
drop table if exists fixture_tongs_entity;
create table fixture_tongs_entity (
    id bigint primary key auto_increment,
    code varchar(31) not null,
    seq_id bigint not null,
    bill_no varchar(31) not null,
    reg_date datetime not null,
    userd_count bigint not null,
    location varchar(31) not null,
    pic_url varchar(255) default null,
    production_date datetime not null,
    document_date datetime not null,
    operator_id bigint not null,
    is_scrapped tinyint unsigned default '0',
    status tinyint unsigned default '0',
    repair_counts bigint not null,
    last_repair_on datetime default null,
    expexted_life bigint not null,
    workcell_id bigint not null,
    gmt_create datetime not null,
    gmt_modified datetime not null,
    is_deleted tinyint default '0'
);

-- 工作部门
drop table if exists fixture_workcell;
create table fixture_workcell (
    id bigint primary key auto_increment,
    name varchar(31) not null,
    gmt_create datetime default null,
    gmt_modified datetime default null,
    is_deleted tinyint unsigned default '0'
);

-- 系统用户
drop table if exists fixture_user;
create table fixture_user (
    id bigint primary key auto_increment,
    name varchar(31) not null,
    user_photo varchar(255) default null,
    role_id tinyint default '0',
    password varchar(255) not null,
    workcell_id bigint default null,
    email varchar(255) not null,
    work_no varchar(31) not null,
    gmt_create datetime default null,
    gmt_modified datetime default null,
    is_deleted tinyint default '0'
);

-- 系统角色
drop table if exists fixture_role;
create table fixture_role (
    id bigint primary key auto_increment,
    name varchar(63) not null,
    gmt_create datetime default null,
    gmt_modified datetime default null,
    is_deleted tinyint unsigned default '0'
);


-- 生产线
drop table if exists fixture_production_line;
create table fixture_production_line (
    id bigint primary key auto_increment,
    name varchar(31) not null,
    workcell_id bigint not null,
    gmt_create datetime not null,
    gmt_modified datetime not null,
    is_deleted tinyint unsigned default '0'
);

-- 维修记录表
drop table if exists fixture_repair_record;
create table fixture_repair_record (
    id bigint primary key auto_increment,
    repair_on datetime default null,
    tong_id bigint not null,
    description varchar(255) default null,
    repair_over_on datetime default null,
    workcell_id bigint not null,
    gmt_create datetime default null,
    gmt_modified datetime default null,
    is_deleted tinyint unsigned default '0'
);

-- 进出库记录
drop table if exists fixture_inventory_records;
create table fixture_inventory_records (
    id bigint primary key auto_increment,
    log_on datetime default null,
    log_by bigint not null,
    handled_by bigint not null,
    in_or_out tinyint not null,
    production_line bigint not null,
    tong_id bigint not null,
    location varchar(31) not null,
    workcell_id bigint not null,
    gmt_create datetime default null,
    gmt_modified datetime default null,
    is_deleted tinyint unsigned default '0'
);

-- 夹具采购表
drop table if exists fixture_purchase;
create table fixture_purchase(
    id bigint primary key auto_increment,
    billno varchar(31) not null,
    operator_id bigint not null,
    log_on datetime not null,
    tong_id bigint not null,
    workcell_id bigint not null,
    gmt_create datetime default null,
    gmt_modified datetime default null,
    is_deleted tinyint unsigned default '0'
);

-- 夹具报废表
drop table if exists fixture_scrap;
create table fixture_scrap (
    id bigint primary key auto_increment,
    operator_id bigint not null,
    log_on datetime default null,
    tong_id bigint not null,
    description varchar(255) default null,
    workcell_id bigint not null,
    gmt_create datetime default null,
    gmt_modified datetime default null,
    is_deleted tinyint unsigned default '0'
);