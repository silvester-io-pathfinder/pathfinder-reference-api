using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class AncestralSuspicion : Template
    {
        public static readonly Guid ID = Guid.Parse("ca11fd58-dec1-43d2-9110-30e6ab13ff15");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Ancestral Suspicion",
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
            yield return new TextBlock { Id = Guid.Parse("8efd5d37-fe12-4552-bda0-a8763decb3fc"), Type = TextBlockType.Text, Text = "Long-lived elves have seen civilizations rise and fall, often at the hands of outside forces. As a result, they have developed a wariness of others who might seek to influence or control them. You’ve been trained to resist such manipulation, gaining a +2 circumstance bonus to saving throws against effects that would make you controlled, such as (spell: dominate), and to Perception checks to (action: Sense Motive) when trying to determine if a creature is under the influence of such an effect. When you roll a success on a saving throw against such an effect, you get a critical success instead." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("89b2a518-30f0-487d-a56f-b67e4f926e34"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
