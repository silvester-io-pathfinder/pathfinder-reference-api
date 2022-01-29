using Silvester.Pathfinder.Reference.Database.Effects.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Entities;

using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Effects;

using Silvester.Pathfinder.Reference.Database.Models.Effects.Builders;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.ClassFeatures.Sorcerers
{
    public class MasterSpellcaster : Template
    {
        public static readonly Guid ID = Guid.Parse("23dba3a9-5570-48e5-ac72-ed9d14ba5e04");

        protected override ClassFeature GetClassFeature()
        {
            return new ClassFeature
            {
                Id = ID, 
                Level = 15,
                Name = "Master Spellcaster", 
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse("1ea1540a-63c5-4c11-9e28-58ad9d756bcc"), Type = TextBlockType.Text, Text = "You have achieved mastery over the magic in your blood. Your proficiency ranks for spell attack rolls and spell DCs for spells of your bloodline's tradition increase to master." };
        }

        protected override void GetEffects(BooleanEffectBuilder builder)
        {
            builder.GainSpecificSpellAttackProficiency(Guid.Parse("24fa0dea-6610-4a6c-8c95-f30cb70bea53"), Proficiencies.Instances.Master.ID);
            builder.GainSpecificSpellDcProficiency(Guid.Parse("6e26fedf-0261-48c9-a41e-10184c9bc5e3"), Proficiencies.Instances.Master.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("50962d89-97b3-40ac-890f-35abd7c78a71"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 194
            };
        }
    }
}
