using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class SharedPrey : Template
    {
        public static readonly Guid ID = Guid.Parse("1157c50a-0d0c-40ad-a629-60e9256ba46e");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Shared Prey",
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
            yield return new TextBlock { Id = Guid.Parse("0881b6ac-30d0-4a9b-8faa-154c7a53bb12"), Type = TextBlockType.Text, Text = "Hunting as a duo, you and your ally both single out your prey. When you use (feat: Hunt Prey) and select only one prey, you can grant your (feat: Hunt Prey) benefits and hunter’s edge to an ally in addition to gaining them yourself. The ally retains these benefits until you use (feat: Hunt Prey) again." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("79862c53-b1c1-484b-ae17-0a7ecbe33fb3"), Feats.Instances.DoublePrey.ID);
            builder.HaveSpecificFeat(Guid.Parse("3cb8f926-5adf-4a32-a92a-d382af479b8d"), Feats.Instances.WardensBoon.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("b4a8caea-cac0-47ca-a84f-93bebac6888f"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
