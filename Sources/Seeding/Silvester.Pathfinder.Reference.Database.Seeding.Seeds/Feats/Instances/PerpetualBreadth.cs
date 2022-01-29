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
    public class PerpetualBreadth : Template
    {
        public static readonly Guid ID = Guid.Parse("518a1cb3-02cf-4610-91d4-d4ca9414dacc");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Perpetual Breadth",
                Level = 8,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("c127251f-552d-488e-bfca-6e397043021a"), Type = TextBlockType.Text, Text = $"You have expanded your supply of near-infinite items. Choose a research field. Add one item from the list of options available to that field from perpetual infusions, or two items if you choose your own field. If you have perpetual potency or perpetual perfection, you gain an additional item (or items if you chose your own field) appropriate to the field you chose, for instance a higher-level version of the bomb you chose or a new poison." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificClassFeature(Guid.Parse("0cff430e-3f54-49c7-8541-b6eeb955b8fb"), ClassFeatures.Alchemists.PerpetualInfusions.ID);
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("ede4f6c4-4d58-4cd4-9e3e-3b6389f818f7"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
