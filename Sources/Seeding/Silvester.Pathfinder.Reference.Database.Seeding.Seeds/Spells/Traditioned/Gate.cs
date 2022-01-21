using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.Traits;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Spells.Instances
{
    public class Gate : Template
    {
        public static readonly Guid ID = Guid.Parse("7b790e8c-c322-4424-b92d-4835b0efb5d5");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Gate",
                Level = 10,
                Range = "120 feet.",
                IsDismissable = true,
                Duration = "Sustained up to 1 minute.",
                SpellTypeId = SpellTypes.Instances.Spell.ID,
                ActionTypeId = ActionTypes.Instances.TwoActions.ID,
                MagicSchoolId = MagicSchools.Instances.Conjuration.ID
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("fa39e9af-2830-4121-a306-162feee935e6"), Type = TextBlockType.Text, Text = "You tear open a rift to another plane, creating a portal that creatures can travel through in either direction. This portal is vertical and circular, with a radius of 40 feet. The portal appears at a location of your choice on the destination plane, assuming you have a clear idea of both the destination's location on the plane and what the destination looks like. If you attempt to create a gate into or out of the realm of a deity or another powerful being, that being can prevent the gate from forming." };
        }

        public override IEnumerable<Guid> GetSpellComponents()
        {
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
            builder.Add(Guid.Parse("01a030e1-04d0-4bb0-ba72-1a819bb6ba1d"), Traits.Instances.Uncommon.ID);
            builder.Add(Guid.Parse("f1d05b25-30da-4518-b2b0-a001f5fe0340"), Traits.Instances.Conjuration.ID);
            builder.Add(Guid.Parse("11fd19c1-0f25-4727-89c8-a68d2c5489dc"), Traits.Instances.Transmutation.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("15d1cae4-0d1a-45c9-8e71-a4dcfacca2f1"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 340
            };
        }
    }
}
