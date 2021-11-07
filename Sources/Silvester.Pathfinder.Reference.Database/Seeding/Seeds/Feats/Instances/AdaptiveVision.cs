using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class AdaptiveVision : Template
    {
        public static readonly Guid ID = Guid.Parse("1cdc653e-da91-47f8-b7cc-efad8a77b076");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Adaptive Vision",
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
            yield return new TextBlock { Id = Guid.Parse("662945cf-a320-4289-9672-1fd3d1990c51"), Type = TextBlockType.Text, Text = "~ Access: You are from Dongun Hold or Alkenstar." };
            yield return new TextBlock { Id = Guid.Parse("28b57463-c405-4b36-b55e-2fcd60b4f4aa"), Type = TextBlockType.Text, Text = "After years of using black powder weaponry in dimly lit spaces, you’ve become accustomed to dazzling flashes of light and sudden shifts in illumination. You gain a +1 circumstance bonus to saving throws against (trait: visual) effects. If you roll a success on a saving throw against a (trait: visual) effect, you get a critical success instead." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("d55dbe25-d4f2-4b3d-9eb8-53cbda6812c3"),
                SourceId = Sources.Instances.GunsAndGears.ID,
                Page = -1
            };
        }
    }
}
