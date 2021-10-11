using Silvester.Pathfinder.Reference.Database.Models;
using Silvester.Pathfinder.Reference.Database.Models.Effects;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Bindings.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Backgrounds.Instances
{
    public class StreetPreacher : Template
    {
        public static readonly Guid ID = Guid.Parse("f5363bda-c26b-4a8b-807f-7bf88221457b");

        protected override Background GetBackground()
        {
            return new Background
            {
                Id = ID, 
                Name = "Street Preacher",
                RarityId = Rarities.Instances.Common.ID
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse("04da2593-bfee-4548-8dfe-d563f4f52860"), Type = TextBlockType.Text, Text = "Forget the church orthodoxy and the stuffy cloisters' spreading the word of your god to the people is your calling. You've preached on the street corners and in public houses, to wanderers on the road and to captives in the stocks. Adventuring can take you across the world. What vocation could better serve to take your holy words to fresh ears?" };
        }

        protected override IEnumerable<Effect> GetEffects()
        {
            yield return new RestrictedAbilityBoostEffect
            {
                Id = Guid.Parse("bff44487-24aa-41f1-8e31-315e0e0e3125"),
                RequiredStats = new StatEffectBinding[]
                {
                    new StatEffectBinding{Id = Guid.Parse("850d9cb9-16a6-4940-bd62-22fbae013b14"), StatId = Stats.Instances.Wisdom.ID },
                    new StatEffectBinding{Id = Guid.Parse("5add8629-a5c8-42d6-ada6-2c6aebb36098"), StatId = Stats.Instances.Charisma.ID }
                }
            };

            yield return new FreeAbilityBoostEffect
            {
                Id = Guid.Parse("6171e082-3286-4b5e-b09c-acd54d84c973")
            };

            yield return new RestrictedSkillEffect
            {
                Id = Guid.Parse("60def510-00c3-4c90-85e6-d2f1c848c23b"),
                ProficiencyId = Proficiencies.Instances.Trained.ID,
                SkillId = Skills.Instances.Religion.ID
            };

            yield return new LoreCategoryEffect
            {
                Id = Guid.Parse("5d0e330f-5939-4039-b4d9-b0b1aaa68210"),
                ProficiencyId = Proficiencies.Instances.Trained.ID,
                LoreCategoryId = LoreCategories.Instances.Deities.ID,
                Restrictions = "The chosen Lore skill must be related to your patron deity."
            };


            yield return new FeatEffect
            {
                Id = Guid.Parse("2631ba83-6576-4ad0-b15c-eaef99692e9c"),
                FeatId = Feats.General.DubiousKnowledgeFeat.ID
            };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("f0709433-0d87-46fc-8c8e-49409cb30e10"),
                SourceId = Sources.Instances.SecretsOfMagic.ID,
                Page = 29
            };
        }
    }
}
