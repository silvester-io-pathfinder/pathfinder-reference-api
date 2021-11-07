using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class LeshySuperstition : Template
    {
        public static readonly Guid ID = Guid.Parse("b20a136f-6b16-43e2-8111-44286a36f945");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Leshy Superstition",
                Level = 1,
                ActionTypeId = ActionTypes.Instances.Reaction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = "You attempt a saving throw against a spell or magical effect, but haven't rolled yet.",
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("d3af31cc-6aea-4fc0-a87b-6a177c4d3831"), Type = TextBlockType.Text, Text = "You notice spirits that inhabit objects, learning which bring good fortune and which are unlucky. You focus on the power of a lucky object, granting you a +1 circumstance bonus to your saving throw against the triggering effect." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("684bf237-e858-4dea-b001-907eac0fe713"),
                SourceId = Sources.Instances.LostOmensCharacterGuide.ID,
                Page = -1
            };
        }
    }
}
