using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class EschewMaterials : Template
    {
        public static readonly Guid ID = Guid.Parse("afbd1ff8-b04c-46d0-a181-c5017e1489ef");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Eschew Materials",
                Level = 1,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("f841d7ab-273f-4090-b7f4-ab19adf9956e"), Type = TextBlockType.Text, Text = "You can use clever workarounds to replicate the arcane essence of certain materials. When (activity: Casting a Spell | Cast a Spell) that requires material components, you can provide these material components without a spell component pouch by drawing intricate replacement sigils in the air. Unlike when providing somatic components, you still must have a hand completely free. This doesn’t remove the need for any materials listed in the spell’s cost entry." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("4c5222e0-d9b1-4fb1-b918-3ea77ae0ef20"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
