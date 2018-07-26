using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Excel = Microsoft.Office.Interop.Excel;

namespace D_DHelper
{
    class SpellsBase
    {
        

        public static void OpenSpellsBase()
        {
        // XLSX MODULE
        Excel.Application SpellsBaseApplication = new Excel.Application();
        Excel.Workbook SpellsBaseWorkbook = SpellsBaseApplication.Workbooks.Open(@"C:\Users\Компьютер\Desktop\Программирование\D&D Helper\D-DHelper\D-DHelper\Materials\SpellsBase.xlsx", 0, true, 5, "", "", true, Excel.XlPlatform.xlWindows, "\t", false, false, 0, true, 1, 0); // SpellsBase folder
        Excel.Worksheet SpellsBaseWorksheet = (Excel.Worksheet)SpellsBaseWorkbook.Worksheets.get_Item(1); // Cells with needed data
        Excel.Range SpellsBaseRange; // Cell or Cells
        // XLSX MODULE
    }
}
}
