using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class BardDedication : Template
    {
        public static readonly Guid ID = Guid.Parse("b6ba4d82-addf-485b-a3fa-8ff8d68db49b");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Bard Dedication",
                Level = 2,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = "You cannot select another dedication feat until you have gained two other feats from the bard archetype.",
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("2e2cb767-da8a-4422-a27b-c8cd41c0088e"), Type = TextBlockType.Text, Text = "You cast spells like a bard and gain the (activity: Cast a Spell) activity. You gain a spell repertoire with two common cantrips from the occult spell list, or any other cantrips you learn or discover. You’re trained in spell attack rolls and spell DCs for occult spells. Your key spellcasting ability for bard archetype spells is Charisma, and they are occult bard spells. You become trained in Occultism and Performance; for each of these skills in which you were already trained, you instead become trained in a skill of your choice." };
            yield return new TextBlock { Id = Guid.Parse("1cb6eaca-df08-4878-a7da-e7a999fbd793"), Type = TextBlockType.Text, Text = "Choose a muse as you would if you were a bard. You have that muse for all purposes, allowing you to take that muse’s feats, but you don’t gain any of the other abilities it grants." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificStat(Guid.Parse("e7b28b68-02d8-42f0-9f71-7a340693043a"), requiredStatValue: 14, Stats.Instances.Charisma.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("43cc42a4-5621-4cf0-a819-a53029181870"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
