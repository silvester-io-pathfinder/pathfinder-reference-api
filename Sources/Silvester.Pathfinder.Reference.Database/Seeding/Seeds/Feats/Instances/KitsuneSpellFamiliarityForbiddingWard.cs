using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class KitsuneSpellFamiliarityForbiddingWard : Template
    {
        public static readonly Guid ID = Guid.Parse("f7dda96d-ad38-49fe-9b9c-f107f0756fa3");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Kitsune Spell Familiarity - Forbidding Ward",
                Level = -1,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("97c7246e-d3d1-4de9-86ab-21d56411e32d"), Type = TextBlockType.Text, Text = "Until your next daily preparations, you can cast (spell: forbidding ward) as a divine innate spell at will." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("5173f913-30a8-4afa-878b-1932f4bf9708"),
                SourceId = Sources.Instances.LostOmensAncestryGuide.ID,
                Page = -1
            };
        }
    }
}
