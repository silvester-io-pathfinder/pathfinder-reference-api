using Silvester.Pathfinder.Reference.Database.Effects.Instances;
using Silvester.Pathfinder.Reference.Database.Effects;

using Silvester.Pathfinder.Reference.Database.Models.Entities;


using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Builders;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.ClassFeatures.Inventors
{
    public class AbilityBoosts : Template
    {
        public static readonly Guid ID = Guid.Parse("92d029da-1650-416b-b247-4f03e3860777");

        protected override ClassFeature GetClassFeature()
        {
            return new ClassFeature
            {
                Id = ID, 
                Level = 5,
                Name = "Ability Boosts", 
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse("7a319518-eb34-44ba-8046-c93629bf8f70"), Type = TextBlockType.Text, Text = "At 5th level and every 5 levels thereafter, you boost four different ability scores. You can use these ability boosts to increase your ability scores above 18. Boosting an ability score increases it by 1 if it's already 18 or above, or by 2 if it starts out below 18." };
        }

        protected override void GetEffects(BooleanEffectBuilder builder)
        {
            builder.GainAnyAbilityBoost(Guid.Parse("9a4fb3b2-70f2-45d0-b279-21db1904a0ab"), Guid.Parse("24eb30cd-f1c0-4c75-a439-3f35c4968b65"), requiredLevel: 5);
            builder.GainAnyAbilityBoost(Guid.Parse("44aa4ea7-cf03-42bc-8d10-256b258c6159"), Guid.Parse("dcc2205c-d1a1-4c01-b3ff-5bbb2b89915d"), requiredLevel: 5);
            builder.GainAnyAbilityBoost(Guid.Parse("4a3aee0f-6f55-46c5-878a-bf8fd07fcc47"), Guid.Parse("ebc548c0-2ba9-4a89-827c-10d761b0b03a"), requiredLevel: 5);
            builder.GainAnyAbilityBoost(Guid.Parse("933e4bfe-a4ac-4572-9cd3-b97ca6f5903d"), Guid.Parse("daa61404-d4a7-4b0b-a64f-bcfcdbb0f6fb"), requiredLevel: 5);

            builder.GainAnyAbilityBoost(Guid.Parse("5e5baeca-6759-4000-9204-c4bf5aadf4ae"), Guid.Parse("32907f88-0695-4800-be91-4634ff4fc2d8"), requiredLevel: 10);
            builder.GainAnyAbilityBoost(Guid.Parse("e4437105-7157-4af8-a710-f2d790978f3c"), Guid.Parse("ee3a273c-87d7-4230-b498-3ab620de4306"), requiredLevel: 10);
            builder.GainAnyAbilityBoost(Guid.Parse("7893c709-3f58-4b36-8bca-511592dac8c7"), Guid.Parse("d1e96c0d-0900-433e-982d-7f06af75d394"), requiredLevel: 10);
            builder.GainAnyAbilityBoost(Guid.Parse("7110dd6c-9868-49f0-8b78-0aa14c7ace71"), Guid.Parse("763d0146-2392-4d60-94e4-ae491cd5b7ac"), requiredLevel: 10);

            builder.GainAnyAbilityBoost(Guid.Parse("f8cf33f6-deef-4b5f-89c6-f254ba890dd3"), Guid.Parse("21a86a4c-c138-4b1c-8f00-aa5693ec4ac0"), requiredLevel: 15);
            builder.GainAnyAbilityBoost(Guid.Parse("2ff11248-e659-49fa-bd57-cfcee717a35d"), Guid.Parse("c40f4af7-58d7-45bc-9857-b84f7345d9ce"), requiredLevel: 15);
            builder.GainAnyAbilityBoost(Guid.Parse("52e8d444-de30-4b3b-8c61-52a279820f76"), Guid.Parse("ab58174a-5c5e-4130-8fda-5d02ad1f285b"), requiredLevel: 15);
            builder.GainAnyAbilityBoost(Guid.Parse("df7c2658-7a2a-4597-8d7a-eabcdab52f4f"), Guid.Parse("ea64864e-e875-4b24-96e9-9ed91fb64e11"), requiredLevel: 15);

            builder.GainAnyAbilityBoost(Guid.Parse("c0ea36af-8b58-4db9-ad2c-3d7d5059ac5a"), Guid.Parse("9c1f10ed-6ea3-4216-9f3e-09ec29b96ce0"), requiredLevel: 20);
            builder.GainAnyAbilityBoost(Guid.Parse("60b550f2-c94c-4bbf-bc40-341a805fd9d8"), Guid.Parse("2f9c2a48-9833-43f6-a0cd-127cd587f1b4"), requiredLevel: 20);
            builder.GainAnyAbilityBoost(Guid.Parse("898cda84-54db-438e-84d6-861416483521"), Guid.Parse("1b8a16cd-17b7-4c46-9491-39e8c7f6fb7c"), requiredLevel: 20);
            builder.GainAnyAbilityBoost(Guid.Parse("cbb2221b-188c-4b3f-81c0-60f0abfd757d"), Guid.Parse("5a8b8a58-0751-481c-ba36-b1be4ad91112"), requiredLevel: 20);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("de9e6228-b4c5-4d10-a9d2-423dd120a522"),
                SourceId = Sources.Instances.GunsAndGears.ID,
                Page = 20
            };
        }
    }
}
