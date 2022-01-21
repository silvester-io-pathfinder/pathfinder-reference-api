using Silvester.Pathfinder.Reference.Database.Effects;
using Silvester.Pathfinder.Reference.Database.Models.Entities;


using Silvester.Pathfinder.Reference.Database.Seeding.Seeds.SkillActions.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using Silvester.Pathfinder.Reference.Database.Effects.Instances;
using System.Collections.Generic;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Builders;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Backgrounds.Instances
{
    public class Cursed : Template
    {
        public static readonly Guid ID = Guid.Parse("41aa860d-428d-42e3-9f74-6c5217efec45");

        protected override Background GetBackground()
        {
            return new Background
            {
                Id = ID, 
                Name = "Cursed",
                RarityId = Rarities.Instances.Rare.ID
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse("d349b8ea-d84e-402a-8c8f-212112148542"), Type = TextBlockType.Text, Text = "You are the victim of a personal or hereditary curse. Through great effort and occult study, you have learned to fend off the curse's worst effects and, by extension, you can protect yourself against other harmful magic. However, the curse still hangs over you and sometimes manifests in dangerous ways." };
        }

        protected override void GetEffects(BooleanEffectBuilder builder)
        {
            builder.AddOr(Guid.Parse("a56f110d-3b7a-4bba-b712-b1cc9a0ca9e0"), or =>
            {
                or.GainSpecificAbilityBoost(Guid.Parse("24d5bcb7-a08a-4761-91a9-fecc5d0c5374"), Stats.Instances.Intelligence.ID);
                or.GainSpecificAbilityBoost(Guid.Parse("b7bac2e1-60ad-4f45-825f-a980601c4bb8"), Stats.Instances.Charisma.ID);
            });

            builder.GainAnyAbilityBoost(Guid.Parse("ce6400bf-bd86-441e-a3d7-ddec6945e86a"));
            builder.GainSpecificSkillProficiency(Guid.Parse("481f55de-9dcd-4661-939e-da1d869d4fec"), Proficiencies.Instances.Trained.ID, Skills.Instances.Occultism.ID);
            builder.GainSpecificLoreProficiency(Guid.Parse("872587c1-a28b-4264-a093-3fef4bb6f107"), Proficiencies.Instances.Trained.ID, Lores.Instances.Curse.ID);
            builder.GainSpecificFeat(Guid.Parse("1622aaea-7f40-4b39-933e-d2ec88708b29"), Feats.Instances.WardingSign.ID);
            builder.GainAnyCurse(Guid.Parse("bf2e71e8-24bc-4d6f-84a3-04392d29f9d9"));
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("48e57401-8663-4498-b04b-f00ee0b424f8"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = 50
            };
        }
    }
}
