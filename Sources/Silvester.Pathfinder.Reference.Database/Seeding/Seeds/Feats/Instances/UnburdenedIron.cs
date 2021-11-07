using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class UnburdenedIron : Template
    {
        public static readonly Guid ID = Guid.Parse("5630dfff-e2db-4b05-847c-dc3bddb66dcf");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Unburdened Iron",
                Level = 1,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("4f2fb1ff-2462-4d9a-a61a-731c9337afe2"), Type = TextBlockType.Text, Text = "You’ve learned techniques first devised by your ancestors during their ancient wars, allowing you to comfortably wear massive suits of armor. Ignore the reduction to your Speed from any armor you wear." };
            yield return new TextBlock { Id = Guid.Parse("ded3ed31-70bb-4dd0-ab75-5e593c4369a2"), Type = TextBlockType.Text, Text = "In addition, any time you’re taking a penalty to your Speed from some other reason, deduct 5 feet from the penalty. If your Speed is taking multiple penalties, pick only one penalty to reduce." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("7a3a6a2f-c8cf-427b-8215-5ba5e83a09b5"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
