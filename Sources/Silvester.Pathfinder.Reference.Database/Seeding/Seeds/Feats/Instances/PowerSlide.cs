using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class PowerSlide : Template
    {
        public static readonly Guid ID = Guid.Parse("bf4afea8-de88-4492-862c-9574215edb3d");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Power Slide",
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
            yield return new TextBlock { Id = Guid.Parse("84ee7ba1-1cd9-46f9-9833-647385d4b374"), Type = TextBlockType.Text, Text = "You throw the vehicle into a barely controlled skid, turning sharply to evade pursuit or bring your weapons to bear. You Drive with a –2 penalty to your piloting check, gaining the effects of the Drive action for the same number of actions you spent to Power Slide. At the end of the movement, if you succeed, you can turn the vehicle up to 90 degrees. If you critically succeed at your piloting check, you can instead turn the vehicle up to 180 degrees." };
            yield return new TextBlock { Id = Guid.Parse("9a3c05d0-398e-4077-afaf-e94619c34b1d"), Type = TextBlockType.Text, Text = "You may use ONE-ACTION to THREE-ACTIONS when performing this activity." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("fbdb8697-696b-435b-9f6b-25ef11518923"), Feats.Instances.TrickDriverDedication.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("1427d3fb-39aa-4b68-b111-7b0013b3d935"),
                SourceId = Sources.Instances.GunsAndGears.ID,
                Page = -1
            };
        }
    }
}
