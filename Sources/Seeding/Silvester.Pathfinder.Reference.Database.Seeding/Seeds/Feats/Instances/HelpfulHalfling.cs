using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class HelpfulHalfling : Template
    {
        public static readonly Guid ID = Guid.Parse("eb72faf5-502d-4ccc-ad3d-3ff56c8099af");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Helpful Halfling",
                Level = 9,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("2f0691e0-1c8d-400c-99bb-8c3c8d03415a"), Type = TextBlockType.Text, Text = "When you aid a friend with a task, you find many ways to help and avoid interfering. On a critical success to (action: Aid), you grant your ally a +3 circumstance bonus if you have expert proficiency in the skill (rather than +2), and you grant your ally a +4 circumstance bonus if you have master proficiency (rather than +3). If you roll a critical failure on a check to (action: Aid), you don’t give your ally a -1 circumstance penalty to their check." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("4027dc0c-6aae-498c-8578-da8ffaa18df3"),
                SourceId = Sources.Instances.LostOmensCharacterGuide.ID,
                Page = -1
            };
        }
    }
}
