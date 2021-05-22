using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Utilities.Tables;
using Silvester.Pathfinder.Official.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Spells.Instances
{
    public class PrismaticSpray : Template
    {
        public static readonly Guid ID = Guid.Parse("c402eb7e-7482-473e-a93c-a00ae2aa6443");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Prismatic Spray",
                Level = 7,
                Area = "30-foot cone.",
                SpellTypeId = SpellTypes.Instances.Spell.ID,
                ActionTypeId = ActionTypes.Instances.TwoActions.ID,
                MagicSchoolId = MagicSchools.Instances.Evocation.ID
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("f40f0373-5862-432b-8952-301f50ce95fb"), Type = TextBlockType.Text, Text = "A spray of rainbow light beams cascades from your open hand. Each creature in the area must roll 1d8 on the table below to see which beam affects it, then attempt a saving throw of the indicated type. The table notes any additional traits that apply to each type of ray. If a creature is struck by multiple beams, it uses the same d20 result for all its saving throws. For all rays, a successful saving throw negates the effect for that creature." };
        }

        protected override Table? GetTable(TableBuilder builder)
        {
            builder
                .AddColumn("6ca123fe-d3de-444e-8e7b-a2312913fd9f", "1d8")
                .AddColumn("09bfd599-c40b-46a7-a20a-9c6462f5b314", "Color")
                .AddColumn("1732bfa4-4f69-4877-8669-a63df0d1fabd", "Save")
                .AddColumn("31d79ecf-61eb-4720-a428-daeb519e4b44", "Effect (Traits)")
                .AddRow("7c351358-cfa8-432e-a9f6-63084994f3a8", row =>
                {
                    row
                        .AddCell("48194501-c45e-4cbc-8627-1f4c0f4d90a2", "1")
                        .AddCell("3713fc47-41a9-47e4-9e53-5747aa62c6a0", "Red")
                        .AddCell("39fa72a0-237e-4880-8f22-1543791d8daa", "Reflex")
                        .AddCell("f643c2ea-e650-4dec-9d43-97b1c1c70125", "50 fire damage (fire).");
                })
                .AddRow("27d3bf9f-c660-45df-9e89-492027a410f1", row =>
                {
                    row
                        .AddCell("aad5596d-15e7-4858-92bf-90426d94c329", "2")
                        .AddCell("633a5e12-13d4-4e88-b522-7437e1544dd4", "Orange")
                        .AddCell("018070e7-ce96-478b-a33e-c4ff41857977", "Reflex")
                        .AddCell("838afa4e-e2bc-4e9b-8362-f61f365aa991", "60 acid damage (acid).");
                })
                .AddRow("7e4fd6be-c972-4977-b727-28df2acf32e6", row =>
                {
                    row
                        .AddCell("2c53e992-d67c-4aed-a997-50302f3e7da9", "3")
                        .AddCell("66252eaa-f04f-4b90-a442-60f25bad3ee2", "Yellow")
                        .AddCell("88da78e9-8b2c-488d-a85e-95840a9a186d", "Reflex")
                        .AddCell("095791cf-28a0-4b20-9e4a-4479a9041081", "70 electricity damage (electricity).");
                })
                .AddRow("3fdca9cd-e3d4-49df-9482-32a3c38f7051", row =>
                {
                    row
                        .AddCell("f513949f-95bf-48ad-9139-5da25b60f919", "4")
                        .AddCell("2c3b1ba1-a50c-4a4d-88c8-8da50ac12dbb", "Green")
                        .AddCell("96a3d2db-6df7-4d9e-8e24-5caa1c39fbb7", "Fortitude")
                        .AddCell("7d31be5d-f364-48ae-a04c-54d0e2745bf7", "30 poison damage and enfeebled 1 for 1 minute (poison).");
                })
                .AddRow("51558f46-046a-48e2-8dcc-201b8a9888f7", row =>
                {
                    row
                        .AddCell("d10ca47c-420e-423e-9a7b-811629baef3c", "5")
                        .AddCell("b555850e-ec50-4d7d-9adb-388d9d4dc764", "Blue")
                        .AddCell("245575a1-44b4-44c5-be5c-fdd493757edc", "Fortitude")
                        .AddCell("c56ff7d5-f181-4f85-ac30-5bb35552d772", "Affected as if by flesh to stone.");
                })
                .AddRow("8d9bc647-5119-4bdd-85ea-bd3eedda5d03", row =>
                {
                    row
                        .AddCell("07708ee5-0ac7-4ba6-b10c-242d5a3232f8", "6")
                        .AddCell("9cd860fd-5ddd-4e00-8537-e5255da00cdb", "Indigo")
                        .AddCell("7e25ca2e-d2af-4c50-b5a2-1c9a29e37e2d", "Will")
                        .AddCell("3e3e0c77-f4b0-443c-b9d3-66b261bcc88b", "Confused, as the warp mind spell (mental).");
                })
                .AddRow("79860964-d0ec-4234-b0ed-abcda815cee6", row =>
                {
                    row
                        .AddCell("4dc94d09-7ef3-4951-9c3e-beeb8dddcbf0", "7")
                        .AddCell("3ae421de-cd42-4620-8a6f-9504ab7652bd", "Violet")
                        .AddCell("19d981f4-68b8-49c9-b9e4-b51f7b748f7f", "Will")
                        .AddCell("3c856f4f-caac-4db3-b4f7-2c76e2893f03", "Slowed 1 for 1 minute; if a critical failure, sent to another plane, as plane shift (teleportation).");
                })
                .AddRow("40e8b921-e62c-4ed0-aa8c-e93e7334152e", row =>
                {
                    row
                        .AddCell("63c16510-4d11-439d-8179-e3e8dd45786d", "8")
                        .AddCell("f5a5715f-b496-4bca-a2f2-5e52964753fa", "Potent Beam")
                        .AddCell("131297f2-aaab-458e-91d0-ca1e3278ff60", "-")
                        .AddCell("fc30d3e9-7541-4fb6-9a8b-530e4c26e3d1", "Affected by two beams - roll twice, rerolling any duplicates or results of 8.");
                });

            return builder.Build("755b85a4-3292-4c5e-b898-f89e5e06e9b1");
        }

        public override IEnumerable<Guid> GetSpellComponents()
        {
            yield return SpellComponents.Instances.Somatic.ID;
            yield return SpellComponents.Instances.Verbal.ID;
        }

        public override IEnumerable<Guid> GetMagicTraditions()
        {
            yield return MagicTraditions.Instances.Arcane.ID;
            yield return MagicTraditions.Instances.Occult.ID;
        }

        public override IEnumerable<Guid> GetTraits()
        {
            yield return Traits.Instances.Evocation.ID;
            yield return Traits.Instances.Light.ID;
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("2fc01dc2-1372-4239-92c7-b41d7c9413e9"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 360
            };
        }
    }
}
