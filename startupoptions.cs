public class StartupOptions{
  public bool LoggingEnabled;
  // todo: this shall replace SettngsLocation.xml
  string LoggingFolder;

  bool ConfifEnabled;
  string ConfigFolder;

  bool ProcedureDataCollectionEnabled;
  string DataFolder;

  bool SqlDatabaseEnabled;
  
  // Default is execution root folder
  string CustomModleAssembliesFolder;

}
