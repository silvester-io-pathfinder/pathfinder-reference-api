using Silvester.Pathfinder.Reference.Database.Effects.Instances;
using Silvester.Pathfinder.Reference.Database.Effects;

using Silvester.Pathfinder.Reference.Database.Models.Entities;


using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Builders;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.ClassFeatures.Fighters
{
    public class AbilityBoosts : Template
    {
        public static readonly Guid ID = Guid.Parse("9ab2afd5-c6c6-45d0-bd09-a5d158e729e9");

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
            yield return new TextBlock { Id = Guid.Parse("7bbd416d-2cbd-4568-8a26-de8292330480"), Type = TextBlockType.Text, Text = "At 5th level and every 5 levels thereafter, you boost four different ability scores. You can use these ability boosts to increase your ability scores above 18. Boosting an ability score increases it by 1 if it's already 18 or above, or by 2 if it starts out below 18." };
        }

        protected override void GetEffects(BooleanEffectBuilder builder)
        {
            builder.GainAnyAbilityBoost(Guid.Parse("9a37b31f-d934-4f93-bb0f-95115eddbe5c"), Guid.Parse("35e9930b-fcad-47af-be71-6a05fdfdf673"), requiredLevel: 5);
            builder.GainAnyAbilityBoost(Guid.Parse("182a9647-c722-4f65-832e-573e97029c97"), Guid.Parse("526ce9f7-ad68-49a8-87c5-23e41a01d3e8"), requiredLevel: 5);
            builder.GainAnyAbilityBoost(Guid.Parse("2c3cbc74-d979-4f2a-bb64-72b508f8d938"), Guid.Parse("5301d367-296a-4b6e-b945-bba62ee7b22a"), requiredLevel: 5);
            builder.GainAnyAbilityBoost(Guid.Parse("d830d401-5cd8-4df4-8635-37cb34afed4f"), Guid.Parse("a3275f8e-a0f2-4953-8564-8e3832e2f0ec"), requiredLevel: 5);

            builder.GainAnyAbilityBoost(Guid.Parse("75d22b73-b27a-472a-bd2f-7380d2f23b72"), Guid.Parse("4291d433-34ca-440a-be4e-6ede9bf648b3"), requiredLevel: 10);
            builder.GainAnyAbilityBoost(Guid.Parse("478e6ae5-a463-47da-af9f-fa740151f902"), Guid.Parse("28c88c35-fe97-4ea6-bf65-eaa6e4dba18e"), requiredLevel: 10);
            builder.GainAnyAbilityBoost(Guid.Parse("9be33fee-3663-42a4-9bc3-bb8daf8a2d7c"), Guid.Parse("bb288920-4e41-4004-8a4f-eb16df56336f"), requiredLevel: 10);
            builder.GainAnyAbilityBoost(Guid.Parse("bf670e2c-73dd-4de0-bbb5-70bfacd3764d"), Guid.Parse("f6e48ee8-4b21-4b32-b65e-8ccc6a8e7cf3"), requiredLevel: 10);

            builder.GainAnyAbilityBoost(Guid.Parse("c559249f-0855-4f0b-9dea-b5cdfef6bc3c"), Guid.Parse("82095e75-0e49-4f86-aa0b-5fe7d67871a4"), requiredLevel: 15);
            builder.GainAnyAbilityBoost(Guid.Parse("9b01ff9b-44d6-45e6-8f05-5cdd256e224e"), Guid.Parse("f0e55de3-d8d4-4465-ad72-993bc2d0a554"), requiredLevel: 15);
            builder.GainAnyAbilityBoost(Guid.Parse("28e958c1-f476-4af4-8c68-32f4ec6c2025"), Guid.Parse("339b2a50-045c-4f9b-a490-d61d203788de"), requiredLevel: 15);
            builder.GainAnyAbilityBoost(Guid.Parse("b6a1fb24-7b9b-4b61-9ffa-16a9c78d7667"), Guid.Parse("d62c32b4-60b3-4a0a-aee0-0eca7b5ad88b"), requiredLevel: 15);

            builder.GainAnyAbilityBoost(Guid.Parse("f61aa82a-9a4f-4381-aeac-e95568999e24"), Guid.Parse("c95949e3-508f-4e66-ba15-371160293248"), requiredLevel: 20);
            builder.GainAnyAbilityBoost(Guid.Parse("8a481120-26e1-4055-b87c-1eb7bb1159cb"), Guid.Parse("6c3b051e-b1f2-4d7d-be7a-08e0918c2099"), requiredLevel: 20);
            builder.GainAnyAbilityBoost(Guid.Parse("9adf9dab-e323-4471-8164-1b03ebe60bca"), Guid.Parse("a18bd1cb-e9eb-4d10-b2c0-f5ce8ad032af"), requiredLevel: 20);
            builder.GainAnyAbilityBoost(Guid.Parse("80ea16f1-f323-4e99-8929-da5b2c19549f"), Guid.Parse("11a527af-15ce-486e-b637-5732f366d11c"), requiredLevel: 20);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("2cdb3979-2be7-424e-b47b-eba933457d1c"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 142
            };
        }
    }
}
