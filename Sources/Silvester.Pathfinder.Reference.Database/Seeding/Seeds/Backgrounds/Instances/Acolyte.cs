using Silvester.Pathfinder.Reference.Database.Models;
using Silvester.Pathfinder.Reference.Database.Models.Effects;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Bindings.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Backgrounds.Instances
{
    public class Acolyte : Template
    {
        public static readonly Guid ID = Guid.Parse("639750b4-63ef-43ec-a71a-194bb32dc02a");

        protected override Background GetBackground()
        {
            return new Background
            {
                Id = ID, 
                Name = "Acolyte",
                RarityId = Rarities.Instances.Common.ID
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse("a6ae0f59-79d8-4a49-a088-add1850849fa"), Type = TextBlockType.Text, Text = "You spent your early days in a religious monastery or cloister. You may have traveled out into the world to spread the message of your religion or because you cast away the teachings of your faith, but deep down you'll always carry within you the lessons you learned." };
        }

        protected override IEnumerable<Effect> GetEffects()
        {
            yield return new RestrictedAbilityBoostEffect
            {
                Id = Guid.Parse("7802836b-e9d5-4efd-a225-13c0bd3488da"),
                RequiredStats = new StatEffectBinding[]
                {
                    new StatEffectBinding{Id = Guid.Parse("ba7c44f0-e48f-49fb-8674-30ca1ea72c35"), StatId = Stats.Instances.Intelligence.ID },
                    new StatEffectBinding{Id = Guid.Parse("2f7b0c40-8e0b-4c1a-8356-1abe5f586fce"), StatId = Stats.Instances.Wisdom.ID }
                }
            };

            yield return new FreeAbilityBoostEffect
            {
                Id = Guid.Parse("3f501e4e-9820-4dc9-a384-25b387255ab5")
            };

            yield return new RestrictedSkillEffect
            {
                Id = Guid.Parse("535a8019-7d2e-44d0-b18d-cf72f1491ead"),
                ProficiencyId = Proficiencies.Instances.Trained.ID,
                SkillId = Skills.Instances.Religion.ID
            };

            yield return new LoreEffect
            {
                Id = Guid.Parse("3dbfa60e-6513-4331-ad5c-3e85ef0bf015"),
                ProficiencyId = Proficiencies.Instances.Trained.ID,
                LoreId = Lores.Instances.Scribing.ID
            };

            yield return new FeatEffect
            {
                Id = Guid.Parse("36fd4704-d6ee-41b2-9f11-279a09f81d4a"),
                FeatId = Feats.General.StudentOfTheCanonFeat.ID
            };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("4f5df6e6-f849-4360-8cf9-7d0baa0999cf"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 60
            };
        }
    }
}
