using Silvester.Pathfinder.Reference.Database.Effects.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Ancestries.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Heritages.Instances
{
    public class JinxedHalfling : Template
    {
        public static readonly Guid ID = Guid.Parse("c2c39377-feae-4142-a4c9-6d0e458d355c");

        protected override Heritage GetHeritage()
        {
            return new Heritage 
            { 
                Id = ID, 
                RarityId = Rarities.Instances.Common.ID, 
                Name = "Jinxed Halfling"
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse("177eb029-adba-4d7b-b538-b708c727464c"), Type = TextBlockType.Text, Text = "You were born with a strange blessing: bereft of the typical halfling luck, you can instead manipulate the fortunes of others. You can never take the Halfling Luck feat, and you gain the Jinx action." };
        }

        protected override void GetEffects(BooleanEffectBuilder builder)
        {
            builder.GainSpecificFeat(Guid.Parse("bb60f0d1-3621-4c06-9189-2c6f612389f0"), Feats.Instances.Jinx.ID);
            builder.ProhibitSpecificFeat(Guid.Parse("4667c25f-acdd-4206-ab84-367a1d16ab47"), Feats.Instances.HalflingLuck.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("be69a293-a9a7-42c6-9f4c-6c34e054ad1d"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = 46
            };
        }

        protected override IEnumerable<Guid> GetAncestries()
        {
            yield return Halfling.ID;
        }
    }
}
