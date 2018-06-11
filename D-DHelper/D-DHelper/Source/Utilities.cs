using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D_DHelper
{
    class Utilities : IUserInterface
    {
        public void CreateCharacter()
        {
            CharactersCreator.OpenCharactersCreator();
        }

        public void OpenSpellsBase()
        {
            SpellsBase.OpenSpellsBase();
        }

        public void OpenCharactersBase()
        {
            CharactersBase.OpenCharactersBase();
        }

        public void OpenItemsBase()
        {
            ItemsBase.OpenItemsBase();
        }

        public void OpenDiceRoller()
        {
            DiceRoller.OpenDiceRoller();
        }

        public void OpenMonstersBase()
        {
            MonstersBase.OpenMonstersBase();
        }

        public void OpenInitiativeCounter()
        {
            InitiativeCounter.OpenInitiativeCounter();
        }

        public void OpenAdventuresJournal()
        {
            AdventuresJournal.OpenAdventuresJournal();
        }

        public void OpenOwnContentBuilder()
        {
            OwnContentBuilder.OpenOwnContentBuilder();
        }
    }
}
