using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class FlourishAndRuin : Template
    {
        public static readonly Guid ID = Guid.Parse("646848a1-e413-4d5d-acd2-4d701b88d2f9");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Flourish and Ruin",
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
            yield return new TextBlock { Id = Guid.Parse("bd0fcf91-cf4b-4296-aa9c-ceda1be48ebf"), Type = TextBlockType.Text, Text = "You can call upon the vital essence of your spirit to restore life to your allies and call forth vines to ensnare and bludgeon your foes. You can cast (spell: field of life) and (spell: tangling creepers) as 6th-level primal innate spells once per day each. You become an expert in primal spell attack rolls and primal spell DCs." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("01200f4a-515f-47bc-93a1-3f4892b3c725"),
                SourceId = Sources.Instances.LostOmensAncestryGuide.ID,
                Page = -1
            };
        }
    }
}
