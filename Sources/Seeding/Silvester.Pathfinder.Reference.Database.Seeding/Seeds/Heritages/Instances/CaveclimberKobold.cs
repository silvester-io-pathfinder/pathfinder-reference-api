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
    public class CaveclimberKobold : Template
    {
        public static readonly Guid ID = Guid.Parse("b9650793-5c92-4d66-bdf7-02ed9f7dbd6d");

        protected override Heritage GetHeritage()
        {
            return new Heritage 
            { 
                Id = ID, 
                RarityId = Rarities.Instances.Common.ID, 
                Name = "Caveclimber Kobold"
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse("0a7583b8-2c5e-453b-8701-9a30faae1b16"), Type = TextBlockType.Text, Text = "You live in a vertically-oriented home, and you're a consummate climber. You gain the Combat Climber skill feat, even if you don't meet the prerequisites. You can use your clawed feet and tail to Climb, leaving your hands free. Additionally, if you succeed at an Athletics check to Climb, you critically succeed instead." };
        }

        protected override void GetEffects(BooleanEffectBuilder builder)
        {
            builder.DisableFeatPrerequisites(Guid.Parse("f59b9524-2767-4bd4-b7d4-a622973c3d11"), Feats.Instances.CombatClimber.ID);
            builder.GainSpecificFeat(Guid.Parse("1bdfc6bd-2839-4316-8a14-d9f3a3a709cf"), Feats.Instances.CombatClimber.ID);
            builder.Manual(Guid.Parse("550d2b07-8eb1-4f4d-89ad-0ab02f1fab43"), "You can use your clawed feet and tail to Climb, leaving your hands free.");
            builder.ImproveSpecificSkillSpecificSkillActionCheck(Guid.Parse("7388351e-00e7-437d-b929-bc2fc209c73f"), Skills.Instances.Athletics.ID, SkillActions.Instances.Climb.ID, RollResult.Success, becomes: RollResult.CriticalSuccess);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("30d8f438-729a-4bba-be33-cc60b96ca5b0"),
                SourceId = Sources.Instances.AncestryGuide.ID,
                Page = 37
            };
        }

        protected override IEnumerable<Guid> GetAncestries()
        {
            yield return Ancestries.Instances.Kobold.ID;
        }
    }
}
