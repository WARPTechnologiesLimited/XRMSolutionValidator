Some files in this directory were created using the Microsoft (R) Xml Schemas/DataTypes support utility (xsd.exe) generation tool.

The following behaviours have been noticed and should observered when regenerating them:

- When generating solution.cs from the solution.xml file the produced file must have a find and replace executed to change "[][]" to "[]" - this appears to be a bug in the XSD tool.
- Each file contains the NewDataSet class so it must be commented out on new/regenerated files.