using Silvester.Pathfinder.Reference.Database.Effects.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Entities;

using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Effects;

using Silvester.Pathfinder.Reference.Database.Models.Effects.Builders;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.ClassFeatures.Druids
{
    public class LegendarySpellcaster : Template
    {
        public static readonly Guid ID = Guid.Parse("7bdd30f5-19d0-446f-bd1e-f1e5f2f9f329");

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
            yield return new TextBlock { Id = Guid.Parse("fb4a2139-5631-4b58-8f5c-73b5b81a2741"), Type = TextBlockType.Text, Text = "You have developed an unparalleled rapport with the magic of nature. Your proficiency ranks for primal spell attack rolls and spell DCs increase to legendary." };
        }

        protected override void GetEffects(BooleanEffectBuilder builder)
        {
            builder.GainSpecificSpellAttackProficiency(Guid.Parse("7b5b1bf2-f9bd-45c4-991b-285930b1d01b"), Proficiencies.Instances.Legendary.ID);
            builder.GainSpecificSpellDcProficiency(Guid.Parse("4575406c-290c-49b7-8aa0-fb7728a3fe59"), Proficiencies.Instances.Legendary.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("0b08f1a8-b33e-481d-8bd2-7543b042dd9f"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 133
            };
        }
    }
}
