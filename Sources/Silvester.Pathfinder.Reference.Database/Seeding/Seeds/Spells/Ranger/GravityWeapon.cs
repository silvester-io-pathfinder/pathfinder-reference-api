using Silvester.Pathfinder.Reference.Database.Models;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Spells.Instances
{
    public class GravityWeapon : Template
    {
        public static readonly Guid ID = Guid.Parse("fb5e5e4f-8c14-405c-8f91-dd5c6e56ff4d");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Gravity Weapon",
                Level = 1,
                Duration = "1 minute.",
                ActionTypeId = ActionTypes.Instances.OneAction.ID,
                ClassId = Classes.Instances.Ranger.ID,
                SpellTypeId = SpellTypes.Instances.Focus.ID,
                MagicSchoolId = MagicSchools.Instances.Evocation.ID,
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("c34177aa-5173-4541-aabf-601fabd0d7e2"), Type = TextBlockType.Text, Text = "You build up gravitational force and funnel it into your blows, leading to more powerful attacks with blade and bow alike. On your first weapon Strike each round, you gain a status bonus to damage equal to twice the number of weapon damage dice." };
        }

        public override IEnumerable<Guid> GetSpellComponents()
        {
            yield return SpellComponents.Instances.Somatic.ID;
        }

        public override IEnumerable<Guid> GetTraits()
        {
            yield return Traits.Instances.Uncommon.ID;
            yield return Traits.Instances.Evocation.ID;
            yield return Traits.Instances.Ranger.ID;
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("48b13453-9258-4c3a-bf0f-7c20f5fa056b"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = 234
            };
        }
    }
}
