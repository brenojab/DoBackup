using DoBackup.Classes;
using Newtonsoft.Json;
using System;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;

namespace DoBackup
{
  public partial class Main : Form
  {

    private ParamsFile _parametros;

    public Main()
    {
      InitializeComponent();

      _parametros = CarregaParametrosJSON();
    }



    private void btnBKPNuvem_Click(object sender, EventArgs e)
    {
      // Monta os argumentos
      _parametros.DBFilename = string.Concat(_parametros.TargetBacpacPath, _parametros.AzureDBName, Constants.STRING_SEPARATOR, DateTime.Now.ToString("dd-MM-yy-HH.mm"), Constants.FILE_EXTENSION);
      _parametros.DateTimeExecution = DateTime.Now.ToString("dd-MM-yy-HH.mm");

      string sqlPackageExportArgs = $@"/Action:{_parametros.ExportAction} /ssn:{_parametros.AzureServerName} /sdn:{_parametros.AzureDBName} /su:{_parametros.AzureDBUser} /sp:{_parametros.AzureDBPassword} /tf:{_parametros.DBFilename} /p:Storage=File";

      RunWithRedirect(_parametros.SqlPackageEXELocation, sqlPackageExportArgs);

      MessageBox.Show($@"Exportado da nuvem para {_parametros.TargetBacpacPath}");
    }

    private ParamsFile CarregaParametrosJSON()
    {
      if (!File.Exists("donotdelete.json"))
      {
        File.Create("donotdelete.json");
        MessageBox.Show("Não existem arquivos de configuração. Favor salvar uma configuração para criá-lo.");
      }

      return JsonConvert.DeserializeObject<ParamsFile>(File.ReadAllText(@"donotdelete.json"));
    }

    private void RunWithRedirect(string cmdPath, string cmdArgs)
    {
      var proc = new Process();
      proc.StartInfo.FileName = cmdPath;
      proc.StartInfo.Arguments = cmdArgs;

      // set up output redirection
      proc.StartInfo.RedirectStandardOutput = true;
      proc.StartInfo.RedirectStandardError = true;
      proc.EnableRaisingEvents = true;
      proc.StartInfo.CreateNoWindow = true;

      //proc.StartInfo.Domain = "bh01";
      //proc.StartInfo.UserName = "breno.batista";

      //string password = "";
      //System.Security.SecureString ssPwd = new System.Security.SecureString();

      //for (int x = 0; x < password.Length; x++)
      //{
      //  ssPwd.AppendChar(password[x]);
      //}

      //proc.StartInfo.Password = ssPwd;

      // see below for output handler
      proc.ErrorDataReceived += proc_DataReceived;
      proc.OutputDataReceived += proc_DataReceived;

      // exigência, senão, erro
      proc.StartInfo.UseShellExecute = false;

      proc.Start();

      proc.BeginErrorReadLine();
      proc.BeginOutputReadLine();

      proc.WaitForExit();
    }

    private void proc_DataReceived(object sender, DataReceivedEventArgs e)
    {
      if (e.Data != null)
        this.BeginInvoke(new Action(() => txtLog.Text += (Environment.NewLine + e.Data)));
    }

    private void txtLog_TextChanged(object sender, EventArgs e)
    {
      string dbFilename = string.Concat(_parametros.TargetBacpacPath, _parametros.AzureDBName, Constants.STRING_SEPARATOR, DateTime.Now.ToString("dd-MM-yy-HH.mm"), Constants.STRING_SEPARATOR, _parametros.GUID, Constants.FILE_EXTENSION);
      File.WriteAllText(string.Concat(dbFilename, ".log"), txtLog.Text);
    }

    private void btnGeraBKPCliente_Click(object sender, EventArgs e)
    {
      ParamsFile parametros = CarregaParametrosJSON();

      // Atribuições...
      parametros.GUID = txtGUIDCliente.Text;
      parametros.DateTimeExecution = DateTime.Now.ToString("dd-MM-yy-HH.mm");

      // Monta os argumentos
      //parametros.TargetBacpacPath = @"educonnectDevdb-16-10-2017-09.08-TOTVSDEVBATISTA.bacpac";
      //parametros.SqlDBName = string.Concat(parametros.SqlDBName, txtGUIDCliente.Text);

      //string sqlPackageImportArgs = $@"/Action:{importAction} /tsn:tcp:{sqlServerName} /tdn:{_lastTargetBACPACPath} /tu:{sqlDBUser} /tp:{sqlDBPass} /sf:{_lastTargetBACPACPath} /p:DatabaseEdition=Premium /p:DatabaseServiceObjective=P4 /p:Storage=File";

      string source = $"\"Data Source= {parametros.SqlServerName};Initial Catalog= {parametros.SqlDBName};User Id={parametros.SqlDBUser};Password={parametros.SqlDBPassword}\"";

      string sqlPackageImportArgs = $@"/Action:{Constants.IMPORT_ACTION} /tcs:{source} /sf:{parametros.TargetBacpacPath}";

      RunWithRedirect(parametros.SqlPackageEXELocation, sqlPackageImportArgs);

      /*
      "\\10.31.0.212\C$\Program Files (x86)\Microsoft SQL Server\120\DAC\bin\SqlPackage.exe" /Action:Import /tcs:"Data Source=10.31.0.212;Initial Catalog=educonnectDevdb;User Id=rm;Password=rm" /sf:"educonnectDevdb-16-10-17-13.22.bacpac" 

       */

      // Executa os scripts na base restaurada...
      string sqlDELETEPath = @"C:\users\breno.batista\script.sql";

      RunWithRedirect("sqlcmd", $@"-S . -d teste -i {sqlDELETEPath}");
    }

    private void btnBKPFtp_Click(object sender, EventArgs e)
    {
      _parametros.SqlFTPClientBackup = txtFTPCliente.Text;

      File.Move(_parametros.SqlClientBackup, _parametros.SqlFTPClientBackup);

      MessageBox.Show("Executa exporta base para FTP");

      MessageBox.Show("Concluído");
    }

    private void btnParams_Click(object sender, EventArgs e)
    {
      new ParamsForm().ShowDialog();
    }
  }

}
