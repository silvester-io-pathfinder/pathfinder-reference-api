using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class RescuersPress : Template
    {
        public static readonly Guid ID = Guid.Parse("7860a65d-5bfe-4007-9945-211f13afb551");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Rescuer's Press",
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
            yield return new TextBlock { Id = Guid.Parse("a75b5dad-4ba0-4e54-9dc6-5b2b72eb0c18"), Type = TextBlockType.Text, Text = "Any shield you wield gains the (trait: shove) trait. When you (action: Shove) using a shield and (action: Stride) as part of that action, you can move an additional 5 feet to either side of the creature you (action: Shoved | Shove)." };
            yield return new TextBlock { Id = Guid.Parse("5b8d6028-4433-4ca3-b959-dd71e3de2edc"), Type = TextBlockType.Text, Text = "In addition, if you are in the (feat: Everstand Stance) and successfully (action: Shove) a creature using a shield that you wield two-handed, you can increase the distance of your (action: Shove) to 10 feet." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("7c1adece-26dd-4309-87ff-802511ff5743"), Feats.Instances.LastwallSentryDedication.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("b0aefda3-fc52-4623-a945-64d5f0c54425"),
                SourceId = Sources.Instances.LostOmensLegends.ID,
                Page = -1
            };
        }
    }
}
