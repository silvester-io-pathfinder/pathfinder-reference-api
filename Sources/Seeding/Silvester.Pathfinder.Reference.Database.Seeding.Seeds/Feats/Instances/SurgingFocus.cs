using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class SurgingFocus : Template
    {
        public static readonly Guid ID = Guid.Parse("1259c9f3-e937-4dfb-8d0a-b9e94d2e1b6d");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Surging Focus",
                Level = 8,
                ActionTypeId = ActionTypes.Instances.FreeAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = "An ally you can see falls to 0 Hit Points.",
                Frequency = "once per day"
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("e136f332-d64a-4f7a-9a60-547a4e828838"), Type = TextBlockType.Text, Text = $"When an ally you can see falls in battle, your fight or flight response triggers a surge in your deity's might within you. You instantly regain 1 Focus Point." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("3c38c82e-f35c-4b7b-8c8a-9269b7369878"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
