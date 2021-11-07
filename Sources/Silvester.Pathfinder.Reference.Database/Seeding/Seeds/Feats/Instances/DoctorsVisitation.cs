using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class DoctorsVisitation : Template
    {
        public static readonly Guid ID = Guid.Parse("d8d47ec5-95a3-4048-9a6d-48aac8bae743");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Doctor's Visitation",
                Level = 4,
                ActionTypeId = ActionTypes.Instances.OneAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("3c1aee88-db73-499f-a2a7-880431bee4f8"), Type = TextBlockType.Text, Text = "You move to provide immediate care to those who need it. (action: Stride), then use one of the following: (feat: Battle Medicine) or (action: Treat Poison). You can spend a second action to instead (action: Stride) and then (action: Administer First Aid) or (feat: Treat a Condition | Treat Condition) (if you have it)." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("80137594-b6c4-46d7-9c85-915c45e110be"), Feats.Instances.MedicDedication.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("311bf56f-c9f4-44da-b091-ebc45d95eb37"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
