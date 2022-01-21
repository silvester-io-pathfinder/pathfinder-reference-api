using Silvester.Pathfinder.Reference.Database.Effects.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Entities;

using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Effects;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.ClassFeatures.Investigators
{
    public class GreaterResolve : Template
    {
        public static readonly Guid ID = Guid.Parse("0fa9a85b-9164-4b09-b94d-304ef5661cfd");

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
            yield return new TextBlock { Id = Guid.Parse("4aa90a9a-ec63-4639-bf73-6522d4ea3ef7"), Type = TextBlockType.Text, Text = "Your unbelievable training grants you mental resiliency. Your proficiency rank for Will saves increases to legendary. When you roll a success on a Will save, you get a critical success. When you roll a critical failure on a Will save, you get a failure instead. When you fail a Will save against a damaging effect, you take half damage." };
        }

        protected override void GetEffects(BooleanEffectBuilder builder)
        { 
            builder.GainSpecificSavingThrowProficiency(Guid.Parse("023b9adb-4a31-460c-bdae-3133b4b4738f"), Proficiencies.Instances.Legendary.ID, SavingThrowStats.Instances.Will.ID);
            builder.ImproveSpecificSavingThrow(Guid.Parse("93603f26-5e3d-425e-8a00-b140c6e36116"), SavingThrowStats.Instances.Will.ID, RollResult.CriticalFailure, becomes: RollResult.Failure);
            //TODO: Add the half damage effect.
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("fb60454b-2532-46c4-b74c-4a5c65d20e4b"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = 59
            };
        }
    }
}
