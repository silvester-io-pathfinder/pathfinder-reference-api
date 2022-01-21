using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Builders;
using Silvester.Pathfinder.Reference.Database.Effects.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Heritages.Instances
{
    public class BattleReadyOrc : Template
    {
        public static readonly Guid ID = Guid.Parse("f2fc5666-5b39-48e6-82b6-09e94eb4d888");

        protected override Heritage GetHeritage()
        {
            return new Heritage 
            { 
                Id = ID, 
                RarityId = Rarities.Instances.Common.ID, 
                Name = "Battle-Ready Orc"
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse("62c95ca9-ac98-447a-aace-27d50a0fda02"), Type = TextBlockType.Text, Text = "You descend from a line of terrifying battlefield commanders. You become trained in Intimidation, and you gain the Intimidating Glare skill feat." };
        }

        protected override void GetEffects(BooleanEffectBuilder builder)
        {
            builder.GainSpecificSkillProficiency(Guid.Parse("b388a728-f7dd-49ca-b7f9-7e7bc943b064"), Proficiencies.Instances.Trained.ID, Skills.Instances.Intimidation.ID);
            builder.GainSpecificFeat(Guid.Parse("17040c20-f3ef-4593-b2d8-420a25be09fb"), Feats.Instances.IntimidatingGlare.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("2612d910-a22d-4c3f-8f22-5361c4d0165d"),
                SourceId = Sources.Instances.AncestryGuide.ID,
                Page = 49
            };
        }

        protected override IEnumerable<Guid> GetAncestries()
        {
            yield return Ancestries.Instances.Orc.ID;
        }
    }
}
