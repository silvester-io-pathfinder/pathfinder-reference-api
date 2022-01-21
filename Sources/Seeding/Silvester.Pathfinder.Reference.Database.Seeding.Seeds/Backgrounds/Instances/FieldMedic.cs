using Silvester.Pathfinder.Reference.Database.Effects;
using Silvester.Pathfinder.Reference.Database.Models.Entities;


using Silvester.Pathfinder.Reference.Database.Seeding.Seeds.PlayModes.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using Silvester.Pathfinder.Reference.Database.Effects.Instances;
using System.Collections.Generic;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Builders;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Backgrounds.Instances
{
    public class FieldMedic : Template
    {
        public static readonly Guid ID = Guid.Parse("9431fb9a-a526-4b72-afe3-f5fc9cb75100");

        protected override Background GetBackground()
        {
            return new Background
            {
                Id = ID, 
                Name = "Field Medic",
                RarityId = Rarities.Instances.Common.ID
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse("79ddfa2e-bf7d-46b9-8927-460ede3a2b1c"), Type = TextBlockType.Text, Text = "In the chaotic rush of battle, you learned to adapt to rapidly changing conditions as you administered to battle casualties. You patched up soldiers, guards, or other combatants, and learned a fair amount about the logistics of war." };
        }

        protected override void GetEffects(BooleanEffectBuilder builder)
        {
            builder.AddOr(Guid.Parse("8eb61f7b-e1a3-4dc5-b3d0-eef9f9d4035e"), or =>
            {
                or.GainSpecificAbilityBoost(Guid.Parse("6a80c8da-3dc8-4ad5-859c-50b2965a2c5e"), Stats.Instances.Constitution.ID);
                or.GainSpecificAbilityBoost(Guid.Parse("09bb3c06-441f-4f70-a7a1-bfc0a3a1e7a7"), Stats.Instances.Wisdom.ID);
            });

            builder.GainAnyAbilityBoost(Guid.Parse("293cf1c4-c66b-4c58-a329-872c3dbc497f"));
            builder.GainSpecificSkillProficiency(Guid.Parse("0d4ff26e-e982-4f75-b600-6b3175d2b963"), Proficiencies.Instances.Trained.ID, Skills.Instances.Medicine.ID);
            builder.GainSpecificLoreProficiency(Guid.Parse("9b618a89-4164-4927-935a-a5cf328cd4c8"), Proficiencies.Instances.Trained.ID, Lores.Instances.Warfare.ID);
            builder.GainSpecificFeat(Guid.Parse("23c86e81-6c30-4467-891e-536a6ff1e6a8"), Feats.Instances.BattleMedicine.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("e41e95bd-5ff0-44a9-84e1-c1dc28ec00bf"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 62
            };
        }
    }
}
