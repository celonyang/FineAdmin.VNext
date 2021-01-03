# FineAdmin.VNext

#### 介绍

  -使用ok-admin+ASP.NET CORE3.1 搭建的通用权限(RBAC)后台管理系统<br>
  -支持MYSQL(支持),SQLSERVER(支持)，ORACLE切换(未测试)<br>
  -支持分布式缓存<br>
  -支持Autofac属性注入<br>
  -快速开发,简单封装<br>

   基本上保证了[FineAdmin.Mvc](https://gitee.com/Liu_Cabbage/FineAdmin.Mvc.git)的项目结构，除了调用HttpContext的类放到来web目录外，其他代码与[FineAdmin.Mvc](https://gitee.com/Liu_Cabbage/FineAdmin.Mvc.git)项目结构一致，方便基于[FineAdmin.Mvc](https://gitee.com/Liu_Cabbage/FineAdmin.Mvc.git)的项目的移植。仓储层、业务层等都采用Standard2.0类库，方便UI层支持net framework和net core。

#### 技术选型

ASP.NET CORE3.1 Dapper DapperExtensions Autofac Redis Nlog Quartz log4net smobiler6.1

#### 特别感谢

1. [Layui](https://www.layui.com)
2. [ok-admin](https://gitee.com/bobi1234/ok-admin)
3. [FineAdmin.Mvc](https://gitee.com/Liu_Cabbage/FineAdmin.Mvc.git)
4. [Zl.WebApp][https://gitee.com/Zl819058637/Zl.WebApp.git]

#### 开源协议

[GPL-3.0](https://gitee.com/Liu_Cabbage/FineAdmin.Mvc/blob/master/LICENSE)

## 下一步

1、改造多数据库支持，方便外部系统集成

2、集成移动端开发Smobiler

