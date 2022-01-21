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
    public class StudentOfMagic : Template
    {
        public static readonly Guid ID = Guid.Parse("bea9d879-667c-467c-ac8f-29dacca8f3f7");

        protected override Background GetBackground()
        {
            return new Background
            {
                Id = ID, 
                Name = "Student of Magic",
                RarityId = Rarities.Instances.Common.ID
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse("5d5ce680-2641-405f-a373-82a0b40baa17"), Type = TextBlockType.Text, Text = "You are currently enrolled at a school of magic, where you're learning the fundamentals of your magical tradition. Whether your adventuring occurs during breaks between semesters, as part of a work study program, or even within the halls of the academy itself, you'll have to learn to juggle your dual life." };
        }

        protected override void GetEffects(BooleanEffectBuilder builder)
        {
            builder.AddOr(Guid.Parse("8d9cd86e-c00f-45a5-a224-51f0c49088e4"), or =>
            {
                or.GainSpecificAbilityBoost(Guid.Parse("c9b90a6e-e2f3-4623-8e5a-c9c2300a32ee"), Stats.Instances.Intelligence.ID);
                or.GainSpecificAbilityBoost(Guid.Parse("f04dac20-cc28-4c44-802d-8c971fddc279"), Stats.Instances.Wisdom.ID);
            });

            builder.GainAnyAbilityBoost(Guid.Parse("3544a092-9857-4c21-be2f-6261d7e70024"));

            builder.AddOr(Guid.Parse("1834e6fa-bdf9-4213-ab58-27c0470fb1fa"), or =>
            {
                or.GainSpecificSkillProficiency(Guid.Parse("3b76bc90-a2a3-48b1-8505-c6ce74e3b47c"), Proficiencies.Instances.Trained.ID, Skills.Instances.Arcana.ID);
                or.GainSpecificSkillProficiency(Guid.Parse("121087d6-2b7d-4bc3-bdc5-a413be65f243"), Proficiencies.Instances.Trained.ID, Skills.Instances.Nature.ID);
                or.GainSpecificSkillProficiency(Guid.Parse("ca03b303-5d46-4d6d-9ad7-2a6665300790"), Proficiencies.Instances.Trained.ID, Skills.Instances.Occultism.ID);
                or.GainSpecificSkillProficiency(Guid.Parse("62d34358-0611-476b-b5ed-fe1e07a1d17d"), Proficiencies.Instances.Trained.ID, Skills.Instances.Religion.ID);
            });

            builder.GainSpecificLoreProficiency(Guid.Parse("29f4a338-858a-4421-a127-c48237f80186"), Proficiencies.Instances.Trained.ID, Lores.Instances.Academia.ID);
            builder.GainSpecificFeat(Guid.Parse("4ac4b6b9-bf4d-4af2-8e37-d73deaf6afcb"), Feats.Instances.RecognizeSpell.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("a11add7c-2a01-47fa-ae54-ccb16c3619f1"),
                SourceId = Sources.Instances.SecretsOfMagic.ID,
                Page = 29
            };
        }
    }
}
