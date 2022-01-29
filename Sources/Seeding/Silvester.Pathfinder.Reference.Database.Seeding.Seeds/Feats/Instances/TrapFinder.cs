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
    public class TrapFinder : Template
    {
        public static readonly Guid ID = Guid.Parse("03dc6b6b-012e-4aa0-bd72-564019c43b44");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Trap Finder",
                Level = 1,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("17ddfa95-3458-4fd4-bb92-a482c46610a3"), Type = TextBlockType.Text, Text = $"You have an intuitive sense that alerts you to the dangers and presence of traps. You gain a +1 circumstance bonus to Perception checks to find traps, to AC against attacks made by traps, and to saves against traps. Even if you aren't {ToMarkdownLink<Models.Entities.Activity>("Searching", Activities.Instances.Search.ID)}, you get a check to find traps that normally require you to be {ToMarkdownLink<Models.Entities.Activity>("Searching", Activities.Instances.Search.ID)}. You still need to meet any other requirements to find the trap." };
            yield return new TextBlock { Id = Guid.Parse("3aa1adf0-e8d7-43c1-bce1-64048bc01636"), Type = TextBlockType.Text, Text = $"You can disable traps that require a proficiency rank of master in Thievery. If you have master proficiency in Thievery, you can disable traps that require a proficiency rank of legendary instead, and your circumstance bonuses against traps increase to +2." };
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {
            builder.Add(Guid.Parse(""), Traits.Instances.Investigator.ID);
            builder.Add(Guid.Parse(""), Traits.Instances.Rogue.ID);

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("5b5a2023-a28d-48e9-b8d1-32390d0ca97e"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
