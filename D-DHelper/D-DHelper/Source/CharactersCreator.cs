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

            FromTextboxToCell("B", characterscreatorform.CharactersNameTextBox);
            FromTextboxToCell("C", characterscreatorform.RaceTextbox);
            FromTextboxToCell("D", characterscreatorform.ClassTextbox);
            FromTextboxToCell("E", characterscreatorform.AlignmentTextbox);
            FromTextboxToCell("F", characterscreatorform.LevelTextbox);

            // Characteristics

            FromTextboxToCell("G", characterscreatorform.STRTextbox);
            FromTextboxToCell("H", characterscreatorform.DEXTextbox);
            FromTextboxToCell("I", characterscreatorform.CONTextbox);
            FromTextboxToCell("J", characterscreatorform.INTTextbox);
            FromTextboxToCell("K", characterscreatorform.WISTextbox);
            FromTextboxToCell("L", characterscreatorform.CHATextbox);

            // AC, Init, Speed

            FromTextboxToCell("M", characterscreatorform.ACTextbox);
            FromTextboxToCell("N", characterscreatorform.InitiativeTextbox);
            FromTextboxToCell("O", characterscreatorform.SpeedTextbox);

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

            // Description
            FromTextboxToCell("AH", characterscreatorform.AttacksTextbox);
            FromTextboxToCell("AI", characterscreatorform.OtherTextbox);
        }
        
        public static void OpenCharactersCreator(Form form)
        {
            CharactersCreatorForm characterscreatorform = new CharactersCreatorForm(form);
            characterscreatorform.Show();
        }

        private static void FromTextboxToCell(string Letter, TextBox textbox)
        {
            CharactersBaseRange = CharactersBaseWorksheet.get_Range(Letter + Key, Type.Missing);
            CharactersBaseRange.Value2 = textbox.Text;
        }
    }
}
