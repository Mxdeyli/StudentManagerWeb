# StudentManagerWeb

使用 Windows、.NET Framework 4.7.2、ASP.NET Web Forms 和 SQL Server。Visual Studio 需要安装 ASP.NET 和 Web 开发工作负载。

1. 创建 SQL Server 数据库并执行 `schema.sql`。在 `UserLogin` 表添加本地演示账户。当前版本沿用原项目的 `UserName` 和明文 `Pwd` 字段。
2. 将 `STUDENTMANAGERWEB_CONNECTION_STRING` 设为该库的连接字符串，然后启动 Visual Studio 或 IIS Express。
3. 打开 `ThreeLayer_project.sln`，还原 NuGet 包后运行，从 `Login.aspx` 登录。登录后可在学生列表新增、修改或删除记录。
