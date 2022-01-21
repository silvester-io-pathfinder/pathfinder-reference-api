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
    public class ImprovedEvasion : Template
    {
        public static readonly Guid ID = Guid.Parse("f1a8323e-b23d-4f43-b168-89e7ae5e214b");

        protected override ClassFeature GetClassFeature()
        {
            return new ClassFeature
            {
                Id = ID, 
                Level = 15,
                Name = "Improved Evasion", 
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse("d6b799c5-4b35-435c-af9e-b3d26d150770"), Type = TextBlockType.Text, Text = "Your ability to elude danger is matchless. Your proficiency rank for Reflex saves increases to legendary. When you roll a critical failure on a Reflex save, you get a failure instead. When you roll a failure on a Reflex save against a damaging effect, you take half damage." };
        }

        protected override void GetEffects(BooleanEffectBuilder builder)
        {
            builder.GainSpecificSavingThrowProficiency(Guid.Parse("50b293a1-5524-4b7b-a35a-3ac02760ca58"), Proficiencies.Instances.Legendary.ID, SavingThrowStats.Instances.Reflex.ID);
            builder.ImproveSpecificSavingThrow(Guid.Parse("b30b30af-d7a2-4e84-a258-3b738e24ec40"), SavingThrowStats.Instances.Reflex.ID, RollResult.CriticalFailure, becomes: RollResult.Failure);
            //TODO: Add half damage effect.
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("51192a7d-def6-423d-825e-303e7869f52c"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 170
            };
        }
    }
}
