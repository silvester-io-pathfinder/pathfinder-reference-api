using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class BrawlingFocus : Template
    {
        public static readonly Guid ID = Guid.Parse("1e9c4347-a396-4094-b3f0-a8aeb23e012b");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Brawling Focus",
                Level = 4,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("b46b2e7a-32a4-467a-9b88-30d5fc125e05"), Type = TextBlockType.Text, Text = "You know how to make the most of your attacks when fighting hand-to-hand. You gain access to the critical specialization effects of unarmed strikes in the brawling group and weapons in the brawling group. If you have (feat: Monastic Weaponry), you also gain the critical specialization effects of all monk weapons in which you are trained." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("eaf4196e-d4c2-4d9b-b5ba-242a5deb5e49"), Feats.Instances.BulletDancerDedication.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("8a001695-07ad-4f40-bc6e-239daa7bd342"),
                SourceId = Sources.Instances.GunsAndGears.ID,
                Page = -1
            };
        }
    }
}
