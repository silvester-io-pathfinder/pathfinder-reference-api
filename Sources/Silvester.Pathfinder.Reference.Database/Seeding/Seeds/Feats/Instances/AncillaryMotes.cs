using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class AncillaryMotes : Template
    {
        public static readonly Guid ID = Guid.Parse("e46272c0-8eb1-4152-ab22-218612aea424");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Ancillary Motes",
                Level = 9,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = true,
                Special = "You can take this feat more than once, gaining one more use of (feat: Crystalline Dust) per day each time.",
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("d0134d89-24d4-4317-9d85-27ec664ca22b"), Type = TextBlockType.Text, Text = "You can use (feat: Crystalline Dust) one more time per day." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("b859a92d-38d0-4052-8bed-8f59018a72a5"), Feats.Instances.CrystallineDust.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("d78ba487-4012-4fb4-860a-686133a5b1e5"),
                SourceId = Sources.Instances.LostOmensAncestryGuide.ID,
                Page = -1
            };
        }
    }
}
