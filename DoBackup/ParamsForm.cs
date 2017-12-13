using DoBackup.Classes;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoBackup
{
  public partial class ParamsForm : Form
  {
    public ParamsForm()
    {
      InitializeComponent();
    }

    private void btnSalvar_Click(object sender, EventArgs e)
    {
      var file = new ParamsFile()
      {
        //string _sqlPackageEXE = @"\\10.31.0.212\C$\Program Files (x86)\Microsoft SQL Server\120\DAC\bin\SqlPackage.exe";
        SqlPackageEXELocation = @"C:\Program Files (x86)\Microsoft SQL Server\140\DAC\bin\sqlpackage.exe",
        // File args
        TargetBacpacPath = @"C:\BatchsAzureBackup\",

        // Client args
        GUID = "TOTVSDEVBATISTA",

        // Azure Database args
        AzureServerName = @"tcp:educonnectdevdbserver.database.windows.net,1433",
        AzureDBName = @"educonnectDevdb",
        AzureDBUser = @"totvs",
        AzureDBPassword = @"",

        // Client Database args
        SqlServerName = @"10.31.0.212",
        SqlDBName = @"educonnectDevdb",
        SqlDBUser = @"totvs",
        SqlDBPassword = @"",

        // Folder args
        SqlClientBackup = @"C:\Temp\Azure\ClientBKP",
        SqlFTPClientBackup = @"C:\Temp\Azure\FTP",


        // SQLPackage args
        ExportAction = @"Export",
        ImportAction = @"Import",
        DBFilename = "educonnectDevdbBKP",

        DateTimeExecution = DateTime.Now.ToString("dd-MM-yy-HH.mm")

      };

      File.WriteAllText(@"donotdelete.json", JsonConvert.SerializeObject(file));


      using (StreamWriter sw = File.CreateText(@"donotdelete.json"))
      {
        JsonSerializer serializer = new JsonSerializer();
        serializer.Serialize(sw, file);
      }
    }

    private void btnCarregar_Click(object sender, EventArgs e)
    {
      if (!File.Exists("donotdelete.json"))
      {
        File.Create("donotdelete.json");
        MessageBox.Show("Não existem arquivos de configuração. Favor salvar uma configuração para criá-lo.");
      }

      ParamsFile file = JsonConvert.DeserializeObject<ParamsFile>(File.ReadAllText(@"donotdelete.json"));




    }
  }
}
