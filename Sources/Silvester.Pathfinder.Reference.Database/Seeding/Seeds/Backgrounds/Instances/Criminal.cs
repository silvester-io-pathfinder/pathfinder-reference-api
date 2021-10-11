using Silvester.Pathfinder.Reference.Database.Models;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Backgrounds.Instances
{
    public class Criminal : Template
    {
        public static readonly Guid ID = Guid.Parse("608165d2-d3e3-41a6-9fb0-fed315dfe16a");

        protected override Background GetBackground()
        {
            return new Background
            {
                Id = ID, 
                Name = "Criminal",
                RarityId = Rarities.Instances.Common.ID
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse("3f207a52-606b-4d01-8855-17a272617776"), Type = TextBlockType.Text, Text = "As an unscrupulous independent or as a member of an underworld organization, you lived a life of crime. You might have become an adventurer to seek redemption, to escape the law, or simply to get access to bigger and better loot." };
        }

        protected override IEnumerable<Effect> GetEffects()
        {
            yield return new RestrictedAbilityBoostEffect
            {
                Id = Guid.Parse("6b49e508-e252-4a94-9115-9c03b960a8ea"),
                RequiredStats = new StatEffectBinding[]
                {
                    new StatEffectBinding{Id = Guid.Parse("fe0db37a-1339-4a41-91b4-9b32064dd053"), StatId = Stats.Instances.Dexterity.ID },
                    new StatEffectBinding{Id = Guid.Parse("671a778b-dfc1-473c-9a92-2edb93f0b74e"), StatId = Stats.Instances.Intelligence.ID }
                }
            };

            yield return new FreeAbilityBoostEffect
            {
                Id = Guid.Parse("b66db32a-e1b5-46e7-b2bb-3b09c0342de4")
            };

            yield return new RestrictedSkillEffect
            {
                Id = Guid.Parse("a758b0b2-ca0b-4983-a9ce-84614bf97e8d"),
                ProficiencyId = Proficiencies.Instances.Trained.ID,
                SkillId = Skills.Instances.Stealth.ID
            };

            yield return new LoreEffect
            {
                Id = Guid.Parse("0d8d7875-14a0-496b-8b82-35c6bab3a47d"),
                ProficiencyId = Proficiencies.Instances.Trained.ID,
                LoreId = Lores.Instances.Underworld.ID
            };

            yield return new FeatEffect
            {
                Id = Guid.Parse("3ddb997c-0965-4a1c-b7e4-7c17b48c2478"),
                FeatId = Feats.General.ExperiencedSmugglerFeat.ID
            };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("32b3bc9c-bf7e-4b62-bd87-569a914b2c54"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 61
            };
        }
    }
}
