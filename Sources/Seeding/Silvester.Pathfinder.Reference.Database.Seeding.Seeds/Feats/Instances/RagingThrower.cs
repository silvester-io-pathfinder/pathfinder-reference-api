using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class RagingThrower : Template
    {
        public static readonly Guid ID = Guid.Parse("b360473c-24c0-4f87-b7de-1ef805878d0d");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Raging Thrower",
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
            yield return new TextBlock { Id = Guid.Parse("5c41aaec-d6de-4cf5-bbe4-19292b80c987"), Type = TextBlockType.Text, Text = $"Thrown weapons become especially deadly in your fury. You apply the additional damage from {ToMarkdownLink<Models.Entities.Feat>("Rage", Feats.Instances.Rage.ID)} to your thrown weapon attacks. If you have the {ToMarkdownLink<Models.Entities.Feat>("Brutal Critical", Feats.Instances.BrutalCritical.ID)} feat or the devastator class feature, apply their benefits to thrown weapon attacks." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("46222dfe-ec98-4099-9acf-99e4ea39dcac"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
