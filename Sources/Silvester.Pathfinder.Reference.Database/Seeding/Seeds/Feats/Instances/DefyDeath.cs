using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class DefyDeath : Template
    {
        public static readonly Guid ID = Guid.Parse("02b0c042-aff6-4723-951e-cc1a621655cd");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Defy Death",
                Level = 5,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("660f44f6-9645-4f01-ab37-1ed1af56a854"), Type = TextBlockType.Text, Text = "You’re exceptionally difficult to kill. The DC of your recovery checks is equal to 9 + your dying value, or 8 + your dying value if you have the (feat: Toughness) general feat. In addition, whenever someone returns you to life using magic that would normally leave you debilitated for a week (such as (spell: raise dead) or the resurrect ritual), you don’t suffer that condition." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("eab9e678-a431-4b54-a5d9-07d4f1672fdd"), Feats.Instances.OrcFerocity.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("3c7238b7-425d-4cf1-9df0-c895a270662a"),
                SourceId = Sources.Instances.LostOmensAncestryGuide.ID,
                Page = -1
            };
        }
    }
}
