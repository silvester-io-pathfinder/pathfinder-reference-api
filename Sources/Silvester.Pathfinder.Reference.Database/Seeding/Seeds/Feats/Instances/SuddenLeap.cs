using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class SuddenLeap : Template
    {
        public static readonly Guid ID = Guid.Parse("2f5fc6a3-8c17-4b99-9909-07bdf7ad318e");

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
            yield return new TextBlock { Id = Guid.Parse("68a30ca4-98ea-4f04-8d62-593c953a6cb8"), Type = TextBlockType.Text, Text = "You make an impressive leap and swing while you soar. Make a (Action: Leap), (Action: High Jump), or (Action: Long Jump) and attempt one melee (Action: Strike) at any point during your jump. Immediately after the (Action: Strike), you fall to the ground if you’re in the air, even if you haven’t reached the maximum distance of your jump. If the distance you fall is no more than the height of your jump, you take no damage and land upright." };
            yield return new TextBlock { Id = Guid.Parse("6d3e837d-4ec4-44b9-b3db-81ecaea60573"), Type = TextBlockType.Text, Text = "When attempting a (Action: High Jump) or (Action: Long Jump) during a Sudden Leap, determine the DC using the (Action: Long Jump) DCs, and increase your maximum distance to double your Speed." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("25044586-6fd7-4508-8029-4674d9d96c62"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
