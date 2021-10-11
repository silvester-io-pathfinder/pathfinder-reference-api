using Silvester.Pathfinder.Reference.Database.Models;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Backgrounds.Instances
{
    public class Outrider : Template
    {
        public static readonly Guid ID = Guid.Parse("90fa7caa-4286-45c1-a0b9-85051d822db4");

        protected override Background GetBackground()
        {
            return new Background
            {
                Id = ID, 
                Name = "Outrider",
                RarityId = Rarities.Instances.Common.ID
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse("22221b84-11a4-4ee8-94ad-89db5d4f6c67"), Type = TextBlockType.Text, Text = "In your youth, you galloped on horseback over vast prairies, serving as a vanguard for your settlement, an army, or another group. Seeing so many different lands built a thirst in you to adventure and explore the world instead of just racing past it." };
        }

        protected override IEnumerable<Effect> GetEffects()
        {
            yield return new RestrictedAbilityBoostEffect
            {
                Id = Guid.Parse("389a8e9b-fe42-4a9d-a532-6fb6da4697d4"),
                RequiredStats = new StatEffectBinding[]
                {
                    new StatEffectBinding{Id = Guid.Parse("609cb456-1a71-4cec-bc08-6ed7aabfe821"), StatId = Stats.Instances.Constitution.ID },
                    new StatEffectBinding{Id = Guid.Parse("088f2ae3-2d8f-403e-a12d-46893c62102e"), StatId = Stats.Instances.Wisdom.ID }
                }
            };

            yield return new FreeAbilityBoostEffect
            {
                Id = Guid.Parse("f5304914-898f-4a24-86c5-6399dabfeb8e")
            };

            yield return new RestrictedSkillEffect
            {
                Id = Guid.Parse("a95ede6f-fb55-4391-8455-3d5e68f362d3"),
                ProficiencyId = Proficiencies.Instances.Trained.ID,
                SkillId = Skills.Instances.Nature.ID
            };

            yield return new LoreEffect
            {
                Id = Guid.Parse("a809f840-e2f9-4c9a-bf11-9e6b3754f16e"),
                ProficiencyId = Proficiencies.Instances.Trained.ID,
                LoreId = Lores.Instances.Plains.ID
            };

            yield return new FeatEffect
            {
                Id = Guid.Parse("1ce88df0-0195-4944-8c1c-a335581a520b"),
                FeatId = Feats.General.ExpressRiderFeat.ID
            };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("30c35551-92d1-4e41-961b-a3f424955e70"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = 48
            };
        }
    }
}
