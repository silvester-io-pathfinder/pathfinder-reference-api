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
    public class Determination : Template
    {
        public static readonly Guid ID = Guid.Parse("cb0ba404-9ab8-4856-84f1-53f5e40e6843");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Determination",
                Level = 14,
                ActionTypeId = ActionTypes.Instances.OneAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = "once per day"
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("6ca36b7e-3b21-4d18-b811-916ae6d4d47b"), Type = TextBlockType.Text, Text = $"Your training allows you to shrug off your foes' spells and conditions when the need is dire. Choose a single nonpermanent spell or condition that is affecting you. If you chose a condition, its effect on you ends. If you chose a spell, attempt to counteract the spell (your counteract level is equal to half your level, rounded up, and you attempt a Will save as your counteract check)." };
            yield return new TextBlock { Id = Guid.Parse("a88ca7c2-1dd7-4284-a98a-979c548a6885"), Type = TextBlockType.Text, Text = $"This doesn't remove any Hit Point damage normally dealt by the spell or condition, and it doesn't prevent the spell or debilitating effect from affecting other allies or the environment around you. It can't remove an ongoing affliction or prevent such an affliction from inflicting conditions on you later. It can't remove conditions from the situation (such as prone or flanked). If the effect comes from a creature, hazard, or item of 20th level or higher, Determination can't remove its effect on you." };
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("c35a1471-8d4a-4b59-b51d-7e2b7d8778d6"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
