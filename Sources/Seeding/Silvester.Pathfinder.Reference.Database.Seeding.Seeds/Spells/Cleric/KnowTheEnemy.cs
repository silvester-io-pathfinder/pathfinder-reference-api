using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.Traits;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Spells.Instances
{
    public class KnowTheEnemy : Template
    {
        public static readonly Guid ID = Guid.Parse("5377e30c-90c3-4782-9684-7f460c199538");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Know the Enemy",
                Level = 4,
                Trigger = "You roll initiative and can see a creature, you succeed at an attack roll against a creature, or a creature fails a saving throw against one of your spells.",
                DomainId = Domains.Instances.Knowledge.ID,
                ActionTypeId = ActionTypes.Instances.Reaction.ID,
                ClassId = Classes.Instances.Cleric.ID,
                SpellTypeId = SpellTypes.Instances.Focus.ID,
                MagicSchoolId = MagicSchools.Instances.Divination.ID
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("5f1933d7-ca3c-4034-9127-84bbe463d0fb"), Type = TextBlockType.Text, Text = "You quickly remind yourself of useful information. Use a Recall Knowledge action, rolling the appropriate skill check to identify the triggering creature's abilities. You can roll your check twice and use the better result." };
        }

        public override IEnumerable<Guid> GetSpellComponents()
        {
            yield return SpellComponents.Instances.Somatic.ID;
        }

        public override void GetTraits(ITraitBindingBuilder<SpellTraitBinding, Spell> builder)
        {
            builder.Add(Guid.Parse("efab4446-55e7-456a-bf00-472748a9ae40"), Traits.Instances.Uncommon.ID);
            builder.Add(Guid.Parse("b646800a-d4c1-4b97-b766-48776d6c45bc"), Traits.Instances.Cleric.ID);
            builder.Add(Guid.Parse("a5cfd0f5-2f7c-4bfd-b949-ccb08d64eee5"), Traits.Instances.Divination.ID);
            builder.Add(Guid.Parse("6129566a-a2e2-434d-9746-d6d568dd218d"), Traits.Instances.Fortune.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("f2379800-6016-4cfa-8b72-6557a727d560"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 393
            };
        }
    }
}
