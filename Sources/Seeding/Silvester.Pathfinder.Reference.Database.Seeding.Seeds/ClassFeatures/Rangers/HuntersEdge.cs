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
    public class HuntersEdge : Template
    {
        public static readonly Guid ID = Guid.Parse("67f44b90-07fc-46c6-a40f-bad99414a081");

        protected override ClassFeature GetClassFeature()
        {
            return new ClassFeature
            {
                Id = ID, 
                Level = 1,
                Name = "Hunters Edge", 
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse("7ce6682d-a7e3-45b0-aa6f-2ecbfbb2cb3d"), Type = TextBlockType.Text, Text = "You have trained for countless hours to become a more skilled hunter and tracker, gaining an additional benefit when you Hunt Prey depending on the focus of your training. Choose a hunter's edge." };
        }

        protected override void GetEffects(BooleanEffectBuilder builder)
        {
            builder.GainAnyHuntersEdge(Guid.Parse("669f438f-b84f-400d-82b2-47eec6a48f23"));
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("0f8df60d-c70c-4d99-abf3-12431b16e6f7"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 168
            };
        }
    }
}
