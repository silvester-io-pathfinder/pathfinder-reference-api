using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class SteelYourResolve : Template
    {
        public static readonly Guid ID = Guid.Parse("5638eef5-c3ce-46f1-8852-8830f1d9102c");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Steel Your Resolve",
                Level = 3,
                ActionTypeId = ActionTypes.Instances.OneAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("73fc4076-10a3-4565-a624-c02fac479677"), Type = TextBlockType.Text, Text = $"Regain Stamina Points equal to half your maximum." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("fbf09f5d-d975-4295-9608-fcc1cd04c398"),
                SourceId = Sources.Instances.VariantRuleForStamina.ID,
                Page = -1
            };
        }
    }
}
