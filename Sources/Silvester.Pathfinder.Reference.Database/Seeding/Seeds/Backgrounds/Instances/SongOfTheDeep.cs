using Silvester.Pathfinder.Reference.Database.Models;
using Silvester.Pathfinder.Reference.Database.Models.Effects;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Bindings.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Backgrounds.Instances
{
    public class SongOfTheDeep : Template
    {
        public static readonly Guid ID = Guid.Parse("d74bc722-17cc-476b-993f-b803e9ecc0aa");

        protected override Background GetBackground()
        {
            return new Background
            {
                Id = ID, 
                Name = "Song of the Deep",
                RarityId = Rarities.Instances.Rare.ID
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse("1991a7be-b1ea-4061-b6bb-f8ffd3856e9d"), Type = TextBlockType.Text, Text = "During a sea voyage, you washed overboard, ingested sea water, and drowned. Merfolk, kelpies, sea serpents, or another magical denizen of the sea pulled your unconscious body from the briny depths. Having spent so much time underwater, your lungs were filled with salt water. To restore your ability to breathe, they exhaled into your lungs and shared the ability to breathe underwater in the process. You came back with the ability to breathe water, as well as a newfound knowledge of your time beneath the waves." };
        }

        protected override IEnumerable<Effect> GetEffects()
        {
            yield return new RestrictedAbilityBoostEffect
            {
                Id = Guid.Parse("6453a6e3-f7a5-4d1a-ae14-a5a8b476e4e8"),
                RequiredStats = new StatEffectBinding[]
                {
                    new StatEffectBinding{Id = Guid.Parse("79b092c2-3a88-449a-a7cd-9ab7f9a11a3c"), StatId = Stats.Instances.Strength.ID },
                    new StatEffectBinding{Id = Guid.Parse("e5386ae0-16dd-4685-9b38-07a98c3c7e65"), StatId = Stats.Instances.Constitution.ID },
                    new StatEffectBinding{Id = Guid.Parse("49d34e1b-fafd-4a48-901b-73261ded3ab3"), StatId = Stats.Instances.Charisma.ID }
                }
            };

            yield return new RestrictedSkillEffect
            {
                Id = Guid.Parse("edde3455-8385-42c3-9cd5-a3dea71f2907"),
                ProficiencyId = Proficiencies.Instances.Trained.ID,
                SkillId = Skills.Instances.Athletics.ID
            };

            yield return new LoreEffect
            {
                Id = Guid.Parse("f9a2e4a5-8745-4e69-b931-653fca73018b"),
                ProficiencyId = Proficiencies.Instances.Trained.ID,
                LoreId = Lores.Instances.Ocean.ID
            };

            yield return new AbilityEffect 
            {
                Id = Guid.Parse("8fd1949f-d1de-40b2-a9f8-13a14258af83"),
                AbilityId = Abilities.Instances.Waterbreathing.ID 
            };

            yield return new ChoiceEffect
            {
                Id = Guid.Parse("ccb8937d-cccb-466e-bac5-8a55d39270a0"),
                IsOptional = true,
                Choices = new Effect[]
                {
                    new LoseAirBreathingEffect { Id = Guid.Parse("32db8722-b192-466a-9c2e-769574494189") },
                    new FreeAbilityBoostEffect { Id = Guid.Parse("e8b99513-9e2e-459e-8af0-9381960b4a79") }
                }
            };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("f73c27d1-9895-442a-9d7f-138bb310173f"),
                SourceId = Sources.Instances.SecretsOfMagic.ID,
                Page = 31
            };
        }
    }
}
