using Silvester.Pathfinder.Reference.Database.Effects.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Entities;

using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Effects;

using Silvester.Pathfinder.Reference.Database.Models.Effects.Builders;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.ClassFeatures.Fighters
{
    public class CombatFlexibility : Template
    {
        public static readonly Guid ID = Guid.Parse("aedf59cf-cf52-413b-ace6-4f2cea1d4cbc");

        protected override ClassFeature GetClassFeature()
        {
            return new ClassFeature
            {
                Id = ID, 
                Level = 9,
                Name = "Combat Flexibility", 
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse("f7187c0f-aaf5-43d0-9391-e37e5e4692e7"), Type = TextBlockType.Text, Text = "Through your experience in battle, you can prepare your tactics to suit different situations. When you make your daily preparations, you gain one fighter feat of 8th level or lower that you don't already have. You can use that feat until your next daily preparations. You must meet all of the feat's other prerequisites." };
        }

        protected override void GetEffects(BooleanEffectBuilder builder)
        {
            builder.GainAnyDailyClassFeat(Guid.Parse("d560f5e2-1495-41a7-9a2a-f0e916ac91d1"), Classes.Instances.Fighter.ID, level: 8);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("7b9ba069-84fc-46c6-a875-808f59170a07"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 143
            };
        }
    }
}
