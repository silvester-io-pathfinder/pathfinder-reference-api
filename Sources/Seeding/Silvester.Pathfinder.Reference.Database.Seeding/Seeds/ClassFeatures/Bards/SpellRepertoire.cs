using Silvester.Pathfinder.Reference.Database.Effects.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Entities;

using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;

using Silvester.Pathfinder.Reference.Database.Models.Prerequisites;
using Silvester.Pathfinder.Reference.Database.Effects;

using Silvester.Pathfinder.Reference.Database.Models.Effects.Builders;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.ClassFeatures.Bards
{
    public class SpellRepertoire : Template
    {
        public static readonly Guid ID = Guid.Parse("21c55556-16d3-4856-bc8e-9030fb91151d");

        protected override ClassFeature GetClassFeature()
        {
            return new ClassFeature
            {
                Id = ID, 
                Level = 1,
                Name = "Spell Repertoire", 
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse("e9f42750-0309-4c71-9435-bbd63281a6c9"), Type = TextBlockType.Text, Text = "The collection of spells you can cast is called your spell repertoire. At 1st level, you learn two 1st-level occult spells of your choice and five occult cantrips of your choice. You choose these from the common spells from the occult list or from other occult spells to which you have access. You can cast any spell in your spell repertoire by using a spell slot of an appropriate spell level." };
            yield return new TextBlock { Id = Guid.Parse("53e0336d-4617-47b6-a0b8-4fcf7399d5bd"), Type = TextBlockType.Text, Text = "You add to this spell repertoire as you increase in level. Each time you get a spell slot (see Table 3�6), you add a spell to your spell repertoire of the same level. At 2nd level, you select another 1st-level spell; at 3rd level, you select two 2nd-level spells, and so on. When you add spells, you might add a higher-level version of a spell you already have, so you can cast a heightened version of that spell." };
            yield return new TextBlock { Id = Guid.Parse("f733d2e0-99c6-4490-996d-a14d87a2a510"), Type = TextBlockType.Text, Text = "Though you gain them at the same rate, your spell slots and the spells in your spell repertoire are separate. If a feat or other ability adds a spell to your spell repertoire, it wouldn't give you another spell slot, and vice versa." };
        }

        protected override void GetEffects(BooleanEffectBuilder builder)
        {
            builder.GainSpecificMagicTraditionAnySpell(Guid.Parse("916402ef-6dfc-4a28-8cf2-1a3e3ec0d7aa"), MagicTraditions.Instances.Occult.ID, spellLevel: 1);
            builder.GainSpecificMagicTraditionAnySpell(Guid.Parse("286de7e7-71ec-4ef6-b508-723d61e19022"), MagicTraditions.Instances.Occult.ID, spellLevel: 1);
            builder.GainSpecificMagicTraditionAnySpell(Guid.Parse("6d1742e0-ae75-4d2b-b808-d5f6f9da0ac6"), Guid.Parse("1f4a6f1b-b245-4cb5-82f0-f1adedc48db0"), MagicTraditions.Instances.Occult.ID, spellLevel: 1, requiredLevel: 2);

            builder.GainSpecificMagicTraditionAnySpell(Guid.Parse("af5528cd-1e8a-4716-90fd-228f25942bd1"), Guid.Parse("4335a8c0-6392-477a-97b0-1bdaeba9e682"), MagicTraditions.Instances.Occult.ID, spellLevel: 2, requiredLevel: 3);
            builder.GainSpecificMagicTraditionAnySpell(Guid.Parse("f7eba2af-de20-4655-864d-fcc3b6e701d9"), Guid.Parse("34d10a3f-fa5d-433d-b38d-6b80e4d32202"), MagicTraditions.Instances.Occult.ID, spellLevel: 2, requiredLevel: 3);
            builder.GainSpecificMagicTraditionAnySpell(Guid.Parse("dd0350ef-884a-46b4-92bb-555bd9d0887b"), Guid.Parse("3fcc3b27-4dcb-46eb-a11b-a8d3aa5a1031"), MagicTraditions.Instances.Occult.ID, spellLevel: 2, requiredLevel: 4);

            builder.GainSpecificMagicTraditionAnySpell(Guid.Parse("e29cdd01-5f1e-4d3b-b44b-cb93d0099f9b"), Guid.Parse("c08ed9aa-3665-40a9-bf92-051e0cbac9cf"), MagicTraditions.Instances.Occult.ID, spellLevel: 3, requiredLevel: 5);
            builder.GainSpecificMagicTraditionAnySpell(Guid.Parse("e4ac9118-95d9-4d76-83b3-b129353f96e5"), Guid.Parse("3957b3b2-22a3-4f26-9595-71699020cff0"), MagicTraditions.Instances.Occult.ID, spellLevel: 3, requiredLevel: 5);
            builder.GainSpecificMagicTraditionAnySpell(Guid.Parse("97f24b43-cbee-447e-b076-d22ff5ce23ba"), Guid.Parse("cdc7c982-a7ba-414d-99b0-477f4a1f1a56"), MagicTraditions.Instances.Occult.ID, spellLevel: 3, requiredLevel: 6);

            builder.GainSpecificMagicTraditionAnySpell(Guid.Parse("9f14a11d-c7cd-497d-827d-e01406203621"), Guid.Parse("f6a941df-cfb4-4443-bc2c-1440c02c3ade"), MagicTraditions.Instances.Occult.ID, spellLevel: 4, requiredLevel: 7);
            builder.GainSpecificMagicTraditionAnySpell(Guid.Parse("dc58bf29-5c6c-4933-8dab-35cdd9311542"), Guid.Parse("149c567a-5036-4758-b991-78710c8f0def"), MagicTraditions.Instances.Occult.ID, spellLevel: 4, requiredLevel: 7);
            builder.GainSpecificMagicTraditionAnySpell(Guid.Parse("2f0dc605-d728-4ea8-9795-e1ba592cdfaf"), Guid.Parse("442ca7c1-0297-4cee-a57c-6a8452b0612e"), MagicTraditions.Instances.Occult.ID, spellLevel: 4, requiredLevel: 8);

            builder.GainSpecificMagicTraditionAnySpell(Guid.Parse("2e670c1d-03b8-4725-a889-93679ab37012"), Guid.Parse("8b62a202-7db5-44ec-b05a-2f1d08e13cdc"), MagicTraditions.Instances.Occult.ID, spellLevel: 5, requiredLevel: 9);
            builder.GainSpecificMagicTraditionAnySpell(Guid.Parse("5edbda17-368c-4967-ba24-8a2a8bedce5e"), Guid.Parse("b9082d22-1754-414b-a214-11b1994c4874"), MagicTraditions.Instances.Occult.ID, spellLevel: 5, requiredLevel: 9);
            builder.GainSpecificMagicTraditionAnySpell(Guid.Parse("2370e631-09a7-4ebd-98eb-7b596fe758b5"), Guid.Parse("81caa1b4-a6b9-48df-9262-710a244dfae2"), MagicTraditions.Instances.Occult.ID, spellLevel: 5, requiredLevel: 10);

            builder.GainSpecificMagicTraditionAnySpell(Guid.Parse("14d35797-daa7-4532-b773-9271e97ac156"), Guid.Parse("aee80124-c0d6-46e5-a767-545bde4668f0"), MagicTraditions.Instances.Occult.ID, spellLevel: 6, requiredLevel: 11);
            builder.GainSpecificMagicTraditionAnySpell(Guid.Parse("fb774fbb-42e0-4913-a3d3-ecc497f8bb9d"), Guid.Parse("034ca3b2-7b41-49a0-b6fc-42f9d8c48d28"), MagicTraditions.Instances.Occult.ID, spellLevel: 6, requiredLevel: 11);
            builder.GainSpecificMagicTraditionAnySpell(Guid.Parse("3de5e7db-737f-4aac-abab-3ba7bdd2c395"), Guid.Parse("592b7d67-6e99-4d14-ab79-f1a07e6fa4c3"), MagicTraditions.Instances.Occult.ID, spellLevel: 6, requiredLevel: 12);

            builder.GainSpecificMagicTraditionAnySpell(Guid.Parse("18706166-71f2-4376-8513-1b48b94d26b1"), Guid.Parse("833bc2bf-b51b-4e02-8cb2-f32ab40b7b2b"), MagicTraditions.Instances.Occult.ID, spellLevel: 7, requiredLevel: 13);
            builder.GainSpecificMagicTraditionAnySpell(Guid.Parse("576fe0ff-5a8b-4fec-a251-7786e279dd33"), Guid.Parse("9c50618b-9917-48e9-8aa0-922e686e1a48"), MagicTraditions.Instances.Occult.ID, spellLevel: 7, requiredLevel: 13);
            builder.GainSpecificMagicTraditionAnySpell(Guid.Parse("67feaca6-d2f3-47ac-899b-453f6fbb2e8b"), Guid.Parse("0af9b9d4-a2f8-4e56-bef4-579f2ea734eb"), MagicTraditions.Instances.Occult.ID, spellLevel: 7, requiredLevel: 14);

            builder.GainSpecificMagicTraditionAnySpell(Guid.Parse("a7b59d6c-6057-4042-ac14-db51ac9562bb"), Guid.Parse("60e19520-7a16-4fb4-b824-417727434f69"), MagicTraditions.Instances.Occult.ID, spellLevel: 8, requiredLevel: 15);
            builder.GainSpecificMagicTraditionAnySpell(Guid.Parse("ec75ed7e-406f-41d4-9711-93f27604a37c"), Guid.Parse("b8dbaa02-e669-49de-acbf-8691aff5bd4b"), MagicTraditions.Instances.Occult.ID, spellLevel: 8, requiredLevel: 15);
            builder.GainSpecificMagicTraditionAnySpell(Guid.Parse("b2b2b54e-6234-4006-8beb-fceeb5e9bfe2"), Guid.Parse("8327914d-9cae-4926-ae3c-a82b142ff7f0"), MagicTraditions.Instances.Occult.ID, spellLevel: 8, requiredLevel: 16);

            builder.GainSpecificMagicTraditionAnySpell(Guid.Parse("a8e35e4c-7cea-4c8a-bfec-1119e1357373"), Guid.Parse("043906c6-0ddb-4eaf-91ad-def3341c19d8"), MagicTraditions.Instances.Occult.ID, spellLevel: 9, requiredLevel: 17);
            builder.GainSpecificMagicTraditionAnySpell(Guid.Parse("7f46c54b-05b1-4ee7-8e39-fded9772f00c"), Guid.Parse("62e66b31-a2dc-40f8-89cd-fc6e7a374835"), MagicTraditions.Instances.Occult.ID, spellLevel: 9, requiredLevel: 17);
            builder.GainSpecificMagicTraditionAnySpell(Guid.Parse("21e87496-ba56-4f39-9432-c4ca31d6fd63"), Guid.Parse("50686329-261b-4917-b055-aeb788225d6f"), MagicTraditions.Instances.Occult.ID, spellLevel: 9, requiredLevel: 18);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("2e6276c7-d2d1-4099-a960-5719d36ce199"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 96
            };
        }
    }
}
