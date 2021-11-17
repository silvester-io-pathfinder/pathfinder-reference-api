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
        public static readonly Guid ID = Guid.Parse("a3a0c267-d399-4263-a5cb-c34e8f732658");

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
            yield return new TextBlock { Id = Guid.Parse("47609566-06d5-49eb-b3f4-94236a74d6aa"), Type = TextBlockType.Text, Text = "You hatched into a warren among narrow tunnels and countless kin. Your body is flexible. When Climbing rock walls, stalactites, and other natural stone features, you move at half your Speed on a success and at full Speed on a critical success (and you move at full Speed on a success if you have Quick Climb). This doesn't affect you if you're using a climb Speed. If you roll a success on an Acrobatics check to Squeeze, you get a critical success instead." };
        }

        protected override void GetEffects(BooleanEffectBuilder builder)
        {
            builder.Manual(Guid.Parse("3d155878-5e50-4418-a74d-04ee48ec3b72"), "When Climbing rock walls, stalactites, and other natural stone features, you move at half your Speed on a success and at full Speed on a critical success (and you move at full Speed on a success if you have Quick Climb). This doesn't affect you if you're using a climb Speed.");
            builder.ImproveSpecificSkillSpecificSkillActionCheck(Guid.Parse("e09eb173-9329-4244-a58a-1309b1286ef3"), Skills.Instances.Acrobatics.ID, SkillActions.Instances.Squeeze.ID, RollResult.Success, becomes: RollResult.CriticalSuccess);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("a3d3ab1b-cf36-4f1f-8de9-73739e6013d5"),
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
