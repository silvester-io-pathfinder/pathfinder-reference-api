using Silvester.Pathfinder.Reference.Database.Models;
using Silvester.Pathfinder.Reference.Database.Models.Effects;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Bindings.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Instances;
using Silvester.Pathfinder.Reference.Database.Seeding.Seeds.SkillActions.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

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

        protected override IEnumerable<Effect> GetEffects()
        {
            yield return new GainSpecificAbilityBoostEffect
            {
                Id = Guid.Parse("07adfcf4-b1e4-430a-b32e-6851197ff039"),
                RequiredStats = new StatEffectBinding[]
                {
                    new StatEffectBinding{Id = Guid.Parse("bc390738-e90e-444d-8d44-48429cd8c57a"), StatId = Stats.Instances.Intelligence.ID },
                    new StatEffectBinding{Id = Guid.Parse("1977c019-81aa-43b2-b4e4-0a29720e90e4"), StatId = Stats.Instances.Charisma.ID }
                }
            };

            yield return new GainAnyAbilityBoostEffect
            {
                Id = Guid.Parse("c67f5620-4fa1-4087-9ff2-4cbf4a3356d7")
            };

            yield return new GainSpecificSkillProficiencyEffect
            {
                Id = Guid.Parse("dfb0597b-52ea-4a01-befa-fe7af794ade2"),
                ProficiencyId = Proficiencies.Instances.Trained.ID,
                SkillId = Skills.Instances.Occultism.ID
            };

            yield return new GainSpecificLoreProficiencyEffect
            {
                Id = Guid.Parse("ae921f51-dcd4-497b-b031-a37f2a6eb66c"),
                ProficiencyId = Proficiencies.Instances.Trained.ID,
                LoreId = Lores.Instances.Curse.ID
            };

            yield return new GainSpecificFeatEffect
            {
                Id = Guid.Parse("d5dc2bb1-1d60-4a96-993f-cf7d863b96d6"),
                FeatId = Feats.Special.WardingSignFeat.ID
            };

            yield return new GainAnyCurseEffect
            {
                Id = Guid.Parse("5e0845e4-478b-455b-ad7a-405b50153e46")
            };
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
