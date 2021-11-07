using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class DriveByAttack : Template
    {
        public static readonly Guid ID = Guid.Parse("6dcec8f6-2ec9-43bd-887a-fea5657e88df");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Drive-By Attack",
                Level = 12,
                ActionTypeId = ActionTypes.Instances.OneAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("b5c58ca1-e659-45fc-88a9-d2014f43cf3c"), Type = TextBlockType.Text, Text = "You can smoothly line up an attack without disrupting your control. You Drive, gaining the effects of the Drive action for the same number of actions you spent to Drive-By Attack. At any point during your vehicle’s movement, you (action: Strike)." };
            yield return new TextBlock { Id = Guid.Parse("b47fd1d4-5910-4083-b403-c7f1df1a5784"), Type = TextBlockType.Text, Text = "You may use ONE-ACTION to THREE-ACTIONS when performing this activity." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("2d630d28-de7e-431d-990b-3d8f707db35d"), Feats.Instances.TrickDriverDedication.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("def0c7db-46a7-405d-a6c4-18c51c4c032a"),
                SourceId = Sources.Instances.GunsAndGears.ID,
                Page = -1
            };
        }
    }
}
