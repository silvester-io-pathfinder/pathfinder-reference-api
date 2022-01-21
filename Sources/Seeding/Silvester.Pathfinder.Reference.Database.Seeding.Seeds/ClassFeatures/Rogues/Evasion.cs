using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Effects;
using Silvester.Pathfinder.Reference.Database.Effects.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.ClassFeatures.Evasion
{
    public class Evasion : Template
    {
        public static readonly Guid ID = Guid.Parse("945d18b0-2008-4898-ac0d-afd9641d6062");

        protected override ClassFeature GetClassFeature()
        {
            return new ClassFeature
            {
                Id = ID, 
                Level = 7,
                Name = "Evasion", 
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse("a09e655a-22c7-449f-bb30-a62aa9b16360"), Type = TextBlockType.Text, Text = "ou�ve learned to move quickly to avoid explosions, dragons� breath, and worse. Your proficiency rank for Reflex saves increases to master. When you roll a success on a Reflex save, you get a critical success instead." };
        }

        protected override void GetEffects(BooleanEffectBuilder builder)
        {
            builder.GainSpecificSavingThrowProficiency(Guid.Parse("ae1d4487-4ba8-49be-b2a0-77f3579d5224"), Proficiencies.Instances.Master.ID, SavingThrowStats.Instances.Reflex.ID);
            builder.ImproveSpecificSavingThrow(Guid.Parse("55812c65-49f9-42d6-92ae-d0d3b578280c"), SavingThrowStats.Instances.Reflex.ID, RollResult.Success, becomes: RollResult.CriticalSuccess);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("0dc2c614-d967-407d-80c9-347a3e133937"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 182
            };
        }
    }
}
