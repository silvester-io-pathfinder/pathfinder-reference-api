using Silvester.Pathfinder.Reference.Database.Effects.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Entities;

using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Effects;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.ClassFeatures.Fighters
{
    public class Evasion : Template
    {
        public static readonly Guid ID = Guid.Parse("e8011410-b502-4f91-a4bc-350ffb0433b7");

        protected override ClassFeature GetClassFeature()
        {
            return new ClassFeature
            {
                Id = ID, 
                Level = 15,
                Name = "Evasion", 
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse("0e2981b8-9609-4c91-8000-6ba3aea0ae42"), Type = TextBlockType.Text, Text = "you've learned to move quickly to avoid explosions, a dragon's breath, and worse. Your proficiency rank for Reflex saves increases to master. When you roll a success on a Reflex save, you get a critical success instead." };
        }

        protected override void GetEffects(BooleanEffectBuilder builder)
        {
            builder.GainSpecificSavingThrowProficiency(Guid.Parse("6e87ee2f-fd7a-43cc-bd40-eec1c93c896c"), Proficiencies.Instances.Master.ID, SavingThrowStats.Instances.Reflex.ID);
            builder.ImproveSpecificSavingThrow(Guid.Parse("f34eb2ea-64fb-47e7-8ce2-5db17b62828f"), SavingThrowStats.Instances.Reflex.ID, RollResult.Success, becomes: RollResult.CriticalSuccess);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("315ea345-89f7-45e6-911f-c63c912df578"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 143
            };
        }
    }
}
