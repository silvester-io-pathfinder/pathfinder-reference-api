using Silvester.Pathfinder.Reference.Database.Effects.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Entities;

using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Effects;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.ClassFeatures.Gunslingers
{
    public class Evasion : Template
    {
        public static readonly Guid ID = Guid.Parse("f2bc7dfd-f4a6-45f2-8452-27c408befff8");

        protected override ClassFeature GetClassFeature()
        {
            return new ClassFeature
            {
                Id = ID, 
                Level = 11,
                Name = "Evasion", 
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse("c4beca4d-36da-454d-afd6-096f24693e1e"), Type = TextBlockType.Text, Text = "you've learned to move quickly to avoid explosions, a dragon's breath, and worse. Your proficiency rank for Reflex saves increases to master. When you roll a success on a Reflex save, you get a critical success instead." };
        }

        protected override void GetEffects(BooleanEffectBuilder builder)
        {
            builder.GainSpecificSavingThrowProficiency(Guid.Parse("76d763b5-1c22-4021-9912-042dc467cbb3"), Proficiencies.Instances.Master.ID, SavingThrowStats.Instances.Reflex.ID);
            builder.ImproveSpecificSavingThrow(Guid.Parse("93eeb815-b800-4861-9364-14ed6feb30bb"), SavingThrowStats.Instances.Reflex.ID, RollResult.Success, becomes: RollResult.CriticalSuccess);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("5bf5a8a1-fb9c-4e2f-a489-1d800b3b2d58"),
                SourceId = Sources.Instances.GunsAndGears.ID,
                Page = 107
            };
        }
    }
}
