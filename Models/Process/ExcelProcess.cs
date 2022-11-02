using System.Data;
using OfficeOpenXml;
namespace NguyenDuyenCuongBTH3.Models.Process
{
public class ExcelProcess
{
public DataTable ExcelToDataTable(string strPath)
{
FileInfo fi = new FileInfo(strPath);
ExcelPackage excelPackage = new ExcelPackage(fi);
DataTable dt = new DataTable() ;
ExcelWorksheet worksheet = excel Package.Workbook.Worksheets [0] ;
//check if the worksheet is completely empty
if (worksheet.Dimension == null)
{
return dt;
}
//create a list to hold the column names
List<string> columnNames
= new Listestring>();
//needed to keep track of empty column headers
int currentColumn = 1;
//loop all columns in the sheet and add them to the datatable
foreach (var cell in worksheet. Cells[1, 1, 1, worksheet.Dimension.End.Column])
{
    string columnName = cell.Text.Trim();
//check if the previous header was empty and add it if it was
if (cell.Start.Column != currentColumn)
{
columnNames. Add ("Header.
dt.Columns. Add ("Header
currentColumn++;
+
currentColumn):
currentColumn):
7
//add the column name to the list to count the duplicates
columnNames. Add (co lumnName);
//count the duplicate column names and make them unique to avoid the exceptir
//A column named
"Name "
already belongs
to this DataTable
int occurrences
columnNames .Count (x => x. Equals (columnName) ) ;
if (occurrences
1)
{
columnName
= columnName
+ " '+ occurrences;
7
//add the column to
the datatable
dt. Columns .Add (columnName) ;
currentColumn++;
}
//start adding the contents of the excel file to the datatable
for (int i
=2; i
<2
worksheet.Dimension.End.Row; it+)
{
var row
= worksheet.Cellsli,
DataRow newRow = dt.NewRow() :
//loop all cells in the row
foreach (var cell in row)
{
1.
i, worksheet.Dimension.End.Column] ;
newRow[cell.Start.Column
11 = cell.Text;
7
dt. Rows.Add (newRow) ;
}
return dt;
}
}