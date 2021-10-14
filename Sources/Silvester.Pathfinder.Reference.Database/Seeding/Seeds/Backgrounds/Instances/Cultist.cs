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
    public class Cultist : Template
    {
        public static readonly Guid ID = Guid.Parse("92747282-f80a-4fa9-b355-179dec25588d");

        protected override Background GetBackground()
        {
            return new Background
            {
                Id = ID, 
                Name = "Cultist",
                RarityId = Rarities.Instances.Common.ID
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse("44786491-c52b-4b82-8ed1-19ca5cb681c6"), Type = TextBlockType.Text, Text = "You were (or still are) a member of a cult whose rites may involve sacred dances to ensure a strong harvest or dire rituals that call upon dark powers. You might have taken up adventuring to further your cult's aims, to initiate yourself into the world's grander mysteries, or to flee unsavory practices or strictures." };
        }

        protected override IEnumerable<Effect> GetEffects()
        {
            yield return new RestrictedAbilityBoostEffect
            {
                Id = Guid.Parse("df7cba8c-73c0-4519-9c04-093cab1cf39c"),
                RequiredStats = new StatEffectBinding[]
                {
                    new StatEffectBinding{Id = Guid.Parse("050269be-de94-4fad-8134-08b963afbe39"), StatId = Stats.Instances.Intelligence.ID },
                    new StatEffectBinding{Id = Guid.Parse("d10bc9ad-7916-4b66-bfcf-4ed8b7cd5d9c"), StatId = Stats.Instances.Charisma.ID }
                }
            };

            yield return new FreeAbilityBoostEffect
            {
                Id = Guid.Parse("8aea94a2-0296-4427-bf3b-ab4c327457e3")
            };

            yield return new RestrictedSkillEffect
            {
                Id = Guid.Parse("adb054bc-6939-41d4-8a0e-b20db38dfe9f"),
                ProficiencyId = Proficiencies.Instances.Trained.ID,
                SkillId = Skills.Instances.Occultism.ID
            };

            yield return new LoreCategoryEffect
            {
                Id = Guid.Parse("f3486047-537f-4565-bebc-1f78f07a0692"),
                ProficiencyId = Proficiencies.Instances.Trained.ID,
                LoreCategoryId = LoreCategories.Instances.Deities.ID,
                Restrictions = "The chosen Lore skill must be related to your deity or cult."
            };

            yield return new FeatEffect
            {
                Id = Guid.Parse("51a8c4ef-42a0-45d8-9e49-f3b5e834ebd5"),
                FeatId = Feats.General.SchooledInSecretsFeat.ID
            };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("12d53be2-1632-4dd7-b4ae-a1d0610e5ebf"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = 48
            };
        }
    }
}
