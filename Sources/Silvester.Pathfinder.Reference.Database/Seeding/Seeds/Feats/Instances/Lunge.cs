using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class Lunge : Template
    {
        public static readonly Guid ID = Guid.Parse("03e69cbd-b409-4c9c-8be9-f9dc1804db9a");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Lunge",
                Level = 2,
                ActionTypeId = ActionTypes.Instances.OneAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("c55b61e3-1a4f-457f-9b3f-ae8be07f1d8d"), Type = TextBlockType.Text, Text = "Extending your body to its limits, you attack an enemy that would normally be beyond your reach. Make a (Action: Strike) with a melee weapon, increasing your reach by 5 feet for that (Action: Strike). If the weapon has the (trait: disarm), (trait: shove), or (trait: trip) trait, you can use the corresponding action instead of a (Action: Strike)." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("cefcaa31-9640-40a9-9276-b725389f8725"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
