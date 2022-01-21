using Silvester.Pathfinder.Reference.Database.Effects.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Entities;

using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Effects;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.ClassFeatures.Inventors
{
    public class Juggernaut : Template
    {
        public static readonly Guid ID = Guid.Parse("e4dc5040-7029-4150-8dd3-cdb7cd7796f0");

        protected override ClassFeature GetClassFeature()
        {
            return new ClassFeature
            {
                Id = ID, 
                Level = 17,
                Name = "Juggernaut", 
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse("e1169e57-68b9-42be-8fd8-79031ac61690"), Type = TextBlockType.Text, Text = "Your body is accustomed to physical hardship and resistant to ailments. Your proficiency rank for Fortitude saves increases to master. When you roll a success on a Fortitude save, you get a critical success instead." };
        }

        protected override void GetEffects(BooleanEffectBuilder builder)
        {
            builder.GainSpecificSavingThrowProficiency(Guid.Parse("06bfe1be-7062-44ea-b381-09d9e366ee80"), Proficiencies.Instances.Master.ID, SavingThrowStats.Instances.Fortitude.ID);
            builder.ImproveSpecificSavingThrow(Guid.Parse("67666935-0d64-4658-8598-9b3661a5d34f"), SavingThrowStats.Instances.Fortitude.ID, RollResult.Success, becomes: RollResult.CriticalSuccess);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("9248850c-8c73-4777-9381-b09e57bda50c"),
                SourceId = Sources.Instances.GunsAndGears.ID,
                Page = 24
            };
        }
    }
}
