using Silvester.Pathfinder.Reference.Database.Models;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Backgrounds.Instances
{
    public class Charlatan : Template
    {
        public static readonly Guid ID = Guid.Parse("839f2956-cc7d-452a-83b5-9aa19fbba70f");

        protected override Background GetBackground()
        {
            return new Background
            {
                Id = ID, 
                Name = "Charlatan",
                RarityId = Rarities.Instances.Common.ID
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse("0f1a7ea5-36fe-4bb9-9446-f23e026094f0"), Type = TextBlockType.Text, Text = "You traveled from place to place, peddling false fortunes and snake oil in one town, pretending to be royalty in exile to seduce a wealthy heir in the next. Becoming an adventurer might be your next big scam or an attempt to put your talents to use for a greater cause. Perhaps it's a bit of both, as you realize that after pretending to be a hero, you've become the mask." };
        }

        protected override IEnumerable<Effect> GetEffects()
        {
            yield return new RestrictedAbilityBoostEffect
            {
                Id = Guid.Parse("c062f66b-5996-4ae3-b3ba-7fcde96ba1af"),
                RequiredStats = new StatEffectBinding[]
                {
                    new StatEffectBinding{Id = Guid.Parse("d8f47a28-c460-474b-a71e-44f33b921c53"), StatId = Stats.Instances.Intelligence.ID },
                    new StatEffectBinding{Id = Guid.Parse("dad768ec-0c7b-4f2f-9558-8b6b31ba3ca3"), StatId = Stats.Instances.Charisma.ID }
                }
            };

            yield return new FreeAbilityBoostEffect
            {
                Id = Guid.Parse("13fcd615-9aea-4d3b-a0b9-8c8156c51fab")
            };

            yield return new RestrictedSkillEffect
            {
                Id = Guid.Parse("d8764961-cfe1-4554-8c1b-e9bbadd123fc"),
                ProficiencyId = Proficiencies.Instances.Trained.ID,
                SkillId = Skills.Instances.Deception.ID
            };

            yield return new LoreEffect
            {
                Id = Guid.Parse("bd9fbc28-7728-4f1e-974e-d14fc11884ad"),
                ProficiencyId = Proficiencies.Instances.Trained.ID,
                LoreId = Lores.Instances.Underworld.ID
            };

            yield return new FeatEffect
            {
                Id = Guid.Parse("7b8752fe-914c-4c3d-b536-f28d43797494"),
                FeatId = Feats.General.CharmingLiarFeat.ID
            };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("b9daae1a-2f0f-4fdb-a655-ebc69426b589"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 61
            };
        }
    }
}
