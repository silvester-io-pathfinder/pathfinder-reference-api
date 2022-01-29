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
    public class ModificationOmnirangeStabilizers : Template
    {
        public static readonly Guid ID = Guid.Parse("752136f1-2b7c-46ea-9fe2-d66b742b7767");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Modification - Omnirange Stabilizers",
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
            yield return new TextBlock { Id = Guid.Parse("ad75fb6a-8632-4b64-b76f-021a347ff7d2"), Type = TextBlockType.Enumeration, Text = $"*Ranged Only**" };
            yield return new TextBlock { Id = Guid.Parse("a30929a0-c1bf-44fc-a051-51f72d9de6f1"), Type = TextBlockType.Text, Text = $"You've modified your innovation to be dangerous and effective at any range. If your innovation had the {ToMarkdownLink<Models.Entities.Trait>("volley", Traits.Instances.Volley.ID)} trait, remove the {ToMarkdownLink<Models.Entities.Trait>("volley", Traits.Instances.Volley.ID)} trait. Otherwise, increase your innovation's range increment by 50 feet or an amount equal to the weapon's base range increment, whichever is more." };
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("68177e29-9d35-467e-a549-d5b9f6f6b673"),
                SourceId = Sources.Instances.GunsAndGears.ID,
                Page = -1
            };
        }
    }
}
