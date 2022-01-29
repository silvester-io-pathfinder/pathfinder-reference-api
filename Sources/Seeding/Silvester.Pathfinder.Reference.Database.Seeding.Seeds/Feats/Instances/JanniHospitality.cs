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
    public class JanniHospitality : Template
    {
        public static readonly Guid ID = Guid.Parse("f70f754e-5cc7-4c2f-99d2-ff0f3db8d346");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Janni Hospitality",
                Level = 9,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("251841f0-f717-421e-a288-06141f0f8b38"), Type = TextBlockType.Text, Text = $"You can use magic to show others desert hospitality. You can cast 2nd-level {ToMarkdownLink<Models.Entities.Spell>("create food", Spells.Instances.CreateFood.ID)} once per day and {ToMarkdownLink<Models.Entities.Spell>("create water", Spells.Instances.CreateWater.ID)} twice per day as arcane innate spells." };
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("8297296c-0db7-4d89-bd9c-b58768e2ee3a"),
                SourceId = Sources.Instances.LostOmensAncestryGuide.ID,
                Page = -1
            };
        }
    }
}
