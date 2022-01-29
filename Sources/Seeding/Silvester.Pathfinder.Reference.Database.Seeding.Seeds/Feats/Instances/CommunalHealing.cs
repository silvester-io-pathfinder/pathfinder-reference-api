using Silvester.Pathfinder.Reference.Database.Seeding.Builders.TextBlocks;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.Traits;
using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class CommunalHealing : Template
    {
        public static readonly Guid ID = Guid.Parse("fbe84f1b-03c9-4b67-8d07-9076a1ba9104");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Communal Healing",
                Level = 2,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("06784b51-3794-4d5e-8c2d-2c71a7da37ed"), Type = TextBlockType.Text, Text = $"You're a conduit for positive energy, and as you channel it through you, it heals some of your minor injuries. When you cast the {ToMarkdownLink<Models.Entities.Spell>("heal", Spells.Instances.Heal.ID)} spell to heal a single creature other than yourself, you regain Hit Points equal to the spell level of the heal spell." };
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {
            builder.Add(Guid.Parse("27d060e2-603e-4f9e-8e8d-835d35940411"), Traits.Instances.Cleric.ID);
            builder.Add(Guid.Parse("c4103212-912b-434e-9a77-82ba22f61825"), Traits.Instances.Healing.ID);
            builder.Add(Guid.Parse("eee9f778-b59b-4874-9535-da662dd05730"), Traits.Instances.Positive.ID);

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("6eead6c2-1d45-4f5e-ba6d-1cbb89497d30"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
