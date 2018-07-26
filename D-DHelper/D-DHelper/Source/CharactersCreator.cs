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
        public static void CreateCharacter(CharactersCreatorForm characterscreatorform)
        {
            Excel.Application CharactersBaseApplication = new Excel.Application();
            Excel.Workbook CharactersBaseWorkbook = CharactersBaseApplication.Workbooks.Open(@"C:\Users\Компьютер\Desktop\Программирование\D&D Helper\D-DHelper\D-DHelper\Materials\CharactersBase.xlsx", 0, true, 5, "", "", true, Excel.XlPlatform.xlWindows, "\t", false, false, 0, true, 1, 0); // CharactersBase folder
            Excel.Worksheet CharactersBaseWorksheet = (Excel.Worksheet)CharactersBaseWorkbook.Worksheets.get_Item(1); // Cells with needed data
            Excel.Range CharactersBaseRange; // Cell or Cells
            int Key = 1;

            while (true) // Checking place for new character
            {
                CharactersBaseRange = CharactersBaseWorksheet.get_Range("A" + Key, "A" + Key);
                if (CharactersBaseRange.Text == "")
                    break;
                else
                    Key++;
            }

            CharactersBaseRange.Value2 = Key; // Generate Key

            // Character's information

            FromTextboxToCell("B", characterscreatorform.CharactersNameTextBox, CharactersBaseRange, Key, CharactersBaseWorksheet);
            FromTextboxToCell("C", characterscreatorform.RaceTextbox, CharactersBaseRange, Key, CharactersBaseWorksheet);
            FromTextboxToCell("D", characterscreatorform.ClassTextbox, CharactersBaseRange, Key, CharactersBaseWorksheet);
            FromTextboxToCell("E", characterscreatorform.AlignmentTextbox, CharactersBaseRange, Key, CharactersBaseWorksheet);
            FromTextboxToCell("F", characterscreatorform.LevelTextbox, CharactersBaseRange, Key, CharactersBaseWorksheet);

            // Characteristics

            FromTextboxToCell("G", characterscreatorform.STRTextbox, CharactersBaseRange, Key, CharactersBaseWorksheet);
            FromTextboxToCell("H", characterscreatorform.DEXTextbox, CharactersBaseRange, Key, CharactersBaseWorksheet);
            FromTextboxToCell("I", characterscreatorform.CONTextbox, CharactersBaseRange, Key, CharactersBaseWorksheet);
            FromTextboxToCell("J", characterscreatorform.INTTextbox, CharactersBaseRange, Key, CharactersBaseWorksheet);
            FromTextboxToCell("K", characterscreatorform.WISTextbox, CharactersBaseRange, Key, CharactersBaseWorksheet);
            FromTextboxToCell("L", characterscreatorform.CHATextbox, CharactersBaseRange, Key, CharactersBaseWorksheet);

            // AC, Init, Speed

            FromTextboxToCell("M", characterscreatorform.ACTextbox, CharactersBaseRange, Key, CharactersBaseWorksheet);
            FromTextboxToCell("N", characterscreatorform.InitiativeTextbox, CharactersBaseRange, Key, CharactersBaseWorksheet);
            FromTextboxToCell("O", characterscreatorform.SpeedTextbox, CharactersBaseRange, Key, CharactersBaseWorksheet);

            // Skills

            FromCheckBoxToCell("P" + Key, characterscreatorform.checkBox1, CharactersBaseRange, Key, CharactersBaseWorksheet);
            FromCheckBoxToCell("Q" + Key, characterscreatorform.checkBox2, CharactersBaseRange, Key, CharactersBaseWorksheet);
            FromCheckBoxToCell("R" + Key, characterscreatorform.checkBox3, CharactersBaseRange, Key, CharactersBaseWorksheet);
            FromCheckBoxToCell("S" + Key, characterscreatorform.checkBox4, CharactersBaseRange, Key, CharactersBaseWorksheet);
            FromCheckBoxToCell("I" + Key, characterscreatorform.checkBox5, CharactersBaseRange, Key, CharactersBaseWorksheet);
            FromCheckBoxToCell("U" + Key, characterscreatorform.checkBox6, CharactersBaseRange, Key, CharactersBaseWorksheet);
            FromCheckBoxToCell("V" + Key, characterscreatorform.checkBox7, CharactersBaseRange, Key, CharactersBaseWorksheet);
            FromCheckBoxToCell("W" + Key, characterscreatorform.checkBox8, CharactersBaseRange, Key, CharactersBaseWorksheet);
            FromCheckBoxToCell("X" + Key, characterscreatorform.checkBox9, CharactersBaseRange, Key, CharactersBaseWorksheet);
            FromCheckBoxToCell("Y" + Key, characterscreatorform.checkBox10, CharactersBaseRange, Key, CharactersBaseWorksheet);
            FromCheckBoxToCell("Z" + Key, characterscreatorform.checkBox11, CharactersBaseRange, Key, CharactersBaseWorksheet);
            FromCheckBoxToCell("AA" + Key, characterscreatorform.checkBox12, CharactersBaseRange, Key, CharactersBaseWorksheet);
            FromCheckBoxToCell("AB" + Key, characterscreatorform.checkBox13, CharactersBaseRange, Key, CharactersBaseWorksheet);
            FromCheckBoxToCell("AC" + Key, characterscreatorform.checkBox14, CharactersBaseRange, Key, CharactersBaseWorksheet);
            FromCheckBoxToCell("AD" + Key, characterscreatorform.checkBox15, CharactersBaseRange, Key, CharactersBaseWorksheet);
            FromCheckBoxToCell("AE" + Key, characterscreatorform.checkBox16, CharactersBaseRange, Key, CharactersBaseWorksheet);
            FromCheckBoxToCell("AF" + Key, characterscreatorform.checkBox17, CharactersBaseRange, Key, CharactersBaseWorksheet);
            FromCheckBoxToCell("AG" + Key, characterscreatorform.checkBox18, CharactersBaseRange, Key, CharactersBaseWorksheet);

            // Description
            FromTextboxToCell("AH", characterscreatorform.AttacksTextbox, CharactersBaseRange, Key, CharactersBaseWorksheet);
            FromTextboxToCell("AI", characterscreatorform.OtherTextbox, CharactersBaseRange, Key, CharactersBaseWorksheet);

            CharactersBaseWorkbook.SaveAs(@"C:\Users\Компьютер\Desktop\Программирование\D&D Helper\D-DHelper\D-DHelper\Materials\CharactersBase.xlsx", Excel.XlFileFormat.xlWorkbookNormal, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Excel.XlSaveAsAccessMode.xlNoChange, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing); // BUG - dont save, only for read
            CharactersBaseWorkbook.Close();
            CharactersBaseApplication.Quit();
        }
        
        public static void OpenCharactersCreator(Form form)
        {
            CharactersCreatorForm characterscreatorform = new CharactersCreatorForm(form);
            characterscreatorform.Show();
        }

        private static void FromTextboxToCell(string Letter, TextBox textbox, Excel.Range CharactersBaseRange, int Key, Excel.Worksheet CharactersBaseWorksheet)
        {
            CharactersBaseRange = CharactersBaseWorksheet.get_Range(Letter + Key, Letter + Key);
            CharactersBaseRange.Value2 = textbox.Text;
        }

        private static void FromCheckBoxToCell(string Letter, CheckBox checkbox, Excel.Range CharactersBaseRange, int Key, Excel.Worksheet CharactersBaseWorksheet)
        {
            CharactersBaseRange = CharactersBaseWorksheet.get_Range(Letter + Key, Letter + Key);
            
            if(checkbox.Checked == true)
            {
                CharactersBaseRange.Value2 = "+";
            }

            else
            {
                CharactersBaseRange.Value2 = "-";
            }
        }
    }
}
