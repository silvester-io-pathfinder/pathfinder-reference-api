using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class ShroudedMagic : Template
    {
        public static readonly Guid ID = Guid.Parse("af94cbd9-c392-461a-a0aa-80636db49943");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Shrouded Magic",
                Level = 1,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("94167acc-95bc-45cf-9710-445827e7d09d"), Type = TextBlockType.Text, Text = "Choose one cantrip from the occult spell list. You can cast this cantrip as an occult innate spell at will, heightened to a spell level equal to half your level rounded up." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("21906388-dd40-4908-9514-a209c003b51f"),
                SourceId = Sources.Instances.LostOmensAncestryGuide.ID,
                Page = -1
            };
        }
    }
}
