using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class LifeLeap : Template
    {
        public static readonly Guid ID = Guid.Parse("13bc62fc-6c70-4bd4-ae87-bbc3c9dc6785");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Life Leap",
                Level = 9,
                ActionTypeId = ActionTypes.Instances.OneAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("e238f3e7-5df1-4bf6-8958-e4aa48a30697"), Type = TextBlockType.Text, Text = "You phase through a space that a living creature occupies in a flash, spontaneously appearing on the opposite side of it in a vibrant display of colorful light. You move from your current location to another location that’s still adjacent to the same living creature, but on the opposite side or corner of the creature’s space." };
            yield return new TextBlock { Id = Guid.Parse("b3442961-2389-4fba-85ae-0245864d86ea"), Type = TextBlockType.Text, Text = "To determine whether a position is valid, use the same rules as for flanking: a line through the center of the two spaces must pass through opposite sides or corners of the creature’s space. You pass through the creature’s life force, appearing in the selected location; this doesn’t trigger reactions based on movement. You must be able to see your destination, and you can’t move farther than your Speed would allow." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("b465a78f-f301-4f0e-8fed-728ec8bacac6"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
