using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class ClericDedication : Template
    {
        public static readonly Guid ID = Guid.Parse("f08e4781-3262-4142-bb94-b276f5cce56b");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Cleric Dedication",
                Level = 2,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = "You cannot select another dedication feat until you have gained two other feats from the cleric archetype.",
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("454eca04-568a-444a-af5e-72e5e95385fe"), Type = TextBlockType.Text, Text = "You cast spells like a cleric. You gain access to the (activity: Cast a Spell) activity. You can prepare two common cantrips each day from the divine spell list in this book or any other cantrips you learn or discover. You’re trained in spell attack rolls and spell DCs for divine spells. Your key spellcasting ability for cleric archetype spells is Wisdom, and they are divine cleric spells. Choose a deity as you would if you were a cleric. You become bound by that deity’s anathema. You become trained in Religion and your deity’s associated skill; for each of these skills in which you were already trained, you instead become trained in a skill of your choice. You don’t gain any other abilities from your choice of deity." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificStat(Guid.Parse("255e0ad7-884b-47a1-bfca-51a8bb1a4497"), requiredStatValue: 14, Stats.Instances.Wisdom.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("0880663d-2e08-4b08-a3b5-cf33d772559e"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
