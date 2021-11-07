using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class BasicBardSpellcasting : Template
    {
        public static readonly Guid ID = Guid.Parse("fb0068a4-d1a5-4d9c-a87a-61436bc7ae62");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Basic Bard Spellcasting",
                Level = 4,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("467bc072-670c-41e4-9b26-a3b583825e02"), Type = TextBlockType.Text, Text = "You gain a 1st-level spell slot. At 6th level, you gain a 2nd-level spell slot and you can select one spell from your repertoire as a signature spell. At 8th level, you gain a 3rd-level spell slot. Each time you gain a spell slot of a new level from the bard archetype, add a common occult spell or another spell you learned or discovered to your repertoire, of the appropriate spell level." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("e21d0624-dbda-4d5d-ab77-846a0930e82b"), Feats.Instances.BardDedication.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("0222fa20-e4df-4fa9-a69a-f7e90454f3c0"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
