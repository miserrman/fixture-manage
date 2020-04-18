## 每日一骚话
#### 2020-04-18 —— llh
##### 更改
1. 添加日志类（LogHelper)
    ```
    // 使用方法
    using TongManage.Utils;
    LogHelper.WriteLog(typeof(String), "test"); // 将日志写入 ./log/AT_date.log 下
    ```
##### BUG
1. 修复 xml 文件 workcellId 拼写错误
---
#### 2020-04-14 —— llh
##### 更改
1. 修改数据库结构（fixture_purchase），添加 code, def_id, seq_id 字段，删除 tong_id 字段。
    ```
    alter table fixture_purchase add code varchar(31);
    alter table fixture_purchase add seq_id bigint(5);
    alter table fixture_purchase add def_id bigint(9);
    alter table fixture_purchase drop column tong_id;
    ```
---
#### 2020-04-13 —— llh
##### 更改
1. 修改数据库表结构（Purchase，Scrap，Repair_Record），为每个表添加 **status** 字段。状态的具体含义还需定义。
    可以直接在原先的数据库上运行以下命令：
    ```
    alter table fixture_purchase add status int;
    alter table fixture_scrap add status int;
    alter table fixture_repair_record add status int;
    ```
2. 添加三个请求方法和三个回应方法（个人认为 6 个方法可以合并为 3 个）
3. 更改工夹具状态
##### BUG
1. 修复 PUT 方法与 DELETE 方法无法访问
---
有两个前端界面模板
1、gentelella文件（我选这个修改了一部分）
2、startbootstrap-sb-admin-2文件（看看感觉不太合适，没有修改 ）
 
