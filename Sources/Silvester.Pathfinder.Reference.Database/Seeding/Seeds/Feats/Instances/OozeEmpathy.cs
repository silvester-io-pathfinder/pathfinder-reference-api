using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class OozeEmpathy : Template
    {
        public static readonly Guid ID = Guid.Parse("16a96c16-26a9-413e-b64b-30e446883d1a");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Ooze Empathy",
                Level = 8,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("72a722a7-bea5-4b82-8df4-274aa59dddd1"), Type = TextBlockType.Text, Text = "You can connect with oozes (and other amorphous aberrations, at the GM’s discretion) on a rudimentary level. You can use Diplomacy to (action: Make an Impression) on oozes and to make very simple (action: Requests | Request) of them. In most instances, oozes will give you time to make your case." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("9eeaeccd-e650-4823-b3a9-31fc28055e90"), Feats.Instances.OozemorphDedication.ID);
            builder.Manual(Guid.Parse("32809732-a066-4970-86de-993b2f4365e9"), "At least two other class feats from the oozemorph archetype.");
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("92d500be-1ae3-44ee-9fd6-3a19da004588"),
                SourceId = Sources.Instances.TheSlithering.ID,
                Page = -1
            };
        }
    }
}
