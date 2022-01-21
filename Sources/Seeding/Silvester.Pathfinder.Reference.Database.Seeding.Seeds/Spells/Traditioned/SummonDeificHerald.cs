using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.Traits;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Spells.Instances
{
    public class SummonDeificHerald : Template
    {
        public static readonly Guid ID = Guid.Parse("494035fc-c16a-4d38-b68d-de4cd793c687");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Summon Deific Herald",
                Level = 8,
                Range = "100 feet.",
                Requirements = "You have a deity.", 
                Duration = "Until the end of your next turn.",
                SpellTypeId = SpellTypes.Instances.Spell.ID,
                ActionTypeId = ActionTypes.Instances.ThreeActions.ID,
                MagicSchoolId = MagicSchools.Instances.Conjuration.ID,
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("4fe18419-d1c0-4513-acbe-2027b220da2a"), Type = TextBlockType.Text, Text = "Your faith is strong enough to briefly summon a direct representative of your deity, such as the deity�s herald. The herald occupies the space of a Huge creature and has a Speed of 60 feet. The effects of this spell depend on your deity�s alignment." };
        }

        protected override IEnumerable<InlineAction> GetInlineActions()
        {
            yield return new InlineAction
            {
                Id = Guid.Parse("5646bdb2-ae38-4813-a61c-6e8ccfadb4e9"),
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                Name = "Arrive",
                Kind = "Lawful Good",
                Traits = new[]
                {
                    new InlineActionTraitBinding { Id = Guid.Parse("f17b2dc5-ba95-47a6-9ac0-ca89ed6e1e3c"), TraitId = Traits.Instances.Enchantment.ID },
                    new InlineActionTraitBinding { Id = Guid.Parse("ac1e166a-afcd-4ce0-8c45-cd8d6c8e2681"), TraitId = Traits.Instances.Good.ID },
                    new InlineActionTraitBinding { Id = Guid.Parse("944732f2-edf1-4c3c-b25c-352e9b43d5d2"), TraitId = Traits.Instances.Lawful.ID },
                },
                Effect = new[]
                {
                    new TextBlock { Id = Guid.Parse("60579e35-6a89-41b3-b95e-309549a0749c"), Type = TextBlockType.Heading, Text = "Aura of Retribution" },
                    new TextBlock { Id = Guid.Parse("b125b5ac-c929-404a-aa78-26d04d3ad268"), Type = TextBlockType.Text, Text = "While within 100 feet of the herald, you and your allies gain the champion's Retributive Strike reaction (Core Rulebook 107)." },
                }
            };

            yield return new InlineAction
            {
                Id = Guid.Parse("4221d593-e505-44df-9184-2fab90f0236f"),
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                Name = "Depart",
                Kind = "Lawful Good",
                Effect = new[]
                {
                    new TextBlock { Id = Guid.Parse("035e1317-646c-4f21-a885-bc90aa2be6a6"), Type = TextBlockType.Heading, Text = "Holy Smite" },
                    new TextBlock { Id = Guid.Parse("d59fc46c-fc52-4b99-b6c8-a9e365b8c876"), Type = TextBlockType.Text, Text = "The herald casts 5th-level divine wrath (choosing good) in a 100-foot emanation." },
                }
            };

            yield return new InlineAction
            {
                Id = Guid.Parse("3204b5d2-bde2-4444-be14-ba5936a9a539"),
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                Name = "Arive",
                Kind = "Neutral Good",
                Traits = new[]
                {
                    new InlineActionTraitBinding { Id = Guid.Parse("5939feab-5d85-40f9-9df6-8937fbbf4a91"), TraitId = Traits.Instances.Enchantment.ID },
                    new InlineActionTraitBinding { Id = Guid.Parse("27801f0e-7a2c-4ba2-8605-ed6686ab6880"), TraitId = Traits.Instances.Good.ID },
                },
                Effect = new[]
                {
                    new TextBlock { Id = Guid.Parse("198a6f5e-6b3c-4a38-804f-dc60f27fe23a"), Type = TextBlockType.Heading, Text = "Aura of Redemption" },
                    new TextBlock { Id = Guid.Parse("2fc379cd-abe6-477c-912a-698f1eec8edf"), Type = TextBlockType.Text, Text = "While within 100 feet of the herald, you and your allies gain the champion's Glimpse of Redemption reaction (Core Rulebook 107)." },
                }
            };

            yield return new InlineAction
            {
                Id = Guid.Parse("91734d33-a1d6-4310-8535-c2254423508a"),
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                Name = "Depart",
                Kind = "Neutral Good",
                Effect = new[]
                {
                    new TextBlock { Id = Guid.Parse("b01f84e4-8f49-4354-b771-fe30c5f61034"), Type = TextBlockType.Heading, Text = "Merciful Healing" },
                    new TextBlock { Id = Guid.Parse("a42b5068-2e9c-4c86-a63d-4bf66f42a339"), Type = TextBlockType.Text, Text = "The herald casts the 3-action version of 5th-level heal with a radius of 100 feet. This spell targets only you and your allies." },
                }
            };

            yield return new InlineAction
            {
                Id = Guid.Parse("5f71cb1a-6516-498f-88e1-74228d3c4dc3"),
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                Name = "Arrive",
                Kind = "Chaotic Good",
                Traits = new[]
                {
                    new InlineActionTraitBinding { Id = Guid.Parse("fe4a58c9-b715-4251-9948-e9f150894d08"), TraitId = Traits.Instances.Chaotic.ID },
                    new InlineActionTraitBinding { Id = Guid.Parse("88ffb095-f2e1-4daf-8ece-162ac9368603"), TraitId = Traits.Instances.Enchantment.ID },
                    new InlineActionTraitBinding { Id = Guid.Parse("16ee6bbc-80c8-41a6-904e-0db7aae15129"), TraitId = Traits.Instances.Good.ID },
                },
                Effect = new[]
                {
                    new TextBlock { Id = Guid.Parse("1dbd2b65-c1a2-4290-b1a6-83335cffb34d"), Type = TextBlockType.Heading, Text = "Aura of Liberation" },
                    new TextBlock { Id = Guid.Parse("809a6226-ce15-4258-9046-3de3ba2d32f0"), Type = TextBlockType.Text, Text = "While within 100 feet of the herald, you and your allies gain the champion's Liberating Step reaction (Core Rulebook 107)." },
                }
            };

            yield return new InlineAction
            {
                Id = Guid.Parse("6d697e4e-bdde-4392-bfca-618169039efe"),
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                Name = "Depart",
                Kind = "Chaotic Good",
                Effect = new[]
                {
                    new TextBlock { Id = Guid.Parse("2b9111fb-06cc-4815-b697-d87437d47cad"), Type = TextBlockType.Heading, Text = "Radiating Freedom" },
                    new TextBlock { Id = Guid.Parse("41bd4f78-0020-4c1c-9b0d-578e8e52abea"), Type = TextBlockType.Text, Text = "The herald affects you and all your allies within 100 feet with freedom of movement. The duration is reduced to 3 rounds." },
                }
            };

            yield return new InlineAction
            {
                Id = Guid.Parse("19bd9c6d-d308-4d6f-a277-0031f4908a69"),
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                Name = "Arrive",
                Kind = "Lawful Neutral",
                Traits = new[]
                {
                    new InlineActionTraitBinding { Id = Guid.Parse("1dd9d9a9-ced7-4e87-90b1-dbee15c1b106"), TraitId = Traits.Instances.Abjuration.ID },
                    new InlineActionTraitBinding { Id = Guid.Parse("f9fb4378-59d6-4fb3-97ca-590825a41864"), TraitId = Traits.Instances.Lawful.ID },
                },
                Effect = new[]
                {
                    new TextBlock { Id = Guid.Parse("fd643274-e87b-4079-b3de-64766d7da51c"), Type = TextBlockType.Heading, Text = "Defy Chaos" },
                    new TextBlock { Id = Guid.Parse("314626f2-12a8-4159-a42c-c4bf8b7c9723"), Type = TextBlockType.Text, Text = "You and each ally within 100 feet of the herald gain resistance 20 against chaotic damage while the herald is present." },
                }
            };

            yield return new InlineAction
            {
                Id = Guid.Parse("1137cadb-49e4-4809-afa1-d8e5f5f08356"),
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                Name = "Depart",
                Kind = "Lawful Neutral",
                Effect = new[]
                {
                    new TextBlock { Id = Guid.Parse("3b7074a5-9796-4b83-85b6-70653835228f"), Type = TextBlockType.Heading, Text = "Order's Wrath" },
                    new TextBlock { Id = Guid.Parse("78e3ff0a-260f-4e3d-95bd-3a0a74891b1f"), Type = TextBlockType.Text, Text = "The herald casts 5th-level divine wrath (choosing lawful) in a 100-foot emanation." },
                }
            };

            yield return new InlineAction
            {
                Id = Guid.Parse("cc2d4256-7178-40ae-b95a-0edd745c47bc"),
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                Name = "Arrive",
                Kind = "True Neutral",
                Traits = new[]
                {
                    new InlineActionTraitBinding { Id = Guid.Parse("138b7047-236f-436d-8259-18958ab878fa"), TraitId = Traits.Instances.Transmutation.ID },
                },
                Effect = new[]
                {
                    new TextBlock { Id = Guid.Parse("90aa16e9-e52e-45e4-bd11-0fd689250406"), Type = TextBlockType.Heading, Text = "Quickening Ripple" },
                    new TextBlock { Id = Guid.Parse("0544f6b4-0c74-4fdf-bebe-717271b7222b"), Type = TextBlockType.Text, Text = "You and each ally within 100 feet of the herald are quickened while the herald is present, and can use the additional action to Step, Stride, or Strike." },
                }
            };


            yield return new InlineAction
            {
                Id = Guid.Parse("05fdcd3d-a4f3-4f29-8a5b-bfd169d98381"),
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                Name = "Depart",
                Kind = "True Neutral",
                Effect = new[]
                {
                    new TextBlock { Id = Guid.Parse("b6022a16-833f-487f-ac75-b1f6e303db38"), Type = TextBlockType.Heading, Text = "Sapping Beam" },
                    new TextBlock { Id = Guid.Parse("e53508a7-6110-41f0-a6c1-b540763693d7"), Type = TextBlockType.Text, Text = "The herald casts 6th-level enervation (Advanced Player's Guide 218) in a 100‑foot line." },
                }
            };

            yield return new InlineAction
            {
                Id = Guid.Parse("30c27fdf-936d-4f30-9c8b-fbcc5ed1c45c"),
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                Name = "Arrive",
                Kind = "Chaotic Neutral",
                Traits = new[]
                {
                    new InlineActionTraitBinding { Id = Guid.Parse("4e29150b-cb10-4394-87d9-60b5cd4271b8"), TraitId = Traits.Instances.Abjuration.ID },
                    new InlineActionTraitBinding { Id = Guid.Parse("cea9cf76-f51c-4ded-8831-279a7bb3b33c"), TraitId = Traits.Instances.Champion.ID },
                },
                Effect = new[]
                {
                    new TextBlock { Id = Guid.Parse("4fad31f7-aa4d-4bb5-bcfb-95a380fda8ff"), Type = TextBlockType.Heading, Text = "Defy Law" },
                    new TextBlock { Id = Guid.Parse("2a9543d2-b0c5-4b8b-bd90-1550322f066a"), Type = TextBlockType.Text, Text = "You and each ally within 100 feet of the herald gain resistance 20 against lawful damage while the herald is present." },
                }
            };

            yield return new InlineAction
            {
                Id = Guid.Parse("1ee620dd-5c76-4e00-abe0-db79bb05cc17"),
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                Name = "Depart",
                Kind = "Chaotic Neutral",
                Effect = new[]
                {
                    new TextBlock { Id = Guid.Parse("2422d1f4-1d8a-435d-ad02-76902152e46d"), Type = TextBlockType.Heading, Text = "Chaos Hammer" },
                    new TextBlock { Id = Guid.Parse("2b565ee7-e17c-423e-8882-40beb83c9851"), Type = TextBlockType.Text, Text = "The herald casts 5th-level divine wrath (choosing chaotic) in a 100-foot emanation." },
                }
            };

            yield return new InlineAction
            {
                Id = Guid.Parse("62a9e5e9-00a3-424d-9056-c08fc8041ea7"),
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                Name = "Arrive",
                Kind = "Lawful Evil",
                Effect = new[]
                {
                    new TextBlock { Id = Guid.Parse("d7e7b4cc-a2f1-4f4e-992a-13dfdebc7216"), Type = TextBlockType.Heading, Text = "Aura of Iron" },
                    new TextBlock { Id = Guid.Parse("eed66eaa-2a8e-4ffa-8916-034e8ee41784"), Type = TextBlockType.Text, Text = "While within 100 feet of the herald, you and your allies gain the champion's Iron Command reaction (Advanced Player's Guide 117)." },
                }
            };

            yield return new InlineAction
            {
                Id = Guid.Parse("b9296c87-0c3b-4ce8-95eb-2e09d3aa77a2"),
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                Name = "Depart",
                Kind = "Lawful Evil",
                Effect = new[]
                {
                    new TextBlock { Id = Guid.Parse("36e5bb42-6b35-475e-ac65-04d1709aeb6b"), Type = TextBlockType.Heading, Text = "Unholy Blight" },
                    new TextBlock { Id = Guid.Parse("fcf79b4c-e14c-4b5c-be6e-d3b2eb310c9d"), Type = TextBlockType.Text, Text = "The herald casts 5th-level divine wrath (choosing evil) in a 100‑foot emanation." },
                }
            };

            yield return new InlineAction
            {
                Id = Guid.Parse("6a2702c5-bf2e-40f2-bda6-e2c2a939d041"),
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                Name = "Arrive",
                Kind = "Neutral Evil",
                Effect = new[]
                {
                    new TextBlock { Id = Guid.Parse("03d74828-d52b-4167-97f0-6e0a43128401"), Type = TextBlockType.Heading, Text = "Aura of Selfishness" },
                    new TextBlock { Id = Guid.Parse("51d01bcc-adca-48a9-ada4-80f01db2f755"), Type = TextBlockType.Text, Text = "While within 100 feet of the herald, you and your allies gain the champion's Selfish Shield reaction (Advanced Player's Guide 117)." },
                }
            };

            yield return new InlineAction
            {
                Id = Guid.Parse("f6744425-5508-441d-a53b-5d66af5901ff"),
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                Name = "Depart",
                Kind = "Neutral Evil",
                Effect = new[]
                {
                    new TextBlock { Id = Guid.Parse("052ceb3d-68fb-42f3-8475-6bf2627197d1"), Type = TextBlockType.Heading, Text = "Infinite Despair" },
                    new TextBlock { Id = Guid.Parse("1c3fe672-34c2-48b1-b1df-9f292e620f32"), Type = TextBlockType.Text, Text = "The herald casts 5th-level crushing despair in a 100-foot cone." },
                }
            };

            yield return new InlineAction
            {
                Id = Guid.Parse("762d355f-a25b-4444-a5bc-b142ff57fc2c"),
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                Name = "Arrive",
                Kind = "Chaotic Evil",
                Effect = new[]
                {
                    new TextBlock { Id = Guid.Parse("bbb945b1-a7e8-4f8f-8d4d-8f30b0ccb95b"), Type = TextBlockType.Heading, Text = "Aura of Vengeance" },
                    new TextBlock { Id = Guid.Parse("53c95063-d19d-4d9e-b45b-3c124c5b90c1"), Type = TextBlockType.Text, Text = "While within 100 feet of the herald, you and your allies gain the champion's Destructive Vengeance reaction (Advanced Player's Guide 117)." },
                }
            };

            yield return new InlineAction
            {
                Id = Guid.Parse("a0a8db5c-8006-48fb-8faf-b916b89b3b6f"),
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                Name = "Depart",
                Kind = "Chaotic Evil",
                Effect = new[]
                {
                    new TextBlock { Id = Guid.Parse("b629580c-0375-48cf-b926-e94f90bf958b"), Type = TextBlockType.Heading, Text = "Weapon Hurricane" },
                    new TextBlock { Id = Guid.Parse("b3566ce7-7a8b-4716-baea-5dca027c1293"), Type = TextBlockType.Text, Text = "The herald casts 5th-level weapon storm in a 100-foot cone, using d12 for the die size." },
                }
            };
        }

        public override IEnumerable<Guid> GetSpellComponents()
        {
            yield return SpellComponents.Instances.Material.ID;
            yield return SpellComponents.Instances.Somatic.ID;
            yield return SpellComponents.Instances.Verbal.ID;
        }

        public override IEnumerable<Guid> GetMagicTraditions()
        {
            yield return MagicTraditions.Instances.Divine.ID;
        }

        public override void GetTraits(ITraitBindingBuilder<SpellTraitBinding, Spell> builder)
        {
            builder.Add(Guid.Parse("5f38002e-3b52-420d-91e8-eb903cdfdfba"), Traits.Instances.Conjuration.ID);
            builder.Add(Guid.Parse("c5a5b694-5327-4920-a196-4b021fd3d9ac"), Traits.Instances.Incarnate.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("49725dd7-2811-4c35-94aa-d75ed053302c"),
                SourceId = Sources.Instances.SecretsOfMagic.ID,
                Page = 131
            };
        }
    }
}
