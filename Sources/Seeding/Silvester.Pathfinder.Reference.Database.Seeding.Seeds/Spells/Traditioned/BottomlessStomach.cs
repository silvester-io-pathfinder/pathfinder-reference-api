using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.Traits;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Spells.Instances
{
    public class BottomlessStomach : Template
    {
        public static readonly Guid ID = Guid.Parse("a5382240-ebdd-4244-9b15-8f3cfc1f0f47");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Bottomless Stomach",
                Level = 3,
                Range = "Touch.",
                Duration = "1 hour.",
                Targets = "1 willing creature.",
                SpellTypeId = SpellTypes.Instances.Spell.ID,
                ActionTypeId = ActionTypes.Instances.ThreeActions.ID,
                MagicSchoolId = MagicSchools.Instances.Conjuration.ID,
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("8ce1f75a-2cb9-4bdb-8be2-aaf525290ee7"), Type = TextBlockType.Text, Text = "You create a shimmering extradimensional space accessible from the target�s mouth. The space can hold objects and equipment, up to a total of 10 Bulk. This extradimensional storage doesn�t hamper the target�s ability to eat, drink, speak (if applicable), or otherwise act, as it only opens and closes when the target chooses." };
            yield return new TextBlock { Id = Guid.Parse("9b247b75-375b-49d9-9a58-800d11bbaa00"), Type = TextBlockType.Text, Text = "The target can Interact to swallow an object of up to 1 Bulk, which doesn�t harm the object or the target. If the extradimensional space is full, the target can�t add any more objects until first removing one or more stored objects. Organic matter and living creatures can�t be stored in this space. The extradimensional storage is obvious to any creature who looks into the target�s mouth, as the entryway shimmers slightly, though this doesn�t clearly reveal the contents inside." };
            yield return new TextBlock { Id = Guid.Parse("03d9e542-9116-471e-b169-897892c953bd"), Type = TextBlockType.Text, Text = "The target can Interact to spit out a single object of its choice, causing the object to fall to the ground in the target�s space. The target can Interact three times in a row to spit out the entire contents of its extradimensional storage; the target doesn�t have to take these actions all in the same turn, but if it takes any other actions in between, it has to start over. The items eject into the target�s space, possibly spilling out into adjacent spaces if there is too much to fit." };
            yield return new TextBlock { Id = Guid.Parse("b5baca5d-1931-4f74-841c-8269a718f110"), Type = TextBlockType.Text, Text = "When the spell ends or the target falls unconscious, the contents of the extradimensional storage are disgorged in a riotous spew, landing in the nearest unoccupied space, a bit wet but otherwise unharmed." };
        }

        public override IEnumerable<SpellHeightening> GetHeightenings()
        {
            yield return new SpellHeightening
            {
                Id = Guid.Parse("c312cbdb-74d0-4bce-9f26-7fc52944ab57"),
                Level = "5th",
                Details = new TextBlock[]
                {
                    new TextBlock {Id = Guid.Parse("9f3d7731-f7ce-4be1-8608-21fe4971da08"), Type = TextBlockType.Text, Text = "The duration increases to 8 hours." }
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
            yield return MagicTraditions.Instances.Occult.ID;
            yield return MagicTraditions.Instances.Primal.ID;
        }

        public override void GetTraits(ITraitBindingBuilder<SpellTraitBinding, Spell> builder)
        {
            builder.Add(Guid.Parse("69eedade-6033-448a-a7fe-12c5f468737f"), Traits.Instances.Conjuration.ID);
            builder.Add(Guid.Parse("d4079654-6343-4fff-a8cc-bbc97eec45b9"), Traits.Instances.Extradimensional.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("19320a66-2b8a-4f62-bfae-b92b5c493953"),
                SourceId = Sources.Instances.SecretsOfMagic.ID,
                Page = 92
            };
        }
    }
}
