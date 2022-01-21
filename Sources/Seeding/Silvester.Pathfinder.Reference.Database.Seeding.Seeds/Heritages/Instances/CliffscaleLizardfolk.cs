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
    public class CliffscaleLizardfolk : Template
    {
        public static readonly Guid ID = Guid.Parse("72d0cbf7-5f47-4b03-a314-c6f88c902caa");

        protected override Heritage GetHeritage()
        {
            return new Heritage 
            { 
                Id = ID, 
                RarityId = Rarities.Instances.Common.ID, 
                Name = "Cliffscale Lizardfolk"
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse("999b669b-52a5-451d-9264-4860d3c980cf"), Type = TextBlockType.Text, Text = "Your toes are adapted for gripping and climbing. You gain the Combat Climber feat as a bonus feat, and as long as you aren't wearing footwear, you can use the sticky pads on your feet to climb, leaving your hands free. Additionally, if you roll a success on an Athletics check to climb, you get a critical success instead." };
        }

        protected override void GetEffects(BooleanEffectBuilder builder)
        {
            builder.GainSpecificFeat(Guid.Parse("f463cd41-d377-439e-8787-cceeed03013d"), Feats.Instances.CombatClimber.ID);
            builder.Manual(Guid.Parse("18da4043-6657-478f-9fd7-edf609d28cad"), "As long as you aren't wearing footwear, you can use the sticky pads on your feet to climb, leaving your hands free.");
            builder.ImproveSpecificSkillSpecificSkillActionCheck(Guid.Parse("ac5d196c-8457-4f95-ad07-5ba3c1e07d20"), Skills.Instances.Athletics.ID, SkillActions.Instances.Climb.ID, RollResult.Success, becomes: RollResult.CriticalSuccess);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("341f3d15-798c-4467-a899-21e350d83c6b"),
                SourceId = Sources.Instances.CharacterGuide.ID,
                Page = 57
            };
        }

        protected override IEnumerable<Guid> GetAncestries()
        {
            yield return Ancestries.Instances.Lizardfolk.ID;
        }
    }
}
