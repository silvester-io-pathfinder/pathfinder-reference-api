using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class MentalStatic : Template
    {
        public static readonly Guid ID = Guid.Parse("d2cf37c5-d3b9-4e92-86ed-42bd3f91da92");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Mental Static",
                Level = 8,
                ActionTypeId = ActionTypes.Instances.Reaction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = "You roll a critical success on a Will save against a mental effect from a creature.",
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("dc7f0ba1-0493-4003-9bea-3c7770011368"), Type = TextBlockType.Text, Text = "Your thoughts sting back when a lesser mind tries to invade your own. You deal mental damage equal to your level to the triggering creature. This effect has the (trait: nonlethal) trait. If you desire, you can also send them a single mental image to coincide with the damage, such as a watching eye or the dread of floating in an infinite sea." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("dc0ceddd-2130-47fd-8d4f-3cfe229a70a9"),
                SourceId = Sources.Instances.DarkArchive.ID,
                Page = -1
            };
        }
    }
}
