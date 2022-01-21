using Silvester.Pathfinder.Reference.Database.Effects.Instances;
using Silvester.Pathfinder.Reference.Database.Effects;

using Silvester.Pathfinder.Reference.Database.Models.Entities;


using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Builders;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.ClassFeatures.Wizards
{
    public class ExpertSpellcaster : Template
    {
        public static readonly Guid ID = Guid.Parse("ebb63a22-89f7-4e2e-88bd-74a0a6a317a5");

        protected override ClassFeature GetClassFeature()
        {
            return new ClassFeature
            {
                Id = ID, 
                Level = 7,
                Name = "Expert Spellcaster", 
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse("d098abeb-2b74-4427-af1c-ddcd07c4e338"), Type = TextBlockType.Text, Text = "Extended practice of the arcane has improved your capabilities. Your proficiency ranks for arcane spell attack rolls and spell DCs increase to expert." };
        }

        protected override void GetEffects(BooleanEffectBuilder builder)
        {
            builder.GainSpecificSpellAttackProficiency(Guid.Parse("8552ad08-36f7-4e2f-9f33-0dca05ca3a30"), Proficiencies.Instances.Expert.ID);
            builder.GainSpecificSpellDcProficiency(Guid.Parse("75446714-6e66-4f2f-bd8c-2109ea02de97"), Proficiencies.Instances.Expert.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("1d4a89ea-de99-4a8c-b176-3f9f9219226a"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 207
            };
        }
    }
}
