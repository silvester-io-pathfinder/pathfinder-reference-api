using Silvester.Pathfinder.Reference.Database.Seeding.Builders.TextBlocks;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.Traits;
using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class DisturbingDefense : Template
    {
        public static readonly Guid ID = Guid.Parse("45e810aa-a88e-4b7f-be1b-51669e1dc33a");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Disturbing Defense",
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
            yield return new TextBlock { Id = Guid.Parse("d3a89607-1e05-4551-bf1b-2d9005c285db"), Type = TextBlockType.Text, Text = $"Your internal organs and blood vessels have shifted and changed, and even you don't know precisely where in your body they are. You gain resistance to precision damage equal to 2 + your number of class feats from the oozemorph archetype. The DC of your flat checks to recover from persistent bleed damage is 13, rather than 15." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("0f9218cb-3253-4a57-83a0-dc500026d4d9"), Feats.Instances.OozemorphDedication.ID);
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("cdd88149-1151-4c61-a534-d82aff780b24"),
                SourceId = Sources.Instances.TheSlithering.ID,
                Page = -1
            };
        }
    }
}
