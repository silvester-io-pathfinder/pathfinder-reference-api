using Silvester.Pathfinder.Reference.Database.Effects.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Entities;

using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Effects;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.ClassFeatures.Witches
{
    public class Familiar : Template
    {
        public static readonly Guid ID = Guid.Parse("4e9b0ae6-2eca-4ac1-bff1-7f66afa55879");

        protected override ClassFeature GetClassFeature()
        {
            return new ClassFeature
            {
                Id = ID, 
                Level = 1,
                Name = "Familiar", 
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse("8f8fbd3d-ef77-4aa5-aac6-74c15e884ae1"), Type = TextBlockType.Text, Text = "Your patron has sent you a familiar, a mystical creature that teaches you and facilitates your spells. This familiar follows the rules here, though as it's a direct conduit between you and your patron, it's more powerful than other familiars. Your familiar gains an extra familiar ability, and gains another extra ability at 6th, 12th, and 18th levels." };
            yield return new TextBlock { Id = Guid.Parse("011f1441-49d2-4511-a7d8-15b5422ca247"), Type = TextBlockType.Text, Text = "Your familiar is the source and repository of the spells your patron has bestowed upon you, and you must commune with your familiar to prepare your spells each day using your witch spellcasting. Your familiar starts off knowing 10 cantrips, five 1st-level spells, and one additional spell determined by your patron's theme. You choose these spells from the common spells of the tradition determined by your patron or from other spells of that tradition you gain access to." };
            yield return new TextBlock { Id = Guid.Parse("dfc513ab-b0d4-4b65-8b3f-65a2cf559344"), Type = TextBlockType.Text, Text = "Each time you gain a level, your patron teaches your familiar two new spells of any level you can cast, chosen from common spells of your tradition or others you gain access to. Feats can also grant your familiar additional spells." };
            yield return new TextBlock { Id = Guid.Parse("20be66c9-44b4-4934-a800-79ad6f4b9657"), Type = TextBlockType.Text, Text = "Your familiar can learn new spells independently of your patron. It can learn any spell on your tradition's spell list by physically consuming a scroll of that spell in a process that takes 1 hour. You can use the Learn a Spell exploration activity to prepare a special written version of a spell, which your familiar can consume as if it were a scroll. You and your familiar can use the Learn a Spell activity to teach your familiar a spell from another witch's familiar. Both familiars must be present for the entirety of the activity, the spell must be on your spellcasting tradition's spell list, and you must pay the usual cost for that activity, typically in the form of an offering to the other familiar's patron. You can't prepare spells from another witch's familiar." };
            yield return new TextBlock { Id = Guid.Parse("8cb16158-c43e-41ac-9c81-ccae6b73f8f3"), Type = TextBlockType.Text, Text = "If your familiar dies, your patron replaces it during your next daily preparations. The new familiar might be a duplicate or reincarnation of your former familiar or a new entity altogether, but it knows the same spells your former familiar knew regardless. Your familiar's death doesn't affect any spells you have already prepared." };

        }

        protected override void GetEffects(BooleanEffectBuilder builder)
        {
            builder.GainAnyFamiliar(Guid.Parse("07121661-e159-4efe-b4a0-41156995ed64"));
            builder.GainAnyFamiliarAbility(Guid.Parse("9c92037f-9c30-4df7-be29-14852aedd0db"));

            builder.GainAnyFamiliarAbility(Guid.Parse("0eafb16a-5867-420a-8f5d-6bbef53b535b"))
                .AddPrerequisites(Guid.Parse("1f6e67f4-2348-4d6f-91d5-dc1aec11b96d"), prerequisites =>
                {
                    prerequisites.HaveSpecificLevel(Guid.Parse("d162bb77-39eb-4511-9e84-b2974e906778"), Comparator.GreaterThanOrEqualTo, requiredLevel: 6);
                });

            builder.GainAnyFamiliarAbility(Guid.Parse("ab192975-6bde-44a7-8da5-3372b2d4bd9c"))
               .AddPrerequisites(Guid.Parse("48db4bfc-2562-40de-be21-06b657d07261"), prerequisites =>
               {
                   prerequisites.HaveSpecificLevel(Guid.Parse("26465153-67d6-45fa-af4b-31a1421b3606"), Comparator.GreaterThanOrEqualTo, requiredLevel: 12);
               });

            builder.GainAnyFamiliarAbility(Guid.Parse("010086d8-9c64-47c9-a4ca-13a8c6bcee46"))
               .AddPrerequisites(Guid.Parse("573b5a18-d1b0-4dad-a61d-131243ba0043"), prerequisites =>
               {
                   prerequisites.HaveSpecificLevel(Guid.Parse("6aae6275-f078-4c65-9080-c160d1bf5292"), Comparator.GreaterThanOrEqualTo, requiredLevel: 18);
               });

            builder.GainAnyFamiliarSpell(Guid.Parse("e838be0f-200f-49f1-9d81-78c51c5d4fab"), spellLevel: 0, amount: 10);
            builder.GainAnyFamiliarSpell(Guid.Parse("12bf70c6-510a-4e86-8571-322e45cbed67"), spellLevel: 1, amount: 5);

            builder.GainAnyFamiliarSpell(Guid.Parse("28c7d755-d828-42e0-b7de-2c7e3c53d87f"), Guid.Parse("4d9da8a9-701a-4a6d-bfc3-b8769d006556"), spellLevel: 2, amount: 2, requiredLevel: 2);
            builder.GainAnyFamiliarSpell(Guid.Parse("a126d120-835f-4e76-ac4d-2386e1ef1c2c"), Guid.Parse("baba7b44-2e26-4185-9c7a-0902c1399ed4"), spellLevel: 3, amount: 2, requiredLevel: 3);
            builder.GainAnyFamiliarSpell(Guid.Parse("9df71350-fef2-4ecb-a230-83ca9238aa6c"), Guid.Parse("787ed7f6-6800-49cd-850b-be203a129d15"), spellLevel: 4, amount: 2, requiredLevel: 4);
            builder.GainAnyFamiliarSpell(Guid.Parse("1e2d563b-c283-4d4d-8b8e-7283ab7bc073"), Guid.Parse("1253c4f6-745a-4b42-bc3c-3238303a4d1d"), spellLevel: 5, amount: 2, requiredLevel: 5);
            builder.GainAnyFamiliarSpell(Guid.Parse("7f189ba8-5c05-46ee-9171-0925326856d7"), Guid.Parse("2f0ac82a-40c0-4158-84a4-6cd5fe05c7d3"), spellLevel: 6, amount: 2, requiredLevel: 6);
            builder.GainAnyFamiliarSpell(Guid.Parse("7d22e568-330b-4244-b335-fdfccf9a4e37"), Guid.Parse("0cecaac8-fdf6-409e-ac3e-4aee566e72b8"), spellLevel: 7, amount: 2, requiredLevel: 7);
            builder.GainAnyFamiliarSpell(Guid.Parse("09fdf8a9-6ecc-4de3-afa8-aa53c50d159d"), Guid.Parse("fc84af0e-5da1-4be8-a595-4e62fc4d7627"), spellLevel: 8, amount: 2, requiredLevel: 8);
            builder.GainAnyFamiliarSpell(Guid.Parse("8b726087-4617-4a28-8cab-87888152334e"), Guid.Parse("7bfdf716-2bc6-4e96-8c8d-4948deccfa2f"), spellLevel: 9, amount: 2, requiredLevel: 9);
            builder.GainAnyFamiliarSpell(Guid.Parse("6a8b2574-492c-49cf-ad8b-8a98ca554cef"), Guid.Parse("43f4f220-bbd4-4555-a9a2-b9fe185fcc04"), spellLevel: 10, amount: 2, requiredLevel: 10);
            builder.GainAnyFamiliarSpell(Guid.Parse("acfc3603-4f47-417c-9cb3-55befab4c234"), Guid.Parse("e8d55c9d-5652-45ba-b38c-47b2190d7c4e"), spellLevel: 11, amount: 2, requiredLevel: 11);
            builder.GainAnyFamiliarSpell(Guid.Parse("55f7b20f-179a-4459-b895-f902aca3998d"), Guid.Parse("4aeb9d31-69d2-41ec-8c61-721000d830b3"), spellLevel: 12, amount: 2, requiredLevel: 12);
            builder.GainAnyFamiliarSpell(Guid.Parse("c263b07c-31fe-462d-b468-dbc070ca03fc"), Guid.Parse("211312bd-d039-42af-a97c-791332462b5d"), spellLevel: 13, amount: 2, requiredLevel: 13);
            builder.GainAnyFamiliarSpell(Guid.Parse("afb0f902-2c88-4ad9-b43f-c92f097f48dd"), Guid.Parse("2db1cd0b-5310-43ab-9c3d-0e699e2457df"), spellLevel: 14, amount: 2, requiredLevel: 14);
            builder.GainAnyFamiliarSpell(Guid.Parse("6cabb8d5-998e-44b7-b341-d9c4fb35c65f"), Guid.Parse("fbf0fbe8-4072-49c9-a8e9-5033ff5666e9"), spellLevel: 15, amount: 2, requiredLevel: 15);
            builder.GainAnyFamiliarSpell(Guid.Parse("19997b65-938e-42ac-a81e-398be2fa002a"), Guid.Parse("3218f10c-04f6-4d1f-a23b-b01d2947ace8"), spellLevel: 16, amount: 2, requiredLevel: 16);
            builder.GainAnyFamiliarSpell(Guid.Parse("a2392be7-2bb8-41c2-8c62-65c088e4d032"), Guid.Parse("2226c170-1dac-4b3a-be9b-424b8200f1e6"), spellLevel: 17, amount: 2, requiredLevel: 17);
            builder.GainAnyFamiliarSpell(Guid.Parse("aa3eb81a-bfd4-461e-b5bb-ab95dc1eafcf"), Guid.Parse("a95e27d3-7ab5-4789-a4a5-a69593ac4b48"), spellLevel: 18, amount: 2, requiredLevel: 18);
            builder.GainAnyFamiliarSpell(Guid.Parse("89f0ea85-5b26-49f1-bc5a-14c8e37a15df"), Guid.Parse("013b551f-e610-42a7-990d-666e878b1836"), spellLevel: 19, amount: 2, requiredLevel: 19);
            builder.GainAnyFamiliarSpell(Guid.Parse("783cd178-1bcc-4e4f-aefb-6b67f5ee4153"), Guid.Parse("4ad11406-27eb-4212-811c-e0e6c3014a7a"), spellLevel: 20, amount: 2, requiredLevel: 20);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("7c3d2e2f-545c-4ffb-9357-8481dcdb3f48"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = 96
            };
        }
    }
}
