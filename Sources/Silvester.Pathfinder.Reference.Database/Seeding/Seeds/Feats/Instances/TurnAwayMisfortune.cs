using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class TurnAwayMisfortune : Template
    {
        public static readonly Guid ID = Guid.Parse("eb13d767-e4dd-4b63-a745-e0ee2e0f5625");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Turn Away Misfortune",
                Level = 4,
                ActionTypeId = ActionTypes.Instances.Reaction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = "You would attempt a roll affected by a misfortune effect.",
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("f5358a13-4eb4-4557-aa2d-9564b5e96cac"), Type = TextBlockType.Text, Text = "You perform a superstition, such as casting salt over your shoulder to ward off bad luck. Turn Away Misfortune’s (trait: fortune) trait cancels out the (trait: misfortune) effect, causing you to roll normally" };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("02dd4dac-37ac-4aed-a812-119a7c67380e"),
                SourceId = Sources.Instances.DarkArchive.ID,
                Page = -1
            };
        }
    }
}
