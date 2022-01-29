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
    public class CoreRejuvenation : Template
    {
        public static readonly Guid ID = Guid.Parse("0ca74c7c-a326-42b1-835d-3fc1f685032a");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Core Rejuvenation",
                Level = 13,
                ActionTypeId = ActionTypes.Instances.FreeAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = "You have the dying condition and are about to attempt a recovery check.",
                Frequency = "once per day"
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("7c62ea8d-1768-4b2b-9688-b69712608d1f"), Type = TextBlockType.Text, Text = $"Your soul taps into your core's power to push against the grasp of death and allow you to recover consciousness. You're restored to 1 Hit Point, lose the dying and unconscious conditions, and can act normally on this turn. You gain or increase the wounded condition as normal when losing the dying condition in this way." };
            yield return new TextBlock { Id = Guid.Parse("3e427925-a7ac-403c-8206-115b0ae44c71"), Type = TextBlockType.Text, Text = $"----" };
            yield return new TextBlock { Id = Guid.Parse("2c244668-d42c-4bdf-88d9-37f7cd42f0e2"), Type = TextBlockType.Text, Text = $"~ Enhancement: Your soul can draw even more power from your core, granting you additional benefits. When you use Core Rejuvenation, you also gain a number of temporary Hit Points equal to three times your level. These Hit Points remain for 1 minute." };
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {
            builder.Add(Guid.Parse(""), Traits.Instances.Automaton.ID);

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("28ee1ba0-8f48-4fa3-829b-792e6c1d05b6"),
                SourceId = Sources.Instances.GunsAndGears.ID,
                Page = -1
            };
        }
    }
}
