using Silvester.Pathfinder.Reference.Database.Effects;
using Silvester.Pathfinder.Reference.Database.Models.Entities;


using Silvester.Pathfinder.Reference.Database.Seeding.Seeds.PlayModes.Instances;
using Silvester.Pathfinder.Reference.Database.Seeding.Seeds.SkillActions.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using Silvester.Pathfinder.Reference.Database.Effects.Instances;
using System.Collections.Generic;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Builders;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Backgrounds.Instances
{
    public class PathfinderRecruiter : Template
    {
        public static readonly Guid ID = Guid.Parse("a263e669-13dd-4415-8670-6c27a3a470d9");

        protected override Background GetBackground()
        {
            return new Background
            {
                Id = ID, 
                Name = "Pathfinder Recruiter",
                RarityId = Rarities.Instances.Common.ID
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse("32fa615c-d54d-4c4d-8ad5-e8223abcaba8"), Type = TextBlockType.Text, Text = "The Pathfinder Society's always on the lookout for talent, but that talent rarely just stumbles into the Grand Lodge. Whether you're professionally trained to encourage new recruits or the Society's own scouts identified your potential and raised you from childhood, you're committed to expanding the Society's roster." };
        }

        protected override void GetEffects(BooleanEffectBuilder builder)
        {
            builder.AddOr(Guid.Parse("d3952eff-ba66-428d-9a62-07ce5b3e03fc"), or =>
            {
                or.GainSpecificAbilityBoost(Guid.Parse("03227aeb-105b-4179-9c6c-d20ffc79e77f"), Stats.Instances.Wisdom.ID);
                or.GainSpecificAbilityBoost(Guid.Parse("603540cc-2130-44ed-b818-f0005dae864e"), Stats.Instances.Charisma.ID);
            });

            builder.GainAnyAbilityBoost(Guid.Parse("7370e081-4369-46b6-af67-ae99c584a87d"));

            builder.GainSpecificSkillProficiency(Guid.Parse("bc123941-16e0-4e54-974f-8136ff0a4fcd"), Proficiencies.Instances.Trained.ID, Skills.Instances.Diplomacy.ID);
            builder.GainSpecificLoreCategoryProficiency(Guid.Parse("db077ca3-c177-49e4-9c01-dfb4e7b7a06c"), Proficiencies.Instances.Trained.ID, LoreCategories.Instances.Deities.ID, "The chosen Lore skill must be related to one city you've visited often.");
            builder.GainSpecificFeat(Guid.Parse("cf351704-943b-4157-8bfd-1a0315047137"), Feats.Instances.GroupImpression.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("52033497-c1ae-4f98-b68d-06c7dc1dbccc"),
                SourceId = Sources.Instances.PathfinderSocietyGuide.ID,
                Page = 6
            };
        }
    }
}
