using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoBackup.Classes
{
  public class ParamsFile
  {
    public string GUID { get; set; }
    public string SqlPackageEXELocation { get; set; }
    public string TargetBacpacPath { get; set; }

    // Azure params
    public string AzureServerName { get; set; }
    public string AzureDBName { get; set; }
    public string AzureDBUser { get; set; }
    public string AzureDBPassword { get; set; }


    // Database args
    public string SqlServerName { get; set; }
    public string SqlDBName { get; set; }
    public string SqlDBUser { get; set; }
    public string SqlDBPassword { get; set; }

    // Folder args
    public string SqlClientBackup { get; set; }
    public string SqlFTPClientBackup { get; set; }

    // SQLPackage args
    public string ExportAction { get; set; }
    public string ImportAction { get; set; }
    public string DBFilename { get; set; }

    public string DateTimeExecution { get; set; }
  }
}
