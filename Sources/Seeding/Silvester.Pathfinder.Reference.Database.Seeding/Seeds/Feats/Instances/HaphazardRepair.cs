using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class HaphazardRepair : Template
    {
        public static readonly Guid ID = Guid.Parse("e669f734-8ced-4dba-9043-322a9a6e9511");

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
            yield return new TextBlock { Id = Guid.Parse("bd6481cb-f365-469d-aea6-75ef361e0053"), Type = TextBlockType.Text, Text = "You quickly fix your innovation, at the cost of its stability. You (action: Repair) your innovation almost immediately. You don’t have to place the innovation on a flat surface, but you do need to be adjacent to it (including holding or wearing it), as well as having a (item: repair kit) as normal." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("257a1938-87e6-4e3a-80e0-00971d769482"),
                SourceId = Sources.Instances.GunsAndGears.ID,
                Page = -1
            };
        }
    }
}
