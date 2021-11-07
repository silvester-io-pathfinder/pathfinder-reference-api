using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class WardensBoon : Template
    {
        public static readonly Guid ID = Guid.Parse("786f79bd-2489-446d-9d73-1cb771d7bdbd");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Warden's Boon",
                Level = 8,
                ActionTypeId = ActionTypes.Instances.OneAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("f8718e1e-ab36-455d-aa7d-72b8de65c8b1"), Type = TextBlockType.Text, Text = "By pointing out vulnerabilities, you grant the benefits listed in (feat: Hunt Prey) and your hunter’s edge benefit to an ally until the end of their next turn. Depending on whether you call out or use gestures, this action gains either the (trait: auditory) or (trait: visual) trait." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("d9157426-049b-4aac-aac6-89f0e69e47f1"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
