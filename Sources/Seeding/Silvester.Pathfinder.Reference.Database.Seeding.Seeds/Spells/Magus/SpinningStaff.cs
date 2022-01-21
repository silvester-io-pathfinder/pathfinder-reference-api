using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.Traits;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Spells.Instances
{
    public class SpinningStaff : Template
    {
        public static readonly Guid ID = Guid.Parse("df5bebc3-3988-47d1-9939-d221b0ae9f5b");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Spinning Staff",
                Level = 1,
                Requirements = "You're wielding a staff.",
                ActionTypeId = ActionTypes.Instances.OneAction.ID,
                ClassId = Classes.Instances.Magus.ID,
                SpellTypeId = SpellTypes.Instances.Focus.ID,
                MagicSchoolId = MagicSchools.Instances.Evocation.ID
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("47bcc403-1f28-48fa-b35c-be844890aecf"), Type = TextBlockType.Text, Text = "You spin your staff with a twirling flourish, attacking two foes and transforming the momentum into magical energy to charge for your next Spellstrike. Make a melee Strike with your staff against one foe and then a second melee Strike with your staff against a different foe. Your multiple attack penalty applies to both of these attacks as normal." };
        }

        public override IEnumerable<Guid> GetSpellComponents()
        {
            yield return SpellComponents.Instances.Verbal.ID;
        }

        public override void GetTraits(ITraitBindingBuilder<SpellTraitBinding, Spell> builder)
        {
            builder.Add(Guid.Parse("c228a32b-6e15-43ef-af5e-f44b06280cdc"), Traits.Instances.Uncommon.ID);
            builder.Add(Guid.Parse("a06e57b5-12c0-47cc-b313-c8831634140f"), Traits.Instances.Evocation.ID);
            builder.Add(Guid.Parse("60e0aed2-3868-4fdd-9667-bdc12d6e49fa"), Traits.Instances.Magus.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("433bfea4-24d3-46b2-bbbb-c3f24487dbaf"),
                SourceId = Sources.Instances.SecretsOfMagic.ID,
                Page = 144
            };
        }
    }
}
