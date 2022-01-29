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
    public class RoundEars : Template
    {
        public static readonly Guid ID = Guid.Parse("eb942967-cccf-45fb-833f-121b2adb5a14");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Round Ears",
                Level = 1,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = "You can take this feat only at 1st level, and you can't retrain out of this feat or into this feat.",
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("ce6dfa6a-9669-4eb7-8227-960ce18b5a1e"), Type = TextBlockType.Text, Text = $"Your elven lineage is subtle enough that you look barely different from other humans, and you've learned to use that to your advantage. You gain the trained proficiency rank in Deception (or another skill of your choice, if you were already trained in Deception). You gain a +4 circumstance bonus to {ToMarkdownLink<Models.Entities.SkillAction>("Impersonate", SkillActions.Instances.Impersonate.ID)} checks to pretend you aren't a half-elf. Observers are never granted circumstance bonuses to Perception checks due to you {ToMarkdownLink<Models.Entities.SkillAction>("Impersonating", SkillActions.Instances.Impersonate.ID)} a full-blooded human, and you never take circumstance penalties due to you {ToMarkdownLink<Models.Entities.SkillAction>("Impersonating", SkillActions.Instances.Impersonate.ID)} a full-blooded human." };
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {
            builder.Add(Guid.Parse(""), Traits.Instances.HalfElf.ID);

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("8457f932-fde7-40e1-b9c0-f49830ff12b8"),
                SourceId = Sources.Instances.LostOmensCharacterGuide.ID,
                Page = -1
            };
        }
    }
}
