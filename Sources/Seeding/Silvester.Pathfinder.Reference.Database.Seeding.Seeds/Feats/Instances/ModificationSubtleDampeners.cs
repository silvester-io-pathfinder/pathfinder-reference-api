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
    public class ModificationSubtleDampeners : Template
    {
        public static readonly Guid ID = Guid.Parse("da4da3ab-0888-4776-ad6c-468fadf0d8e2");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Modification - Subtle Dampeners",
                Level = -1,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("4e78d8bc-91e8-44d9-9fee-5676f15ae98f"), Type = TextBlockType.Enumeration, Text = $"*Subterfuge Suit Only**" };
            yield return new TextBlock { Id = Guid.Parse("bd302b12-1bba-4207-b512-842b31a27095"), Type = TextBlockType.Text, Text = $"You've designed your armor to help you blend in and dampen noise slightly. When you send your armor into overdrive, the dampeners increase their effect, improving your Stealth. When under the effects of {ToMarkdownLink<Models.Entities.Feat>("Overdrive", Feats.Instances.Overdrive.ID)}, you gain a +1 circumstance bonus to Stealth checks. If you're a master in Crafting, this increases to a +2 circumstance bonus." };
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("9581be6b-5b90-48d6-8454-b3b4105c69ae"),
                SourceId = Sources.Instances.GunsAndGears.ID,
                Page = -1
            };
        }
    }
}
