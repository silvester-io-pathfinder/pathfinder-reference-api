using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Spells.Instances
{
    public class KnowDirection : Template
    {
        public static readonly Guid ID = Guid.Parse("13443716-6941-4cc8-b031-13ea8b0c428d");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Know Direction",
                Level = 1,
                SpellTypeId = SpellTypes.Instances.Cantrip.ID,
                ActionTypeId = ActionTypes.Instances.TwoActions.ID,
                MagicSchoolId = MagicSchools.Instances.Divination.ID
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("de95fe4c-a212-41aa-8b81-bd18458a0d39"), Type = TextBlockType.Text, Text = "In your mind’s eye, you see a path northward. You immediately know which direction is north (if it exists at your current location)." };
        }

        public override IEnumerable<SpellHeightening> GetHeightenings()
        {
            yield return new SpellHeightening
            {
                Id = Guid.Parse("977a323f-a56a-4c27-ae30-eb78c9219679"), 
                Level = "7th",
                Details =
                {
                    new TextBlock { Id = Guid.Parse("6b40dbfb-08cc-4788-a36c-2f82540d98f0"), Type = TextBlockType.Text, Text = "You can instead know the direction to a familiar location, such as a previous home or a favorite tavern." }
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
            yield return MagicTraditions.Instances.Divine.ID;
            yield return MagicTraditions.Instances.Primal.ID;
            yield return MagicTraditions.Instances.Occult.ID;
        }

        public override IEnumerable<Guid> GetTraits()
        {
            yield return Traits.Instances.Cantrip.ID;
            yield return Traits.Instances.Detection.ID;
            yield return Traits.Instances.Divination.ID;
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("4f56bd18-fe3c-424b-8942-93146d49f5bb"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 348
            };
        }
    }
}
