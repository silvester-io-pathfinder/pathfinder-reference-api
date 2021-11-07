using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class HybridForm : Template
    {
        public static readonly Guid ID = Guid.Parse("90cb9111-9d28-4fd9-a31c-4c2a68ad288c");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Hybrid Form",
                Level = 5,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("f57c9d75-3648-4b50-9cac-58e5a1c653c9"), Type = TextBlockType.Text, Text = "When you (action: Change Shape | Change Shape - Kitsune), you retain elements of your kitsune form, allowing you to speak in a fox form, use kitsune unarmed attacks in a tailless form, or gain a tail in your tailless form to use abilities that require one. You can (action: Change Shape | Change Shape - Kitsune) to alter the details of your hybrid form without fully changing into your true form or your alternate form. While in hybrid form, your foxlike features make it obvious that you aren’t a normal humanoid." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("a41b1cec-8594-4ecd-9f60-2818dfa57c26"),
                SourceId = Sources.Instances.LostOmensAncestryGuide.ID,
                Page = -1
            };
        }
    }
}
