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
                CharactersBaseRange = CharactersBaseWorksheet.get_Range("A" + Key, "A" + Key); // 2nd use ==> crash programm
                if (CharactersBaseRange.Text == "")
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

            FromCheckBoxToCell("P" + Key, characterscreatorform.checkBox1);
            FromCheckBoxToCell("Q" + Key, characterscreatorform.checkBox2);
            FromCheckBoxToCell("R" + Key, characterscreatorform.checkBox3);
            FromCheckBoxToCell("S" + Key, characterscreatorform.checkBox4);
            FromCheckBoxToCell("I" + Key, characterscreatorform.checkBox5);
            FromCheckBoxToCell("U" + Key, characterscreatorform.checkBox6);
            FromCheckBoxToCell("V" + Key, characterscreatorform.checkBox7);
            FromCheckBoxToCell("W" + Key, characterscreatorform.checkBox8);
            FromCheckBoxToCell("X" + Key, characterscreatorform.checkBox9);
            FromCheckBoxToCell("Y" + Key, characterscreatorform.checkBox10);
            FromCheckBoxToCell("Z" + Key, characterscreatorform.checkBox11);
            FromCheckBoxToCell("AA" + Key, characterscreatorform.checkBox12);
            FromCheckBoxToCell("AB" + Key, characterscreatorform.checkBox13);
            FromCheckBoxToCell("AC" + Key, characterscreatorform.checkBox14);
            FromCheckBoxToCell("AD" + Key, characterscreatorform.checkBox15);
            FromCheckBoxToCell("AE" + Key, characterscreatorform.checkBox16);
            FromCheckBoxToCell("AF" + Key, characterscreatorform.checkBox17);
            FromCheckBoxToCell("AG" + Key, characterscreatorform.checkBox18);

            // Description
            FromTextboxToCell("AH", characterscreatorform.AttacksTextbox);
            FromTextboxToCell("AI", characterscreatorform.OtherTextbox);

            CharactersBaseWorkbook.SaveAs(@"C:\Users\Компьютер\Desktop\Программирование\D&D Helper\D-DHelper\D-DHelper\Materials\CharactersBase.xlsx", Excel.XlFileFormat.xlWorkbookNormal, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Excel.XlSaveAsAccessMode.xlNoChange, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing); // Save in user dociments folder - bug
            CharactersBaseApplication.Quit();
        }
        
        public static void OpenCharactersCreator(Form form)
        {
            CharactersCreatorForm characterscreatorform = new CharactersCreatorForm(form);
            characterscreatorform.Show();
        }

        private static void FromTextboxToCell(string Letter, TextBox textbox)
        {
            CharactersBaseRange = CharactersBaseWorksheet.get_Range(Letter + Key, Letter + Key);
            CharactersBaseRange.Value2 = textbox.Text;
        }

        private static void FromCheckBoxToCell(string Letter, CheckBox checkbox)
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
