using Silvester.Pathfinder.Reference.Database.Models;
using Silvester.Pathfinder.Reference.Database.Models.Effects;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Bindings.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Instances;
using Silvester.Pathfinder.Reference.Database.Seeding.Seeds.PlayModes.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

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

        protected override IEnumerable<Effect> GetEffects()
        {
            yield return new GainSpecificAbilityBoostEffect
            {
                Id = Guid.Parse("f6b79654-ea54-4dd7-9f33-6f6ebf8648be"),
                RequiredStats = new StatEffectBinding[]
                {
                    new StatEffectBinding{Id = Guid.Parse("44f18efc-37e5-4ee1-89ff-d8203add823a"), StatId = Stats.Instances.Intelligence.ID },
                    new StatEffectBinding{Id = Guid.Parse("713148ab-ff6f-4a61-b460-e794ae3da7a5"), StatId = Stats.Instances.Wisdom.ID }
                }
            };

            yield return new GainAnyAbilityBoostEffect
            {
                Id = Guid.Parse("746795cb-dd1c-41b2-9235-c3f332b37869")
            };

            yield return new ChoiceEffect
            {
                Id = Guid.Parse("14e3b211-f3eb-4f45-ae43-7d36a414300b"),
                Entries = new Effect[]
                {
                    new GainSpecificSkillProficiencyEffect { Id = Guid.Parse("7dd173a2-6b61-4c12-809f-cedc9368f799"), ProficiencyId = Proficiencies.Instances.Trained.ID, SkillId = Skills.Instances.Arcana.ID },
                    new GainSpecificSkillProficiencyEffect { Id = Guid.Parse("7cf66336-f913-481e-8d5f-768beec22b56"), ProficiencyId = Proficiencies.Instances.Trained.ID, SkillId = Skills.Instances.Nature.ID },
                    new GainSpecificSkillProficiencyEffect { Id = Guid.Parse("fefd6e0e-3299-40be-a4e9-8209fb071872"), ProficiencyId = Proficiencies.Instances.Trained.ID, SkillId = Skills.Instances.Occultism.ID },
                    new GainSpecificSkillProficiencyEffect { Id = Guid.Parse("964f7c4b-b65f-4972-a7ff-75aa257974c4"), ProficiencyId = Proficiencies.Instances.Trained.ID, SkillId = Skills.Instances.Religion.ID }
                }
            };

            yield return new GainSpecificLoreProficiencyEffect
            {
                Id = Guid.Parse("78600a8f-276d-4ec2-abd5-d77b324a4d42"),
                ProficiencyId = Proficiencies.Instances.Trained.ID,
                LoreId = Lores.Instances.Academia.ID
            };

            yield return new GainSpecificFeatEffect
            {
                Id = Guid.Parse("0154ba36-816b-4cf1-afc8-1ef67a7b18c3"),
                FeatId = Feats.General.RecognizeSpellFeat.ID
            };
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
