using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class SkullCreeper : Template
    {
        public static readonly Guid ID = Guid.Parse("117ab310-921b-4b33-a33b-502ddb19a3f5");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Skull Creeper",
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
            yield return new TextBlock { Id = Guid.Parse("ccbe5015-43ab-4b64-aa93-7cb423e5e320"), Type = TextBlockType.Text, Text = "You wear skulls to demoralize foes. You become trained in Intimidation and gain the (feat: Intimidating Glare) skill feat. If you’re already trained in Intimidation, you instead become trained in a skill of your choice. If you pay 50 gp for a splendid (item: skull mask | skull mask splendid), the mask grants you a +1 item bonus to Intimidation; its usage is worn (mask)." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("9b200a06-1da2-4675-b97c-86ba9f1313c4"),
                SourceId = Sources.Instances.LostOmensAncestryGuide.ID,
                Page = -1
            };
        }
    }
}
