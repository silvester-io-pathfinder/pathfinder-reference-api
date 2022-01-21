using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.Traits;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Spells.Instances
{
    public class Clairaudience : Template
    {
        public static readonly Guid ID = Guid.Parse("484d98ad-91d1-4b2d-86d0-ec997a6f772b");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Clairaudience",
                Level = 3,
                Range = "500 feet.",
                CastTime = "1 minute.",
                Duration = "10 minutes.",
                SpellTypeId = SpellTypes.Instances.Spell.ID,
                ActionTypeId = ActionTypes.Instances.LongAction.ID,
                MagicSchoolId = MagicSchools.Instances.Divination.ID,
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("904c4278-3e9a-4846-8443-0b3aa0717974"), Type = Utilities.Text.TextBlockType.Text, Text = "You create an invisible floating ear at a location within range (even if it's outside your line of sight or line of effect). It can't move, but you can hear through the ear as if using your normal auditory senses." };
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
        }

        public override void GetTraits(ITraitBindingBuilder<SpellTraitBinding, Spell> builder)
        {
            builder.Add(Guid.Parse("b8c9fc8f-9558-49bb-951d-581b908c39f9"), Traits.Instances.Divination.ID);
            builder.Add(Guid.Parse("dbd25d5b-3cda-4f72-9a69-904fd7c6cbc7"), Traits.Instances.Scrying.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("7a027ded-1052-42d9-b74f-075effc40ee5"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 324
            };
        }
    }
}
