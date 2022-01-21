using Silvester.Pathfinder.Reference.Database.Effects.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Effects;

using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;

using Silvester.Pathfinder.Reference.Database.Effects;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.ClassFeatures.Monks
{
    public class PathToPerfection : Template
    {
        public static readonly Guid ID = Guid.Parse("00ba1731-bd8f-4c91-8430-b3997b7d225f");

        protected override ClassFeature GetClassFeature()
        {
            return new ClassFeature
            {
                Id = ID, 
                Level = 7,
                Name = "Path to Perfection", 
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse("f927b30d-bdcf-4f4a-8140-c249d74224b6"), Type = TextBlockType.Text, Text = "You have progressed along your own path to enlightenment. Choose your Fortitude, Reflex, or Will saving throw. Your proficiency rank for the chosen saving throw increases to master. When you roll a success on the chosen saving throw, you get a critical success instead." };
        }

        protected override void GetEffects(BooleanEffectBuilder builder)
        {
            builder.GainAnySavingThrowProficiency(Guid.Parse("4057ca21-0b99-4301-8bb1-2a82f8092819"), Proficiencies.Instances.Expert.ID);
            builder.ImproveAnySavingThrow(Guid.Parse("e819e56a-53ad-4220-864b-43519b55af34"), RollResult.Success, becomes: RollResult.CriticalSuccess);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("21845c81-ca41-4086-bf10-73c090a8a0e0"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 157
            };
        }
    }
}
