# MessageCenter

Message Center for IM, email, sms and others

## project folder structure

```plaintext
/MessageCenterApplication/
|-- /src/
|   |-- /MessageCenter.Core/                # 核心业务逻辑层
|   |   |-- MessageCenter.Core.csproj
|   |   |-- /Models/
|   |   |-- /Interfaces/
|   |   |-- /Services/
|   |-- /MessageCenter.Infrastructure/      # 基础设施层，如数据库访问、外部服务集成
|   |   |-- MessageCenter.Infrastructure.csproj
|   |   |-- /Data/
|   |   |-- /Repositories/
|   |   |-- /ExternalServices/
|   |-- /MessageCenter.Grpc/                # gRPC服务层
|   |   |-- MessageCenter.Grpc.csproj
|   |   |-- /Protos/
|   |   |-- /Services/
|   |-- /MessageCenter.Api/                 # Web API层
|   |   |-- MessageCenter.Api.csproj
|   |   |-- /Controllers/
|   |   |-- /Configurations/
|   |-- /MessageCenter.MqttClient/          # MQTT客户端项目
|   |   |-- MessageCenter.MqttClient.csproj
|   |   |-- /Client/
|   |-- /MessageCenter.MqttBroker/          # MQTT代理配置和管理
|   |   |-- MessageCenter.MqttBroker.csproj
|   |   |-- /Configurations/
|   |   |-- /Broker/
|-- /tests/                                 # 单元测试和集成测试
|   |-- /MessageCenter.Core.Tests/
|   |   |-- MessageCenter.Core.Tests.csproj
|   |   |-- /UnitTest/
|   |-- /MessageCenter.Infrastructure.Tests/
|   |   |-- MessageCenter.Infrastructure.Tests.csproj
|   |   |-- /IntegrationTest/
|   |-- /MessageCenter.Grpc.Tests/
|   |   |-- MessageCenter.Grpc.Tests.csproj
|   |   |-- /UnitTest/
|   |-- /MessageCenter.Api.Tests/
|   |   |-- MessageCenter.Api.Tests.csproj
|   |   |-- /IntegrationTest/
|-- .gitignore                              # Git 忽略文件
|-- README.md                               # 项目说明文档
|-- LICENSE                                 # 许可证文件
|-- MessageCenterApplication.sln            # 解决方案文件
```

## 解释：

```plaintext
src/：包含所有源代码的目录。
MessageCenter.Core/：核心业务逻辑层，定义消息中心的核心功能和接口。
MessageCenter.Infrastructure/：基础设施层，包括数据访问代码、仓储和对外部服务的集成。
MessageCenter.Grpc/：gRPC服务层，包含服务定义（.proto）和服务实现。
MessageCenter.Api/：Web API层，提供RESTful API接口。
MessageCenter.MqttClient/：MQTT客户端项目，管理消息的发布和订阅。
MessageCenter.MqttBroker/：MQTT代理配置和管理。
tests/：包含所有测试代码的目录，为每个项目提供单元测试和集成测试。
.gitignore：Git忽略文件，用于排除不需要版本控制的文件（例如，编译输出和临时文件）。
README.md：项目的README文档，包括项目介绍、构建指南和使用说明。
LICENSE：项目的许可证文件。
MessageCenterApplication.sln：Visual Studio解决方案文件，包含上述所有项目。
```
