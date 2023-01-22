IBM MQ Console using dotnet core version 6.0 

This project demo concept Publisher and Subscriber the use of ibm mq product 

### Docker Setup
1. `$ docker pull ibmcom/mq:latest`
2. `$ docker run --env LICENSE=accept --env MQ_QMGR_NAME=QM1 --volume qm1data:/mnt/mqm --publish 1419:1414 --publish 9445:9443 --name=ibm-mq  --network mq-demo-network --network-alias qmgr --detach --env MQ_APP_PASSWORD=passw0rd ibmcom/mq:latest`

### Setup Project
    ```
    $ dotnet add package CommandDotNet
    $ dotnet add package CommandDotNet.IoC.MicrosoftDependencyInjection
    $ dotnet add package IBMMQDotnetClient
    $ dotnet add package IBMXMSDotnetClient
    $ dotnet add package Microsoft.Extensions.Configuration
    $ dotnet add package Microsoft.Extensions.Configuration.Binder
    $ dotnet add package Newtonsoft.Json
    $ dotnet add package Microsoft.Extensions.DependencyInjection
    $ dotnet add package Microsoft.Extensions.Configuration.Json
    ```
### Testing
* Publisher / Subscriber
    * Terminal 1 - Publisher 
    
      `$ dotnet IbmMQConsole.dll Publisher "Hello World"`
    * Terminal 1 - Subscriber 
    
      `$ dotnet IbmMQConsole.dll Subscriber "dev/"`

* Sender / Listener
    * Terminal 1 - Sender 
    
      `$ dotnet IbmMQConsole.dll Sender "dotnet core"`
    * Terminal 1 - Listener 
    
      `$ dotnet IbmMQConsole.dll Listener -s 60`
