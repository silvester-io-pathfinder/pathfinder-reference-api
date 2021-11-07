using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class SpinTale : Template
    {
        public static readonly Guid ID = Guid.Parse("c2db3e30-5649-47e4-9363-bde91b5ae4cc");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Spin Tale",
                Level = -1,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = "once every 10 minutes"
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("1076dd57-fb7c-4edd-ad0d-d3f0ceeb31cf"), Type = TextBlockType.Text, Text = "You tell a story, designating one of your allies (but not yourself) as the hero of the story, and one enemy as the villain; both must be within 60 feet. The hero gains a +1 status bonus to attack rolls and saving throws against the villain until the start of your next turn. If you Spin a Tale on your next turn, the story continues for another round, for a maximum of 10 rounds. While the tale continues, minor, crude illusions spring into being in your space; these are (trait: arcane) (trait: illusion) effects that have no mechanical impact other than illustrating your tale." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("f3c8cf1a-7f33-4498-b929-c1abd455aa34"),
                SourceId = Sources.Instances.StrengthOfThousands.ID,
                Page = -1
            };
        }
    }
}
