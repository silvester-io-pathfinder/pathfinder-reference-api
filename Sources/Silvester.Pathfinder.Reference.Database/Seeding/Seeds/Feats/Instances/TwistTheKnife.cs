using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class TwistTheKnife : Template
    {
        public static readonly Guid ID = Guid.Parse("4a6f81d8-fb3e-4a08-b813-47765d0fb455");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Twist the Knife",
                Level = 6,
                ActionTypeId = ActionTypes.Instances.OneAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("5cfa5b90-450b-4aad-a718-02ed3a9d7dfa"), Type = TextBlockType.Text, Text = "After stabbing your opponent in a weak spot, you tear the wound open. You deal persistent bleed damage to the target equal to your number of sneak attack damage dice." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("3e49b066-83b4-4abf-bdfb-274e36dc8a30"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
