using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class KillingStone : Template
    {
        public static readonly Guid ID = Guid.Parse("bc4f2a9c-71df-4f15-901b-54dd1a2511b3");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Killing Stone",
                Level = 13,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("1916e6ce-1eec-4fc4-932e-8e3d3a9fa2d1"), Type = TextBlockType.Text, Text = "Your star orb hides a deadly miasma. You can cast 5th-level (spell: cloudkill) as a divine innate spell once per day. The spell’s normal components are replaced with a focus component (your star orb) and a somatic component to aim the orb towards the location for the spell." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("2e9b9613-d019-4cf5-8bb7-3068fbd38c91"), Feats.Instances.StarOrb.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("5a9122e8-e1d7-4407-88d0-9609160bf8b7"),
                SourceId = Sources.Instances.LostOmensAncestryGuide.ID,
                Page = -1
            };
        }
    }
}
