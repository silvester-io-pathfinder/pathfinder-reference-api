using Silvester.Pathfinder.Reference.Database.Effects.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Mysteries.Instances
{
    public class Lore : Template
    {
        public static readonly Guid ID = Guid.Parse("1814b4e8-edc9-4dd8-958d-3dbe7e3fe3b1");

        protected override Mystery GetMystery()
        {
            return new Mystery
            {
                Id = ID,
                Name = "Lore",
                InitialRevelationId = Spells.Instances.BrainDrain.ID,
                AdvancedRevelationId = Spells.Instances.AccessLore.ID,
                GreaterRevelationId = Spells.Instances.DreadSecret.ID,
                GrantedCantripId = Spells.Instances.ReadAura.ID,
                TrainedSkillId = Skills.Instances.Occultism.ID,
                TrainedSkillAddendum = "Besides Occultism, you gain one Lore skill of your choice."
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("949f0bd4-628e-438b-8dd0-97a09c5a93b8"), Type = TextBlockType.Text, Text = "Knowledge and information come freely to you. You might use this lore to gain power or perhaps to understand the divine mysteries of the multiverse. You might have a conduit to the fabled Akashic Record, maintain a subtle telepathic connection to the collective subconscious of all living creatures, or follow in the footsteps of deities such as Abadar, Irori, Nethys, Irori's scholarly nephew Gruhastha, the fey triune goddess of fate Magdh, or the lawful aeon god-figure known as the Monad." };
        }

        protected override IEnumerable<TextBlock> GetBenefitBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("eb2dc91c-a278-4b7a-ac1d-a83b855a63c7"), Type = TextBlockType.Text, Text = "You hold more mystical knowledge within you than most. You have one additional spell in your repertoire of each level you can cast." };
        }

        protected override IEnumerable<Guid> GetDomains()
        {
            yield return Domains.Instances.Knowledge.ID;
            yield return Domains.Instances.Truth.ID;
        }

        protected override void GetEffects(BooleanEffectBuilder builder)
        {
            //Mystery Benefits
            builder.GainSpecificSpellSlot(Guid.Parse("c54a8a8d-3b14-4857-bf7c-9c2e5c094cb3"), Guid.Parse("aebb331f-74fe-45e0-9ff8-ba5ede64783e"), requiredLevel: 1, spellSlotLevel: 1, amount: 1);
            builder.GainSpecificSpellSlot(Guid.Parse("c6ac01da-3943-4175-ac8e-3f4f75b72df0"), Guid.Parse("4c254d75-169d-4492-a124-af81921b4674"), requiredLevel: 3, spellSlotLevel: 2, amount: 1);
            builder.GainSpecificSpellSlot(Guid.Parse("f5b251c3-a42d-41f1-8821-89130bb7d795"), Guid.Parse("9442ec8e-3f62-4a35-9c44-71a207fc09b4"), requiredLevel: 5, spellSlotLevel: 3, amount: 1);
            builder.GainSpecificSpellSlot(Guid.Parse("6f01401e-c6e7-45c4-b57b-f59c5ebb8ba2"), Guid.Parse("780985f0-4ea3-4da8-963c-3f3b80f6774a"), requiredLevel: 7, spellSlotLevel: 4, amount: 1);
            builder.GainSpecificSpellSlot(Guid.Parse("d2e98f7c-f814-49ee-872b-b9a7d7ec6064"), Guid.Parse("47041930-3299-4604-987e-a63b0786666f"), requiredLevel: 9, spellSlotLevel: 5, amount: 1);
            builder.GainSpecificSpellSlot(Guid.Parse("d64e8a10-4991-416a-bf02-8090a0d763bf"), Guid.Parse("d6a3464c-781d-4dc1-bff1-609e630064b7"), requiredLevel: 11, spellSlotLevel: 6, amount: 1);
            builder.GainSpecificSpellSlot(Guid.Parse("7daf095d-af25-47c5-9fce-fd92fabdf6a0"), Guid.Parse("3912cce1-efa0-4216-8433-a2b6dbd9d268"), requiredLevel: 13, spellSlotLevel: 7, amount: 1);
            builder.GainSpecificSpellSlot(Guid.Parse("4d35896c-f1b0-4538-bba4-8aeb1af0fdab"), Guid.Parse("ebd892bc-68a2-4d0b-87d9-d3f1c44544d6"), requiredLevel: 15, spellSlotLevel: 8, amount: 1);
            builder.GainSpecificSpellSlot(Guid.Parse("cd7a68a3-c0c2-4809-a416-c22b1cb7c7e8"), Guid.Parse("ad91c921-0d2a-4aea-88ab-430a979ff67f"), requiredLevel: 17, spellSlotLevel: 9, amount: 1);
            builder.GainSpecificSpellSlot(Guid.Parse("eec1760b-1a7f-4ddf-bdca-f96d9ce795ce"), Guid.Parse("8b31406c-30c9-4819-a831-f7771ed2de95"), requiredLevel: 19, spellSlotLevel: 10, amount: 1, isSpendingPreventable: false);

            //Trained Skill
            builder.GainSpecificSkillProficiency(Guid.Parse("39afc1b4-95d7-470a-9336-7d4c5db58e7c"), Proficiencies.Instances.Trained.ID, Skills.Instances.Occultism.ID);
            builder.GainAnyLoreProficiency(Guid.Parse("1f5b18dd-caf2-42ed-b6f2-0b0eb1c80e76"), Proficiencies.Instances.Trained.ID);

            //Granted Cantrip
            builder.GainSpecificSpell(Guid.Parse("03490cdb-95ba-4b24-b79b-14a508803958"), Spells.Instances.ReadAura.ID);

            //Initial Revelation Spell
            builder.GainSpecificSpell(Guid.Parse("9cc1ea6a-bd42-48f2-a1c8-77e6d1601ae1"), Spells.Instances.BrainDrain.ID);

            //Advanced Revelation Spell
            builder.GainSpecificSpell(Guid.Parse("e77093e7-24c0-4c18-a3dc-aa7c58c41254"), Spells.Instances.AccessLore.ID)
                .AddPrerequisites(Guid.Parse("3ffc8e56-7ea1-4706-8b58-800c85841b0e"), prerequisites =>
                {
                    prerequisites.HaveSpecificFeat(Guid.Parse("2663acf6-f4da-483c-9ab2-545a7002fd97"), Feats.Instances.AdvancedRevelation.ID);
                });

            //Greater Revelation Spell
            builder.GainSpecificSpell(Guid.Parse("fe5118c6-c31a-4541-8b75-3c8d25e8424e"), Spells.Instances.DreadSecret.ID)
                .AddPrerequisites(Guid.Parse("0705555d-46ab-4cb5-ad4d-0d79a296db5a"), prerequisites =>
                {
                    prerequisites.HaveSpecificFeat(Guid.Parse("fbb62952-2d22-4c74-be26-6f4d3af778fb"), Feats.Instances.GreaterRevelation.ID);
                });
        }

        protected override MysteryCurse GetCurse()
        {
            return new MysteryCurse
            {
                Id = Guid.Parse("6127c7b5-b41e-4f2f-92de-fea98126712f"),
                Name = "Curse of Torrential Knowledge",
                SourcePage = new SourcePage
                {
                    Id = Guid.Parse("ebbe9813-c1b4-4de3-9766-218cd9f982b7"),
                    SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                    Page = 78
                },
                Details = new TextBlock[]
                {
                    new TextBlock { Id = Guid.Parse("ad1887df-7608-4948-a701-f7eebae85769"), Type = TextBlockType.Text, Text = "You have a link to true divine knowledge, but your mortal mind struggles to process and act on what you know. Loose materials around you, such as dust, grains of rice, and droplets of water, slowly shift to form strange runes or faint indecipherable writing, and you sometimes speak unintelligible truths or statements in unknown languages without realizing it." }
                },
                Potencies = new MysteryCursePotency[]
                {
                    new MysteryCursePotency
                    {
                        Id = Guid.Parse("dc0d9aaa-846f-4fb1-be19-ddf7e674e385"),
                        PotencyId = Potencies.Instances.Minor.ID,
                        Details = new TextBlock[] 
                        { 
                            new TextBlock { Id = Guid.Parse("64cb77dc-00c4-4568-b7b8-d86af155cb32"), Type = TextBlockType.Text, Text = "You take a –4 penalty to initiative, as trying to process a surge of information about what's happening around you slows your ability to respond to it." }
                        }
                    },
                    new MysteryCursePotency
                    {
                        Id = Guid.Parse("f9a9d796-733e-483e-8d8a-7f244f122252"),
                        PotencyId = Potencies.Instances.Moderate.ID,
                        Details = new TextBlock[]
                        {
                            new TextBlock { Id = Guid.Parse("b11a478e-e3ea-4c62-8861-11eb91dd8d37"), Type = TextBlockType.Text, Text = "The flow of information through your mind grows. The attention you divert to process this huge influx of information means you are always flat-footed. At the start of each of your turns, you automatically make one check to Recall Knowledge as a free action. This uses a skill of your choice that has the Recall Knowledge action, using a result equal to 10 + your proficiency bonus in that skill (with no other bonuses, penalties, or modifiers)." }
                        }
                    },
                    new MysteryCursePotency
                    {
                        Id = Guid.Parse("cdb44a44-0d29-4d10-b7e8-ae3ad7c9f8db"),
                        PotencyId = Potencies.Instances.Major.ID,
                        Details = new TextBlock[]
                        {
                            new TextBlock { Id = Guid.Parse("470b2884-6871-4da2-ac25-e27474837dd3"), Type = TextBlockType.Text, Text = "The massive flow of information clouding your mind overwhelms your ability to communicate with others. You can understand all languages, but you can't speak, use linguistic effects, or otherwise communicate with your allies. If you Cast a Spell with a verbal component, you must succeed at a DC 5 flat check or the spell is lost. You gain a +4 status bonus on saving throws against linguistic effects." }
                        }
                    }
                },
            };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("c0aedfff-f694-41d5-aca1-839f8a92dba2"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = 77
            };
        }
    }
}
