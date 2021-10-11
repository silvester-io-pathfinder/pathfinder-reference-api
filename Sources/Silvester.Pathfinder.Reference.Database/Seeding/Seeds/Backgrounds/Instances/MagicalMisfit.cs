using Silvester.Pathfinder.Reference.Database.Models;
using Silvester.Pathfinder.Reference.Database.Models.Effects;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Bindings.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Backgrounds.Instances
{
    public class MagicalMisfit : Template
    {
        public static readonly Guid ID = Guid.Parse("e71170f4-f29e-46d9-8cc6-2d2246922a6c");

        protected override Background GetBackground()
        {
            return new Background
            {
                Id = ID, 
                Name = "Magical Misfit",
                RarityId = Rarities.Instances.Common.ID
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse("6b370145-e861-4117-b6e5-7e30ca514446"), Type = TextBlockType.Text, Text = "You don't understand folks who claim that magical talent is some sort of burden or great responsibility; you've always used your magic to cause trouble and to escape the consequences. Whether becoming an adventurer is your attempt to make amends or just a new way to make some mischief, you're excited to see where it takes you, and you still delight in using your skills to get out of trouble." };
        }

        protected override IEnumerable<Effect> GetEffects()
        {
            yield return new RestrictedAbilityBoostEffect
            {
                Id = Guid.Parse("31299fe0-ce67-48c9-9b4f-de5712b43a9c"),
                RequiredStats = new StatEffectBinding[]
                {
                    new StatEffectBinding{Id = Guid.Parse("412d2c65-f782-47b6-943d-fbc4e54912ef"), StatId = Stats.Instances.Dexterity.ID },
                    new StatEffectBinding{Id = Guid.Parse("e45bf0d5-61da-402b-b29e-9306da992c59"), StatId = Stats.Instances.Intelligence.ID }
                }
            };

            yield return new FreeAbilityBoostEffect
            {
                Id = Guid.Parse("29fbe6b8-c522-4c92-bbd3-3ab1036573f2")
            };

            yield return new RestrictedSkillEffect
            {
                Id = Guid.Parse("f1ef071a-d300-42fc-b09a-99ec3ddb64b4"),
                ProficiencyId = Proficiencies.Instances.Trained.ID,
                SkillId = Skills.Instances.Arcana.ID
            };

            yield return new LoreEffect
            {
                Id = Guid.Parse("d84162fa-bd20-4d15-96fd-e2a6047a4b8f"),
                ProficiencyId = Proficiencies.Instances.Trained.ID,
                LoreId = Lores.Instances.Underworld.ID
            };

            yield return new FeatEffect
            {
                Id = Guid.Parse("7fe05a98-3e39-4683-8d8d-c36ca66c9540"),
                FeatId = Feats.General.TrickMagicItemFeat.ID
            };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("970a082d-82e9-4097-a414-09485f43269e"),
                SourceId = Sources.Instances.SecretsOfMagic.ID,
                Page = 29
            };
        }
    }
}
