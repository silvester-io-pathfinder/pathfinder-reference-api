using Silvester.Pathfinder.Reference.Database.Effects.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Entities;

using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Effects;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.ClassFeatures.Bards
{
    public class GreaterResolve : Template
    {
        public static readonly Guid ID = Guid.Parse("e6e4ccfa-d3d0-4dba-bb27-7fc71a799da6");

        protected override ClassFeature GetClassFeature()
        {
            return new ClassFeature
            {
                Id = ID, 
                Level = 17,
                Name = "Greater Resolve", 
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse("057caeff-7fa0-49c5-87d0-29fd45527125"), Type = TextBlockType.Text, Text = "Your unbelievable training grants you mental resiliency. Your proficiency rank for Will saves increases to legendary. When you roll a success on a Will save, you get a critical success. When you roll a critical failure on a Will save, you get a failure instead. When you roll a failure on a Will save against a damaging effect, you take half damage." };
        }

        protected override void GetEffects(BooleanEffectBuilder builder)
        {
            builder.GainSpecificSavingThrowProficiency(Guid.Parse("d5ec87d6-4399-4471-acf8-beea2ebda9cd"), Proficiencies.Instances.Legendary.ID, SavingThrowStats.Instances.Will.ID);
            builder.ImproveSpecificSavingThrow(Guid.Parse("900ba12a-8a1e-498e-93d3-ed103b3d72f1"), SavingThrowStats.Instances.Will.ID, RollResult.Success, becomes: RollResult.CriticalSuccess);
            builder.ImproveSpecificSavingThrow(Guid.Parse("f8a8e813-443a-45c5-b442-6678190213c1"), SavingThrowStats.Instances.Will.ID, RollResult.CriticalFailure, becomes: RollResult.Failure);

            //TODO: Add the half damage effect.
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("a3425768-2a59-4383-ab6e-6a36f0519237"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 99
            };
        }
    }
}
