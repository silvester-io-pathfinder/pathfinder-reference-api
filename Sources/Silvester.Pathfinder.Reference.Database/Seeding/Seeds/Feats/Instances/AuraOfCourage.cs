using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class AuraOfCourage : Template
    {
        public static readonly Guid ID = Guid.Parse("46d026d4-e8af-458c-97c2-822631bac7c1");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Aura of Courage",
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
            yield return new TextBlock { Id = Guid.Parse("caf9fec9-ebd1-42ba-afea-b93127c6f8fd"), Type = TextBlockType.Text, Text = "You stand strong in the face of danger and inspire your allies to do the same. Whenever you become frightened, reduce the condition value by 1 (to a minimum of 0). At the end of your turn when you would reduce your frightened condition value by 1, you also reduce the value by 1 for all allies within 15 feet." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificTenet(Guid.Parse("7ab7a8d9-39ee-4a8d-abbc-6fa42c37af82"), Tenets.Instances.Good.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("e92fbbe2-107a-4508-8e77-273c8cd94272"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
