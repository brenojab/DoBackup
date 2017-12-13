@ECHO *******************************************************************
@ECHO "\\10.31.0.212\C$\Program Files (x86)\Microsoft SQL Server\120\DAC\bin\SqlPackage.exe" /Action:Import /tsn:tcp:localhost /tdn:bkpAzure /tu:rm /tp:rm /sf:"educonnectDevdb-16-10-2017-09.08-TOTVSDEVBATISTA.bacpac" /p:DatabaseEdition=Premium /p:DatabaseServiceObjective=P4 /p:Storage=File"

@ECHO ***********************FINALIZADO**********************************

@ECHO ***********************SQL 2014 MAQ BRENO**************************

"C:\Program Files (x86)\Microsoft SQL Server\140\DAC\bin\sqlpackage.exe" /Action:Export /ssn:tcp:educonnectdevdbserver.database.windows.net,1433 /sdn:educonnectDevdb /su:totvs /sp: /tf:BKP_educonnectDevdb_%time:~0,2%%time:~3,2%%time:~6,2%_%date:~-10,2%%date:~-7,2%%date:~-4,4% /p:Storage=File

@ECHO ***********************FINALIZADO**********************************