using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class NocturnalCharm : Template
    {
        public static readonly Guid ID = Guid.Parse("49a4024f-db21-4de2-b542-956602f12c1e");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Nocturnal Charm",
                Level = 1,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("4eb5cf47-3089-41e3-bdad-3a98cd56a706"), Type = TextBlockType.Text, Text = "The supernatural charm of your vampiric progenitor hangs about you, and you’ve learned to use it on mortals. Against humanoids (or other creatures of your type, if you’re not a humanoid), you gain a +1 circumstance bonus to Deception checks to (action: Lie), and to Diplomacy checks to (action: Gather Information) and (action: Make an Impression)." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("287036c3-37ba-4900-9d8c-4a80acd0dd4c"),
                SourceId = Sources.Instances.LostOmensAncestryGuide.ID,
                Page = -1
            };
        }
    }
}
