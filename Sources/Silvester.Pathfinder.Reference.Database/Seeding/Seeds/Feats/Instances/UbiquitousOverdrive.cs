using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class UbiquitousOverdrive : Template
    {
        public static readonly Guid ID = Guid.Parse("07f96f0f-de0c-4a8f-8e4f-7e8bdde7c13b");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Ubiquitous Overdrive",
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
            yield return new TextBlock { Id = Guid.Parse("bf3d2327-437b-4ed7-9932-62c27cb5f945"), Type = TextBlockType.Text, Text = "You prepare a variety of incredible gizmos on each of your allies, linking them together through careful modification to enable you to power them up all at once. During your daily preparations, select up to six willing allies. Whenever you (action: Overdrive), you grant the benefits of your overdrive to any of these allies you choose who are within 30 feet of you. The allies don’t gain the increased damage from expert, master, or legendary overdrive." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("2f0e3809-ef91-4fa3-8161-cfe74843eb32"), Feats.Instances.SharedOverdrive.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("f832d172-bd25-4d6a-8339-f60b62935ee7"),
                SourceId = Sources.Instances.GunsAndGears.ID,
                Page = -1
            };
        }
    }
}
