using Silvester.Pathfinder.Reference.Database.Effects.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Entities;

using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Effects;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Builders;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.ClassFeatures.Sorcerers
{
    public class SpellRepertoire : Template
    {
        public static readonly Guid ID = Guid.Parse("a1f945c4-8825-4a54-bdd6-e2f9d1386eb9");

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
            yield return new TextBlock { Id = Guid.Parse("2dc68a9f-ebe1-40f8-85da-351845626f5a"), Type = TextBlockType.Text, Text = "The collection of spells you can cast is called your spell repertoire. At 1st level, you learn two 1st-level spells of your choice and four cantrips of your choice, as well as an additional spell and cantrip from your bloodline. You choose these from the common spells from the tradition corresponding to your bloodline, or from other spells from that tradition to which you have access. You can cast any spell in your spell repertoire by using a spell slot of an appropriate spell level." };
            yield return new TextBlock { Id = Guid.Parse("a49a4b65-6071-4d51-85f0-8a0d9c5ebea8"), Type = TextBlockType.Text, Text = "You add to this spell repertoire as you increase in level. Each time you get a spell slot (see Table 3�17), you add a spell of the same level to your spell repertoire. When you gain access to a new level of spells, your first new spell is always the spell granted by your bloodline, but you can choose the other spells. At 2nd level, you select another 1st-level spell; at 3rd level, you gain a new spell from your bloodline and two other 2nd-level spells, and so on. When you add spells, you might select a higher-level version of a spell you already know so that you can cast a heightened version of that spell." };
            yield return new TextBlock { Id = Guid.Parse("107fab8f-e718-42f5-8aa0-7b594b86ba10"), Type = TextBlockType.Text, Text = "Though you gain them at the same rate, your spell slots and the spells in your spell repertoire are separate. If a feat or other ability adds a spell to your spell repertoire, it wouldn't give you another spell slot, and vice versa." };
            yield return new TextBlock { Id = Guid.Parse("8ae810c9-914d-4149-8327-9264a7449bec"), Type = TextBlockType.Heading, Text = "Swapping Spells In Your Repertoire" };
            yield return new TextBlock { Id = Guid.Parse("9bae3aee-4cd5-4c0d-9ef9-805f4e735b4a"), Type = TextBlockType.Text, Text = "As you gain new spells in your spell repertoire, you might want to replace some of the spells you previously learned. Each time you gain a level and learn new spells, you can swap out one of your old spells for a different spell of the same level. This spell can be a cantrip, but you can't swap out bloodline spells. You can also swap out spells by retraining during downtime." };
        }

        protected override void GetEffects(BooleanEffectBuilder builder)
        {
            builder.GainAnySpell(Guid.Parse("47d9e181-8657-4a0f-a275-12ac2e38593e"), Guid.Parse("7d80213c-9a14-4169-a513-d0c2b9304312"), spellLevel: 1, requiredLevel: 1);
            builder.GainAnySpell(Guid.Parse("873775ab-d44a-4d59-ae03-33f63dd254a5"), Guid.Parse("54c7ed3b-a561-4407-906c-7f3c81016aa3"), spellLevel: 1, requiredLevel: 1);
            builder.GainAnySpell(Guid.Parse("0f57320c-63a3-4382-be4b-21d19be1cd40"), Guid.Parse("7e568e5a-59a5-47a1-816e-6760a5e8e70e"), spellLevel: 1, requiredLevel: 1);
            builder.GainAnySpell(Guid.Parse("c6d0328d-941d-4e5f-b99d-4b00bcfb8a03"), Guid.Parse("98f6699e-bd3c-4cde-adfd-869ecf5aa58d"), spellLevel: 1, requiredLevel: 2);

            builder.GainAnySpell(Guid.Parse("84de3c8a-6d9e-4804-9ea2-50e672899ae9"), Guid.Parse("d627c5d0-b5e1-4681-b7b4-458184e823aa"), spellLevel: 2, requiredLevel: 3);
            builder.GainAnySpell(Guid.Parse("b3822b3f-4889-4aab-a54f-bc502b5b4d11"), Guid.Parse("b860ec98-0389-4288-b919-3b14c6a21443"), spellLevel: 2, requiredLevel: 3);
            builder.GainAnySpell(Guid.Parse("95e19bf8-224f-44c0-823b-f5820b755065"), Guid.Parse("f3b96f05-1eb7-46f2-9f26-b127ab00e69a"), spellLevel: 2, requiredLevel: 3);
            builder.GainAnySpell(Guid.Parse("c52bb4be-1dc5-485b-8cd3-7b8b62411b86"), Guid.Parse("ea619632-70de-44fd-8d27-82fa7598c677"), spellLevel: 2, requiredLevel: 4);

            builder.GainAnySpell(Guid.Parse("9d8e2a55-1d7b-4df3-9896-6bf5e2f74627"), Guid.Parse("a5e25b4f-d4fe-45cd-8930-2f8c31edcb6c"), spellLevel: 3, requiredLevel: 5);
            builder.GainAnySpell(Guid.Parse("0e373daf-cdae-4990-83b3-f80907df34fe"), Guid.Parse("0d54f8f0-0281-42b5-bff6-c0d07be7737e"), spellLevel: 3, requiredLevel: 5);
            builder.GainAnySpell(Guid.Parse("e4745fdd-1d70-4249-859c-5be24744489c"), Guid.Parse("4843ff7f-2d82-421c-b606-3df017b327d7"), spellLevel: 3, requiredLevel: 5);
            builder.GainAnySpell(Guid.Parse("a82629de-9e75-4234-994b-fe4e1ba62775"), Guid.Parse("a0b61f7b-df3b-4444-a634-fa9dfdcccb92"), spellLevel: 3, requiredLevel: 6);

            builder.GainAnySpell(Guid.Parse("0d27141c-9574-4601-b4f0-490c3f11da0c"), Guid.Parse("fa4c099e-9679-4f6e-8a05-d8c1594d1626"), spellLevel: 4, requiredLevel: 7);
            builder.GainAnySpell(Guid.Parse("b1f6f43a-6a47-4454-8ec3-0de43130ea3d"), Guid.Parse("72b88fe8-7db2-4ac1-a846-8cb8a7de59ec"), spellLevel: 4, requiredLevel: 7);
            builder.GainAnySpell(Guid.Parse("dfa7d595-beca-4363-b82b-6fe203e6b3c1"), Guid.Parse("b86224f1-c92d-4112-88fe-ba0704c68ad2"), spellLevel: 4, requiredLevel: 7);
            builder.GainAnySpell(Guid.Parse("ef3d14ee-fa25-48c0-9510-cf42f137dc7b"), Guid.Parse("670f3a36-381c-4668-92d2-f470f86ba5ca"), spellLevel: 4, requiredLevel: 8);

            builder.GainAnySpell(Guid.Parse("1d679f76-1c0d-4b98-b086-88bc88523c8b"), Guid.Parse("0dda6005-315c-4b71-8371-dca41f2faf54"), spellLevel: 5, requiredLevel: 9);
            builder.GainAnySpell(Guid.Parse("ec1c79cc-9d73-4035-bee9-0a9ab39c86f4"), Guid.Parse("04c010cf-5cae-48fa-bc87-7d8f629ea2b2"), spellLevel: 5, requiredLevel: 9);
            builder.GainAnySpell(Guid.Parse("77546d99-471c-431c-b0fd-03072615c373"), Guid.Parse("b11dd5b8-01d6-4e3b-ab2f-bdc6525682c4"), spellLevel: 5, requiredLevel: 9);
            builder.GainAnySpell(Guid.Parse("2c24584b-817e-43ba-976d-23da2bd6f9b5"), Guid.Parse("43dabe0d-cb18-4608-9c87-1db03c2f6467"), spellLevel: 5, requiredLevel: 10);

            builder.GainAnySpell(Guid.Parse("f097274b-4fc1-45a4-bbad-84a5cf70e857"), Guid.Parse("65988620-0ab7-45f0-af65-149fb1d50c5b"), spellLevel: 6, requiredLevel: 11);
            builder.GainAnySpell(Guid.Parse("a30c0d08-440f-4c38-8048-1c290799123e"), Guid.Parse("d584e7e3-409e-47fc-ad71-3a1d716442d2"), spellLevel: 6, requiredLevel: 11);
            builder.GainAnySpell(Guid.Parse("1146b7f6-c265-45a5-8b1a-311fc4b5e487"), Guid.Parse("38459a8a-6971-4fd8-bc26-bd36f70d6b71"), spellLevel: 6, requiredLevel: 11);
            builder.GainAnySpell(Guid.Parse("f7a4e820-fba9-4168-946d-6696ab455455"), Guid.Parse("368634db-c074-4483-9d17-150ee7f00498"), spellLevel: 6, requiredLevel: 12);

            builder.GainAnySpell(Guid.Parse("6a994fed-e3b6-4ed3-95b3-f8a2a470be3a"), Guid.Parse("98eef887-af32-49a1-8772-70ffd896bc6f"), spellLevel: 7, requiredLevel: 13);
            builder.GainAnySpell(Guid.Parse("74f8fc55-79d2-4be4-93e8-d8c14107d1d7"), Guid.Parse("b36d8234-817e-4042-aa70-73b408dcbe65"), spellLevel: 7, requiredLevel: 13);
            builder.GainAnySpell(Guid.Parse("39e8463c-032d-4d9b-9895-9803e5e18956"), Guid.Parse("69e374ec-6c09-4767-8115-02de96f953b1"), spellLevel: 7, requiredLevel: 13);
            builder.GainAnySpell(Guid.Parse("76435f43-a5b2-4b05-b4a2-7d0552b46d8b"), Guid.Parse("e49a4041-6eef-4847-8ff7-aced726f0ce1"), spellLevel: 7, requiredLevel: 14);

            builder.GainAnySpell(Guid.Parse("94c2f358-657e-497c-915d-f169ca52ba83"), Guid.Parse("d14bb8b4-7e0f-4598-99bd-f39c0afa4b1f"), spellLevel: 8, requiredLevel: 15);
            builder.GainAnySpell(Guid.Parse("51d85ff4-c841-4fe9-89c7-26c77d2eed17"), Guid.Parse("74fee1e1-89ac-472c-b7f8-f287bf46ec21"), spellLevel: 8, requiredLevel: 15);
            builder.GainAnySpell(Guid.Parse("320343f3-07b2-4270-acdf-b35532384432"), Guid.Parse("4e41afee-b394-4501-98c2-08748f81d3f2"), spellLevel: 8, requiredLevel: 15);
            builder.GainAnySpell(Guid.Parse("90ab7e7f-ada2-4fe3-a7a7-d8cc2c888a72"), Guid.Parse("f851a97a-2d54-4b8a-a348-f1b6dd6fbeb5"), spellLevel: 8, requiredLevel: 16);

            builder.GainAnySpell(Guid.Parse("3a49cb92-5f77-4a2f-851d-81550d46affa"), Guid.Parse("132e736f-1571-42bc-84dd-3a3c17e1577a"), spellLevel: 9, requiredLevel: 17);
            builder.GainAnySpell(Guid.Parse("311a4f89-78b1-4be5-8212-91a8faee1263"), Guid.Parse("84b810c2-837d-40f8-bb47-820dc7a6d971"), spellLevel: 9, requiredLevel: 17);
            builder.GainAnySpell(Guid.Parse("05e8dbd4-a2ac-4e38-8ebf-a39dbfaef6bd"), Guid.Parse("6e510144-fe56-49eb-a290-964a8c23bedd"), spellLevel: 9, requiredLevel: 17);
            builder.GainAnySpell(Guid.Parse("f2206ab5-98a1-4f85-8f62-2730f20f3540"), Guid.Parse("13c1e07c-4282-4ef8-b328-5b81907299f1"), spellLevel: 9, requiredLevel: 18);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("675df712-b9a3-4167-8417-9a37a2ba4883"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 192
            };
        }
    }
}
