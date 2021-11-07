using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class GangUp : Template
    {
        public static readonly Guid ID = Guid.Parse("7ba0882c-3e26-4e0c-ad50-a0921571663c");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Gang Up",
                Level = 6,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("6a44f7a7-0154-41f2-8087-537f9b6105b1"), Type = TextBlockType.Text, Text = "You and your allies harry an opponent in concert. Any enemy is flat-footed against your melee attacks due to flanking as long as the enemy is within both your reach and your ally’s. Your allies must still flank an enemy for it to be flat-footed to them." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("5ab6a183-9d3a-4a6c-87e9-ba6ea5e9f720"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
