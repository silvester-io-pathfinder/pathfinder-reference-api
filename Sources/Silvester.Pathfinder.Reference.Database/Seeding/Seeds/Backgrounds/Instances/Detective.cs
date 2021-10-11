using Silvester.Pathfinder.Reference.Database.Models;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Backgrounds.Instances
{
    public class Detective : Template
    {
        public static readonly Guid ID = Guid.Parse("6c77edee-5e29-4e2d-9161-e63b0d77190e");

        protected override Background GetBackground()
        {
            return new Background
            {
                Id = ID, 
                Name = "Detective",
                RarityId = Rarities.Instances.Common.ID
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse("d4c237dc-fd12-40ca-86d3-933c511cbf1e"), Type = TextBlockType.Text, Text = "You solved crimes as a police inspector or took jobs for wealthy clients as a private investigator. You might have become an adventurer as part of your next big mystery, but likely it was due to the consequences or aftermath of a prior case." };
        }

        protected override IEnumerable<Effect> GetEffects()
        {
            yield return new RestrictedAbilityBoostEffect
            {
                Id = Guid.Parse("fed8cd49-cfbe-4910-8621-bae8e21e9778"),
                RequiredStats = new StatEffectBinding[]
                {
                    new StatEffectBinding{Id = Guid.Parse("c231a33b-f3c8-4757-8e3e-99b7b7b9cbbb"), StatId = Stats.Instances.Intelligence.ID },
                    new StatEffectBinding{Id = Guid.Parse("c06a9ee6-d908-400d-9404-e3273657ecce"), StatId = Stats.Instances.Wisdom.ID }
                }
            };

            yield return new FreeAbilityBoostEffect
            {
                Id = Guid.Parse("c64787f0-dfdb-48b8-9b53-917b295f1713")
            };

            yield return new RestrictedSkillEffect
            {
                Id = Guid.Parse("9d6aadfe-7523-4902-914f-a3dae9c1c62a"),
                ProficiencyId = Proficiencies.Instances.Trained.ID,
                SkillId = Skills.Instances.Society.ID
            };

            yield return new LoreEffect
            {
                Id = Guid.Parse("999da34f-8a6f-4394-ad65-91f23da02428"),
                ProficiencyId = Proficiencies.Instances.Trained.ID,
                LoreId = Lores.Instances.Underworld.ID
            };

            yield return new FeatEffect
            {
                Id = Guid.Parse("755c268e-5f68-4b54-a9a3-a6075cfe8170"),
                FeatId = Feats.General.StreetwiseFeat.ID
            };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("be0183a3-7eaf-416a-9c1e-3e7a65573d1c"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 61
            };
        }
    }
}
