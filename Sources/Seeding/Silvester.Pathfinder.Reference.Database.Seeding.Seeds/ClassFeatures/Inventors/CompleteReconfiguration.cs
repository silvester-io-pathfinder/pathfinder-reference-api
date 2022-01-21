using Silvester.Pathfinder.Reference.Database.Effects.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Entities;

using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Effects;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Builders;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.ClassFeatures.Inventors
{
    public class CompleteReconfiguration : Template
    {
        public static readonly Guid ID = Guid.Parse("77b7c434-87ff-4c78-a809-275cf118db41");

        protected override ClassFeature GetClassFeature()
        {
            return new ClassFeature
            {
                Id = ID, 
                Level = 13,
                Name = "Complete Reconfiguration", 
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse("f96ea6d5-2595-44aa-8042-14f54e68b53e"), Type = TextBlockType.Text, Text = "When it comes to crafting and tinkering, you've become incredibly adept at changing your modifications to adjust your innovation's functionality. When you spend downtime to reconfigure your innovation and succeed at your Crafting check, you can swap any number of modifications, swap your offensive boost, or retrain any number of modification feats, rather than one. You still must swap a modification only with one of the same type (initial, breakthrough, or revolutionary)." };
        }

        protected override void GetEffects(BooleanEffectBuilder builder)
        {
            //TODO: Add Effects.
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("e42a6af7-d94a-4971-a9f3-000336c60399"),
                SourceId = Sources.Instances.GunsAndGears.ID,
                Page = 2
            };
        }
    }
}
