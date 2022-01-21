using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class RuleOfThree : Template
    {
        public static readonly Guid ID = Guid.Parse("e131506d-9ed8-4bee-b146-7c5517a04a44");

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
            yield return new TextBlock { Id = Guid.Parse("a217647f-4466-43e1-9f6b-6300ab0c88ff"), Type = TextBlockType.Text, Text = "You've learned that there is great value in repetition, especially in sets of three. You must be able to speak your intent to the world and call out to the subject of your (feat: Esoteric Antithesis), but the subject doesn't need to understand or even hear you for your Rule of Three to take effect. The benefits depend on how many times you've uttered the Rule of Three and last as long as the creature is subject to your (feat: Esoteric Antithesis)." };
            yield return new TextBlock { Id = Guid.Parse("4e6490a7-1eb1-4271-ac42-5a3748d7f3ec"), Type = TextBlockType.Enumeration, Text = " First Utterance: No benefit. If you've used (feat: Find Flaws) in the presence of the creature, that counts as the first utterance (but not if you (feat: Found Flaws|Find Flaws) while (action: Investigating|Investigate) the creature)." };
            yield return new TextBlock { Id = Guid.Parse("68c26c00-f3b7-40fa-8f34-07b7158f3f53"), Type = TextBlockType.Enumeration, Text = " Second Utterance: You gain a +1 status bonus to attack rolls against the creature." };
            yield return new TextBlock { Id = Guid.Parse("aa791f8d-7691-427b-a6d4-f200e0dc5741"), Type = TextBlockType.Enumeration, Text = " Third Utterance: The status bonus to attack rolls against the creature increases to +2, and the creature becomes flat-footed against your attacks." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("6bc4992e-1fa4-4464-9d97-e7e09d13ce77"), Feats.Instances.FindFlaws.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("248552f3-d306-48d2-9b05-49dc3eb2fbf4"),
                SourceId = Sources.Instances.DarkArchive.ID,
                Page = -1
            };
        }
    }
}
