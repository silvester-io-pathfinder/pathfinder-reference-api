using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class Cleave : Template
    {
        public static readonly Guid ID = Guid.Parse("3c71d3cf-7dfa-4dd3-8183-eb03eca11fda");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Cleave",
                Level = 6,
                ActionTypeId = ActionTypes.Instances.Reaction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = "Your melee Strike kills a creature or knocks it unconscious, and another foe is adjacent to that creature.",
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("b4f15191-c146-4e49-8ac0-cec695cdd6c5"), Type = TextBlockType.Text, Text = "You swing clear through one foe and into another. Make a melee (Action: Strike) against the second foe." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("f7446bae-3de5-4e96-a006-13bb78cbfadb"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
