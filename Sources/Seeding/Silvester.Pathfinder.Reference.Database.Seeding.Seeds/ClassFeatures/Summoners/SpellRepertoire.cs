using Silvester.Pathfinder.Reference.Database.Effects.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Entities;

using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Effects;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.ClassFeatures.Summoners
{
    public class SpellRepertoire : Template
    {
        public static readonly Guid ID = Guid.Parse("6a5cbab0-a4ed-49e7-bba6-2a06df173ede");

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
            yield return new TextBlock { Id = Guid.Parse("a4b098b3-9fa8-4d0e-a25a-bb5414d3dfb3"), Type = TextBlockType.Text, Text = "The collection of spells you can cast is called your spell repertoire. At 1st level, you learn two 1st-level spells of your choice and five cantrips of your choice. You choose these from the common spells from the tradition corresponding to your eidolon, or from other spells from that tradition to which you have access. You can cast any spell in your spell repertoire by using a spell slot of an appropriate spell level. Your spell slots and the spells in your spell repertoire are separate. If a feat or other ability adds a spell to your spell repertoire, it doesn't give you another spell slot, and vice versa" };
            yield return new TextBlock { Id = Guid.Parse("79960ba0-a362-4b60-837c-4acfd57d84ef"), Type = TextBlockType.Text, Text = "You add to this spell repertoire as you increase in level. Each time you get a spell slot (see Table 2�4: Summoner Spells per Day), you add a spell of the same level to your spell repertoire. At 2nd level, you select another 1st-level spell. At 3rd level, you add the first 2nd-level spell to your repertoire. At 4th level you gain your second and your spell repertoire reaches its maximum size of five spells." };
            yield return new TextBlock { Id = Guid.Parse("165c4791-aba1-49e4-b043-b03c34e638d4"), Type = TextBlockType.Text, Text = "At 5th level, in addition to adding two 3rd-level spells to your repertoire, you lose your lowest level of spell slots. Any time you lose a level of spell slots, you lose two spells in your repertoire as well. These can come from spells you already know or out of the number of new spells you're learning. On levels in which you don't change your spell slots, you can swap out multiple spells, as described below." };
            yield return new TextBlock { Id = Guid.Parse("e3ccc406-a4ec-4da2-8a7d-59bc774ccdc7"), Type = TextBlockType.Heading, Text = "Swapping Spells In Your Repertoire" };
            yield return new TextBlock { Id = Guid.Parse("13f79975-34c1-4547-9713-b8eda7fc20cb"), Type = TextBlockType.Text, Text = "As you gain new spells in your repertoire, you might want to replace some of the spells you previously learned. Each time you gain a level and learn new spells, you can swap out one of your old spells for a different spell of the same level. If it's a level at which you lose a set of lower-level slots, you can replace the two in either order. You can also instead swap a cantrip. You can also swap out spells by retraining during downtime." };
            yield return new TextBlock { Id = Guid.Parse("30156ab1-090b-471e-8d6f-eab91d0a9daf"), Type = TextBlockType.Text, Text = "At 6th level and every even level thereafter, you can swap out any number of your spells for different spells of a level you can cast. When you do, you must keep at least one spell you can cast with your lowest level of spell slots so you don't end up with slots you can't use. For instance, at 6th level you would need to keep at least one 2nd-level spell, but all your other spells could be 3rd level." };
        }

        protected override void GetEffects(BooleanEffectBuilder builder)
        {
            //Five cantrips.
            builder.GainAnySpell(Guid.Parse("df1df8a2-3228-417a-8a43-e46712614781"), spellLevel: 0);
            builder.GainAnySpell(Guid.Parse("8b6dbfc5-56e1-4078-9ceb-40d13621e867"), spellLevel: 0);
            builder.GainAnySpell(Guid.Parse("fa0b3c10-dbc6-46f6-b396-59d79d0278fe"), spellLevel: 0);
            builder.GainAnySpell(Guid.Parse("a3aec323-d7b5-4f50-ba81-da8df251e64d"), spellLevel: 0);
            builder.GainAnySpell(Guid.Parse("dafa414e-b600-4d62-ba6d-f2f965120e88"), spellLevel: 0);

            //Two first level spells.
            builder.GainAnySpell(Guid.Parse("8d23c850-085a-45a9-974a-61376c25821e"), Guid.Parse("07bed545-38fc-4e1c-bcf0-41136c1c8227"), spellLevel: 1, requiredLevel: 1);
            builder.GainAnySpell(Guid.Parse("8c8ece27-d0ec-4c09-a1ce-67d39e32bc6a"), Guid.Parse("2d784655-0b83-406d-bf51-14a1ef491659"), spellLevel: 1, requiredLevel: 1);

            //Gain a spell any time you gain a spell slot (excluding the second level 1 spell slot).
            builder.GainAnySpell(Guid.Parse("48b88648-3e03-41e1-a820-edc33ce66871"), Guid.Parse("656f5c5b-bf1c-4e49-be52-178c8ba5c21d"), spellLevel: 2, requiredLevel: 3);
            builder.GainAnySpell(Guid.Parse("0eda13d6-c87a-466a-a141-a44bfdc681e5"), Guid.Parse("1a95526c-3deb-45ef-b8d8-ab565b7ed39e"), spellLevel: 2, requiredLevel: 3);
            builder.GainAnySpell(Guid.Parse("1dc43651-1efb-4305-a61b-9cbc64a42081"), Guid.Parse("55ddde1d-e1c4-490f-9d90-8115e609ce34"), spellLevel: 2, requiredLevel: 4);
            builder.GainAnySpell(Guid.Parse("d0c3c255-6f44-4506-84a8-0e866abca518"), Guid.Parse("77c33aaf-1636-4f6f-833f-5fd89a6b5982"), spellLevel: 2, requiredLevel: 4);
            builder.GainAnySpell(Guid.Parse("822ebc3f-178f-4bd4-b286-a44e3b8e5dd5"), Guid.Parse("bdb7109a-b9d2-4b00-bcdc-38c7c5fbc127"), spellLevel: 3, requiredLevel: 5);
            builder.GainAnySpell(Guid.Parse("95015d7f-66f7-42a9-a344-dd5fcf03499e"), Guid.Parse("90f16437-8fb8-4106-a832-a45605c833f0"), spellLevel: 3, requiredLevel: 5);
            builder.GainAnySpell(Guid.Parse("f6068e05-ca93-4de5-8696-450e79a5611e"), Guid.Parse("c95b84c6-239b-4441-9dd1-72bf14a28a9f"), spellLevel: 4, requiredLevel: 7);
            builder.GainAnySpell(Guid.Parse("77eb4b04-02ad-4c24-9270-b4347d09f838"), Guid.Parse("d33b51da-1ceb-424f-a2ce-e33db2f91c7a"), spellLevel: 4, requiredLevel: 7);
            builder.GainAnySpell(Guid.Parse("2975ee00-1089-403a-b91c-e4b7430db1ce"), Guid.Parse("b6edc4e3-5800-4138-afaf-bf61100741be"), spellLevel: 5, requiredLevel: 9);
            builder.GainAnySpell(Guid.Parse("09572430-ffc0-4481-8512-6d88b9ddb6a1"), Guid.Parse("4d421b55-10f1-4e3e-afb8-2c75100585f2"), spellLevel: 5, requiredLevel: 9);
            builder.GainAnySpell(Guid.Parse("45ee6a54-5899-4751-9bdd-941eb4309a64"), Guid.Parse("126ee929-40bd-4c05-a76a-e596ba76c9b1"), spellLevel: 6, requiredLevel: 11);
            builder.GainAnySpell(Guid.Parse("05a2375d-71e6-4ca0-95d0-2bd9c3311ac1"), Guid.Parse("a3b3fad5-53c4-4dd0-8ac4-a84178d11317"), spellLevel: 6, requiredLevel: 11);
            builder.GainAnySpell(Guid.Parse("91d3d5ee-ff53-4541-aae2-5cf3595543e4"), Guid.Parse("21193121-75a7-47f1-8d94-e75694c93525"), spellLevel: 7, requiredLevel: 13);
            builder.GainAnySpell(Guid.Parse("069dedbe-8224-4903-8c8e-7e3dcef61102"), Guid.Parse("0275ce6f-b00e-4435-9a20-ded9ad3f2962"), spellLevel: 7, requiredLevel: 13);
            builder.GainAnySpell(Guid.Parse("4037a202-4aa7-40ff-a726-19ffd992b3ec"), Guid.Parse("9e1fa93a-6367-4285-b04a-973412e96473"), spellLevel: 8, requiredLevel: 15);
            builder.GainAnySpell(Guid.Parse("2ab49ce9-60c6-493c-8340-7a12d5c61342"), Guid.Parse("b741093c-903a-48e5-bcee-f93fb1b52fa4"), spellLevel: 8, requiredLevel: 15);
            builder.GainAnySpell(Guid.Parse("2b92dadd-95ca-4d4f-8744-ed31a28f954e"), Guid.Parse("1dcf4817-06cb-4e48-a3c5-d7a37bcaf19b"), spellLevel: 9, requiredLevel: 17);
            builder.GainAnySpell(Guid.Parse("53fde524-777c-4bd0-8e5d-1dd7781d0298"), Guid.Parse("6192dbd1-f837-49a1-aa01-057dce152284"), spellLevel: 9, requiredLevel: 17);

            //Lose a spell any time you lose a spell slot.
            builder.LoseAnySpell(Guid.Parse("1cae4f2d-451c-4aee-ba4a-b1e7d520181a"), Guid.Parse("cd1094ac-4e94-431e-91e6-fce74f969d91"), requiredLevel: 5);
            builder.LoseAnySpell(Guid.Parse("23f2e96c-3bcb-40d6-a7bf-897a39fc1421"), Guid.Parse("9edeec06-bfb7-4bd5-92e3-7b6be4d3c9cd"), requiredLevel: 5);
            builder.LoseAnySpell(Guid.Parse("ec8ad826-afff-4be9-9f59-626a8c81733f"), Guid.Parse("4f645a47-b7dd-4e69-8946-dc299679070e"), requiredLevel: 7);
            builder.LoseAnySpell(Guid.Parse("49cc53ff-7482-4852-993f-dbb083b1cda5"), Guid.Parse("970f8151-7919-4715-9f81-2653ae84ddac"), requiredLevel: 7);
            builder.LoseAnySpell(Guid.Parse("9a009c8f-bb45-46a9-9b76-731ab9e73127"), Guid.Parse("e262ca8a-ce3b-41fc-bf26-ad98a18a1f73"), requiredLevel: 9);
            builder.LoseAnySpell(Guid.Parse("19ad8c10-7a56-4358-aedb-369f152f7f96"), Guid.Parse("a41b166f-492a-438e-99e7-445d3477046c"), requiredLevel: 9);
            builder.LoseAnySpell(Guid.Parse("d535f699-1cc2-43b0-8b65-019ab84b5a34"), Guid.Parse("4d56bd04-ad8c-4e0c-b990-e76984e40efd"), requiredLevel: 11);
            builder.LoseAnySpell(Guid.Parse("ef158949-9a4e-48d3-8bce-be793822383d"), Guid.Parse("2c4b416d-2212-4c5e-9be5-c3ba312f81bc"), requiredLevel: 11);
            builder.LoseAnySpell(Guid.Parse("373c0a9e-82f0-4558-a122-8179b711fe3e"), Guid.Parse("34e2e204-2a2b-4e63-99e7-0785744b3e0e"), requiredLevel: 13);
            builder.LoseAnySpell(Guid.Parse("9103cc79-6ce1-4a38-a152-7354aa3b668a"), Guid.Parse("e138c1bd-18d9-45f7-bd2f-e8654fd6cee7"), requiredLevel: 13);
            builder.LoseAnySpell(Guid.Parse("b5d665a0-4412-45f6-a7a3-9de3e2fa7e3e"), Guid.Parse("a6f69f6e-24e3-4726-a760-ebb7606010e0"), requiredLevel: 15);
            builder.LoseAnySpell(Guid.Parse("25fd56d6-e325-4f1f-9775-aca01b9f62a5"), Guid.Parse("d233e5bc-5131-40ac-aa00-7247acaeec04"), requiredLevel: 15);
            builder.LoseAnySpell(Guid.Parse("210b0cca-a9ce-4cb7-9077-4cdb4ae640fc"), Guid.Parse("bc43c2cd-856d-47a5-a861-363f0f6fc150"), requiredLevel: 17);
            builder.LoseAnySpell(Guid.Parse("a0f74649-336b-4bf5-9fe9-8620f5d49d68"), Guid.Parse("65f97f1a-011a-45ef-a0c6-860c1e6af31c"), requiredLevel: 17);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("854e9a43-d3e9-4445-b435-188847d48127"),
                SourceId = Sources.Instances.SecretsOfMagic.ID,
                Page = 55
            };
        }
    }
}
