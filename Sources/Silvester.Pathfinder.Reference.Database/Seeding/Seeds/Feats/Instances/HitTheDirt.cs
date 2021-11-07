using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class HitTheDirt : Template
    {
        public static readonly Guid ID = Guid.Parse("a92fcb74-aa5f-4fd3-b03a-5f2a37d2c3c9");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Hit the Dirt!",
                Level = 4,
                ActionTypeId = ActionTypes.Instances.Reaction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = "A creature you can see attempts a ranged Strike against you.",
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("ad560a10-f23f-4646-a966-f8e07dbb6d0d"), Type = TextBlockType.Text, Text = "You fling yourself out of harm’s way. You (action: Leap). Your movement gives you a +2 circumstance bonus to AC against the triggering attack. Regardless of whether or not the triggering attack hits, you land prone after completing your (action: Leap)." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("0be26370-03a1-4ae7-bf8a-69a8efbd7d68"),
                SourceId = Sources.Instances.GunsAndGears.ID,
                Page = -1
            };
        }
    }
}
