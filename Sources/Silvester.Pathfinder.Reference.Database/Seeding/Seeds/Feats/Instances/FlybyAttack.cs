using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class FlybyAttack : Template
    {
        public static readonly Guid ID = Guid.Parse("95f8f845-5161-45e5-a698-3b3a06b04adf");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Flyby Attack",
                Level = -1,
                ActionTypeId = ActionTypes.Instances.TwoActions.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("1526af00-0084-4406-8e06-1b26deb63506"), Type = TextBlockType.Text, Text = "The bird (action: Flies | Fly) and makes a talon (action: Strike) at any point along the way." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("9c4eb570-3b77-4ec0-9142-3653b33ea708"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
