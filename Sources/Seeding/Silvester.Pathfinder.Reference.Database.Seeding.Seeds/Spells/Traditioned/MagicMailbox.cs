using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.Traits;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Spells.Instances
{
    public class MagicMailbox : Template
    {
        public static readonly Guid ID = Guid.Parse("bae1751b-d794-4979-8d61-cef630d3874a");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Magic Mailbox",
                Level = 4,
                Range = "Touch.",
                Duration = "Until your next daily preparations.",
                Targets = "2 containers, each no larger than 5 feet in any dimension.",
                CastTime = "1 hour.",
                SpellTypeId = SpellTypes.Instances.Spell.ID,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                MagicSchoolId = MagicSchools.Instances.Conjuration.ID,
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("a7cbf8d2-199e-42df-9b90-8580ceafc5e6"), Type = TextBlockType.Text, Text = "You create an interdimensional link between two containers, both of which must be capable of being closed in such a way that their contents aren't visible. If both containers are left closed for 10 consecutive minutes, the contents of each one, totaling no more than 3 Bulk of nonliving, non-magical material per container, transport to the other's location. If a container's contents total more than 3 Bulk, the transport fails." };
            yield return new TextBlock { Id = Guid.Parse("71784742-9936-4fc7-9c06-a7cde804c234"), Type = TextBlockType.Text, Text = "If either container is opened before the full 10 minutes have elapsed, the contents appear as they did when the containers were closed, and the process starts anew as soon as both containers have been closed. After the contents of the containers successfully swap, they can't swap again until after both containers have been opened at least once. Both containers must be located on the same plane for the process to function; if this ceases to be the case or if something else disrupts the effect during an active transposition, the process halts as if one of the containers had been opened." };
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
            builder.Add(Guid.Parse("94fbd196-bbdb-49ac-8544-31f703bad692"), Traits.Instances.Uncommon.ID);
            builder.Add(Guid.Parse("42a1443b-f0be-4a74-afcf-0ff84cdd1e4c"), Traits.Instances.Conjuration.ID);
            builder.Add(Guid.Parse("f6fd1f37-6bfd-41f5-85b6-0c48ba7d61d4"), Traits.Instances.Teleportation.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("a9a1a8ce-5f1e-4b1e-9abe-5929daf00bf6"),
                SourceId = Sources.Instances.SecretsOfMagic.ID,
                Page = 114
            };
        }
    }
}
