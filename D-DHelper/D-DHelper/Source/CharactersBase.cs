using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Excel = Microsoft.Office.Interop.Excel;

namespace D_DHelper
{
    class CharactersBase
    {
        
        public static void OpenCharactersBase()
        {
        // XLSX MODULE
        Excel.Application CharactersBaseApplication = new Excel.Application();
        Excel.Workbook CharactersBaseWorkbook = CharactersBaseApplication.Workbooks.Open(@"C:\Users\Компьютер\Desktop\Программирование\D&D Helper\D-DHelper\D-DHelper\Materials\CharactersBase.xlsx", 0, true, 5, "", "", true, Excel.XlPlatform.xlWindows, "\t", false, false, 0, true, 1, 0); // CharactersBase folder
        Excel.Worksheet CharactersBaseWorksheet = (Excel.Worksheet)CharactersBaseWorkbook.Worksheets.get_Item(1); // Cells with needed data
        Excel.Range CharactersBaseRange; // Cell or Cells
        // XLSX MODULE
    }
}
}
