using Silvester.Pathfinder.Reference.Database.Models;
using Silvester.Pathfinder.Reference.Database.Models.Effects;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Bindings.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Instances;
using Silvester.Pathfinder.Reference.Database.Seeding.Seeds.PlayModes.Instances;
using Silvester.Pathfinder.Reference.Database.Seeding.Seeds.SkillActions.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

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

        protected override IEnumerable<Effect> GetEffects()
        {
            yield return new GainSpecificAbilityBoostEffect
            {
                Id = Guid.Parse("31c0f048-a5aa-42a4-aa82-a258c5293e13"),
                RequiredStats = new StatEffectBinding[]
                {
                    new StatEffectBinding{Id = Guid.Parse("2632fd6f-f21c-4d4c-9059-ed97fc6bb737"), StatId = Stats.Instances.Wisdom.ID },
                    new StatEffectBinding{Id = Guid.Parse("147a3223-9cac-4f84-8d9a-9ed0e601cdaa"), StatId = Stats.Instances.Charisma.ID }
                }
            };

            yield return new GainAnyAbilityBoostEffect
            {
                Id = Guid.Parse("f000fad2-0242-4dfa-badc-ef581c7b12cf")
            };

            yield return new GainSpecificSkillProficiencyEffect
            {
                Id = Guid.Parse("471406ee-a170-47d1-9b5a-ca64277c1860"),
                ProficiencyId = Proficiencies.Instances.Trained.ID,
                SkillId = Skills.Instances.Diplomacy.ID
            };

            yield return new GainSpecificLoreCategoryProficiencyEffect
            {
                Id = Guid.Parse("9915364f-9277-4108-93ad-f38272d4fb99"),
                ProficiencyId = Proficiencies.Instances.Trained.ID,
                LoreCategoryId = LoreCategories.Instances.Settlements.ID,
                Restrictions = "The chosen Lore skill must be related to one city you've visited often."
            };

            yield return new GainSpecificFeatEffect
            {
                Id = Guid.Parse("545ad6af-73a3-4ea2-8ffb-40cc1eee2ab7"),
                FeatId = Feats.General.GroupImpressionFeat.ID
            };
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
