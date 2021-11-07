using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class CrystallineCloud : Template
    {
        public static readonly Guid ID = Guid.Parse("da5b45cd-d68f-4fba-9775-4069a26816cf");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Crystalline Cloud",
                Level = 9,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("68b2327e-2416-47fc-aae4-5a8bd7e18c0c"), Type = TextBlockType.Text, Text = "When you use (feat: Crystalline Dust), you can spend one additional action to disperse the motes as a 10-foot-radius cloud centered on you instead of as haze; the activity gains the (trait: concentrate) trait. All creatures within the cloud become concealed, and all creatures outside the cloud become concealed to creatures within it." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("30ae7bc8-5934-4c96-9a56-684eef42f69d"), Feats.Instances.CrystallineDust.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("7f213fe3-72dc-4d64-91f7-9cea8ed06a13"),
                SourceId = Sources.Instances.LostOmensAncestryGuide.ID,
                Page = -1
            };
        }
    }
}
