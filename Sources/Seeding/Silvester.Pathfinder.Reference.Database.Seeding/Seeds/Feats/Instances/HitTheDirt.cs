using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class HitTheDirt : Template
    {
        public static readonly Guid ID = Guid.Parse("655334d8-2bda-40d3-9bbe-9de4863d5ead");

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
            yield return new TextBlock { Id = Guid.Parse("7b3ba0e2-796a-4d64-9e88-0bd150f3f82f"), Type = TextBlockType.Text, Text = "You fling yourself out of harm’s way. You (action: Leap). Your movement gives you a +2 circumstance bonus to AC against the triggering attack. Regardless of whether or not the triggering attack hits, you land prone after completing your (action: Leap)." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("e7ee5db2-f434-4a5f-a130-988ed32cefa9"),
                SourceId = Sources.Instances.GunsAndGears.ID,
                Page = -1
            };
        }
    }
}
