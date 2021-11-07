using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class HaphazardRepair : Template
    {
        public static readonly Guid ID = Guid.Parse("0b442027-4137-416a-b8b2-3a15ec1e399f");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Haphazard Repair",
                Level = 1,
                ActionTypeId = ActionTypes.Instances.OneAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("38bf0985-5cb2-4dee-a07b-9be0c4bf5f1f"), Type = TextBlockType.Text, Text = "You quickly fix your innovation, at the cost of its stability. You (action: Repair) your innovation almost immediately. You don’t have to place the innovation on a flat surface, but you do need to be adjacent to it (including holding or wearing it), as well as having a (item: repair kit) as normal." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("8e0c9c19-38b0-4e12-b1ef-6c367555e40e"),
                SourceId = Sources.Instances.GunsAndGears.ID,
                Page = -1
            };
        }
    }
}
