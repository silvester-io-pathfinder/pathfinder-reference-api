using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class ThoughtformSummoning : Template
    {
        public static readonly Guid ID = Guid.Parse("f896c7af-54b6-4884-ba1a-ecce6602ff6c");

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
            yield return new TextBlock { Id = Guid.Parse("124be0ca-6454-4054-9feb-0222cb95a033"), Type = TextBlockType.Text, Text = "You can create a prototypical creature from the depths of your imagination. Whenever you summon a creature, you can choose to instead create a psychic construct in the shape of that creature. This grants it resistance to physical damage equal to half its level, weakness 5 to force and mental damage, and the ability to pass through enemies' spaces without needing to (action: Tumble Through) (though it can't end its turn in such a space)." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("0d9e11bc-524f-49fd-8ccc-0a0731f0e09f"),
                SourceId = Sources.Instances.DarkArchive.ID,
                Page = -1
            };
        }
    }
}
