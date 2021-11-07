using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class PanacheParagon : Template
    {
        public static readonly Guid ID = Guid.Parse("6f2642d8-0670-4f5b-91c3-e252497dc46b");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Panache Paragon",
                Level = 20,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("b04beffb-6fcc-4bd5-9b0f-5cd5f1ee921d"), Type = TextBlockType.Text, Text = "You find opportunities to perform stylish feats in the moments between others’ heartbeats and eye blinks. You are permanently quickened. You can use the extra action only to (action: Tumble Through) or perform the skill action listed in your swashbuckler’s style as one that allows you to gain panache, or other actions that would allow you to gain panache at the GM’s discretion." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("34e9dfda-bc35-4bd3-b651-ac2b26b924bc"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
