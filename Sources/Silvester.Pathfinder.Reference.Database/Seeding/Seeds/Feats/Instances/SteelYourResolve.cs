using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class SteelYourResolve : Template
    {
        public static readonly Guid ID = Guid.Parse("32808fa5-d190-4dee-8e3b-dd99d89b21ad");

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
            yield return new TextBlock { Id = Guid.Parse("b9e2413f-b67b-4629-ae5d-9f64b601821c"), Type = TextBlockType.Text, Text = "Regain Stamina Points equal to half your maximum." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("57aec4c7-68de-4ae8-b248-7ab79c555805"),
                SourceId = Sources.Instances.VariantRuleForStamina.ID,
                Page = -1
            };
        }
    }
}
