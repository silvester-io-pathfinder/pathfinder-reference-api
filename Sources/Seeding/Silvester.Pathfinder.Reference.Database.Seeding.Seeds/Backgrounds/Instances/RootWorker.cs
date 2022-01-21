using Silvester.Pathfinder.Reference.Database.Effects;
using Silvester.Pathfinder.Reference.Database.Models.Entities;


using Silvester.Pathfinder.Reference.Database.Seeding.Seeds.PlayModes.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using Silvester.Pathfinder.Reference.Database.Effects.Instances;
using System.Collections.Generic;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Builders;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Backgrounds.Instances
{
    public class RootWorker : Template
    {
        public static readonly Guid ID = Guid.Parse("aa3084cf-28c8-47c8-8711-e759c62d6ba0");

        protected override Background GetBackground()
        {
            return new Background
            {
                Id = ID, 
                Name = "Root Worker",
                RarityId = Rarities.Instances.Common.ID
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse("d8d13c87-5eb3-45b8-8903-98f0921c4d15"), Type = TextBlockType.Text, Text = "Some ailments can't be cured by herbs alone. You learned ritual remedies as well, calling on nature spirits to soothe aches and ward off the evil eye. Taking up with adventurers has given you company on the road, as well as protection from those who would brand you a fake'or worse." };
        }

        protected override void GetEffects(BooleanEffectBuilder builder)
        {
            builder.AddOr(Guid.Parse("ac0aca1e-f317-4d27-8002-af9189af05c8"), or =>
            {
                or.GainSpecificAbilityBoost(Guid.Parse("534190af-af0c-4282-aeae-c7d41a59d6e9"), Stats.Instances.Intelligence.ID);
                or.GainSpecificAbilityBoost(Guid.Parse("b17dbefb-978c-461f-86eb-743c7314bdf6"), Stats.Instances.Wisdom.ID);
            });

            builder.GainAnyAbilityBoost(Guid.Parse("46f9ebf7-cfae-483a-8967-ce98b2fa8729"));
            builder.GainSpecificSkillProficiency(Guid.Parse("84bd5139-8e7a-4c6b-952f-4cf66a410bc2"), Proficiencies.Instances.Trained.ID, Skills.Instances.Occultism.ID);
            builder.GainSpecificLoreProficiency(Guid.Parse("ba4e3a94-2e7d-449d-b243-b5f404558660"), Proficiencies.Instances.Trained.ID, Lores.Instances.Herbalism.ID);
            builder.GainSpecificFeat(Guid.Parse("e3c87db5-1612-46d9-8a81-e2a02f7da698"), Feats.Instances.RootMagic.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("6e533f8d-006e-4d5f-bc06-b5d4ba993d92"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = 49
            };
        }
    }
}
