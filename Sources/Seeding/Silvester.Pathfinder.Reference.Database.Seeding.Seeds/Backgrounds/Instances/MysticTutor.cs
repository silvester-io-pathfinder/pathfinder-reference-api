using Silvester.Pathfinder.Reference.Database.Effects;
using Silvester.Pathfinder.Reference.Database.Effects.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Effects;


using Silvester.Pathfinder.Reference.Database.Seeding.Seeds.PlayModes.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Builders;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Backgrounds.Instances
{
    public class MysticTutor : Template
    {
        public static readonly Guid ID = Guid.Parse("46cafcc7-8033-4c67-9e0e-00ab06b0ec88");

        protected override Background GetBackground()
        {
            return new Background
            {
                Id = ID, 
                Name = "Mystic Tutor",
                RarityId = Rarities.Instances.Rare.ID
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse("db7efe9c-c5d9-491f-a0da-be8f18c7d17c"), Type = TextBlockType.Text, Text = "You spent years predicting, identifying, and harnessing the innate magical talents of those around you. A magic-rich world has taught you that you can never have too much training when everyone around you is capable of magic." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield return Traits.Instances.PervasiveMagic.ID;
        }

        protected override void GetEffects(BooleanEffectBuilder builder)
        {
            builder.AddOr(Guid.Parse("5b034849-b0f9-46d8-9fe5-c025a2ecd6a5"), or =>
            {
                or.GainSpecificAbilityBoost(Guid.Parse("2cf66fd3-6f56-45bc-b11f-9c492e37d5cf"), Stats.Instances.Intelligence.ID);
                or.GainSpecificAbilityBoost(Guid.Parse("4790c6b3-5ae1-4a8d-9ad5-04e4add88784"), Stats.Instances.Wisdom.ID);
            });

            builder.GainAnyAbilityBoost(Guid.Parse("4720d5c1-c7e9-4465-adfd-60cb6a71e89c"));

            builder.AddOr(Guid.Parse("7aa59008-25a5-46fe-8ee1-1ed81481e5d0"), or =>
            {
                or.AddAnd(Guid.Parse("90ad113d-876d-4e94-94c7-ae23fefdf9ba"), and =>
                {
                    and.GainSpecificTrait(Guid.Parse("11cf8854-7677-45b9-a59a-059452c24fe4"), Traits.Instances.Arcane.ID);
                    and.GainSpecificSkillProficiency(Guid.Parse("6ea7200c-19ee-4ef9-be50-5c4b0976c793"), Proficiencies.Instances.Trained.ID, Skills.Instances.Arcana.ID);
                });

                or.AddAnd(Guid.Parse("47f2829a-af99-4069-adce-ae0a31421698"), and =>
                {
                    and.GainSpecificTrait(Guid.Parse("e9505303-b2a1-4b42-9f0d-f7a6b5c60ded"), Traits.Instances.Occult.ID);
                    and.GainSpecificSkillProficiency(Guid.Parse("653bfaea-0c17-45f3-83b5-c02efcecb666"), Proficiencies.Instances.Trained.ID, Skills.Instances.Occultism.ID);
                });
            });

            builder.GainSpecificLoreProficiency(Guid.Parse("d8b19f33-c67a-493a-a2e2-02c6f6f8ffaa"), Proficiencies.Instances.Trained.ID, Lores.Instances.Academia.ID);
            builder.GainSpecificFeat(Guid.Parse("64ff090f-59da-4796-8209-8ae01e0416fb"), Feats.Instances.RecognizeSpell.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("14e8ccf1-6bc1-423a-b5db-7fb2b25653c4"),
                SourceId = Sources.Instances.SecretsOfMagic.ID,
                Page = 219
            };
        }
    }
}
