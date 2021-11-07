using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class ShareRage : Template
    {
        public static readonly Guid ID = Guid.Parse("fe0d023b-3865-4c2e-bc4b-9b90dfa0727b");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Share Rage",
                Level = 8,
                ActionTypeId = ActionTypes.Instances.OneAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("fe93a193-45b0-4d83-898a-97e7e3398187"), Type = TextBlockType.Text, Text = "You stoke an ally’s fury. While you are raging, one willing creature within 30 feet gains the effects of the (feat: Rage) action, except it can still use (trait: concentrate) actions." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("40a8989d-65b3-40ad-b48f-fa9665e4b497"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
