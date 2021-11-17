using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
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

        public override IEnumerable<Guid> GetTraits()
        {
            yield return Traits.Instances.Uncommon.ID;
            yield return Traits.Instances.Evocation.ID;
            yield return Traits.Instances.Magus.ID;
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
