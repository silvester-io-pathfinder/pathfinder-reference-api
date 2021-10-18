using Silvester.Pathfinder.Reference.Database.Models;
using Silvester.Pathfinder.Reference.Database.Utilities.Tables;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Spells.Instances
{
    public class DragonBreath : Template
    {
        public static readonly Guid ID = Guid.Parse("0c2b9b3a-9489-4f8b-88ef-8633d2cd214d");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Dragon Breath",
                Level = 3,
                Area = "30-foot cone or 60-foot line originating from you.",
                IsSavingThrowBasic = true,
                SavingThrowStatId = SavingThrowStats.Instances.Reflex.ID,
                ActionTypeId = ActionTypes.Instances.TwoActions.ID,
                ClassId = Classes.Instances.Sorcerer.ID,
                SpellTypeId = SpellTypes.Instances.Focus.ID,
                MagicSchoolId = MagicSchools.Instances.Evocation.ID
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("92f065ff-4e7b-46d3-b9bc-4fa5be53d80e"), Type = TextBlockType.Text, Text = "You spew energy from your mouth, dealing 5d6 damage. The area, damage type, and save depend on the dragon type in your bloodline." };
        }

        public override IEnumerable<SpellHeightening> GetHeightenings()
        {
            yield return new SpellHeightening
            {
                Id = Guid.Parse("2a41051c-9de6-4552-bbfb-5c8ff1e58568"),
                Level = "+1",
                Details =
                {
                    new TextBlock { Id = Guid.Parse("6656ffc5-f0d8-4009-a69b-dbe99f7df64b"), Type = TextBlockType.Text, Text = "The damage increases by 2d6." }
                }
            };
        }

        protected override Table? GetTable(TableBuilder builder)
        {
            builder
                .AddColumn("8d4fe099-9f43-4beb-bdeb-fe0c65c8666b", "Dragon Type")
                .AddColumn("f4328fbe-dd26-4f0b-ba0a-7a2b780f06d1", "Area and Damage Type")
                .AddColumn("949bd8f3-fee0-4528-bca2-cf1bf56e029f", "Saving Throw")
                .AddRow("1799cadc-8298-4e3f-a2c9-855595bc24ad", row =>
                {
                    row
                        .AddCell("dde93aa0-7bc6-414d-9ae0-81c68aae7d47", "Black or copper.")
                        .AddCell("bbb57cfd-ab60-42dd-9d94-4c8590dd7f17", "60-foot line of acid.")
                        .AddCell("ba302e6a-e058-4f06-893e-98e2bf35cc21", "Reflex.");
                })
                .AddRow("0e106283-258f-43f0-8380-472280606c9d", row =>
                {
                    row
                        .AddCell("e2610661-da07-4b77-952f-fe74d6b06bd9", "Blue or bronze.")
                        .AddCell("6e110940-8204-4035-86c2-7d03281fd3cd", "60-foot line of electricity.")
                        .AddCell("6c7a16a9-0cbf-4e1b-bf91-35ad0bc82b27", "Reflex");
                })
                .AddRow("bd5b21d2-e886-4c88-89f6-71e8a916a1ff", row =>
                {
                    row
                        .AddCell("f6caf324-1e2f-480b-879c-dc76ae1e157f", "Brass.")
                        .AddCell("02569c93-391e-4a66-a5ec-12192479af36", "60-foot line of fire.")
                        .AddCell("4977716e-9d7d-40f1-b60a-b173eb49c23c", "Reflex");
                })
                .AddRow("74a876fa-6879-496d-8d73-4648de1b014c", row =>
                {
                    row
                        .AddCell("22e85977-bb8d-4ed7-ad61-7722c9b63e40", "Green.")
                        .AddCell("e07a7a6d-ec7e-4e76-ad99-b871258f0ba3", "30-foot cone of poison.")
                        .AddCell("3424fbaf-7caa-4204-a44e-dc388130a449", "Fortitude");
                })
                .AddRow("a6d13064-96bc-4ef8-9c10-f355b69a773b", row =>
                {
                    row
                        .AddCell("c89542bb-4f57-4443-8f68-9663596f81c2", "Gold or red.")
                        .AddCell("d0f69b66-154d-4c35-a8c4-e2b98f2090c1", "30-foot cone of fire.")
                        .AddCell("7eeb0641-a92b-402c-9cdf-8b3b284a3f68", "Reflex");
                })
                .AddRow("f273d613-2e9b-4628-8e46-798ba6769c28", row =>
                {
                    row
                        .AddCell("0db1ef65-66e9-472e-8a8d-b4bbfe20c103", "Silver or white.")
                        .AddCell("d07c9ade-1a62-4961-8a0c-d4730a1db098", "30-foot cone of cold.")
                        .AddCell("c6cf8ab9-c13a-4196-9501-459ec2be5c85", "Reflex");
                });

            return builder.Build("8f257a22-51a5-4dfd-994b-cf61347a5f58");
        }

        public override IEnumerable<Guid> GetSpellComponents()
        {
            yield return SpellComponents.Instances.Somatic.ID;
            yield return SpellComponents.Instances.Verbal.ID;
        }

        public override IEnumerable<Guid> GetTraits()
        {
            yield return Traits.Instances.Uncommon.ID;
            yield return Traits.Instances.Evocation.ID;
            yield return Traits.Instances.Sorcerer.ID;
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("3af4b25b-ec24-44ff-8ddb-7fca8ae95697"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 403
            };
        }
    }
}
