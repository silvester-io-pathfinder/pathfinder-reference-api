using Silvester.Pathfinder.Reference.Database.Effects;
using Silvester.Pathfinder.Reference.Database.Effects.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Effects;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Builders;

using Silvester.Pathfinder.Reference.Database.Utilities.Tables;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Bloodlines.Instances
{
    public class Genie : Template
    {
        public static readonly Guid ID = Guid.Parse("2b83fb2f-3197-473d-88e9-3adbcdd0792d");
        
        protected override Bloodline GetBloodline()
        {
            return new Bloodline
            {
                Id = ID, 
                Name = "Genie",
                BloodMagic = "Your spellcasting warps reality and distracts your foes. Either you gain a +1 status bonus to Deception checks for 1 round, or a target takes a �1 status penalty to Perception for 1 round.",
                RarityId = Rarities.Instances.Common.ID,
                InitialBloodlineSpellId = Spells.Instances.GeniesVeil.ID,
                AdvancedBloodlineSpellId = Spells.Instances.HeartsDesire.ID,
                GreaterBloodlineSpellId = Spells.Instances.WishTwistedForm.ID,
                SpellListTraditionId = MagicTraditions.Instances.Arcane.ID
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse("386f8d79-ab92-4ff0-8a37-660f0e99c4a1"), Type = TextBlockType.Text, Text = "Through lineage, magic, or wishes made real, the blood of a noble genie flows through your veins." };
        }

        protected override IEnumerable<TextBlock> GetTypeChoiceDetails()
        {
            yield return new TextBlock { Id = Guid.Parse("8ee60980-3d89-41cb-9c9b-acdedf363ebd"), Type = TextBlockType.Text, Text = "At 1st level, choose the type of genie that influenced your bloodline: janni, djinni, efreeti, marid, or shaitan. You can't change your genie type later. This determines what granted spells you receive at 2nd, 5th, and 8th level." };
            yield return new TextBlock { Id = Guid.Parse("152ba561-a56c-46bd-823b-4b805aa86320"), Type = TextBlockType.Enumeration, Text = "Janni 2nd: create food; 5th: banishment; 8th: scintillating pattern" };
            yield return new TextBlock { Id = Guid.Parse("3d9365d8-f5d7-4759-a494-c3ee7a400875"), Type = TextBlockType.Enumeration, Text = "Djinni 2nd: invisibility; 5th: illusory scene; 8th: punishing winds" };
            yield return new TextBlock { Id = Guid.Parse("3d852768-ff7d-430c-8bf4-dbb74180e06e"), Type = TextBlockType.Enumeration, Text = "Efreeti 2nd: enlarge; 5th: elemental form (fire only); 8th: maze" };
            yield return new TextBlock { Id = Guid.Parse("6114feaa-7350-4c29-91a5-c6857db053d4"), Type = TextBlockType.Enumeration, Text = "Marid 2nd: water walk; 5th: control water; 8th: horrid wilting" };
            yield return new TextBlock { Id = Guid.Parse("c7d33a72-c822-4747-914e-a9ad367aa45e"), Type = TextBlockType.Enumeration, Text = "Shaitan 2nd: glitterdust; 5th: wall of stone; 8th: earthquake" };
        }

        protected override void GetEffects(BooleanEffectBuilder builder)
        {
            builder.GainSpecificSpellCasting(Guid.Parse("1d8686ea-7339-4258-a32a-294eb6e0e305"), MagicTraditions.Instances.Arcane.ID);

            builder.AddOr(Guid.Parse("f873a9ec-bb4e-4418-84b2-78b08cd27684"), or =>
            {
                or.AddAnd(Guid.Parse("08a71204-61e4-407a-bef8-8107e5439434"), and => 
                {
                    and.GainSpecificSpell(Guid.Parse("985718d3-dacc-4898-80d7-b31ac4cf2dae"), Spells.Instances.GeniesVeil.ID);
                    and.GainSpecificSpell(Guid.Parse("3f407375-5601-4d7d-90ca-93acf6df5600"), Spells.Instances.DetectMagic.ID);
                    and.GainSpecificSpell(Guid.Parse("a631768f-b6c4-46a3-91c0-6b77317afd78"), Spells.Instances.IllusoryDisguise.ID);
                    and.GainSpecificSpell(Guid.Parse("10a6d4ab-dc55-430e-a8ec-c316f64231f3"), Spells.Instances.CreateFood.ID);
                    and.GainSpecificSpell(Guid.Parse("fead3221-528b-49d6-923c-a97b6b4b634c"), Spells.Instances.Enthrall.ID);
                    and.GainSpecificSpell(Guid.Parse("e95cfd6c-86ef-490c-8615-98632578bd9e"), Spells.Instances.Creation.ID);
                    and.GainSpecificSpell(Guid.Parse("172fc855-5472-40fe-ad17-c33637ff6228"), Spells.Instances.Banishment.ID);
                    and.GainSpecificSpell(Guid.Parse("69366533-fc81-4fcb-b3c9-dc6bce4f3112"), Spells.Instances.TrueSeeing.ID);
                    and.GainSpecificSpell(Guid.Parse("d6902474-a7a6-41b3-8d76-cef7b049d111"), Spells.Instances.EnergyAegis.ID);
                    and.GainSpecificSpell(Guid.Parse("a2da5ce8-76bc-479e-bb51-ed9b40073293"), Spells.Instances.ScintillatingPattern.ID);
                    and.GainSpecificSpell(Guid.Parse("681617fc-3a10-4de0-9850-7ebf06f4ff7c"), Spells.Instances.ResplendentMansion.ID);
                });

                or.AddAnd(Guid.Parse("45029a44-0dca-4185-9bb3-87f141825028"), and =>
                {
                    and.GainSpecificSpell(Guid.Parse("a9ac4c94-b7da-4ab0-a8e5-5e2b2279df54"), Spells.Instances.GeniesVeil.ID);
                    and.GainSpecificSpell(Guid.Parse("a6d84eea-ad32-4d5d-9fd2-d39cc138ae03"), Spells.Instances.DetectMagic.ID);
                    and.GainSpecificSpell(Guid.Parse("1e9c4790-9f0c-421f-9643-a4c388362c88"), Spells.Instances.IllusoryDisguise.ID);
                    and.GainSpecificSpell(Guid.Parse("3a79a85a-c0b1-4db0-be37-fa05c029de78"), Spells.Instances.Invisibility.ID);
                    and.GainSpecificSpell(Guid.Parse("3fc94004-f56e-49d6-89f3-6d6b3273a05d"), Spells.Instances.Enthrall.ID);
                    and.GainSpecificSpell(Guid.Parse("bd51d2cc-2c01-497f-8c90-1489769a600c"), Spells.Instances.Creation.ID);
                    and.GainSpecificSpell(Guid.Parse("fca3b89a-14c2-4d9b-a822-9a3c03d231e5"), Spells.Instances.IllusoryScene.ID);
                    and.GainSpecificSpell(Guid.Parse("ead95a6e-833a-4764-b0ba-e5a5088f7fa4"), Spells.Instances.TrueSeeing.ID);
                    and.GainSpecificSpell(Guid.Parse("d910610a-b38c-4f26-8643-9416cdeb7ebe"), Spells.Instances.EnergyAegis.ID);
                    and.GainSpecificSpell(Guid.Parse("2d7f845a-7361-4fd8-a202-50af52a6cf48"), Spells.Instances.PunishingWinds.ID);
                    and.GainSpecificSpell(Guid.Parse("abfab7b5-b297-4464-8f1b-b37f165a1849"), Spells.Instances.ResplendentMansion.ID);
                });

                or.AddAnd(Guid.Parse("42852762-3d69-4dee-bd43-01501a789911"), and =>
                {
                    and.GainSpecificSpell(Guid.Parse("1e31a729-c097-4e2f-b214-bdbd8f8c344a"), Spells.Instances.GeniesVeil.ID);
                    and.GainSpecificSpell(Guid.Parse("ddb24e22-042c-4a4c-b317-0201a7e30827"), Spells.Instances.DetectMagic.ID);
                    and.GainSpecificSpell(Guid.Parse("135047d1-62f0-4cc2-b489-07eed194e2d4"), Spells.Instances.IllusoryDisguise.ID);
                    and.GainSpecificSpell(Guid.Parse("e931959d-1f86-4143-98c1-169edb47b9ea"), Spells.Instances.Enlarge.ID);
                    and.GainSpecificSpell(Guid.Parse("64afb52f-9d37-4d19-a056-599ea7585f36"), Spells.Instances.Enthrall.ID);
                    and.GainSpecificSpell(Guid.Parse("474123c2-59f0-49e5-8482-48c72cab0ecd"), Spells.Instances.Creation.ID);
                    and.GainSpecificSpell(Guid.Parse("43482f09-e44f-4081-a951-41e5ec8dc44d"), Spells.Instances.ElementalForm.ID, "Only the Fire elemental form can be used.");
                    and.GainSpecificSpell(Guid.Parse("e22b4c76-5afb-4022-bc91-db2c6df97049"), Spells.Instances.TrueSeeing.ID);
                    and.GainSpecificSpell(Guid.Parse("9d4312e1-8e14-48cf-9854-598f848a87ae"), Spells.Instances.EnergyAegis.ID);
                    and.GainSpecificSpell(Guid.Parse("e641197e-51a1-42fa-a988-940109890cf1"), Spells.Instances.Maze.ID);
                    and.GainSpecificSpell(Guid.Parse("db5dba65-4b76-4641-8fe1-d85279fc9fb5"), Spells.Instances.ResplendentMansion.ID);
                });

                or.AddAnd(Guid.Parse("bfefd918-9ff9-4f7e-ba80-1aadd0b0ea61"), and =>
                {
                    and.GainSpecificSpell(Guid.Parse("98ab0466-e467-412f-a822-ab5dd5936521"), Spells.Instances.GeniesVeil.ID);
                    and.GainSpecificSpell(Guid.Parse("45269cc0-2e4a-4cfb-bc8c-82c200b7c271"), Spells.Instances.DetectMagic.ID);
                    and.GainSpecificSpell(Guid.Parse("1ebe5666-1a03-44b9-9202-4466355dc879"), Spells.Instances.IllusoryDisguise.ID);
                    and.GainSpecificSpell(Guid.Parse("e52ccdd0-5936-47d9-a3f2-4448fe57e021"), Spells.Instances.WaterWalk.ID);
                    and.GainSpecificSpell(Guid.Parse("50257020-5b00-4ce9-afff-12eaf5575820"), Spells.Instances.Enthrall.ID);
                    and.GainSpecificSpell(Guid.Parse("d5d49754-4f85-46e1-b926-d282c180641d"), Spells.Instances.Creation.ID);
                    and.GainSpecificSpell(Guid.Parse("ae236500-fed3-4358-9102-f475205e065c"), Spells.Instances.ControlWater.ID);
                    and.GainSpecificSpell(Guid.Parse("e4d60ca0-b861-42f0-a8df-d3ef1e1bcd5f"), Spells.Instances.TrueSeeing.ID);
                    and.GainSpecificSpell(Guid.Parse("a315f493-f68f-45d6-954e-67df958976c8"), Spells.Instances.EnergyAegis.ID);
                    and.GainSpecificSpell(Guid.Parse("181e547e-aba4-4145-b1dd-ec33620ea0fb"), Spells.Instances.HorridWilting.ID);
                    and.GainSpecificSpell(Guid.Parse("d4d5caa6-270c-48e5-ac8e-4541b092e7dc"), Spells.Instances.ResplendentMansion.ID);
                });

                or.AddAnd(Guid.Parse("6c205205-2a4a-44c0-9bf9-ea08b8f82c89"), and =>
                {
                    and.GainSpecificSpell(Guid.Parse("90a1f24c-7efb-4c12-aaca-c4229649cfd3"), Spells.Instances.GeniesVeil.ID);
                    and.GainSpecificSpell(Guid.Parse("5b11db1b-fb8d-4fd9-afc7-8f57c8046023"), Spells.Instances.DetectMagic.ID);
                    and.GainSpecificSpell(Guid.Parse("0bb77c8f-d608-4ed7-b125-6a933251acd1"), Spells.Instances.IllusoryDisguise.ID);
                    and.GainSpecificSpell(Guid.Parse("32952edd-b37e-4302-8779-37d7720a673b"), Spells.Instances.Glitterdust.ID);
                    and.GainSpecificSpell(Guid.Parse("a23ae1ce-c06b-4b5e-ad2e-d2b9a437a81f"), Spells.Instances.Enthrall.ID);
                    and.GainSpecificSpell(Guid.Parse("ffa75ca6-c14c-44e6-85ac-85a069f2b369"), Spells.Instances.Creation.ID);
                    and.GainSpecificSpell(Guid.Parse("b97f41e5-4577-4dbb-9571-c5faddc95309"), Spells.Instances.WallOfStone.ID);
                    and.GainSpecificSpell(Guid.Parse("5c205452-e406-439e-a22a-f742338e137c"), Spells.Instances.TrueSeeing.ID);
                    and.GainSpecificSpell(Guid.Parse("ea461f7b-7ba8-4e23-899f-99ffcfdad05b"), Spells.Instances.EnergyAegis.ID);
                    and.GainSpecificSpell(Guid.Parse("ddc59693-2bb1-425b-86a5-00be2c11f3e7"), Spells.Instances.Earthquake.ID);
                    and.GainSpecificSpell(Guid.Parse("734d38e8-672e-4d3d-82b9-3e25c73ab52f"), Spells.Instances.ResplendentMansion.ID);
                });
            });
        }

        protected override IEnumerable<Guid> GetSkills()
        {
            yield return Skills.Instances.Arcana.ID;
            yield return Skills.Instances.Deception.ID;
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("99cbfc56-11c1-4468-856a-d0a80ff67b52"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = 138
            };
        }
    }
}
