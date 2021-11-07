using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class ShakeItOff : Template
    {
        public static readonly Guid ID = Guid.Parse("9870963b-9633-479c-a74f-57f58e3c2be7");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Shake It Off",
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
            yield return new TextBlock { Id = Guid.Parse("f234ccd5-9caa-4253-a168-48c8f1b32fa8"), Type = TextBlockType.Text, Text = "You concentrate on your rage, overcoming fear and fighting back sickness. Reduce your frightened condition value by 1, and attempt a Fortitude save to recover from the sickened condition as if you had spent an action retching; you reduce your sickened condition value by 1 on a failure (but not on a critical failure), by 2 on a success, or by 3 on a critical success." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("a9693f8e-0cc3-432e-ba11-9104e40a4eca"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
