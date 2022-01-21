using Silvester.Pathfinder.Reference.Database.Effects.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Entities;

using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Effects;

using Silvester.Pathfinder.Reference.Database.Models.Effects.Builders;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.ClassFeatures.Alchemists
{
    public class IronWill : Template
    {
        public static readonly Guid ID = Guid.Parse("0646a71b-d3f6-4661-bfc9-b3ea02259641");

        protected override ClassFeature GetClassFeature()
        {
            return new ClassFeature
            {
                Id = ID, 
                Level = 7,
                Name = "Iron Will", 
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse("ef07e070-0840-4c04-a43f-94c87c38ab52"), Type = TextBlockType.Text, Text = "Your mental defenses are an iron fortress. Your proficiency rank for Will saves increases to expert." };
        }

        protected override void GetEffects(BooleanEffectBuilder builder)
        {
            builder.GainSpecificSavingThrowProficiency(Guid.Parse("ee9f5428-b313-4a15-a2ad-7058603507c9"), Proficiencies.Instances.Expert.ID, SavingThrowStats.Instances.Will.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("d6466d2a-f589-4421-a6f6-8c64ac5f2de1"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 75
            };
        }
    }
}
