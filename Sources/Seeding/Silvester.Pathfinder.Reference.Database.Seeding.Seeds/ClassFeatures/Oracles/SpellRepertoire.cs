using Silvester.Pathfinder.Reference.Database.Effects.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Entities;

using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Effects;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Builders;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.ClassFeatures.Oracles
{
    public class SpellRepertoire : Template
    {
        public static readonly Guid ID = Guid.Parse("edabe1a8-0cfa-47b7-af85-ee73c8937d47");

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
            yield return new TextBlock { Id = Guid.Parse("b5c4e2ba-ef53-4544-9728-4a60109f3f63"), Type = TextBlockType.Text, Text = "The collection of spells you can cast is called your spell repertoire. At 1st level, you learn two 1st-level spells of your choice and five cantrips of your choice. You choose these from the common spells from the divine spell list, or from other divine spells to which you have access. You can cast any spell in your spell repertoire by using a spell slot of an appropriate spell level." };
            yield return new TextBlock { Id = Guid.Parse("52cd42f6-ec90-444b-8832-7a3ef882993f"), Type = TextBlockType.Text, Text = "You add to this spell repertoire as you increase in level. Each time you get a spell slot (see Table 2-3), you add a spell of the same level to your spell repertoire. At 2nd level, you select another 1st-level spell; at 3rd level, you select two 2nd-level spells, and so on. When you add spells, you might add a higher-level version of a spell you already have, so you can cast a heightened version of that spell." };
            yield return new TextBlock { Id = Guid.Parse("0392ad93-697b-4ccb-bbca-5957b84ed62f"), Type = TextBlockType.Text, Text = "Though you gain them at the same rate, your spell slots and the spells in your spell repertoire are separate. If a feat or other ability adds a spell to your spell repertoire, it wouldn't give you another spell slot, and vice versa." };
            yield return new TextBlock { Id = Guid.Parse("33c4ac5e-9767-418c-a6f0-d80563dd51d5"), Type = TextBlockType.Heading, Text = "Swapping Spells in your Repertoire" };
            yield return new TextBlock { Id = Guid.Parse("b866d0a3-e818-4a08-986d-928dfc2d9827"), Type = TextBlockType.Text, Text = "As you gain new spells in your repertoire, you might want to replace some of the spells you previously learned. Each time you gain a level and learn new spells, you can swap out one of your old spells for a different spell of the same level. You can also instead swap a cantrip. You can also swap out spells by retraining during downtime." };
        }

        protected override void GetEffects(BooleanEffectBuilder builder)
        {
            builder.GainSpecificMagicTraditionAnySpell(Guid.Parse("71df6060-81b4-4095-9bef-43a6aed85cc4"), MagicTraditions.Instances.Divine.ID, spellLevel: 1);
            builder.GainSpecificMagicTraditionAnySpell(Guid.Parse("d6db4182-b928-4b69-8abf-1731d6887de7"), MagicTraditions.Instances.Divine.ID, spellLevel: 1);
            builder.GainSpecificMagicTraditionAnySpell(Guid.Parse("1beea7d9-cc1b-4898-bd03-13598bc95c31"), Guid.Parse("2bbd3534-c4d0-48f6-8e83-90ae86f8f9b5"), MagicTraditions.Instances.Divine.ID, spellLevel: 1, requiredLevel: 2);

            builder.GainSpecificMagicTraditionAnySpell(Guid.Parse("3a89bcaa-ed8e-468c-adeb-006e7b752b79"), Guid.Parse("d5339d64-9a2b-4829-a2b4-56bc50f15ae3"), MagicTraditions.Instances.Divine.ID, spellLevel: 2, requiredLevel: 3);
            builder.GainSpecificMagicTraditionAnySpell(Guid.Parse("f2129efa-2bbb-406f-97d1-c2de6ca8cf4b"), Guid.Parse("037c3382-1c5e-433d-87eb-6dfdaf8654ee"), MagicTraditions.Instances.Divine.ID, spellLevel: 2, requiredLevel: 3);
            builder.GainSpecificMagicTraditionAnySpell(Guid.Parse("840482a7-97b4-4de0-8ca8-98b7ef2a1d11"), Guid.Parse("a50e00ed-a683-4237-a511-e814f2d9a140"), MagicTraditions.Instances.Divine.ID, spellLevel: 2, requiredLevel: 4);

            builder.GainSpecificMagicTraditionAnySpell(Guid.Parse("cb5cc7a6-76dd-4bf2-9cc2-0f49dae59c6c"), Guid.Parse("c7d5fbf7-a408-4ce2-81f7-f044cc95abed"), MagicTraditions.Instances.Divine.ID, spellLevel: 3, requiredLevel: 5);
            builder.GainSpecificMagicTraditionAnySpell(Guid.Parse("a319efac-1255-4bf5-869f-21d429ff34e6"), Guid.Parse("c2a9c189-c627-4e1a-a658-0ab861dae9a6"), MagicTraditions.Instances.Divine.ID, spellLevel: 3, requiredLevel: 5);
            builder.GainSpecificMagicTraditionAnySpell(Guid.Parse("7cfa63b9-421d-4919-86a8-77c8bb624a49"), Guid.Parse("553bd0f2-75de-40f9-9caa-0696e376c53d"), MagicTraditions.Instances.Divine.ID, spellLevel: 3, requiredLevel: 6);

            builder.GainSpecificMagicTraditionAnySpell(Guid.Parse("931bf6dc-b25c-4255-8536-d6b39c505523"), Guid.Parse("4ab55c0f-ca2c-4a66-a4d3-de953225be45"), MagicTraditions.Instances.Divine.ID, spellLevel: 4, requiredLevel: 7);
            builder.GainSpecificMagicTraditionAnySpell(Guid.Parse("a90fc859-0969-4a48-ad68-426f06825de8"), Guid.Parse("71b554b3-1ae7-45aa-b65f-c2444754c9d6"), MagicTraditions.Instances.Divine.ID, spellLevel: 4, requiredLevel: 7);
            builder.GainSpecificMagicTraditionAnySpell(Guid.Parse("7234769a-70b6-4826-a9a9-906eab650084"), Guid.Parse("94820832-083e-4350-95d6-9d83d4a5be32"), MagicTraditions.Instances.Divine.ID, spellLevel: 4, requiredLevel: 8);

            builder.GainSpecificMagicTraditionAnySpell(Guid.Parse("a50e90c7-a225-44b0-a138-ad17d36916c2"), Guid.Parse("af5a2686-5637-4f78-bdb5-d5e18a763268"), MagicTraditions.Instances.Divine.ID, spellLevel: 5, requiredLevel: 9);
            builder.GainSpecificMagicTraditionAnySpell(Guid.Parse("55298b08-7b01-4497-942b-932e02452c0a"), Guid.Parse("a231706c-c6d8-47ee-9dd5-dbb2b8ed3cae"), MagicTraditions.Instances.Divine.ID, spellLevel: 5, requiredLevel: 9);
            builder.GainSpecificMagicTraditionAnySpell(Guid.Parse("9665525e-0a08-442a-8719-3fca9583922d"), Guid.Parse("0c8ef5b3-75ed-4d53-84cf-2c8b1ab89258"), MagicTraditions.Instances.Divine.ID, spellLevel: 5, requiredLevel: 10);

            builder.GainSpecificMagicTraditionAnySpell(Guid.Parse("ae409bbe-e8be-4163-8538-d462c60bf026"), Guid.Parse("ef8292a1-5bbb-41a9-b173-1a82568375d9"), MagicTraditions.Instances.Divine.ID, spellLevel: 6, requiredLevel: 11);
            builder.GainSpecificMagicTraditionAnySpell(Guid.Parse("7f106cb0-0c39-4a50-8a2b-836a03550d6f"), Guid.Parse("bec1f0e2-bbd9-470f-806c-0680c7317b28"), MagicTraditions.Instances.Divine.ID, spellLevel: 6, requiredLevel: 11);
            builder.GainSpecificMagicTraditionAnySpell(Guid.Parse("62160ebd-1722-4901-b644-07c74cde65bc"), Guid.Parse("5202d92d-be9e-4875-bc3a-5def83b187d6"), MagicTraditions.Instances.Divine.ID, spellLevel: 6, requiredLevel: 12);

            builder.GainSpecificMagicTraditionAnySpell(Guid.Parse("c80e31d6-7cef-4ffa-998e-cd909620a157"), Guid.Parse("398546d4-16da-4e26-9c58-1ea195062880"), MagicTraditions.Instances.Divine.ID, spellLevel: 7, requiredLevel: 13);
            builder.GainSpecificMagicTraditionAnySpell(Guid.Parse("51c195c8-a877-4f0a-b829-159317e051bf"), Guid.Parse("2ea2b7aa-4227-44a3-a2c5-bf948af79bfe"), MagicTraditions.Instances.Divine.ID, spellLevel: 7, requiredLevel: 13);
            builder.GainSpecificMagicTraditionAnySpell(Guid.Parse("9e5f4c01-2dbc-49e6-ac90-527ae04b4e70"), Guid.Parse("eb666156-2f42-4b55-8d99-e71a7a8e9498"), MagicTraditions.Instances.Divine.ID, spellLevel: 7, requiredLevel: 14);

            builder.GainSpecificMagicTraditionAnySpell(Guid.Parse("c829ea11-f29f-42ae-b14b-9c5010c68fb1"), Guid.Parse("fca93381-2ffb-4f58-ace2-1e6421394e3d"), MagicTraditions.Instances.Divine.ID, spellLevel: 8, requiredLevel: 15);
            builder.GainSpecificMagicTraditionAnySpell(Guid.Parse("d60bb5a8-cbbe-41a6-bf5e-89a6f6b26c38"), Guid.Parse("31a39cbf-f329-4f7b-b927-48f5c704d2ab"), MagicTraditions.Instances.Divine.ID, spellLevel: 8, requiredLevel: 15);
            builder.GainSpecificMagicTraditionAnySpell(Guid.Parse("e851716e-e9a4-4126-a432-a9c565d26a8c"), Guid.Parse("49a96f58-9206-4bf0-88f2-f893da1c048a"), MagicTraditions.Instances.Divine.ID, spellLevel: 8, requiredLevel: 16);

            builder.GainSpecificMagicTraditionAnySpell(Guid.Parse("1fca8384-5480-42d3-b91c-5257037e04fa"), Guid.Parse("2c31305f-50dc-4d81-b9ae-5b427bb84710"), MagicTraditions.Instances.Divine.ID, spellLevel: 9, requiredLevel: 17);
            builder.GainSpecificMagicTraditionAnySpell(Guid.Parse("12e9084d-e84c-4283-85d3-9598fe7e12a3"), Guid.Parse("247e174c-07fd-47cb-bdb9-ac0e64b5a573"), MagicTraditions.Instances.Divine.ID, spellLevel: 9, requiredLevel: 17);
            builder.GainSpecificMagicTraditionAnySpell(Guid.Parse("7a7b31ec-e514-47e3-9f5c-c29ac117e522"), Guid.Parse("f5136d1f-9f88-4219-b7ec-f32de10624f4"), MagicTraditions.Instances.Divine.ID, spellLevel: 9, requiredLevel: 18);

        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("a0cfe492-4587-4c6f-a445-63d4dbea9f3c"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = 68
            };
        }
    }
}
