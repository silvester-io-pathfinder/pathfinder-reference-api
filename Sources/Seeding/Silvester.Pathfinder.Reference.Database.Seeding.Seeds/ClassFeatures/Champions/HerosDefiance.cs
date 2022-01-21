using Silvester.Pathfinder.Reference.Database.Effects.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Entities;

using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Effects;

using Silvester.Pathfinder.Reference.Database.Models.Effects.Builders;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.ClassFeatures.Champions
{
    public class HerosDefiance : Template
    {
        public static readonly Guid ID = Guid.Parse("d4b70233-e15f-47cc-be88-a208ca4777dd");

        protected override ClassFeature GetClassFeature()
        {
            return new ClassFeature
            {
                Id = ID, 
                Level = 19,
                Name = "Hero's Defiance", 
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse("b4a611ee-4078-4c44-a78e-763bdf667b8e"), Type = TextBlockType.Text, Text = "You can defy fate and continue fighting as long as you have divine energy. You gain the hero�s defiance devotion spell." };
        }

        protected override void GetEffects(BooleanEffectBuilder builder)
        {
            builder.GainSpecificSpell(Guid.Parse("9cf0e1f2-ed77-4970-8981-db2acc118a17"), Spells.Instances.HerosDefiance.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("2adc21f2-5c33-4eb3-a318-25a5064a3c45"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 109
            };
        }
    }
}
