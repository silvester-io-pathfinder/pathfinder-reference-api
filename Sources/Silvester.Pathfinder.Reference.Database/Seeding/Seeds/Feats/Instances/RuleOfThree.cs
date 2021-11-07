using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class RuleOfThree : Template
    {
        public static readonly Guid ID = Guid.Parse("6a1895e8-8840-4b2d-a67c-45c89fc6fc8a");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Rule of Three",
                Level = 6,
                ActionTypeId = ActionTypes.Instances.OneAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = "once per round"
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("dd1c14a1-4b55-49e5-856a-d5d10c4fbbbb"), Type = TextBlockType.Text, Text = "You’ve learned that there is great value in repetition, especially in sets of three. You must be able to speak your intent to the world and call out to the subject of your (feat: Esoteric Antithesis), but the subject doesn’t need to understand or even hear you for your Rule of Three to take effect. The benefits depend on how many times you’ve uttered the Rule of Three and last as long as the creature is subject to your (feat: Esoteric Antithesis)." };
            yield return new TextBlock { Id = Guid.Parse("a46ac6e7-7dbd-47a0-8293-7010bfdd59e0"), Type = TextBlockType.Enumeration, Text = " First Utterance: No benefit. If you’ve used (feat: Find Flaws) in the presence of the creature, that counts as the first utterance (but not if you (feat: Found Flaws|Find Flaws) while (action: Investigating|Investigate) the creature)." };
            yield return new TextBlock { Id = Guid.Parse("d1bc9998-ab4d-4f5d-9aff-8934eaf88f33"), Type = TextBlockType.Enumeration, Text = " Second Utterance: You gain a +1 status bonus to attack rolls against the creature." };
            yield return new TextBlock { Id = Guid.Parse("1917ae5c-40db-4c59-b716-9abef0f3c9bc"), Type = TextBlockType.Enumeration, Text = " Third Utterance: The status bonus to attack rolls against the creature increases to +2, and the creature becomes flat-footed against your attacks." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("876a121d-38ef-47f1-87f5-af3e89a06933"), Feats.Instances.FindFlaws.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("0cb833c4-5dcb-42a5-98cf-df74582d7526"),
                SourceId = Sources.Instances.DarkArchive.ID,
                Page = -1
            };
        }
    }
}
