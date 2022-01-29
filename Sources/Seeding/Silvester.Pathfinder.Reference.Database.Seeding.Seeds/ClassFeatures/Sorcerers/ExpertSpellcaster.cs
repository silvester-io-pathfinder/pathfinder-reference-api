using Silvester.Pathfinder.Reference.Database.Effects.Instances;
using Silvester.Pathfinder.Reference.Database.Effects;

using Silvester.Pathfinder.Reference.Database.Models.Entities;


using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Builders;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.ClassFeatures.Sorcerers
{
    public class ExpertSpellcaster : Template
    {
        public static readonly Guid ID = Guid.Parse("81e5fa85-97fa-4155-b839-250cc4ace810");

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
            yield return new TextBlock { Id = Guid.Parse("3f796f14-022c-47d4-b757-309f8ee27ada"), Type = TextBlockType.Text, Text = "Your inherent magic responds easily and powerfully to your command. Your proficiency ranks for spell attack rolls and spell DCs for spells of your bloodline's tradition increase to expert." };
        }

        protected override void GetEffects(BooleanEffectBuilder builder)
        {
            builder.GainSpecificSpellAttackProficiency(Guid.Parse("b55aeb5d-0718-4356-9d9c-b8c35bf25cb2"), Proficiencies.Instances.Expert.ID);
            builder.GainSpecificSpellDcProficiency(Guid.Parse("f0a29846-6d83-4913-8050-6d07723789e7"), Proficiencies.Instances.Expert.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("ef722b29-8594-4091-a439-1cedba1b2a88"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 194
            };
        }
    }
}
