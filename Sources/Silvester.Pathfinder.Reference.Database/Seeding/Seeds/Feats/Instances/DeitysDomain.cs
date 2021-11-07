using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class DeitysDomain : Template
    {
        public static readonly Guid ID = Guid.Parse("f2f1413f-fe75-48d0-a254-4fffd13ff414");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Deity's Domain",
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
            yield return new TextBlock { Id = Guid.Parse("397c422a-4619-4ff8-867e-ca0ec2300dff"), Type = TextBlockType.Text, Text = "You embody an aspect of your deity. Choose one of your deity’s domains. You gain the domain’s initial domain spell as a devotion spell." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("6ea4ac84-af40-49c6-8d0f-80165f18a893"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
