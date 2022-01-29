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
    public class SavageCritical : Template
    {
        public static readonly Guid ID = Guid.Parse("f29c42e8-fc62-446d-934d-344ecef03859");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Savage Critical",
                Level = 18,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("14eacfce-c3be-4099-b560-4abe24c30e67"), Type = TextBlockType.Text, Text = $"The wounds you inflict are grievous. When you {ToMarkdownLink<Models.Entities.Action>("Strike", Actions.Instances.Strike.ID)} with a weapon or unarmed attack for which you have legendary proficiency, you critically succeed if you roll a 19 on the die as long as that result is a success. This has no effect on a 19 if the result would be a failure." };
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {
            builder.Add(Guid.Parse(""), Traits.Instances.Fighter.ID);

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("418a4412-e2ae-4c8d-8116-6830bb4e31cb"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
