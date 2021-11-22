using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Spells.Instances
{
    public class TempestOfShades : Template
    {
        public static readonly Guid ID = Guid.Parse("331e0a4f-bc8e-48bd-a8b3-44dad0325e02");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Tempest of Shades",
                Level = 7,
                Range = "100 feet.",
                Duration = "Until the end of your next turn.",
                SpellTypeId = SpellTypes.Instances.Spell.ID,
                ActionTypeId = ActionTypes.Instances.ThreeActions.ID,
                MagicSchoolId = MagicSchools.Instances.Necromancy.ID,
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("8bab8bb9-5b2c-40f2-a2ba-8ee6425f6a4f"), Type = TextBlockType.Text, Text = "You channel the forces of undeath to briefly call forth an amalgam of the vengeful dead slain by your enemies and allies alike. This amalgam manifests as a large tornado of insubstantial, howling faces. It occupies the space of a Huge creature and has a Speed of 60 feet." };
            yield return new TextBlock { Id = Guid.Parse("f12f32c9-43fd-458e-8b90-e70a1d76893b"), Type = TextBlockType.Heading, Text = "Arrive (negative)" };
            yield return new TextBlock { Id = Guid.Parse("f5c48540-61a6-4805-978e-270f4a2a5305"), Type = TextBlockType.Text, Text = "Vortex of Death - Each enemy creature within a 60-foot emanation must attempt a Fortitude save with the following effects." };
            yield return new TextBlock { Id = Guid.Parse("b3c06890-e37d-4385-b012-ddac351121ca"), Type = TextBlockType.Enumeration, Text = "Critical Success: The creature is unaffected" };
            yield return new TextBlock { Id = Guid.Parse("2d95b448-03ca-4522-bed4-9a114d067dc4"), Type = TextBlockType.Enumeration, Text = "Success: The creature is drained 1." };
            yield return new TextBlock { Id = Guid.Parse("16e3c338-8a52-4665-8e4a-9e6e33e0e2f9"), Type = TextBlockType.Enumeration, Text = "Failure: The creature is drained 2." };
            yield return new TextBlock { Id = Guid.Parse("8420666a-d516-4cbc-acbb-15fa8119ef68"), Type = TextBlockType.Enumeration, Text = "Critical Failure: The creature is drained 3." };
            yield return new TextBlock { Id = Guid.Parse("e53690cd-474e-4b8a-b54d-729ea5d40d8c"), Type = TextBlockType.Heading, Text = "Depart (emotion, fear, mental)" };
            yield return new TextBlock { Id = Guid.Parse("e9c74b00-9399-4c46-972a-c507929ef973"), Type = TextBlockType.Text, Text = "Howl of Eternity - The vengeful dead lets out an anguished scream. All your enemies within a 100-foot emanation must attempt Will saves with the following effects." };
            yield return new TextBlock { Id = Guid.Parse("e93cfc37-7ae4-4ad7-ae93-d78fed0e0465"), Type = TextBlockType.Enumeration, Text = "Critical: Success The creature is unaffected." };
            yield return new TextBlock { Id = Guid.Parse("c03e55f0-0848-477d-9a25-791d7ee60663"), Type = TextBlockType.Enumeration, Text = "Success: The creature is frightened 1." };
            yield return new TextBlock { Id = Guid.Parse("04e07d08-0f4e-4a05-b3b7-d44aa24ba003"), Type = TextBlockType.Enumeration, Text = "Failure: The creature is frightened 3." };
            yield return new TextBlock { Id = Guid.Parse("0cd0d1e3-f3f6-40f9-8a5c-901cc42da347"), Type = TextBlockType.Enumeration, Text = "Critical Failure: The creature is frightened 3. It�s also fleeing for 1 round or until it�s no longer frightened, whichever comes first." };
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

        public override IEnumerable<Guid> GetTraits()
        {
            yield return Traits.Instances.Incarnate.ID;
            yield return Traits.Instances.Necromancy.ID;
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("698e3ab9-2d84-42eb-be49-9fd6fcdfb8a6"),
                SourceId = Sources.Instances.SecretsOfMagic.ID,
                Page = 135
            };
        }
    }
}
