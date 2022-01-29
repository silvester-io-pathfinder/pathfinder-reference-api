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
    public class UncannyAgility : Template
    {
        public static readonly Guid ID = Guid.Parse("688ff15d-5c1a-4213-bcb6-b9cc5bebd93b");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Uncanny Agility",
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
            yield return new TextBlock { Id = Guid.Parse("711e2b2c-ebe8-48f8-b3f1-ec4a792f317c"), Type = TextBlockType.Text, Text = $"You have near-supernatural poise that lets you move swiftly across the most unsteady surfaces. You gain the {ToMarkdownLink<Models.Entities.Feat>("Steady Balance", Feats.Instances.SteadyBalance.ID)} skill feat. You can {ToMarkdownLink<Models.Entities.Action>("Step", Actions.Instances.Step.ID)} into difficult terrain caused by uneven ground, such as a rocky field or hilly incline." };
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("f961dee4-ad2f-42d5-ab35-8508a2d1da14"),
                SourceId = Sources.Instances.LostOmensAncestryGuide.ID,
                Page = -1
            };
        }
    }
}
