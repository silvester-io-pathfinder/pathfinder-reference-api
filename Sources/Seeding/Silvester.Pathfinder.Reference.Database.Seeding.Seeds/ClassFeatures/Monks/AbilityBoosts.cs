using Silvester.Pathfinder.Reference.Database.Effects.Instances;
using Silvester.Pathfinder.Reference.Database.Effects;

using Silvester.Pathfinder.Reference.Database.Models.Entities;


using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Builders;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.ClassFeatures.Monks
{
    public class AbilityBoosts : Template
    {
        public static readonly Guid ID = Guid.Parse("2b98bbd5-78dd-444b-81d4-649bdcdfedc7");

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
            yield return new TextBlock { Id = Guid.Parse("ad6eda69-7756-48bb-b042-d08434e6ebb1"), Type = TextBlockType.Text, Text = "At 5th level and every 5 levels thereafter, you boost four different ability scores. You can use these ability boosts to increase your ability scores above 18. Boosting an ability score increases it by 1 if it's already 18 or above, or by 2 if it starts out below 18." };
        }

        protected override void GetEffects(BooleanEffectBuilder builder)
        {
            builder.GainAnyAbilityBoost(Guid.Parse("11d77fca-55c0-4712-880a-228ad91b052d"), Guid.Parse("e1060d38-9e30-43e0-80f4-587e8bc9eacf"), requiredLevel: 5);
            builder.GainAnyAbilityBoost(Guid.Parse("f127667f-f6e8-48dc-a798-2efa46d1df9f"), Guid.Parse("e97faabe-3d9a-4f44-8ac3-1120d28535b4"), requiredLevel: 5);
            builder.GainAnyAbilityBoost(Guid.Parse("49e1da29-2df0-4860-8aa5-26b994f79046"), Guid.Parse("02724830-9dab-4561-bea4-43b80909bf86"), requiredLevel: 5);
            builder.GainAnyAbilityBoost(Guid.Parse("5dcf2a58-58a4-4efd-b6cb-f79526d0923c"), Guid.Parse("4b18b912-b04a-43eb-b8e8-6061ea666b7f"), requiredLevel: 5);

            builder.GainAnyAbilityBoost(Guid.Parse("50357810-8b44-48e6-9ea0-1075107a2f8c"), Guid.Parse("32b3461d-a00d-46f6-bd55-f2732ca7ad63"), requiredLevel: 10);
            builder.GainAnyAbilityBoost(Guid.Parse("edb6c595-84d7-4936-8586-4c1cabcbe46e"), Guid.Parse("46acbcd2-9d26-40c6-ade3-3151dbb8d47c"), requiredLevel: 10);
            builder.GainAnyAbilityBoost(Guid.Parse("580e0de7-3c90-4170-9f2c-3dcaeef88cd9"), Guid.Parse("9a7f9a06-c788-4595-90fc-624aeb58da5f"), requiredLevel: 10);
            builder.GainAnyAbilityBoost(Guid.Parse("740d2335-bcd2-46a4-9202-0aaabbada02d"), Guid.Parse("9d8f186e-8ccc-4bca-b752-71e99af15c97"), requiredLevel: 10);

            builder.GainAnyAbilityBoost(Guid.Parse("ee106e32-67cd-4e73-bc25-cb1e12e42278"), Guid.Parse("1f95d8b7-161c-4b48-9fdc-9de14855308a"), requiredLevel: 15);
            builder.GainAnyAbilityBoost(Guid.Parse("417e05cd-be10-4622-9082-b15ab7f4cd99"), Guid.Parse("e71382a9-0607-427d-a67c-8b84c31ada2e"), requiredLevel: 15);
            builder.GainAnyAbilityBoost(Guid.Parse("c07f5fc9-c7aa-42c2-9bb0-3c4568caf4b9"), Guid.Parse("8df7659a-d212-456a-8a8c-203cf8de7f49"), requiredLevel: 15);
            builder.GainAnyAbilityBoost(Guid.Parse("7456e775-2ca8-458d-94d3-e4ff38106c80"), Guid.Parse("11735287-76fb-4bc7-97de-9df96f95ef2f"), requiredLevel: 15);

            builder.GainAnyAbilityBoost(Guid.Parse("e4562239-d2aa-41a3-bc22-a8d0dccb47c2"), Guid.Parse("6c66e2ad-bbb5-42ce-9436-3080e7b48d9b"), requiredLevel: 20);
            builder.GainAnyAbilityBoost(Guid.Parse("c72abcb4-8809-45f7-8728-cefa77c7a686"), Guid.Parse("77af35fb-afba-4216-b215-222947456608"), requiredLevel: 20);
            builder.GainAnyAbilityBoost(Guid.Parse("997b8708-30f3-4b55-a052-0922ea6bfa17"), Guid.Parse("a7901874-8df0-4900-a2c6-e7e2433c694c"), requiredLevel: 20);
            builder.GainAnyAbilityBoost(Guid.Parse("53bca7c9-8cfc-4890-9a2e-f9d09503cb95"), Guid.Parse("0baffad2-4af9-4020-b80a-d2f9d71dc0c5"), requiredLevel: 20);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("47523c94-f70d-4179-8a42-caf36e0d5159"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 156
            };
        }
    }
}
