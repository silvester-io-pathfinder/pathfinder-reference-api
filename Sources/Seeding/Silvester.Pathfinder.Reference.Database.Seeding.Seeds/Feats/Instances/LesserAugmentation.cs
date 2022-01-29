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
    public class LesserAugmentation : Template
    {
        public static readonly Guid ID = Guid.Parse("79ea2ac1-bb5a-4ac8-a611-e1038d5e819c");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Lesser Augmentation",
                Level = 9,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("6b33711a-55b1-47db-9a88-9a65f93febb3"), Type = TextBlockType.Text, Text = $"You've focused on enhancing yourself and have received an improvement to one of your existing abilities. You gain the enhancement benefits of one of your 1st- or 5th-level automaton ancestry feats." };
            yield return new TextBlock { Id = Guid.Parse("8ff6c1ee-504d-4690-abe2-ce5579b04e33"), Type = TextBlockType.Text, Text = $"You are also capable of reconfiguring your augmentations to meet your needs. You can spend one week of downtime to change the enhancement you gain with this feat." };
            yield return new TextBlock { Id = Guid.Parse("40f18c07-e9df-4cd3-b126-032fc33d51c3"), Type = TextBlockType.Text, Text = $"----" };
            yield return new TextBlock { Id = Guid.Parse("6f8a2a22-14de-44e5-ba3d-782cefe967cd"), Type = TextBlockType.Text, Text = $"~ Enhancement: You gain the enhancement benefits of another 1st- or 5th-level automaton ancestry feat. Also, your reconfigurations take less time. You only need to spend 1 day of downtime to change any of your enhancements. If you have multiple enhancements, changing each one requires a separate day." };
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {
            builder.Add(Guid.Parse("d5160f67-fce9-4038-a48f-4daf6ab501d5"), Traits.Instances.Automaton.ID);

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("0ed3806b-c8e3-413e-9bcf-94839a7c0db7"),
                SourceId = Sources.Instances.GunsAndGears.ID,
                Page = -1
            };
        }
    }
}
