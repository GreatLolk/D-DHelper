using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Excel = Microsoft.Office.Interop.Excel;

namespace D_DHelper
{
    class MonstersBase
    {
        public static void OpenMonstersBase()
        {
        // XLSX MODULE
        Excel.Application MonstersBaseApplication = new Excel.Application();
        Excel.Workbook MonstersBaseWorkbook = MonstersBaseApplication.Workbooks.Open(@"C:\Users\Компьютер\Desktop\Программирование\D&D Helper\D-DHelper\D-DHelper\Materials\MonstersBase.xlsx", 0, true, 5, "", "", true, Excel.XlPlatform.xlWindows, "\t", false, false, 0, true, 1, 0); // MonstersBase folder
        Excel.Worksheet MonstersBaseWorksheet = (Excel.Worksheet)MonstersBaseWorkbook.Worksheets.get_Item(1); // Cells with needed data
        Excel.Range MonstersBaseRange; // Cell or Cells
        // XLSX MODULE
    }
}
}
