using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class LitanyOfDepravity : Template
    {
        public static readonly Guid ID = Guid.Parse("a88ce5d2-906c-453e-8726-5bb7ad17750c");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Litany of Depravity",
                Level = 14,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("5f4644d6-77b0-46c5-9f10-a7aaffa0257f"), Type = TextBlockType.Text, Text = "You undercut your enemy’s vain moralism, opening their heart to evil. You can cast the (spell: litany of depravity) focus spell. Increase the number of Focus Points in your focus pool by 1." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificTenet(Guid.Parse("d86e1604-729e-4919-b1ef-1c25abd8aef9"), Tenets.Instances.Evil.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("f80917f2-7014-4c4a-aab7-2d91d64444d3"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
