using Silvester.Pathfinder.Reference.Database.Effects.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Entities;

using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Effects;

using Silvester.Pathfinder.Reference.Database.Models.Effects.Builders;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.ClassFeatures.Witches
{
    public class LegendarySpellcaster : Template
    {
        public static readonly Guid ID = Guid.Parse("7c98af4a-4ce0-4e9d-8959-446df61bf616");

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
            yield return new TextBlock { Id = Guid.Parse("dfcef2db-816b-4710-bcbf-46126112c203"), Type = TextBlockType.Text, Text = "You've perfected your command of the magic your patron provides. Your proficiency ranks for spell attacks and spell DCs for your witch spellcasting increase to legendary." };
        }

        protected override void GetEffects(BooleanEffectBuilder builder)
        {
            builder.GainSpecificSpellAttackProficiency(Guid.Parse("97bd24b0-b0ea-4bf3-82e3-464a245cba72"), Proficiencies.Instances.Legendary.ID);
            builder.GainSpecificSpellDcProficiency(Guid.Parse("bafe2224-94e2-401f-acba-49a7d8d22a6e"), Proficiencies.Instances.Legendary.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("14a37bec-ed16-49cf-b442-3a5709f75dd6"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = 99
            };
        }
    }
}
