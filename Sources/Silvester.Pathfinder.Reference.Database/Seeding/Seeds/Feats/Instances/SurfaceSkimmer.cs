using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class SurfaceSkimmer : Template
    {
        public static readonly Guid ID = Guid.Parse("a16ed2f1-0fcb-42cb-82ff-15bc70f29b60");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Surface Skimmer",
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
            yield return new TextBlock { Id = Guid.Parse("f85ac792-615d-4afc-a40f-dde33429530a"), Type = TextBlockType.Text, Text = "By sinking gently beneath the waves, you obscure your presence and utilize the water as a barrier between you and land combatants. While you are submerged just below the water’s surface, you have cover from attacks made by creatures out of the water." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("f1c5e2bd-30e8-4432-afa5-2ebf79931983"),
                SourceId = Sources.Instances.LostOmensAncestryGuide.ID,
                Page = -1
            };
        }
    }
}
