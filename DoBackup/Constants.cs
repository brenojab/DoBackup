using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoBackup
{
  public static class Constants
  {
    // File args
    public static string STRING_SEPARATOR = @"-";
    public static string FILE_EXTENSION = @".bacpac";
    
    // SQLPackage args
    public static string EXPORT_ACTION = @"Export";
    public static string IMPORT_ACTION = @"Import";
  }
}
