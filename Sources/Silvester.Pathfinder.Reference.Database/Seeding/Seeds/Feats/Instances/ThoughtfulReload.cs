using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class ThoughtfulReload : Template
    {
        public static readonly Guid ID = Guid.Parse("cfa2cc5a-377f-4acf-bb60-857f82e92ec2");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Thoughtful Reload",
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
            yield return new TextBlock { Id = Guid.Parse("2a8065a4-6479-4f2e-8515-0f8f26ec774b"), Type = TextBlockType.Text, Text = "As you sink deep into a state of analytical calm and focus on the foe before you, your hands reload a bullet instinctively. Attempt a (action: Recall Knowledge) check against an opponent you can see and then (action: Interact) to reload." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("b37906eb-c713-4fbf-9afd-5b08458db1d9"),
                SourceId = Sources.Instances.GunsAndGears.ID,
                Page = -1
            };
        }
    }
}
