using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;

namespace D_DHelper
{
    class CharactersCreator
    {
        // XLSX MODULE
        private static Excel.Application CharactersBaseApplication = new Excel.Application();
        private static Excel.Workbook CharactersBaseWorkbook = CharactersBaseApplication.Workbooks.Open(@"C:\Users\Компьютер\Desktop\Программирование\D&D Helper\D-DHelper\D-DHelper\Materials\CharactersBase.xlsx", 0, true, 5, "", "", true, Excel.XlPlatform.xlWindows, "\t", false, false, 0, true, 1, 0); // CharactersBase folder
        private static Excel.Worksheet CharactersBaseWorksheet = (Excel.Worksheet)CharactersBaseWorkbook.Worksheets.get_Item(1); // Cells with needed data
        private static Excel.Range CharactersBaseRange; // Cell or Cells
        private static int Key = 1;
        // XLSX MODULE

        public static void CreateCharacter(CharactersCreatorForm characterscreatorform)
        {
            while (true) // Checking place for new character
            {
                CharactersBaseRange = CharactersBaseWorksheet.get_Range("A" + Key, Type.Missing);
                if (CharactersBaseRange.Value2 = null)
                    break;
                else
                    Key++;
            }

            CharactersBaseRange.Value2 = Key; // Generate Key
            
            // Character's information
            CharactersBaseRange = CharactersBaseWorksheet.get_Range("B" + Key, Type.Missing);
            CharactersBaseRange.Value2 = characterscreatorform.CharactersNameTextBox.Text;

            CharactersBaseRange = CharactersBaseWorksheet.get_Range("C" + Key, Type.Missing);
            CharactersBaseRange.Value2 = characterscreatorform.RaceTextbox.Text;

            CharactersBaseRange = CharactersBaseWorksheet.get_Range("D" + Key, Type.Missing);
            CharactersBaseRange.Value2 = characterscreatorform.ClassTextbox.Text;

            CharactersBaseRange = CharactersBaseWorksheet.get_Range("E" + Key, Type.Missing);
            CharactersBaseRange.Value2 = characterscreatorform.AlignmentTextbox.Text;

            CharactersBaseRange = CharactersBaseWorksheet.get_Range("F" + Key, Type.Missing);
            CharactersBaseRange.Value2 = characterscreatorform.LevelTextbox.Text;

            // Characteristics
            CharactersBaseRange = CharactersBaseWorksheet.get_Range("G" + Key, Type.Missing);
            CharactersBaseRange.Value2 = characterscreatorform.STRTextbox.Text;

            CharactersBaseRange = CharactersBaseWorksheet.get_Range("H" + Key, Type.Missing);
            CharactersBaseRange.Value2 = characterscreatorform.DEXTextbox.Text;

            CharactersBaseRange = CharactersBaseWorksheet.get_Range("I" + Key, Type.Missing);
            CharactersBaseRange.Value2 = characterscreatorform.CONTextbox.Text;

            CharactersBaseRange = CharactersBaseWorksheet.get_Range("J" + Key, Type.Missing);
            CharactersBaseRange.Value2 = characterscreatorform.INTTextbox.Text;

            CharactersBaseRange = CharactersBaseWorksheet.get_Range("K" + Key, Type.Missing);
            CharactersBaseRange.Value2 = characterscreatorform.WISTextbox.Text;

            CharactersBaseRange = CharactersBaseWorksheet.get_Range("L" + Key, Type.Missing);
            CharactersBaseRange.Value2 = characterscreatorform.CHATextbox.Text;
            //

            CharactersBaseRange = CharactersBaseWorksheet.get_Range("M" + Key, Type.Missing);
            CharactersBaseRange.Value2 = characterscreatorform.ACTextbox.Text;

            CharactersBaseRange = CharactersBaseWorksheet.get_Range("N" + Key, Type.Missing);
            CharactersBaseRange.Value2 = characterscreatorform.InitiativeTextbox.Text;

            CharactersBaseRange = CharactersBaseWorksheet.get_Range("O" + Key, Type.Missing);
            CharactersBaseRange.Value2 = characterscreatorform.SpeedTextbox.Text;

            // Skills
            CharactersBaseRange = CharactersBaseWorksheet.get_Range("P" + Key, Type.Missing);
            CharactersBaseRange.Value2 = characterscreatorform.CharactersNameTextBox.Text;

            CharactersBaseRange = CharactersBaseWorksheet.get_Range("Q" + Key, Type.Missing);
            CharactersBaseRange.Value2 = characterscreatorform.CharactersNameTextBox.Text;

            CharactersBaseRange = CharactersBaseWorksheet.get_Range("R" + Key, Type.Missing);
            CharactersBaseRange.Value2 = characterscreatorform.CharactersNameTextBox.Text;

            CharactersBaseRange = CharactersBaseWorksheet.get_Range("S" + Key, Type.Missing);
            CharactersBaseRange.Value2 = characterscreatorform.CharactersNameTextBox.Text;

            CharactersBaseRange = CharactersBaseWorksheet.get_Range("T" + Key, Type.Missing);
            CharactersBaseRange.Value2 = characterscreatorform.CharactersNameTextBox.Text;

            CharactersBaseRange = CharactersBaseWorksheet.get_Range("U" + Key, Type.Missing);
            CharactersBaseRange.Value2 = characterscreatorform.CharactersNameTextBox.Text;

            CharactersBaseRange = CharactersBaseWorksheet.get_Range("V" + Key, Type.Missing);
            CharactersBaseRange.Value2 = characterscreatorform.CharactersNameTextBox.Text;

            CharactersBaseRange = CharactersBaseWorksheet.get_Range("W" + Key, Type.Missing);
            CharactersBaseRange.Value2 = characterscreatorform.CharactersNameTextBox.Text;

            CharactersBaseRange = CharactersBaseWorksheet.get_Range("X" + Key, Type.Missing);
            CharactersBaseRange.Value2 = characterscreatorform.CharactersNameTextBox.Text;

            CharactersBaseRange = CharactersBaseWorksheet.get_Range("Y" + Key, Type.Missing);
            CharactersBaseRange.Value2 = characterscreatorform.CharactersNameTextBox.Text;

            CharactersBaseRange = CharactersBaseWorksheet.get_Range("Z" + Key, Type.Missing);
            CharactersBaseRange.Value2 = characterscreatorform.CharactersNameTextBox.Text;

            CharactersBaseRange = CharactersBaseWorksheet.get_Range("AA" + Key, Type.Missing);
            CharactersBaseRange.Value2 = characterscreatorform.CharactersNameTextBox.Text;

            CharactersBaseRange = CharactersBaseWorksheet.get_Range("AB" + Key, Type.Missing);
            CharactersBaseRange.Value2 = characterscreatorform.CharactersNameTextBox.Text;

            CharactersBaseRange = CharactersBaseWorksheet.get_Range("AC" + Key, Type.Missing);
            CharactersBaseRange.Value2 = characterscreatorform.CharactersNameTextBox.Text;

            CharactersBaseRange = CharactersBaseWorksheet.get_Range("AD" + Key, Type.Missing);
            CharactersBaseRange.Value2 = characterscreatorform.CharactersNameTextBox.Text;

            CharactersBaseRange = CharactersBaseWorksheet.get_Range("AE" + Key, Type.Missing);
            CharactersBaseRange.Value2 = characterscreatorform.CharactersNameTextBox.Text;

            CharactersBaseRange = CharactersBaseWorksheet.get_Range("AF" + Key, Type.Missing);
            CharactersBaseRange.Value2 = characterscreatorform.CharactersNameTextBox.Text;

            CharactersBaseRange = CharactersBaseWorksheet.get_Range("AG" + Key, Type.Missing);
            CharactersBaseRange.Value2 = characterscreatorform.CharactersNameTextBox.Text;
            //Skills

            // Description
            CharactersBaseRange = CharactersBaseWorksheet.get_Range("AH" + Key, Type.Missing);
            CharactersBaseRange.Value2 = characterscreatorform.AttacksTextbox.Text;

            CharactersBaseRange = CharactersBaseWorksheet.get_Range("AI" + Key, Type.Missing);
            CharactersBaseRange.Value2 = characterscreatorform.OtherTextbox.Text;
            //
        }
        
        public static void OpenCharactersCreator(Form form)
        {
            CharactersCreatorForm characterscreatorform = new CharactersCreatorForm(form);
        }
    }
}
