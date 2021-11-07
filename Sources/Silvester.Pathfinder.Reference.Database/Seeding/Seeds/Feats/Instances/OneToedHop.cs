using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class OneToedHop : Template
    {
        public static readonly Guid ID = Guid.Parse("66b1b1db-de9d-466d-8ab8-0b6755881879");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "One-Toed Hop",
                Level = 5,
                ActionTypeId = ActionTypes.Instances.OneAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("109c5e0b-2c8d-4178-849e-2a889048cb9c"), Type = TextBlockType.Text, Text = "Assuming a peculiar stance, you make a short hop on each toe. You make a vertical (action: Leap) without triggering reactions that can be triggered by (trait: move) actions or upon leaving or entering a square." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("42ee2c6e-271f-44d5-8aec-7f2491ee0375"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
