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
            builder.AddOr(Guid.Parse(""), or =>
            {
                or.GainSpecificAbilityBoost(Guid.Parse(""), Stats.Instances.Intelligence.ID);
                or.GainSpecificAbilityBoost(Guid.Parse(""), Stats.Instances.Wisdom.ID);
            });

            builder.GainAnyAbilityBoost(Guid.Parse(""));

            builder.AddOr(Guid.Parse(""), or =>
            {
                or.AddAnd(Guid.Parse(""), and =>
                {
                    and.GainSpecificTrait(Guid.Parse(""), Traits.Instances.Arcane.ID);
                    and.GainSpecificSkillProficiency(Guid.Parse(""), Proficiencies.Instances.Trained.ID, Skills.Instances.Arcana.ID);
                });

                or.AddAnd(Guid.Parse(""), and =>
                {
                    and.GainSpecificTrait(Guid.Parse(""), Traits.Instances.Occult.ID);
                    and.GainSpecificSkillProficiency(Guid.Parse(""), Proficiencies.Instances.Trained.ID, Skills.Instances.Occultism.ID);
                });
            });

            builder.GainSpecificLoreProficiency(Guid.Parse(""), Proficiencies.Instances.Trained.ID, Lores.Instances.Academia.ID);
            builder.GainSpecificFeat(Guid.Parse(""), Feats.Instances.RecognizeSpell.ID);
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
