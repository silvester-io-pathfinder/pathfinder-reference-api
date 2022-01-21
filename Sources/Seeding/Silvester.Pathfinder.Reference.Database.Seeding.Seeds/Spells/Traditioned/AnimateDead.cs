using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.Traits;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Spells.Instances
{
    public class AnimateDead : Template
    {
        public static readonly Guid ID = Guid.Parse("e3b20a74-a9ee-4040-845b-9a8952da99b4");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Animate Dead",
                Level = 1,
                Range = "30 feet.",
                IsDismissable = true,
                Duration = "Sustained up to 1 minute.",
                SpellTypeId = SpellTypes.Instances.Spell.ID,
                ActionTypeId = ActionTypes.Instances.ThreeActions.ID,
                MagicSchoolId = MagicSchools.Instances.Necromancy.ID
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("bbc6ae9c-5a1d-4de2-9904-4814c40cdfdd"), Type = TextBlockType.Text, Text = "Your magic dredges up a corpse or skeleton and fills it with necromantic life, and you force the dead to fight at your command. You summon a common creature that has the undead trait and whose level is –1; this creature gains the summoned trait. Heightening the spell increases the maximum level of creature you can summon." };
        }

        public override IEnumerable<SpellHeightening> GetHeightenings()
        {
            yield return new SpellHeightening
            {
                Id = Guid.Parse("b3bb18ca-10e7-4de6-82c6-36b18edbe701"),
                Level = "2nd",
                Details =
                {
                    new TextBlock { Id = Guid.Parse("5e5f4aaa-c806-4191-a8b7-05bccabec06a"), Type = TextBlockType.Text, Text = "The creature's level is level 1." }
                }
            };

            yield return new SpellHeightening
            {
                Id = Guid.Parse("9bb21265-78fc-495e-8867-a5d696febd32"),
                Level = "3rd",
                Details =
                {
                    new TextBlock { Id = Guid.Parse("18487951-0b54-456e-906c-69706d30e295"), Type = TextBlockType.Text, Text = "The creature's level is level 2." }
                }
            };

            yield return new SpellHeightening
            {
                Id = Guid.Parse("f9838c28-98b9-4361-8d1c-462e78299ab9"),
                Level = "4th",
                Details =
                {
                    new TextBlock { Id = Guid.Parse("8ad99ed5-5058-40b8-83fe-439a052024b6"), Type = TextBlockType.Text, Text = "The creature's level is level 3." }
                }
            };

            yield return new SpellHeightening
            {
                Id = Guid.Parse("082e7c2f-ec86-4837-afb1-318e85e3b294"),
                Level = "5th",
                Details =
                {
                    new TextBlock { Id = Guid.Parse("0d22cbe3-9e74-466c-9460-b459c1549e65"), Type = TextBlockType.Text, Text = "The creature's level is level 5." }
                }
            };

            yield return new SpellHeightening
            {
                Id = Guid.Parse("dec685c4-edc8-4b62-aefd-c03a6f7f9bd5"),
                Level = "6th",
                Details =
                {
                    new TextBlock { Id = Guid.Parse("d6db73fc-2e42-4fd9-9c71-a73c116f00d6"), Type = TextBlockType.Text, Text = "The creature's level is level 7." }
                }
            };

            yield return new SpellHeightening
            {
                Id = Guid.Parse("67db2547-4d42-45ab-9892-fb275c5089d8"),
                Level = "7th",
                Details =
                {
                    new TextBlock { Id = Guid.Parse("4c9ad91d-e3e4-4eaf-9386-4b6afa276b3b"), Type = TextBlockType.Text, Text = "The creature's level is level 9." }
                }
            };

            yield return new SpellHeightening
            {
                Id = Guid.Parse("3fd0072c-92d8-468f-8bc1-f96aa3f5fe80"),
                Level = "8th",
                Details =
                {
                    new TextBlock { Id = Guid.Parse("97764a66-9d13-4d65-ada2-969ebb66e681"), Type = TextBlockType.Text, Text = "The creature's level is level 11." }
                }
            };

            yield return new SpellHeightening
            {
                Id = Guid.Parse("f9543f3e-8805-4280-8d63-64a376985c9d"),
                Level = "9th",
                Details =
                {
                    new TextBlock { Id = Guid.Parse("c9f44428-7bce-4dac-adbf-3b9df034f826"), Type = TextBlockType.Text, Text = "The creature's level is level 13." }
                }
            };

            yield return new SpellHeightening
            {
                Id = Guid.Parse("4767097d-b48b-4efd-9dc0-9e5290f95250"),
                Level = "10th",
                Details =
                {
                    new TextBlock { Id = Guid.Parse("9ffb4021-a330-45c3-9476-f82bc11e443c"), Type = TextBlockType.Text, Text = "The creature's level is level 15." }
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
            yield return MagicTraditions.Instances.Arcane.ID;
            yield return MagicTraditions.Instances.Divine.ID;
            yield return MagicTraditions.Instances.Occult.ID;
        }

        public override void GetTraits(ITraitBindingBuilder<SpellTraitBinding, Spell> builder)
        {
            builder.Add(Guid.Parse("716c8d37-5dd7-4f80-b929-01d6c83f857a"), Traits.Instances.Necromancy.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("ba72f9e1-db95-4ed6-8be1-185a0d8f2fd6"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = 214
            };
        }
    }
}
