using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class FearsomeBrute : Template
    {
        public static readonly Guid ID = Guid.Parse("92c6f9e9-a458-453b-87ad-473e82ddf702");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Fearsome Brute",
                Level = 10,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("c51c8777-1319-4f2d-b540-cb7428bfafb3"), Type = TextBlockType.Text, Text = "Fear makes your foes weak and more vulnerable to your attacks. You gain a circumstance bonus to damage rolls for (Action: Strikes | Strike) against frightened creatures. The bonus is equal to double the target’s frightened value." };
            yield return new TextBlock { Id = Guid.Parse("99070d51-d343-4da1-adb3-3736215853de"), Type = TextBlockType.Text, Text = "If you have master proficiency in Intimidation, increase the bonus to triple the target’s frightened value." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("ed36ac53-5733-4d84-9f76-229a9dd744bb"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
