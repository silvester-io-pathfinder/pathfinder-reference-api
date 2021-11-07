using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class ThoughtformSummoning : Template
    {
        public static readonly Guid ID = Guid.Parse("e5f99129-cb03-44de-91de-1d6f821b4344");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Thoughtform Summoning",
                Level = 6,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("92d4ad4b-3673-4879-bf0a-4da6b20ff87b"), Type = TextBlockType.Text, Text = "You can create a prototypical creature from the depths of your imagination. Whenever you summon a creature, you can choose to instead create a psychic construct in the shape of that creature. This grants it resistance to physical damage equal to half its level, weakness 5 to force and mental damage, and the ability to pass through enemies’ spaces without needing to (action: Tumble Through) (though it can’t end its turn in such a space)." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("ae85826c-11ba-4aa1-aac2-0c91bca9737a"),
                SourceId = Sources.Instances.DarkArchive.ID,
                Page = -1
            };
        }
    }
}
