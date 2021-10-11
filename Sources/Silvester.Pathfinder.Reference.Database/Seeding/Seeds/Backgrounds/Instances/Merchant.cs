using Silvester.Pathfinder.Reference.Database.Models;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Backgrounds.Instances
{
    public class Merchant : Template
    {
        public static readonly Guid ID = Guid.Parse("751e9e0d-f84d-4736-a572-66d667d8df53");

        protected override Background GetBackground()
        {
            return new Background
            {
                Id = ID, 
                Name = "Merchant",
                RarityId = Rarities.Instances.Common.ID
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse("f0f17886-b77f-4d18-8006-d19ba5ea8d06"), Type = TextBlockType.Text, Text = "In a dusty shop, market stall, or merchant caravan, you bartered wares for coin and trade goods. The skills you picked up still apply in the adventuring life, in which a good deal on a suit of armor could prevent your death." };
        }

        protected override IEnumerable<Effect> GetEffects()
        {
            yield return new RestrictedAbilityBoostEffect
            {
                Id = Guid.Parse("824ed31f-0772-411d-9b1f-333954fc25b9"),
                RequiredStats = new StatEffectBinding[]
                {
                    new StatEffectBinding{Id = Guid.Parse("ef1b923a-0bda-4807-b7fb-019ef2e92ed5"), StatId = Stats.Instances.Intelligence.ID },
                    new StatEffectBinding{Id = Guid.Parse("fb885add-7c07-4b98-845e-4e3cd01a2a30"), StatId = Stats.Instances.Charisma.ID }
                }
            };

            yield return new FreeAbilityBoostEffect
            {
                Id = Guid.Parse("192df459-bf02-4dd6-b58e-0a968ff355c0")
            };

            yield return new RestrictedSkillEffect
            {
                Id = Guid.Parse("edc298ef-669f-496d-b9c6-4f8a31893417"),
                ProficiencyId = Proficiencies.Instances.Trained.ID,
                SkillId = Skills.Instances.Diplomacy.ID
            };

            yield return new LoreEffect
            {
                Id = Guid.Parse("e785cfc5-2275-4bba-85e4-8880fa761d47"),
                ProficiencyId = Proficiencies.Instances.Trained.ID,
                LoreId = Lores.Instances.Mercantile.ID
            };

            yield return new FeatEffect
            {
                Id = Guid.Parse("d5580569-5fb7-4e24-8096-77ba5661f6f4"),
                FeatId = Feats.General.BargainHunterFeat.ID
            };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("c323518c-729f-4cc4-be58-6ae4c70f165a"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 63
            };
        }
    }
}
