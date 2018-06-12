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
        // XLSX MODULE
        private static Excel.Application ItemsBaseApplication = new Excel.Application();
        private static Excel.Workbook ItemsBaseWorkbook = ItemsBaseApplication.Workbooks.Open(@"C:\Users\Компьютер\Desktop\Программирование\D&D Helper\D-DHelper\D-DHelper\Materials\ItemsBase.xlsx", 0, true, 5, "", "", true, Excel.XlPlatform.xlWindows, "\t", false, false, 0, true, 1, 0); // ItemsBase folder
        private static Excel.Worksheet ItemsBaseWorksheet = (Excel.Worksheet)ItemsBaseWorkbook.Worksheets.get_Item(1); // Cells with needed data
        private static Excel.Range ItemsBaseRange; // Cell or Cells
        // XLSX MODULE

        public static void OpenItemsBase()
        {
        }
    }
}
