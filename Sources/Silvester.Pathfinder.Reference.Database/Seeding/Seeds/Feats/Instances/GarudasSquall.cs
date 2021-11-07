using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class GarudasSquall : Template
    {
        public static readonly Guid ID = Guid.Parse("7e5af282-7d66-4515-adbd-1808b16c514f");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Garuda's Squall",
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
            yield return new TextBlock { Id = Guid.Parse("c8ea4847-5eb7-4d28-afa9-daaea367ac2f"), Type = TextBlockType.Text, Text = "Garudas’ marksmanship and magic are second nature to you. Whenever you critically hit using a bow, you apply the weapon’s critical specialization effect." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("d2cac6a8-a43b-4369-90b7-6f29cf746a5f"), Feats.Instances.Plumekith.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("7cfe5870-aedd-4bcb-99ed-6bea4b349e36"),
                SourceId = Sources.Instances.LostOmensAncestryGuide.ID,
                Page = -1
            };
        }
    }
}
