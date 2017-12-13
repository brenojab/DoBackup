@ECHO sqlcmd -S . -d teste -U rm -i "C:\users\breno.batista\script.sql" -o "C:\users\breno.batista\testeSQL.log"



runas.exe /user:bh01\breno.batista cmd.exe
sqlcmd -S . -d teste  -i "C:\users\breno.batista\script.sql" -o "C:\users\breno.batista\testeSQL.log"
pause