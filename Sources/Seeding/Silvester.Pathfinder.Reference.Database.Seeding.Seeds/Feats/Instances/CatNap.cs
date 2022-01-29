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
    public class CatNap : Template
    {
        public static readonly Guid ID = Guid.Parse("37a4a4fe-71c9-4aeb-adf2-324fc9bbd701");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Cat Nap",
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
            yield return new TextBlock { Id = Guid.Parse("6be3dd27-41b1-4357-88ef-933b05fab0cb"), Type = TextBlockType.Text, Text = $"You can briefly sleep to regain your energy quickly. Once per hour, by sleeping for 10 minutes, you can gain temporary Hit Points equal to your level that last for 10 minutes." };
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {
            builder.Add(Guid.Parse("fa3a1b7c-44f7-4689-8e8d-5871ecc2cec2"), Traits.Instances.Catfolk.ID);
            builder.Add(Guid.Parse("aa59a11e-e7d8-4d1d-b2ba-d557ecac3103"), Traits.Instances.Concentrate.ID);
            builder.Add(Guid.Parse("3fb22472-fbaa-4ae9-a5ec-b5c971417afd"), Traits.Instances.Exploration.ID);

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("498b19b5-504a-47e0-b0ad-c09cff38de2e"),
                SourceId = Sources.Instances.LostOmensAncestryGuide.ID,
                Page = -1
            };
        }
    }
}
