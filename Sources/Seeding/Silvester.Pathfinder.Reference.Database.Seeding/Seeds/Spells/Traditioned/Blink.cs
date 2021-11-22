using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Spells.Instances
{
    public class Blink : Template
    {
        public static readonly Guid ID = Guid.Parse("e130e307-ede2-4a68-9667-cfc482855d95");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Blink",
                Level = 3,
                Duration = "1 minute.",
                SpellTypeId = SpellTypes.Instances.Spell.ID,
                ActionTypeId = ActionTypes.Instances.TwoActions.ID,
                MagicSchoolId = MagicSchools.Instances.Conjuration.ID,
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("06487cd4-8f08-4bda-bbdb-74387d15734e"), Type = Utilities.Text.TextBlockType.Text, Text = "You blink quickly between the Material Plane and the Ethereal Plane. You gain resistance 5 to all damage (except force). You can Sustain the Spell to vanish and reappear 10 feet away in a random direction determined by the GM; the movement doesn't trigger reactions. At the end of your turn, you vanish and reappear as above." };
        }

        public override IEnumerable<SpellHeightening> GetHeightenings()
        {
            yield return new SpellHeightening
            { 
                Id = Guid.Parse("84e120a3-6dd6-4348-9a07-934858f71840"),
                Level = "+2",
                Details =
                {
                    new TextBlock { Id = Guid.Parse("74827007-1d12-462a-a927-1324a4bf22ae"), Type = Utilities.Text.TextBlockType.Text, Text = "The resistance increases by 3." }
                }
            };
        }

        public override IEnumerable<Guid> GetSpellComponents()
        {
            yield return SpellComponents.Instances.Somatic.ID;
            yield return SpellComponents.Instances.Verbal.ID;
        }

        public override IEnumerable<Guid> GetMagicTraditions()
        {
            yield return MagicTraditions.Instances.Arcane.ID;
            yield return MagicTraditions.Instances.Occult.ID;
        }

        public override IEnumerable<Guid> GetTraits()
        {
            yield return Traits.Instances.Conjuration.ID;
            yield return Traits.Instances.Teleportation.ID;
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("94822dca-8ae8-44f8-8f16-dcaf4cebcc68"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 321
            };
        }
    }
}
