using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class UnleashImmediateGratification : Template
    {
        public static readonly Guid ID = Guid.Parse("d6d41707-8ec6-4716-b7be-bec5eeb0aa4f");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Unleash Immediate Gratification",
                Level = 12,
                ActionTypeId = ActionTypes.Instances.OneAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("2899c38e-c40b-42b6-a666-c220e0d071b9"), Type = TextBlockType.Text, Text = $"You can push your mind immediately into an overloaded state, though doing so accelerates your mental strain." };
            yield return new TextBlock { Id = Guid.Parse("fe271f7a-c92b-4db3-9258-cf0f0dc2fb01"), Type = TextBlockType.Text, Text = $"~ Benefit: You gain the basic benefits of having your psyche unleashed, allowing you to amp focus spells without paying the cost, but you gain no specific benefits beyond that." };
            yield return new TextBlock { Id = Guid.Parse("a05a0dbe-ed98-40e9-b4f1-3addd53cff3d"), Type = TextBlockType.Text, Text = $"~ Drawback: Prematurely pushing yourself into an overloaded state leaves your mind struggling to catch up. You're stupefied 1 for the duration of your Unleashed psyche, and you can't remove or mitigate this condition in any way." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("34b75e57-7f29-4c6d-834b-0904743ce09c"),
                SourceId = Sources.Instances.DarkArchive.ID,
                Page = -1
            };
        }
    }
}
