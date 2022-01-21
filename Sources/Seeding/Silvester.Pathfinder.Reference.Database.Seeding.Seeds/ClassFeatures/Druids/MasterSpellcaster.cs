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
    public class MasterSpellcaster : Template
    {
        public static readonly Guid ID = Guid.Parse("40850b63-0e9e-458a-a6a0-03d88fc3e085");

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
            yield return new TextBlock { Id = Guid.Parse("ef85f2a1-5f7e-4d6c-b4c6-6527177036f8"), Type = TextBlockType.Text, Text = "Primal magic answers your command. Your proficiency ranks for primal spell attack rolls and spell DCs increase to master." };
        }

        protected override void GetEffects(BooleanEffectBuilder builder)
        {
            builder.GainSpecificSpellAttackProficiency(Guid.Parse("ea7e352a-a6aa-4c89-96fe-1c5092930015"), Proficiencies.Instances.Master.ID);
            builder.GainSpecificSpellDcProficiency(Guid.Parse("8a0bd01a-016c-43c2-8de1-139b5a2cc8e6"), Proficiencies.Instances.Master.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("c08a7604-b5a6-42e9-9b17-0e5af99093ef"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 133
            };
        }
    }
}
