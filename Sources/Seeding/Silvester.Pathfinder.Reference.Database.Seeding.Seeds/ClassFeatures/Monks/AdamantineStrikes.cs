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
    public class AdamantineStrikes : Template
    {
        public static readonly Guid ID = Guid.Parse("ea134c61-19e5-49b6-b6f3-55691cedaebb");

        protected override ClassFeature GetClassFeature()
        {
            return new ClassFeature
            {
                Id = ID, 
                Level = 17,
                Name = "Adamantine Strikes", 
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse("30111ca4-c4a4-4b47-ae26-dc6cc9ea44d9"), Type = TextBlockType.Text, Text = "When you focus your will into your limbs, your blows are as unyielding as the hardest of metals. Your unarmed attacks are treated as adamantine." };
        }

        protected override void GetEffects(BooleanEffectBuilder builder)
        {
            //TODO: Add effects.
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("81a4c258-4846-4c60-9012-454ce339d400"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 158
            };
        }
    }
}
