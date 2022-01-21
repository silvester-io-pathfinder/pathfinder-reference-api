using Silvester.Pathfinder.Reference.Database.Effects.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Entities;

using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Effects;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Builders;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.ClassFeatures.Alchemists
{
    public class PowerfulAlchemy : Template
    {
        public static readonly Guid ID = Guid.Parse("2ac3bf84-e649-4530-a645-922c76afa04d");

        protected override ClassFeature GetClassFeature()
        {
            return new ClassFeature
            {
                Id = ID, 
                Level = 5, 
                Name = "Powerful Alchemy", 
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse("be50377c-e3ea-4453-a933-845929eb8993"), Type = TextBlockType.Text, Text = "Alchemical items you create on the fly are particularly potent. When you use Quick Alchemy to create an infused alchemical item that allows a saving throw, you can change its DC to your class DC." };
        }

        protected override void GetEffects(BooleanEffectBuilder builder)
        {
            //TODO: Add effects.
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("1323f958-d93c-4f85-b8f9-5a3bd9c36f22"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 74
            };
        }
    }
}
