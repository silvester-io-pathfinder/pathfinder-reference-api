using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class AiryStep : Template
    {
        public static readonly Guid ID = Guid.Parse("eeaecd1e-2b89-4dae-8071-cdca73c8e77f");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Airy Step",
                Level = 13,
                ActionTypeId = ActionTypes.Instances.Reaction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = "A creature targets you with an attack or other targeted effect, and you can see the attacker.",
                Frequency = "once per day"
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("d244a633-bd56-4fd2-960b-025c96ed18be"), Type = TextBlockType.Text, Text = "You create a blanket of fog in a 5-foot burst centered on one corner of your space. All creatures within that area are concealed, and all others are concealed to them. This concealment applies to the triggering effect, and the fog lasts for 1 minute or until dispersed by a strong wind. After resolving the triggering effect, you (action: Step). If an effect prevents you from (action: Stepping | Step), you attempt to (action: Escape) the effect and (action: Step) if you succeed." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("70e88b68-d406-44a1-876b-9a1a6eb0936e"),
                SourceId = Sources.Instances.LostOmensAncestryGuide.ID,
                Page = -1
            };
        }
    }
}
