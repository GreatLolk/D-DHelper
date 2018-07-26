using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Excel = Microsoft.Office.Interop.Excel;

namespace D_DHelper
{
    class ItemsBase
    {
        public static void OpenItemsBase()
        {
        // XLSX MODULE
        Excel.Application ItemsBaseApplication = new Excel.Application();
        Excel.Workbook ItemsBaseWorkbook = ItemsBaseApplication.Workbooks.Open(@"C:\Users\Компьютер\Desktop\Программирование\D&D Helper\D-DHelper\D-DHelper\Materials\ItemsBase.xlsx", 0, true, 5, "", "", true, Excel.XlPlatform.xlWindows, "\t", false, false, 0, true, 1, 0); // ItemsBase folder
        Excel.Worksheet ItemsBaseWorksheet = (Excel.Worksheet)ItemsBaseWorkbook.Worksheets.get_Item(1); // Cells with needed data
        Excel.Range ItemsBaseRange; // Cell or Cells
        // XLSX MODULE
    }
}
}
