@ECHO *******************************************************************
@ECHO \\10.31.0.212\C$\Program Files (x86)\Microsoft SQL Server\120\DAC\bin\SqlPackage.exe /Action:Import /sf:"C:\BatchsAzureBackup\educonnectDevdb.bacpac" /tsn:10.31.0.212 /tdn:educonnectDevdb /tu:rm /tp:rm

"\\10.31.0.212\C$\Program Files (x86)\Microsoft SQL Server\120\DAC\bin\SqlPackage.exe" /Action:Import /tcs:"Data Source=10.31.0.212;Initial Catalog=educonnectDevdb;User Id=rm;Password=" /sf:"educonnectDevdb-16-10-17-13.22.bacpac"

@ECHO ***********************FINALIZADO**********************************

@ECHO ***********************BRENO BATISTA*******************************
"\\10.31.0.212\C$\Program Files (x86)\Microsoft SQL Server\120\DAC\bin\SqlPackage.exe" /Action:Import /tcs:"Data Source=10.31.0.212;Initial Catalog=educonnectDevdb;User Id=rm;Password=" /sf:"educonnectDevdb-16-10-17-13.22.bacpac"
