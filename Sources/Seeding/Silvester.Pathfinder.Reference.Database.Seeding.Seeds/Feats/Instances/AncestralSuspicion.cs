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
    public class AncestralSuspicion : Template
    {
        public static readonly Guid ID = Guid.Parse("75f6fd50-7225-453c-8d6b-b4fedd82ed0a");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Ancestral Suspicion",
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
            yield return new TextBlock { Id = Guid.Parse("94d12173-3a0e-4b3c-b9c3-05cc5ecfa03e"), Type = TextBlockType.Text, Text = $"Long-lived elves have seen civilizations rise and fall, often at the hands of outside forces. As a result, they have developed a wariness of others who might seek to influence or control them. You've been trained to resist such manipulation, gaining a +2 circumstance bonus to saving throws against effects that would make you controlled, such as {ToMarkdownLink<Models.Entities.Spell>("dominate", Spells.Instances.Dominate.ID)}, and to Perception checks to {ToMarkdownLink<Models.Entities.Action>("Sense Motive", Actions.Instances.SenseMotive.ID)} when trying to determine if a creature is under the influence of such an effect. When you roll a success on a saving throw against such an effect, you get a critical success instead." };
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {
            builder.Add(Guid.Parse(""), Traits.Instances.Elf.ID);

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("008add6b-e4f7-4e64-bdaa-c2982811d1ef"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
