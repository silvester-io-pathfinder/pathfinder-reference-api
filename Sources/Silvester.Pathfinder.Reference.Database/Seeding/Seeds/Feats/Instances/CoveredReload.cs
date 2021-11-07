using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class CoveredReload : Template
    {
        public static readonly Guid ID = Guid.Parse("4e7a61ac-00ff-4a86-bddd-ec6d109a1e9e");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Covered Reload",
                Level = -1,
                ActionTypeId = ActionTypes.Instances.OneAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("3f4b2c48-2394-4aef-861e-856f8a4eab4f"), Type = TextBlockType.Text, Text = "You duck into a safe position or minimize your profile while reloading to make your next attack. Either (action: Take Cover) or attempt to (action: Hide), then (action: Interact) to reload. As normal, you must meet the requirements to (action: Take Cover) or (action: Hide); you must be prone, benefiting from cover, or near a feature that allows you to (action: Take Cover), and you need to be benefiting from cover or concealed to a creature to (action: Hide) from that creature." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("c9be6a34-8e37-40b6-b9c0-8cc5bcb41fa5"),
                SourceId = Sources.Instances.GunsAndGears.ID,
                Page = -1
            };
        }
    }
}
