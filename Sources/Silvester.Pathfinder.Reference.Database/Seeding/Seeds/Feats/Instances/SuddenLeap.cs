using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class SuddenLeap : Template
    {
        public static readonly Guid ID = Guid.Parse("10076e11-11c1-4085-be9c-c0bd6f50834e");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Sudden Leap",
                Level = 8,
                ActionTypeId = ActionTypes.Instances.TwoActions.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = "If you have (feat: Felling Strike), you can spend 3 actions to make a Sudden Leap and use (feat: Felling Strike) instead of a normal (action: Strike).",
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("edc16d9e-946f-4477-8a1b-90961db31e9f"), Type = TextBlockType.Text, Text = "You make an impressive leap and swing while you soar. Make a (Action: Leap), (Action: High Jump), or (Action: Long Jump) and attempt one melee (Action: Strike) at any point during your jump. Immediately after the (Action: Strike), you fall to the ground if you’re in the air, even if you haven’t reached the maximum distance of your jump. If the distance you fall is no more than the height of your jump, you take no damage and land upright." };
            yield return new TextBlock { Id = Guid.Parse("b3169fbc-dbac-4ba0-a376-ca9fb23c8b0c"), Type = TextBlockType.Text, Text = "When attempting a (Action: High Jump) or (Action: Long Jump) during a Sudden Leap, determine the DC using the (Action: Long Jump) DCs, and increase your maximum distance to double your Speed." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("cfac71c2-4404-4a9f-a30d-e96206d83fc1"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
