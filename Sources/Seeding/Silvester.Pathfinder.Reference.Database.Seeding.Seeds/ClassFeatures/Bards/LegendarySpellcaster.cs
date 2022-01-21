using Silvester.Pathfinder.Reference.Database.Effects.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Entities;

using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Effects;

using Silvester.Pathfinder.Reference.Database.Models.Effects.Builders;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.ClassFeatures.Bards
{
    public class LegendarySpellcaster : Template
    {
        public static readonly Guid ID = Guid.Parse("2d235230-6547-422a-8b6e-0587c2a95182");

        protected override ClassFeature GetClassFeature()
        {
            return new ClassFeature
            {
                Id = ID, 
                Level = 19,
                Name = "Legendary Spellcaster", 
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse("23fb5734-b1bd-452a-9db7-130b0de68865"), Type = TextBlockType.Text, Text = "Your command of occult magic is the stuff of legends. Your proficiency ranks for occult spell attack rolls and spell DCs increase to legendary" };
        }

        protected override void GetEffects(BooleanEffectBuilder builder)
        {
            builder.GainSpecificSpellAttackProficiency(Guid.Parse("8d6300c4-54b8-4450-b56c-4fa65c1dd9c0"), Proficiencies.Instances.Legendary.ID);
            builder.GainSpecificSpellDcProficiency(Guid.Parse("fdc16510-cd30-4f5d-b32e-4a5f9af86439"), Proficiencies.Instances.Legendary.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("2b34511d-1f6f-4947-8b08-04491873488f"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 99
            };
        }
    }
}
