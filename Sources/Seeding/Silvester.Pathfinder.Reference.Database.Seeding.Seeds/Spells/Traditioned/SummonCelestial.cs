using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.Traits;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Spells.Instances
{
    public class SummonCelestial : Template
    {
        public static readonly Guid ID = Guid.Parse("3ba05e95-d555-4604-be1e-7dc79909d3c2");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Summon Celestial",
                Level = 5,
                Range = "30 feet.",
                Duration = "Sustained up to 1 minute.",
                SpellTypeId = SpellTypes.Instances.Spell.ID,
                ActionTypeId = ActionTypes.Instances.ThreeActions.ID,
                MagicSchoolId = MagicSchools.Instances.Conjuration.ID
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("ff6ab978-65d2-4673-b87d-01e26c93898b"), Type = TextBlockType.Text, Text = "You conjure a celestial to fight for you. You summon a common creature that has the celestial trait and whose level is 5 or lower, such as those found in Pathfinder Bestiary volumes. Heightening the spell increases the maximum level of creature you can summon." };
        }

        public override IEnumerable<SpellHeightening> GetHeightenings()
        {
            yield return new SpellHeightening
            {
                Id = Guid.Parse("26597ff0-c120-4779-8cda-f8228eb07cba"),
                Level = "2nd",
                Details =
                {
                    new TextBlock { Id = Guid.Parse("334ced20-f751-448c-8f1a-332fcc8a8d15"), Type = TextBlockType.Text, Text = "The summoned creature's level is 1." }
                }
            };

            yield return new SpellHeightening
            {
                Id = Guid.Parse("6fbc6b41-9db9-4317-b9be-c345a66bf1ce"),
                Level = "3rd",
                Details =
                {
                    new TextBlock { Id = Guid.Parse("ecdfd898-032c-457c-89c6-3a4392953e38"), Type = TextBlockType.Text, Text = "The summoned creature's level is 2." }
                }
            };

            yield return new SpellHeightening
            {
                Id = Guid.Parse("68894058-c1b6-4e11-a9f3-dc1f40598c7f"),
                Level = "4th",
                Details =
                {
                    new TextBlock { Id = Guid.Parse("f02d8bf6-19fe-4603-9fe2-7796c0136d99"), Type = TextBlockType.Text, Text = "The summoned creature's level is 3." }
                }
            };

            yield return new SpellHeightening
            {
                Id = Guid.Parse("5d643f61-cd82-4e50-9a0b-58a6f9a79302"),
                Level = "5th",
                Details =
                {
                    new TextBlock { Id = Guid.Parse("38a2cdb3-2e4d-49d8-9cac-35c69d1cc1db"), Type = TextBlockType.Text, Text = "The summoned creature's level is 5." }
                }
            };

            yield return new SpellHeightening
            {
                Id = Guid.Parse("bff0a22c-b381-4980-9def-0a3d91dd8228"),
                Level = "6th",
                Details =
                {
                    new TextBlock { Id = Guid.Parse("a48786b4-8f34-4a70-ba5a-cb00fa44746b"), Type = TextBlockType.Text, Text = "The summoned creature's level is 7." }
                }
            };

            yield return new SpellHeightening
            {
                Id = Guid.Parse("acee8164-fad0-40e0-810c-439a5761fe26"),
                Level = "7th",
                Details =
                {
                    new TextBlock { Id = Guid.Parse("214b4d19-acaf-433b-9fa9-d7092fde0c2f"), Type = TextBlockType.Text, Text = "The summoned creature's level is 9." }
                }
            };

            yield return new SpellHeightening
            {
                Id = Guid.Parse("c8810026-ecfb-4cfe-ba29-bb48f6a05155"),
                Level = "8th",
                Details =
                {
                    new TextBlock { Id = Guid.Parse("3659485b-730f-458a-906b-b56627d7ea7e"), Type = TextBlockType.Text, Text = "The summoned creature's level is 11." }
                }
            };

            yield return new SpellHeightening
            {
                Id = Guid.Parse("9761c7e1-6f1c-45f0-8693-a9a33f3f66d7"),
                Level = "9th",
                Details =
                {
                    new TextBlock { Id = Guid.Parse("17b907f1-aedf-4083-af8a-d3fd689cb2ca"), Type = TextBlockType.Text, Text = "The summoned creature's level is 13." }
                }
            };

            yield return new SpellHeightening
            {
                Id = Guid.Parse("fc113e06-9141-435a-9627-6a95a1e3eac9"),
                Level = "10th",
                Details =
                {
                    new TextBlock { Id = Guid.Parse("b6ce0a0e-8965-4228-9031-144614b42ea6"), Type = TextBlockType.Text, Text = "The summoned creature's level is 15." }
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
            yield return MagicTraditions.Instances.Primal.ID;
        }

        public override void GetTraits(ITraitBindingBuilder<SpellTraitBinding, Spell> builder)
        {
            builder.Add(Guid.Parse("8d56ca99-9b88-44fd-801c-e9906f58d82c"), Traits.Instances.Conjuration.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("1f33cf7a-5cd4-4a80-abbd-c16d806a7bd8"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 375
            };
        }
    }
}
