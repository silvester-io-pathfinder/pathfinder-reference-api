using Silvester.Pathfinder.Reference.Database.Effects.Instances;
using Silvester.Pathfinder.Reference.Database.Effects;

using Silvester.Pathfinder.Reference.Database.Models.Entities;


using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Builders;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.ClassFeatures.Oracles
{
    public class MagicalFortitude : Template
    {
        public static readonly Guid ID = Guid.Parse("e5a01cb0-c3f7-41ae-b954-3a7bc0fcc5b1");

        protected override ClassFeature GetClassFeature()
        {
            return new ClassFeature
            {
                Id = ID, 
                Level = 9,
                Name = "Magical Fortitude", 
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse("c4c4b5da-d2c8-4c4b-86d3-5f53079fdaae"), Type = TextBlockType.Text, Text = "Magical power has improved your body�s resiliency. Your proficiency rank for Fortitude saves increases to expert." };
        }

        protected override void GetEffects(BooleanEffectBuilder builder)
        {
            builder.GainSpecificSavingThrowProficiency(Guid.Parse("c75f2700-968d-459c-be50-27335d305469"), Proficiencies.Instances.Expert.ID, SavingThrowStats.Instances.Fortitude.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("4245c3ca-3f0a-429d-b4af-f2ed9946cb36"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = 71
            };
        }
    }
}
