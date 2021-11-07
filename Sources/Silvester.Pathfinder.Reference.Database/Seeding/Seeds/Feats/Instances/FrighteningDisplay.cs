using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class FrighteningDisplay : Template
    {
        public static readonly Guid ID = Guid.Parse("569f41dd-4b20-4e62-b1b5-70e30f7029c3");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Frightening Display",
                Level = -1,
                ActionTypeId = ActionTypes.Instances.OneAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("b55d5297-9887-48cc-bc05-957c2a4a5e56"), Type = TextBlockType.Text, Text = "Your ape makes a loud and frightening display, throwing a foe off balance. The ape attempts to (action: Demoralize) the target creature; this display gains the (trait: visual) trait and doesn’t require language. While frightened by this ability, the target is flat-footed to your ape." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("0fb2a984-68bf-4d86-81cd-b3f367759080"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
