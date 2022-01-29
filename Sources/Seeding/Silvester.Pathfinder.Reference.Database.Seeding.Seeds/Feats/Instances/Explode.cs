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
    public class Explode : Template
    {
        public static readonly Guid ID = Guid.Parse("110e4f7e-e975-4c0d-9cbe-616d82732118");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Explode",
                Level = -1,
                ActionTypeId = ActionTypes.Instances.TwoActions.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("1599fd3e-93ba-4e3a-8b85-cef2bc02c41d"), Type = TextBlockType.Text, Text = $"You intentionally take your innovation beyond normal safety limits, making it explode and damage nearby creatures without damaging the innovation... hopefully. The explosion deals 2d6 fire damage with a basic Reflex save to all creatures in a 5-foot emanation around you (if you're wearing or holding the innovation) or around your innovation (if your innovation is a minion)." };
            yield return new TextBlock { Id = Guid.Parse("535c6dd6-a78d-4c9f-bdea-985c79633095"), Type = TextBlockType.Text, Text = $"At 3rd level, and every level thereafter, increase your explosion's damage by 1d6." };
            yield return new TextBlock { Id = Guid.Parse("205cb1df-5598-4f82-89f0-12c50ee432a4"), Type = TextBlockType.Text, Text = $"If you have the breakthrough innovation class feature, you can choose either a 5-foot or 10-foot emanation for the area when you use Explode; if you have the revolutionary innovation class feature, you can choose a 5-foot, 10-foot, or 15-foot emanation." };
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("d337f177-e0d3-4ec3-bac8-45c78fc6b8dc"),
                SourceId = Sources.Instances.GunsAndGears.ID,
                Page = -1
            };
        }
    }
}
