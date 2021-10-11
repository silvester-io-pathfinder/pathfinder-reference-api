using Silvester.Pathfinder.Reference.Database.Models;
using Silvester.Pathfinder.Reference.Database.Models.Effects;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Bindings.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Backgrounds.Instances
{
    public class Ward : Template
    {
        public static readonly Guid ID = Guid.Parse("43c093ea-e06e-4759-a0df-6c4df20fe7b3");

        protected override Background GetBackground()
        {
            return new Background
            {
                Id = ID, 
                Name = "Ward",
                RarityId = Rarities.Instances.Common.ID
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse("b22e9381-d3c6-4405-9508-b84c683d9e8a"), Type = TextBlockType.Text, Text = "When you were young, you became the ward of another house'boarded, fed, and educated, but never quite a part of the family. Perhaps you had to tend to their needs in return for feeding and raising you, or perhaps you were provided for but disregarded. Now, adventuring is your chance to grow and roam free." };
        }

        protected override IEnumerable<Effect> GetEffects()
        {
            yield return new RestrictedAbilityBoostEffect
            {
                Id = Guid.Parse("4badce05-8345-476f-a1cb-1b475d49a54c"),
                RequiredStats = new StatEffectBinding[]
                {
                    new StatEffectBinding{Id = Guid.Parse("485ce386-8b79-4431-813b-7f1ef2041f5d"), StatId = Stats.Instances.Constitution.ID },
                    new StatEffectBinding{Id = Guid.Parse("28beefed-8f14-4eca-8e36-7bc0ec21dc4c"), StatId = Stats.Instances.Charisma.ID }
                }
            };

            yield return new FreeAbilityBoostEffect
            {
                Id = Guid.Parse("80792058-575c-4009-b39c-23bbaff54ee9")
            };

            yield return new RestrictedSkillEffect
            {
                Id = Guid.Parse("dab172e1-487b-4749-9084-af51e0e752b9"),
                ProficiencyId = Proficiencies.Instances.Trained.ID,
                SkillId = Skills.Instances.Performance.ID
            };

            yield return new LoreEffect
            {
                Id = Guid.Parse("5566acd4-4add-47ee-a6ec-47d5b6d23efe"),
                ProficiencyId = Proficiencies.Instances.Trained.ID,
                LoreId = Lores.Instances.Genealogy.ID
            };

            yield return new FeatEffect
            {
                Id = Guid.Parse("f32d0dc9-18fd-485c-a447-a0ea59ca5638"),
                FeatId = Feats.General.FascinatingPerformanceFeat.ID
            };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("240488cd-288d-470a-ad81-57f39af5bf9f"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = 49
            };
        }
    }
}
