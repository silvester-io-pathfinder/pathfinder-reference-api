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
    public class CavernKobold : Template
    {
        public static readonly Guid ID = Guid.Parse("");

        protected override Heritage GetHeritage()
        {
            return new Heritage 
            { 
                Id = ID, 
                RarityId = Rarities.Instances.Common.ID, 
                Name = "Cavern Kobold"
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Text, Text = "You hatched into a warren among narrow tunnels and countless kin. Your body is flexible. When Climbing rock walls, stalactites, and other natural stone features, you move at half your Speed on a success and at full Speed on a critical success (and you move at full Speed on a success if you have Quick Climb). This doesn't affect you if you're using a climb Speed. If you roll a success on an Acrobatics check to Squeeze, you get a critical success instead." };
        }

        protected override void GetEffects(BooleanEffectBuilder builder)
        {
            builder.Manual(Guid.Parse(""), "When Climbing rock walls, stalactites, and other natural stone features, you move at half your Speed on a success and at full Speed on a critical success (and you move at full Speed on a success if you have Quick Climb). This doesn't affect you if you're using a climb Speed.");
            builder.ImproveSpecificSkillSpecificSkillActionCheck(Guid.Parse(""), Skills.Instances.Acrobatics.ID, SkillActions.Instances.Squeeze.ID, RollResult.Success, becomes: RollResult.CriticalSuccess);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse(""),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = 13
            };
        }

        protected override IEnumerable<Guid> GetAncestries()
        {
            yield return Ancestries.Instances.Kobold.ID;
        }
    }
}
