using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class Webslinger : Template
    {
        public static readonly Guid ID = Guid.Parse("b5ca1a15-e567-4caa-827f-8aedb389773b");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Webslinger",
                Level = 13,
                ActionTypeId = ActionTypes.Instances.ThreeActions.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = "once per 10 minutes"
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("81dc1fca-49ec-4fa0-96a6-b30f72892a31"), Type = TextBlockType.Text, Text = "Your natural ability to create silken webs blends with your magical powers, allowing you to create impossibly large webs with great frequency. This has the effects of a 2nd-level (spell: web) spell using your class DC or spell DC, whichever is higher." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("6d62457f-47f0-4e0a-a280-b6bf2c987f49"),
                SourceId = Sources.Instances.LostOmensMwangiExpanse.ID,
                Page = -1
            };
        }
    }
}
