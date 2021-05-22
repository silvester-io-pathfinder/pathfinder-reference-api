using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Spells.Instances
{
    public class DreamingPotential : Template
    {
        public static readonly Guid ID = Guid.Parse("299bd621-5766-49ce-bc04-2a55df46db48");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Dreaming Potential",
                Level = 5,
                CastTime = "10 minutes.",
                Range = "Touch.",
                Duration = "8 hours.",
                Targets = "1 willing sleeping creature.",
                SpellTypeId = SpellTypes.Instances.Spell.ID,
                ActionTypeId = ActionTypes.Instances.LongAction.ID,
                MagicSchoolId = MagicSchools.Instances.Enchantment.ID
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("5bbdbace-de72-4cfe-8512-185541e45a36"), Type = TextBlockType.Text, Text = "You draw the target into a lucid dream where it can explore the endless possibilities of its own potential within the everchanging backdrop of its dreamscape. If it sleeps the full 8 hours uninterrupted, when it wakes, it counts as having spent a day of downtime retraining, though it can’t use dreaming potential for any retraining that would require either an instructor or specialized knowledge it can’t access within the dream." };
        }

        public override IEnumerable<Guid> GetSpellComponents()
        {
            yield return SpellComponents.Instances.Material.ID;
            yield return SpellComponents.Instances.Somatic.ID;
            yield return SpellComponents.Instances.Verbal.ID;
        }

        public override IEnumerable<Guid> GetMagicTraditions()
        {
            yield return MagicTraditions.Instances.Occult.ID;
        }

        public override IEnumerable<Guid> GetTraits()
        {
            yield return Traits.Instances.Enchantment.ID;
            yield return Traits.Instances.Mental.ID;
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("b20732a5-a41e-4c95-89ed-f14dea0c1f29"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 333
            };
        }
    }
}
