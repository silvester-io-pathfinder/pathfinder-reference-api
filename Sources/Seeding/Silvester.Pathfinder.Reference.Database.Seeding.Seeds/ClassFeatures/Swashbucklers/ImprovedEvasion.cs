using Silvester.Pathfinder.Reference.Database.Effects.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Entities;

using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Effects;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.ClassFeatures.Swashbucklers
{
    public class ImprovedEvasion : Template
    {
        public static readonly Guid ID = Guid.Parse("ba48e511-95c0-4a22-8f84-27512475342f");

        protected override ClassFeature GetClassFeature()
        {
            return new ClassFeature
            {
                Id = ID, 
                Level = 13,
                Name = "Improved Evasion", 
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse("f923746c-57ae-413c-9cad-669487eb5cdb"), Type = TextBlockType.Text, Text = "You elude danger to a degree that few can match. Your proficiency rank for Reflex saves increases to legendary. When you roll a critical failure on a Reflex save, you get a failure instead. When you roll a failure on a Reflex save against a damaging effect, you take half damage." };
        }

        protected override void GetEffects(BooleanEffectBuilder builder)
        {
            builder.GainSpecificSavingThrowProficiency(Guid.Parse("34c8eebf-0613-422a-a846-bab3a9e26189"), Proficiencies.Instances.Legendary.ID, SavingThrowStats.Instances.Reflex.ID);
            builder.ImproveSpecificSavingThrow(Guid.Parse("75942f6b-3baa-408d-af4c-1647843e64c4"), SavingThrowStats.Instances.Reflex.ID, RollResult.CriticalFailure, becomes: RollResult.Failure);
            //TODO: Add half damage effect.
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("2275f211-f85d-42dc-b4f5-57f2c00b12d0"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = 87
            };
        }
    }
}
