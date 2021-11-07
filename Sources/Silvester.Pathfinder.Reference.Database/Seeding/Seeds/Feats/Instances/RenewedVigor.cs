using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class RenewedVigor : Template
    {
        public static readonly Guid ID = Guid.Parse("127668ff-0114-482e-acb1-d3f17553b9bf");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Renewed Vigor",
                Level = 8,
                ActionTypeId = ActionTypes.Instances.OneAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("601fbea8-2fe9-46ed-b878-84362da2c14d"), Type = TextBlockType.Text, Text = "You pause to recover your raging vigor. You gain temporary Hit Points equal to half your level plus your Constitution modifier." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("8484770c-d405-4c72-a7ce-30008e3f12a6"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
