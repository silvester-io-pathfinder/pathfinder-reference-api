using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class RockRunner : Template
    {
        public static readonly Guid ID = Guid.Parse("4c92f7ec-7cae-461f-95dd-6a7099f99d3d");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Rock Runner",
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
            yield return new TextBlock { Id = Guid.Parse("6927eb16-6da2-4dac-8b81-e6027befa442"), Type = TextBlockType.Text, Text = "Your innate connection to stone makes you adept at moving across uneven surfaces. You can ignore difficult terrain caused by rubble and uneven ground made of stone and earth. In addition, when you use the Acrobatics skill to (Action: Balance) on narrow surfaces or uneven ground made of stone or earth, you aren’t flat-footed, and when you roll a success at one of these Acrobatics checks, you get a critical success instead." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("afefff5f-46e3-40c7-8f5e-f4ac4841dde6"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
