using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class EludeTrouble : Template
    {
        public static readonly Guid ID = Guid.Parse("b593241e-721e-43ff-b1e9-b0c51d68aab2");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Elude Trouble",
                Level = 17,
                ActionTypeId = ActionTypes.Instances.Reaction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = "A creature misses you with a melee attack.",
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("a8ae4522-4578-4ebd-a58e-67248afc16d1"), Type = TextBlockType.Text, Text = "You slip through your foe’s opening. (action: Stride) up to your Speed. This movement doesn’t trigger movement-based reactions from the creature that missed you." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("3e7f3b9b-c57a-47cf-ad68-f0cf04467cad"),
                SourceId = Sources.Instances.LostOmensAncestryGuide.ID,
                Page = -1
            };
        }
    }
}
