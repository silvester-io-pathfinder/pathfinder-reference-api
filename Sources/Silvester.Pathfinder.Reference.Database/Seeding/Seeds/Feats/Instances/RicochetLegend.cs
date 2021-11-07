using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class RicochetLegend : Template
    {
        public static readonly Guid ID = Guid.Parse("09433dfe-7981-4663-a440-1e5407830f10");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Ricochet Legend",
                Level = 20,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("7df9482b-d0e5-43ae-8e61-d04a64c7ae8d"), Type = TextBlockType.Text, Text = "The more obstacles between you and your target, the deadlier your shots become, as you ricochet off multiple surfaces to hit them. When using (feat: Ricochet Shot), your shot can bounce off of any surface within your weapon’s first three range increments and the target can’t benefit from cover unless they have total cover on all sides." };
            yield return new TextBlock { Id = Guid.Parse("60876d75-7b7d-46f9-b61f-29f097e981a8"), Type = TextBlockType.Text, Text = "In addition, a creature must attempt a Will save against your class DC the first time in an encounter you attack it with a (feat: Ricochet Shot). If it fails, it’s stunned 2 and is unable to determine where your shot originated." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("2a8b9458-7291-4344-831e-dc376883279a"), Feats.Instances.RicochetMaster.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("8bc91ffb-22cc-49d9-834e-00502db9042d"),
                SourceId = Sources.Instances.GunsAndGears.ID,
                Page = -1
            };
        }
    }
}
