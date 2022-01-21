using Silvester.Pathfinder.Reference.Database.Effects.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Effects;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.ClassFeatures.Rangers
{
    public class Juggernaut : Template
    {
        public static readonly Guid ID = Guid.Parse("a556b7a8-bf01-48c4-8f37-b50dfb29bc29");

        protected override ClassFeature GetClassFeature()
        {
            return new ClassFeature
            {
                Id = ID, 
                Level = 11,
                Name = "Juggernaut", 
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse("862ff3c0-ad7b-45b0-b5ff-f0090b30ac39"), Type = TextBlockType.Text, Text = "Your body has become accustomed to physical hazards and resistant to pathogens and ailments. Your proficiency rank for Fortitude saves increases to master. When you roll a success on a Fortitude save, you get a critical success instead." };
        }

        protected override void GetEffects(BooleanEffectBuilder builder)
        {
            builder.GainSpecificSavingThrowProficiency(Guid.Parse("502cee3e-856b-4a12-a538-f9d9e63ffbe7"), Proficiencies.Instances.Master.ID, SavingThrowStats.Instances.Fortitude.ID);
            builder.ImproveSpecificSavingThrow(Guid.Parse("81fc1aa5-deab-4ade-8f50-6b1b23b69abb"), SavingThrowStats.Instances.Fortitude.ID, RollResult.Success, becomes: RollResult.CriticalSuccess);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("7ae0c0ae-562b-441d-9571-093a1f11efb6"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 169
            };
        }
    }
}
