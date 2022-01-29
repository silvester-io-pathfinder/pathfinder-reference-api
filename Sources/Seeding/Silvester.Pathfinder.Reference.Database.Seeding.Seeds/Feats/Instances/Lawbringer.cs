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
    public class Lawbringer : Template
    {
        public static readonly Guid ID = Guid.Parse("31b41650-cb1c-45c6-9ef9-c440a4abce63");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Lawbringer",
                Level = 1,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("589339ce-eff1-4e11-8af7-1c7def81c85e"), Type = TextBlockType.Text, Text = $"You trace your lineage to archons: embodiments of heavenly virtues, guardians of the seven-tiered mountain of Heaven, and nurturers of law and virtue within mortals. Your own virtue and orderly mind protect you from foes who would turn your emotions against you. You gain a +1 circumstance bonus to saves against emotion effects, and if you roll a success on a save against an {ToMarkdownLink<Models.Entities.Trait>("emotion", Traits.Instances.Emotion.ID)} effect, you get a critical success instead." };
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {
            builder.Add(Guid.Parse("15dae061-fc9a-437a-b8d2-ca1ecd0baefe"), Traits.Instances.Aasimar.ID);
            builder.Add(Guid.Parse("6ec013ea-e950-46dc-b20b-ba576f699045"), Traits.Instances.Lineage.ID);

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("0516f877-ec48-46ed-9192-40ca05aef644"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
