using Silvester.Pathfinder.Reference.Database.Effects.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Entities;

using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Effects;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.ClassFeatures.Magusi
{
    public class Juggernaut : Template
    {
        public static readonly Guid ID = Guid.Parse("0734ab5d-33fa-496e-82fa-eb23cb0f90c9");

        protected override ClassFeature GetClassFeature()
        {
            return new ClassFeature
            {
                Id = ID, 
                Level = 15,
                Name = "Juggernaut", 
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse("3d2e90bd-6d31-4ff5-8f63-4f816f25a12d"), Type = TextBlockType.Text, Text = "Your body is accustomed to physical hardship and resistant to a wide range of ailments. Your proficiency rank for Fortitude saves increases to master. When you roll a success on a Fortitude save, you get a critical success instead." };
        }

        protected override void GetEffects(BooleanEffectBuilder builder)
        {
            builder.GainSpecificSavingThrowProficiency(Guid.Parse("f1da1d01-1f10-459d-96a8-72c4dee72781"), Proficiencies.Instances.Master.ID, SavingThrowStats.Instances.Fortitude.ID);
            builder.ImproveSpecificSavingThrow(Guid.Parse("599c96bf-f903-40cc-b7c2-d5a52e356bbe"), SavingThrowStats.Instances.Fortitude.ID, RollResult.Success, becomes: RollResult.CriticalSuccess);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("22b65989-7d36-460e-a91f-a4b99956698a"),
                SourceId = Sources.Instances.SecretsOfMagic.ID,
                Page = 42
            };
        }
    }
}
