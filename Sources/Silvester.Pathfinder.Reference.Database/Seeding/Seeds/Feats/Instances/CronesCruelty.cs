using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class CronesCruelty : Template
    {
        public static readonly Guid ID = Guid.Parse("349d292d-2e13-4874-9cb7-2b6abbd73e34");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Crone's Cruelty",
                Level = 17,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("da41fec4-1334-46ac-b68f-75e80946a5cd"), Type = TextBlockType.Text, Text = "Filled with rancor and hate, you rend the minds of those who displease you. You can cast (spell: warp mind) once per day as an occult innate spell." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("e3991338-976f-41c3-bfff-d95645bb2a3f"),
                SourceId = Sources.Instances.LostOmensAncestryGuide.ID,
                Page = -1
            };
        }
    }
}
