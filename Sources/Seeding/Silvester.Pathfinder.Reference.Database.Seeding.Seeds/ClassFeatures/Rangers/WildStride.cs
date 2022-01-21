using Silvester.Pathfinder.Reference.Database.Effects.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Entities;

using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Effects;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Builders;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.ClassFeatures.Rangers
{
    public class WildStride : Template
    {
        public static readonly Guid ID = Guid.Parse("499be93f-599a-48d0-8f3b-ae932d18f6e3");

        protected override ClassFeature GetClassFeature()
        {
            return new ClassFeature
            {
                Id = ID, 
                Level = 11,
                Name = "Wild Stride", 
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse("4aabb447-4358-4563-a591-1807b52d3211"), Type = TextBlockType.Text, Text = "You move quickly through obstacles, whether they�re tumbled stone, tangled undergrowth, or sucking mud. You can ignore the effects of non-magical difficult terrain. As normal for ignoring difficult terrain, this also lets you treat the hindrances of greater difficult terrain as those of difficult terrain." };
        }

        protected override void GetEffects(BooleanEffectBuilder builder)
        {
            //TODO: Add effects.
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("0575fb5f-7818-41f1-8a7b-05ade07d60c3"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 169
            };
        }
    }
}
