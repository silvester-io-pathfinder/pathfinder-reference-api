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

        protected override void GetEffects(BooleanEffectBuilder builder)
        {
            builder.AddOr(Guid.Parse("4b332622-c23a-4aa2-9e1a-f5315ad7ef88"), or =>
            {
                or.GainSpecificAbilityBoost(Guid.Parse("45c4afc2-5f27-400b-a87e-578103c3ebf1"), Stats.Instances.Intelligence.ID);
                or.GainSpecificAbilityBoost(Guid.Parse("8ee9228f-11f9-408a-a2c5-24bc0ad64cd9"), Stats.Instances.Charisma.ID);
            });

            builder.GainAnyAbilityBoost(Guid.Parse("a5e602b8-9b9b-423a-aa08-9145ded78bb2"));
            builder.GainSpecificSkillProficiency(Guid.Parse("2fa48484-a56b-407b-8d44-e61c0752f852"), Proficiencies.Instances.Trained.ID, Skills.Instances.Diplomacy.ID);
            builder.GainSpecificLoreProficiency(Guid.Parse("237a7fb7-9825-48b0-a4c0-94e23bca767e"), Proficiencies.Instances.Trained.ID, Lores.Instances.Mercantile.ID);
            builder.GainSpecificFeat(Guid.Parse("d6a2a811-6c2e-4cb2-b21f-4eea3259c299"), Feats.Instances.BargainHunter.ID);
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
