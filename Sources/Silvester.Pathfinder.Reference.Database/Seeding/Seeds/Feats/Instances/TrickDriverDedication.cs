using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class TrickDriverDedication : Template
    {
        public static readonly Guid ID = Guid.Parse("fb2af8a6-6f8f-4701-8076-f77760eea7f0");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Trick Driver Dedication",
                Level = 2,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = "You cannot select another dedication feat until you have gained two other feats from the trick driver archetype.",
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("ae242bec-d3f5-415f-bfb6-3ef346d7bb27"), Type = TextBlockType.Text, Text = "You are equally at home piloting any vehicle, adapting yourself instantly to varied controls, movements, and handling. Whenever piloting a vehicle requires a Piloting Lore or Sailing Lore check, you can use your Driving Lore proficiency instead. You can use Dexterity in place of Intelligence when attempting piloting checks with Driving Lore. You become an expert in Driving Lore. At 7th level, you become a master in Driving Lore, and at 15th level, you become legendary in Driving Lore." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("60e87cb2-c4f6-4c00-a11a-5f1e9064e6e7"),
                SourceId = Sources.Instances.GunsAndGears.ID,
                Page = -1
            };
        }
    }
}
