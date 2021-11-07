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
        public static readonly Guid ID = Guid.Parse("");

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
            yield return new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Text, Text = "You live in a vertically-oriented home, and you're a consummate climber. You gain the Combat Climber skill feat, even if you don't meet the prerequisites. You can use your clawed feet and tail to Climb, leaving your hands free. Additionally, if you succeed at an Athletics check to Climb, you critically succeed instead." };
        }

        protected override void GetEffects(BooleanEffectBuilder builder)
        {
            builder.DisableFeatPrerequisites(Guid.Parse(""), Feats.Instances.CombatClimber.ID);
            builder.GainSpecificFeat(Guid.Parse(""), Feats.Instances.CombatClimber.ID);
            builder.Manual(Guid.Parse(""), "You can use your clawed feet and tail to Climb, leaving your hands free.");
            builder.ImproveSpecificSkillSpecificSkillActionCheck(Guid.Parse(""), Skills.Instances.Athletics.ID, SkillActions.Instances.Climb.ID, RollResult.Success, becomes: RollResult.CriticalSuccess);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse(""),
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
