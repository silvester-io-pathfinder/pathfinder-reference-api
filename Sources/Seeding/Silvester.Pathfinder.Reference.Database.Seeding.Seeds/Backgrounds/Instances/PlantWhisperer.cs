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
    public class PlantWhisperer : Template
    {
        public static readonly Guid ID = Guid.Parse("2d428abd-d8fa-4d36-8a86-bbdabd56d36e");

        protected override Background GetBackground()
        {
            return new Background
            {
                Id = ID, 
                Name = "Plant Whisperer",
                RarityId = Rarities.Instances.Common.ID
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse("e9f99e6d-196e-4325-baf7-129cd4b3ee90"), Type = TextBlockType.Text, Text = "You've always had a green thumb, allowing you to care for plants that others found too difficult to grow and tend with a skill that borders on the magical. As you travel, you encounter all sorts of new plants and plant creatures, allowing you to expand your horizons and deepen your understanding of flora." };
        }

        protected override void GetEffects(BooleanEffectBuilder builder)
        {
            builder.AddOr(Guid.Parse("f27a1877-039f-4358-be0f-4401e8f4e256"), or =>
            {
                or.GainSpecificAbilityBoost(Guid.Parse("1a91115d-b69f-44f3-ba02-82390a7ff0c9"), Stats.Instances.Wisdom.ID);
                or.GainSpecificAbilityBoost(Guid.Parse("61f6177e-1d08-4c39-a6f6-eeaca5a29de3"), Stats.Instances.Charisma.ID);
            });

            builder.GainAnyAbilityBoost(Guid.Parse("99ff53c5-c7fe-4b6b-9eba-154e401bc8e1"));
            builder.GainSpecificSkillProficiency(Guid.Parse("9f198a1f-c51c-4701-a9ac-93b917854712"), Proficiencies.Instances.Trained.ID, Skills.Instances.Nature.ID);
            builder.GainSpecificLoreProficiency(Guid.Parse("36df71da-33c1-45e7-bcaf-a5862348805f"), Proficiencies.Instances.Trained.ID, Lores.Instances.Plant.ID);
            builder.GainSpecificFeat(Guid.Parse("968df3f6-359e-4a77-a2e9-42db066a42dd"), Feats.Instances.NaturalMedicine.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("38120214-4000-44d8-8906-fa6a708f2219"),
                SourceId = Sources.Instances.SecretsOfMagic.ID,
                Page = 29
            };
        }
    }
}
