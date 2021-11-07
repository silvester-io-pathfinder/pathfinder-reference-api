using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class SiphonPower : Template
    {
        public static readonly Guid ID = Guid.Parse("24213023-bf40-442f-a1a4-b0a5be3736a8");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Siphon Power",
                Level = 16,
                ActionTypeId = ActionTypes.Instances.FreeAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = "This feat has the trait corresponding to the tradition of spells you cast ((trait: arcane), (trait: divine), (trait: occult), or (trait: primal)).",
                Trigger = null,
                Frequency = "once per day"
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("ce5615c4-00c8-49e5-acbc-58588091aa91"), Type = TextBlockType.Text, Text = "You draw upon the reservoir of your patron’s magic that resides within your familiar. During your turn, you can cast one spell your familiar knows that was granted by your patron’s theme or lessons without spending a spell slot to do so (or even having it prepared). The spell must be at least 1 level lower than the highest-level spell you can cast." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("07a6265e-b08b-496d-9fa0-a4f8e32a0b4d"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
