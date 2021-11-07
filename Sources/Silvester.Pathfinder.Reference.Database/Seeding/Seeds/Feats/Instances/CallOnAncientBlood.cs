using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class CallOnAncientBlood : Template
    {
        public static readonly Guid ID = Guid.Parse("b01eda7d-c535-47d2-8db1-43745e7951b2");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Call on Ancient Blood",
                Level = -1,
                ActionTypeId = ActionTypes.Instances.Reaction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = "You attempt a saving throw against a magical effect, but you haven't rolled yet.",
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("690ca17d-b4c1-4400-b7dd-e94f0cf77577"), Type = TextBlockType.Text, Text = "Your ancestors’ innate resistance to magic surges, before slowly ebbing down. You gain a +1 circumstance bonus to the triggering saving throw and until the end of this turn." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("4d330e4a-58cf-430d-b3cd-99cd5c5ab943"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
