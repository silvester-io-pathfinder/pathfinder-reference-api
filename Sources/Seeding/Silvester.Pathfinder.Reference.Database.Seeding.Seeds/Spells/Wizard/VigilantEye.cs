using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;using System;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.Traits;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Spells.Instances
{
    public class VigilantEye : Template
    {
        public static readonly Guid ID = Guid.Parse("e09acd1c-36c5-482d-be8f-300b90a92a2a");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Vigilant Eye",
                Level = 4,
                Range = "500 feet.",
                Duration = "1 hour.",
                ActionTypeId = ActionTypes.Instances.OneAction.ID,
                ClassId = Classes.Instances.Wizard.ID,
                SpellTypeId = SpellTypes.Instances.Focus.ID,
                MagicSchoolId = MagicSchools.Instances.Divination.ID
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("fd5f857c-2087-4e88-b59b-2d12b1a67d83"), Type = TextBlockType.Text, Text = "You create an invisible eye sensor, as clairvoyance (page 324). When created, this eye must be in your line of sight." };
            yield return new TextBlock { Id = Guid.Parse("23df727e-014c-4a99-adbf-584d61e6899a"), Type = TextBlockType.Text, Text = "When the spell's duration ends, you can spend 1 Focus Point as a free action to extend the duration for another hour, though as normal, it ends immediately during your next daily preparations." };
        }

        public override IEnumerable<Guid> GetSpellComponents()
        {
            yield return SpellComponents.Instances.Somatic.ID;
        }

        public override void GetTraits(ITraitBindingBuilder<SpellTraitBinding, Spell> builder)
        {
            builder.Add(Guid.Parse("ce1d8d02-c8f4-45e3-9ccf-35ef4b1981be"), Traits.Instances.Uncommon.ID);
            builder.Add(Guid.Parse("4bdb097b-dcf6-4b55-ae4f-d9a88d3670d6"), Traits.Instances.Divination.ID);
            builder.Add(Guid.Parse("7aa34964-a497-4733-b718-9d276d145468"), Traits.Instances.Wizard.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("9bc3ef59-2cb2-4fff-867d-7c7581350aa2"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 407
            };
        }
    }
}
