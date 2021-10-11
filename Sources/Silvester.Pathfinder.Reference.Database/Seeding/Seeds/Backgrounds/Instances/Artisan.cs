using Silvester.Pathfinder.Reference.Database.Models;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Backgrounds.Instances
{
    public class Artisan : Template
    {
        public static readonly Guid ID = Guid.Parse("74d5f9f5-0428-41db-b417-f0c5889072bf");

        protected override Background GetBackground()
        {
            return new Background
            {
                Id = ID, 
                Name = "Artisan",
                RarityId = Rarities.Instances.Common.ID
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse("5d1aa430-6fba-4dd8-9390-5eb2b1d3730b"), Type = TextBlockType.Text, Text = "As an apprentice, you practiced a particular form of building or crafting, developing specialized skill. You might have been a blacksmith�s apprentice toiling over the forge for countless hours, a young tailor sewing garments of all kinds, or a shipwright shaping the hulls of ships." };
        }

        protected override IEnumerable<Effect> GetEffects()
        {
            yield return new RestrictedAbilityBoostEffect
            {
                Id = Guid.Parse("bc6deaf8-97ad-45ec-b21c-5189da55f820"),
                RequiredStats = new StatEffectBinding[]
                {
                    new StatEffectBinding{Id = Guid.Parse("69855b6c-93a3-4cc8-9e1c-c43ecd6f6775"), StatId = Stats.Instances.Strength.ID },
                    new StatEffectBinding{Id = Guid.Parse("bb5237b1-192f-4a01-9333-d3b3f9c8cb76"), StatId = Stats.Instances.Intelligence.ID }
                }
            };

            yield return new FreeAbilityBoostEffect
            {
                Id = Guid.Parse("efb7ffc6-86df-4a1e-b2d4-5ad0a180605d")
            };

            yield return new RestrictedSkillEffect
            {
                Id = Guid.Parse("4957d873-58c2-4539-a4ad-e765e47714d0"),
                ProficiencyId = Proficiencies.Instances.Trained.ID,
                SkillId = Skills.Instances.Crafting.ID
            };

            yield return new LoreEffect
            {
                Id = Guid.Parse("6bda3a9e-2395-4435-9c13-cc0057ba8c7a"),
                ProficiencyId = Proficiencies.Instances.Trained.ID,
                LoreId = Lores.Instances.Guild.ID
            };

            yield return new FeatEffect
            {
                Id = Guid.Parse("ddfb482e-8294-4adb-8ff9-256c99d97ccf"),
                FeatId = Feats.General.SpecialtyCraftingFeat.ID
            };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("8a305580-2d54-4090-94ae-465b22e10fab"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 60
            };
        }
    }
}
