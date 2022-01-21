using Silvester.Pathfinder.Reference.Database.Effects.Instances;
using Silvester.Pathfinder.Reference.Database.Effects;

using Silvester.Pathfinder.Reference.Database.Models.Entities;


using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Builders;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.ClassFeatures.Summoners
{
    public class AbilityBoosts : Template
    {
        public static readonly Guid ID = Guid.Parse("7fd6b819-5107-41bc-9395-505849a08835");

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
            yield return new TextBlock { Id = Guid.Parse("d7a5b954-b077-41ef-a6e3-893c24b940fa"), Type = TextBlockType.Text, Text = "At 5th level and every 5 levels thereafter, you boost four different ability scores. You can use these ability boosts to increase your ability scores above 18. Boosting an ability score increases it by 1 if the ability score is already 18 or above, or by 2 if it starts out below 18." };
            yield return new TextBlock { Id = Guid.Parse("d66e0819-e702-41d2-9796-06c7ba53430f"), Type = TextBlockType.Text, Text = "Your eidolon also gets four ability boosts at these levels. The eidolon's ability boosts follow the same rules as yours." };
        }

        protected override void GetEffects(BooleanEffectBuilder builder)
        {
            builder.GainAnyAbilityBoost(Guid.Parse("d9d60b5c-c9c5-4b2d-a3be-d9fb230ec1d0"), Guid.Parse("98b2158f-5eb9-4a6d-88dc-24ca03c614b3"), requiredLevel: 5);
            builder.GainAnyAbilityBoost(Guid.Parse("0d83e7b7-9208-4cfe-90c5-ea8b3fae727f"), Guid.Parse("3b434862-f47c-4b2b-8e92-fd8db8285902"), requiredLevel: 5);
            builder.GainAnyAbilityBoost(Guid.Parse("6f030727-2be5-49e0-b682-1f6fa1dbc149"), Guid.Parse("ada3fcdc-acc1-4245-b25c-2aadbfacdb24"), requiredLevel: 5);
            builder.GainAnyAbilityBoost(Guid.Parse("a1438425-0615-498f-96bb-1fa5c7dc95a3"), Guid.Parse("3b4126a0-1c50-445c-a34e-12ed70384549"), requiredLevel: 5);

            builder.GainAnyAbilityBoost(Guid.Parse("8a0ec993-61cd-4e7a-953f-0b2bc74e66e2"), Guid.Parse("6b6e523a-e29a-401a-82d2-bb93e6de4e7d"), requiredLevel: 10);
            builder.GainAnyAbilityBoost(Guid.Parse("1f59eb63-e9e4-42ed-8270-3e2f3326b1a5"), Guid.Parse("c8c4dd35-b51d-4c4b-aa6b-9948ca949d13"), requiredLevel: 10);
            builder.GainAnyAbilityBoost(Guid.Parse("d4a79aa2-d7cc-47a0-81cc-336d70706302"), Guid.Parse("3681d3cc-a533-483c-8473-9a0d2266c886"), requiredLevel: 10);
            builder.GainAnyAbilityBoost(Guid.Parse("c088597d-9894-4434-98f2-ed15d0eb6962"), Guid.Parse("56c961d3-ede1-441d-849a-7340681ef27c"), requiredLevel: 10);

            builder.GainAnyAbilityBoost(Guid.Parse("648d3c53-4e8d-4f7e-a793-9c8dfbd0c572"), Guid.Parse("a730b386-3e60-4d74-97ad-65d780e0294e"), requiredLevel: 15);
            builder.GainAnyAbilityBoost(Guid.Parse("6885c19c-5923-42b6-abf1-30dfe9465cfb"), Guid.Parse("81c74b56-57c0-4a6e-98aa-e663a2f7d049"), requiredLevel: 15);
            builder.GainAnyAbilityBoost(Guid.Parse("814993ea-ae46-4b4d-a852-ec778ef797e6"), Guid.Parse("96a1981b-8df7-4084-93ab-98b3a78bb185"), requiredLevel: 15);
            builder.GainAnyAbilityBoost(Guid.Parse("d32cac4d-d7f8-42b2-afac-467fefe674ae"), Guid.Parse("a9c00273-49cb-46ed-a521-592f793bdf17"), requiredLevel: 15);

            builder.GainAnyAbilityBoost(Guid.Parse("5637efb6-d68c-4bd6-8570-b265b0edef5e"), Guid.Parse("2a492557-de89-4f2b-88b6-0a7a00dadf06"), requiredLevel: 20);
            builder.GainAnyAbilityBoost(Guid.Parse("f2125235-17d6-4112-8f05-3485f4e6276d"), Guid.Parse("64edfc97-fb94-4448-b114-d73ad1bb18fc"), requiredLevel: 20);
            builder.GainAnyAbilityBoost(Guid.Parse("08da95e4-42ba-4ac9-bf05-c7624850fedd"), Guid.Parse("68df2da5-70c4-4adf-9cf9-e7171e86bd7d"), requiredLevel: 20);
            builder.GainAnyAbilityBoost(Guid.Parse("13cfa9a6-d1ae-44b3-bf2a-b70fe51c2da6"), Guid.Parse("32be1662-33fc-4803-9de9-f00aefcde835"), requiredLevel: 20);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("feeb8c54-b4ca-438e-b040-5b08fbb8d1f4"),
                SourceId = Sources.Instances.SecretsOfMagic.ID,
                Page = 56
            };
        }
    }
}
