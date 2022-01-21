using Silvester.Pathfinder.Reference.Database.Effects.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Entities;

using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Effects;

using Silvester.Pathfinder.Reference.Database.Models.Effects.Builders;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.ClassFeatures.Oracles
{
    public class MasterSpellcaster : Template
    {
        public static readonly Guid ID = Guid.Parse("eb982c77-d5f9-45f8-a188-e0e96fe57107");

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
            yield return new TextBlock { Id = Guid.Parse("1511c32b-356b-4333-905f-77b3e20faad9"), Type = TextBlockType.Text, Text = "You truly understand the deep and complex divine power within your mystery. Your proficiency ranks for divine spell attack rolls and spell DCs increase to master." };
        }

        protected override void GetEffects(BooleanEffectBuilder builder)
        {
            builder.GainSpecificSpellAttackProficiency(Guid.Parse("baa8b868-3f23-47f1-a9e0-80af0e814359"), Proficiencies.Instances.Master.ID);
            builder.GainSpecificSpellDcProficiency(Guid.Parse("18df9164-1239-40a2-b268-51fb5404fc0e"), Proficiencies.Instances.Master.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("c42e91eb-1216-4c97-a407-c888f9d052a1"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = 72
            };
        }
    }
}
