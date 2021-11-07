using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class InnerStrength : Template
    {
        public static readonly Guid ID = Guid.Parse("255ea297-5354-4b60-bd43-6130bfcacfed");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Inner Strength",
                Level = 6,
                ActionTypeId = ActionTypes.Instances.OneAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("3ce49396-6af7-40e0-8554-0badbcfc7305"), Type = TextBlockType.Text, Text = "Your strength is part of your rage, so as long as your anger remains, you can gather your strength and rage to overcome any sort of enfeeblement. You reduce your enfeebled condition’s value by 1." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("d73e94e0-c78b-436a-be6d-f35e205d9e29"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
