using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class SunBlade : Template
    {
        public static readonly Guid ID = Guid.Parse("b1cbb71c-743d-4cf7-bb36-04359d93f3b4");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Sun Blade",
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
            yield return new TextBlock { Id = Guid.Parse("65dd2ca0-8e4f-4768-92f8-d974194833ae"), Type = TextBlockType.Text, Text = "~ Access: The following class feat is available to Knights of Lastwall." };
            yield return new TextBlock { Id = Guid.Parse("3d1e9f27-9092-47b2-822a-11766267d677"), Type = TextBlockType.Text, Text = "You can unleash burning sunlight from your sword or spear. You gain the (spell: sun blade) devotion spell. Increase the number of Focus Points in your focus pool by 1." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("df475643-cedc-41a4-bd31-421fac230699"),
                SourceId = Sources.Instances.LostOmensCharacterGuide.ID,
                Page = -1
            };
        }
    }
}
