using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class OneShotOneKill : Template
    {
        public static readonly Guid ID = Guid.Parse("a5941d44-e6d5-4f7b-a26b-6d7d69d93c5d");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "One Shot, One Kill",
                Level = -1,
                ActionTypeId = ActionTypes.Instances.FreeAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = "You roll Stealth for initiative",
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("3cb99d7f-515a-4b9c-ab3b-4aa8ef0d1a5c"), Type = TextBlockType.Text, Text = "Your first shot is the deadliest. Interact to draw a firearm or crossbow. On your first turn, your first (action: Strike) with that weapon deals an additional 1d6 precision damage. This precision damage increases to 2d6 at 9th level and 3d6 at 15th level." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("f3f4b310-ef49-4110-a1fb-fbbe53f9ba3e"),
                SourceId = Sources.Instances.GunsAndGears.ID,
                Page = -1
            };
        }
    }
}
