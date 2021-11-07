using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class TheHarderTheyFall : Template
    {
        public static readonly Guid ID = Guid.Parse("1ce56fa2-b745-4e76-a5bf-5c90d4ca4a56");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "The Harder They Fall",
                Level = 4,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("b45ec2be-99da-42df-a39c-7cf0608c0f8d"), Type = TextBlockType.Text, Text = "You make your foes fall painfully when you trip them. When you successfully (action: Trip) a flat-footed foe, your target takes 1d6 bludgeoning damage. On a critical success, the target takes 1d6 bludgeoning damage plus your sneak attack damage." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("f2642ca0-eb5e-4860-af92-55f68feeb6cb"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
