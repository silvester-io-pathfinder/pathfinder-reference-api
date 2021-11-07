using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class CloseQuarters : Template
    {
        public static readonly Guid ID = Guid.Parse("460014ed-17fc-4e3a-b7b3-4a95d3a70e24");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Close Quarters",
                Level = 9,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("11fcdc87-8f3b-4679-88c3-848f7a6c13f2"), Type = TextBlockType.Text, Text = "You’ve trained to fight with allies in tunnel warrens, dense undergrowth, or similarly cramped terrain. If you are Small or smaller, you can end your movement in the same square as a Small or smaller ally. No more than two creatures can share the same space when using this ability or a similar one." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("54a04fd0-afdd-4fad-bcef-7eaa35ad3c7e"),
                SourceId = Sources.Instances.LostOmensAncestryGuide.ID,
                Page = -1
            };
        }
    }
}
