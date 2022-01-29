using Silvester.Pathfinder.Reference.Database.Seeding.Builders.TextBlocks;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.Traits;
using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class TrickDriverDedication : Template
    {
        public static readonly Guid ID = Guid.Parse("0c0027f3-b066-40a9-a1cc-4ac73cc279c2");

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
            yield return new TextBlock { Id = Guid.Parse("411a8121-42ce-43d6-95d4-7e0c98cc9f0f"), Type = TextBlockType.Text, Text = $"You are equally at home piloting any vehicle, adapting yourself instantly to varied controls, movements, and handling. Whenever piloting a vehicle requires a Piloting Lore or Sailing Lore check, you can use your Driving Lore proficiency instead. You can use Dexterity in place of Intelligence when attempting piloting checks with Driving Lore. You become an expert in Driving Lore. At 7th level, you become a master in Driving Lore, and at 15th level, you become legendary in Driving Lore." };
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("88dbf2aa-1209-4f47-94b7-6a52c474b985"),
                SourceId = Sources.Instances.GunsAndGears.ID,
                Page = -1
            };
        }
    }
}
