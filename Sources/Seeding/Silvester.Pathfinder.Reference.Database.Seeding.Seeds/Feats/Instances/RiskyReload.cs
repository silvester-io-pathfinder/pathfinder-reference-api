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
    public class RiskyReload : Template
    {
        public static readonly Guid ID = Guid.Parse("81c90e41-7701-4189-aacc-cb09f97595a3");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Risky Reload",
                Level = 4,
                ActionTypeId = ActionTypes.Instances.OneAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("553675c1-86e4-4223-b938-38ac3c651bc9"), Type = TextBlockType.Text, Text = $"You've practiced a technique for rapidly reloading your firearm, but attempting to use this technique is a dangerous gamble with your firearm's functionality. {ToMarkdownLink<Models.Entities.Action>("Interact", Actions.Instances.Interact.ID)} to reload a firearm, then make a {ToMarkdownLink<Models.Entities.Action>("Strike", Actions.Instances.Strike.ID)} with that firearm. If the {ToMarkdownLink<Models.Entities.Action>("Strike", Actions.Instances.Strike.ID)} fails, the firearm misfires." };
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {
            builder.Add(Guid.Parse(""), Traits.Instances.Flourish.ID);
            builder.Add(Guid.Parse(""), Traits.Instances.Gunslinger.ID);

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("9ce178b5-5325-4492-9e68-4d35e38f307f"),
                SourceId = Sources.Instances.GunsAndGears.ID,
                Page = -1
            };
        }
    }
}
