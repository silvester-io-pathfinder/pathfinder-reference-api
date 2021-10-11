using Silvester.Pathfinder.Reference.Database.Models;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Backgrounds.Instances
{
    public class Barber : Template
    {
        public static readonly Guid ID = Guid.Parse("61e6910c-3bfc-4083-bc7a-1334661c1fca");

        protected override Background GetBackground()
        {
            return new Background
            {
                Id = ID, 
                Name = "Barber",
                RarityId = Rarities.Instances.Common.ID
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse("58eb06b3-8656-43a3-ac7a-c28d30b6734a"), Type = TextBlockType.Text, Text = "Haircuts, dentistry, bloodletting, and surgery'if it takes a steady hand and a razor, you do it. You may have taken to the road to expand your skills, or to test yourself against a world that leaves your patients so battered and bruised." };
        }

        protected override IEnumerable<Effect> GetEffects()
        {
            yield return new RestrictedAbilityBoostEffect
            {
                Id = Guid.Parse("a6ee3746-78d5-47b1-ba9e-3c1a41e85bf2"),
                RequiredStats = new StatEffectBinding[]
                {
                    new StatEffectBinding{Id = Guid.Parse("54d18dd0-c4bb-4e44-ba9e-25fda2e1dde2"), StatId = Stats.Instances.Dexterity.ID },
                    new StatEffectBinding{Id = Guid.Parse("a98ee55e-891b-495c-9809-f938577e0ddd"), StatId = Stats.Instances.Wisdom.ID }
                }
            };

            yield return new FreeAbilityBoostEffect
            {
                Id = Guid.Parse("ebd351d8-083e-4931-a74a-d0a8ba9905db")
            };

            yield return new RestrictedSkillEffect
            {
                Id = Guid.Parse("2b3d4105-9f3a-4abf-8e67-362469a91848"),
                ProficiencyId = Proficiencies.Instances.Trained.ID,
                SkillId = Skills.Instances.Medicine.ID
            };

            yield return new LoreEffect
            {
                Id = Guid.Parse("9edc2d98-48cb-4054-91b5-de901affd205"),
                ProficiencyId = Proficiencies.Instances.Trained.ID,
                LoreId = Lores.Instances.Surgery.ID
            };

            yield return new FeatEffect
            {
                Id = Guid.Parse("84186d73-6d9a-4c3a-a6ea-0559bf997cc8"),
                FeatId = Feats.General.RiskySurgeryFeat.ID
            };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("f1983c92-0c2e-411a-94f1-3fb75a383757"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = 48
            };
        }
    }
}
