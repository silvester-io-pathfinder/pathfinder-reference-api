using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class Determination : Template
    {
        public static readonly Guid ID = Guid.Parse("4d3b5eaf-087f-4b4c-a70d-b33f03c6f2fa");

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
            yield return new TextBlock { Id = Guid.Parse("06c8e6c1-c209-4c40-8412-d5a05c44c96a"), Type = TextBlockType.Text, Text = "Your training allows you to shrug off your foes’ spells and conditions when the need is dire. Choose a single nonpermanent spell or condition that is affecting you. If you chose a condition, its effect on you ends. If you chose a spell, attempt to counteract the spell (your counteract level is equal to half your level, rounded up, and you attempt a Will save as your counteract check)." };
            yield return new TextBlock { Id = Guid.Parse("5c7e142a-6eab-4975-8c04-8ad5fe9e8b25"), Type = TextBlockType.Text, Text = "This doesn’t remove any Hit Point damage normally dealt by the spell or condition, and it doesn’t prevent the spell or debilitating effect from affecting other allies or the environment around you. It can’t remove an ongoing affliction or prevent such an affliction from inflicting conditions on you later. It can’t remove conditions from the situation (such as prone or flanked). If the effect comes from a creature, hazard, or item of 20th level or higher, Determination can’t remove its effect on you." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("80b347d6-526f-4106-b892-9f50153be7c8"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
