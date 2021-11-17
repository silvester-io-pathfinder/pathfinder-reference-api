using Silvester.Pathfinder.Reference.Database.Effects.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Entities;

using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Effects;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Builders;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.ClassFeatures.Monks
{
    public class MysticStrike : Template
    {
        public static readonly Guid ID = Guid.Parse("8af4974e-d817-403c-a26d-fe058a8cc811");

        protected override ClassFeature GetClassFeature()
        {
            return new ClassFeature
            {
                Id = ID, 
                Level = 3,
                Name = "Mystic Strike", 
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse("7524a919-f0c5-4560-9157-5e0964d2a403"), Type = TextBlockType.Text, Text = "Focusing your will into your physical attacks imbues them with mystical energy. Your unarmed attacks become magical, allowing them to get past resistances to non-magical attacks. However, you still need an item such as handwraps of mighty blows to gain an item bonus to attack rolls or increase your attacks' weapon damage dice." };
        }

        protected override void GetEffects(BooleanEffectBuilder builder)
        {
            //TODO: Add effects.
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("fe64bf0b-12bb-4a48-9fca-dfb7bdce87eb"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 156
            };
        }
    }
}
