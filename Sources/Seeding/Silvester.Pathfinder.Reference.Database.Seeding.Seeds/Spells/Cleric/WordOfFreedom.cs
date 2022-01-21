using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.Traits;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Spells.Instances
{
    public class WordOfFreedom : Template
    {
        public static readonly Guid ID = Guid.Parse("e9aee3ed-b52d-425f-89c6-e557c7cc0cc4");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Word of Freedom",
                Level = 4,
                Range = "30 feet.",
                Duration = "1 round.",
                Targets = "1 creature.",
                DomainId = Domains.Instances.Freedom.ID,
                ActionTypeId = ActionTypes.Instances.OneAction.ID,
                ClassId = Classes.Instances.Cleric.ID,
                SpellTypeId = SpellTypes.Instances.Focus.ID,
                MagicSchoolId = MagicSchools.Instances.Enchantment.ID
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("21c9d5a8-d2db-415b-9a8f-9634dbc2c0ba"), Type = TextBlockType.Text, Text = "You utter a liberating word of power that frees a creature. You suppress one of the following conditions of your choice: confused, frightened, grabbed, or paralyzed. The target isn't affected by the chosen condition, and if you suppress the grabbed condition, the target automatically breaks free from any grab affecting it when you Cast the Spell." };
            yield return new TextBlock { Id = Guid.Parse("0bb480e3-2efa-43f9-87e3-d1d5ab1552a3"), Type = TextBlockType.Text, Text = "If you don't remove the effect that provided the condition, the condition returns after the spell ends. For example, if a spell was making the target confused for 1 minute, word of freedom would let the target act normally for a round, but the confused condition would return afterward." };
        }

        public override IEnumerable<Guid> GetSpellComponents()
        {
            yield return SpellComponents.Instances.Verbal.ID;
        }

        public override void GetTraits(ITraitBindingBuilder<SpellTraitBinding, Spell> builder)
        {
            builder.Add(Guid.Parse("bcef5def-bd4a-401e-af28-9db83ce4d568"), Traits.Instances.Uncommon.ID);
            builder.Add(Guid.Parse("d5a6f8b8-6eb5-4c44-a2d9-533a787b8935"), Traits.Instances.Cleric.ID);
            builder.Add(Guid.Parse("86156955-70b9-4f92-ae29-75a8fdde55ab"), Traits.Instances.Enchantment.ID);
            builder.Add(Guid.Parse("74c5ab9a-49a6-45e6-ab57-2c140ff8d083"), Traits.Instances.Mental.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("7256f152-dd1a-4063-b6aa-6908e83c0d44"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 399
            };
        }
    }
}
