using Silvester.Pathfinder.Reference.Database.Effects.Instances;
using Silvester.Pathfinder.Reference.Database.Effects;

using Silvester.Pathfinder.Reference.Database.Models.Entities;


using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Builders;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.ClassFeatures.Druids
{
    public class ExpertSpellcaster : Template
    {
        public static readonly Guid ID = Guid.Parse("1296819e-cd85-4b1a-9746-a6300210e9d9");

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
            yield return new TextBlock { Id = Guid.Parse("ccdca345-7e49-4eb3-b0eb-452c43907557"), Type = TextBlockType.Text, Text = "Your command of primal forces has deepened, empowering your spells. Your proficiency ranks for primal spell attack rolls and spell DCs increase to expert." };
        }

        protected override void GetEffects(BooleanEffectBuilder builder)
        {
            builder.GainSpecificSpellAttackProficiency(Guid.Parse("da38e6f3-1f77-4303-91f5-2f2edc439c18"), Proficiencies.Instances.Expert.ID);
            builder.GainSpecificSpellDcProficiency(Guid.Parse("39109609-fa3d-4f74-8610-8953b54c5871"), Proficiencies.Instances.Expert.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("3e19e795-1e70-4d64-9575-fb53e12fbc1f"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 133
            };
        }
    }
}
