using Silvester.Pathfinder.Reference.Database.Effects.Instances;
using Silvester.Pathfinder.Reference.Database.Effects;

using Silvester.Pathfinder.Reference.Database.Models.Entities;


using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Builders;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.ClassFeatures.Witches
{
    public class ExpertSpellcaster : Template
    {
        public static readonly Guid ID = Guid.Parse("0e0bd701-18e9-4bd5-a302-dbac1ad97378");

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
            yield return new TextBlock { Id = Guid.Parse("6549c331-a9fd-4a0a-a6ea-1d694e675536"), Type = TextBlockType.Text, Text = "You've learned to better control the power your patron has granted you. Your proficiency ranks for spell attacks and spell DCs for your witch spellcasting increase to expert." };
        }

        protected override void GetEffects(BooleanEffectBuilder builder)
        {
            builder.GainSpecificSpellAttackProficiency(Guid.Parse("730b5008-91be-416b-b00b-9a76c599ba7e"), Proficiencies.Instances.Expert.ID);
            builder.GainSpecificSpellDcProficiency(Guid.Parse("a00bd0a9-8979-4499-bb5d-5326b1b2ccb9"), Proficiencies.Instances.Expert.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("29199e4d-8b2c-4ac2-97e2-7e376d7cbaed"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = 98
            };
        }
    }
}
