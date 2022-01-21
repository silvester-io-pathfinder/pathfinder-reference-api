using Silvester.Pathfinder.Reference.Database.Effects;
using Silvester.Pathfinder.Reference.Database.Effects.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Builders;

using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.ResearchFields.Instances
{
    public class Mutagenist : Template
    {
        public static readonly Guid ID = Guid.Parse("0266c009-9e51-49aa-b62a-4c54a3825bec");

        protected override ResearchField GetResearchField()
        {
            return new ResearchField
            {
                Id = ID, 
                Name = "Mutagenist", 
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse("ee5d598e-37e3-4d70-936c-28c4c9431976"), Type = TextBlockType.Text, Text = "You focus on bizarre mutagenic transformations that sacrifice one aspect of a creature's physical or psychological being in order to strengthen another. You start with the formulas for two 1st-level mutagens in your formula book, in addition to your other formulas." };
        }

        protected override void GetEffects(BooleanEffectBuilder builder)
        {
            builder.GainSpecificFeat(Guid.Parse("de33793e-5539-4793-8d63-2865a1274c80"), Feats.Instances.MutagenicFlashback.ID);
            builder.GainAnyMutagenFormula(Guid.Parse("b652d504-d00c-43c7-9010-acfd5bef78de"), level: 1);
            builder.GainAnyMutagenFormula(Guid.Parse("6ba40ea3-6928-4e60-a5dc-0b20c6397000"), level: 1);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("bbd418bf-b8a5-4b2b-98df-d859c950b73d"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 73
            };
        }
    }
}
