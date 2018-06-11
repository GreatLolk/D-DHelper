using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
        // XLSX MODULE

        // Characters variables
        public static string CharactersName { get; set; }
        public static string CharactersRace { get; set; }
        public static string CharactersClass { get; set; }
        public static string CharactersAlignment { get; set; }
        public static string CharactersLevelXP { get; set; }
        public static int CharactersStrength { get; set; }
        public static int CharactersDexterity { get; set; }
        public static int CharactersConstitution { get; set; }
        public static int CharactersIntelligence { get; set; }
        public static int CharactersWisdom { get; set; }
        public static int CharactersCharisma { get; set; }
        public static int CharactersArmorClass { get; set; }
        public static int CharactersInitiative { get; set; }
        public static int CharactersSpeed { get; set; }
        public static char CharactersAcrobatics { get; set; }
        public static char CharactersAnimalHandlings { get; set; }
        public static char CharactersArcana { get; set; }
        public static char CharactersAthletics { get; set; }
        public static char CharactersDeception { get; set; }
        public static char CharactersHistory { get; set; }
        public static char CharactersInsight { get; set; }
        public static char CharactersIntimidation { get; set; }
        public static char CharactersInvestigation { get; set; }
        public static char CharactersMedicine { get; set; }
        public static char CharactersNature { get; set; }
        public static char CharactersPerception { get; set; }
        public static char CharactersPerformance { get; set; }
        public static char CharactersPersuasion { get; set; }
        public static char CharactersReligion { get; set; }
        public static char CharactersSleightOfHand { get; set; }
        public static char CharactersStealh { get; set; }
        public static char CharactersSurvival { get; set; }
        // Characters variables

        public static void CreateCharacter()
        {
        }
        
        public static void OpenCharactersCreator()
        {
        }
    }
}
