Some files in this directory were created using the Microsoft (R) Xml Schemas/DataTypes support utility (xsd.exe) generation tool.
The commands to run are:

xsd cp_ad.xml (this command produces the xsd)
xsd cp_ad.xsd /c /namespace:WARP.XrmSolutionValidator.Core.XrmModels


The following behaviours have been noticed and should observered when regenerating them:

- When generating some .cs file from .xml files the produced file must have a find and replace executed to change "[][]" to "[]" - this appears to be a bug in the XSD tool.
  The indication this issue is occuring is the exception - "System.PlatformNotSupportedException: 'Compiling JScript/CSharp scripts is not supported'"
- Each file contains the NewDataSet class so it must be removed on new/regenerated files.
- Some other claasses in generated files will also class names, again these should be removed or renamed.