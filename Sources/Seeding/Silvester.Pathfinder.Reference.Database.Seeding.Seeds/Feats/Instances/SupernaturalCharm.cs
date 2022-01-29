using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class SupernaturalCharm : Template
    {
        public static readonly Guid ID = Guid.Parse("29e2f47e-4787-490d-97bd-16227ea49f56");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Supernatural Charm",
                Level = 5,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("7f05f28d-6d74-4c28-be25-677813e84c3c"), Type = TextBlockType.Text, Text = $"The elven magic in your blood manifests as a force you can use to become more appealing or alluring. You can cast 1st-level {ToMarkdownLink<Models.Entities.Spell>("charm", Spells.Instances.Charm.ID)} as an arcane innate spell once per day." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("eb40f979-515f-4025-834d-4093a034d0c0"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
