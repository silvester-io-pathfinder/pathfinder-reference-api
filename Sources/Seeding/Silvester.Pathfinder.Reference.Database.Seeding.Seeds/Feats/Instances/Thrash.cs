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
    public class Thrash : Template
    {
        public static readonly Guid ID = Guid.Parse("8661946e-05c1-42ab-91a2-079f33fb3956");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Thrash",
                Level = 8,
                ActionTypeId = ActionTypes.Instances.OneAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("d2692fdd-88d5-469d-82c5-e15692ece76f"), Type = TextBlockType.Text, Text = $"You thrash the grabbed foe around. It takes bludgeoning damage equal to your Strength modifier plus your weapon specialization damage plus your {ToMarkdownLink<Models.Entities.Feat>("Rage", Feats.Instances.Rage.ID)} damage. The foe must attempt a basic Fortitude save against your class DC." };
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {
            builder.Add(Guid.Parse(""), Traits.Instances.Barbarian.ID);
            builder.Add(Guid.Parse(""), Traits.Instances.Rage.ID);

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("d0332cc2-5470-4edf-8dcf-dd0fad52865a"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
