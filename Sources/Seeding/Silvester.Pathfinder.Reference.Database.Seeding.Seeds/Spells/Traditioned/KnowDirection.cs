using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.Traits;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Spells.Instances
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
            yield return new TextBlock { Id = Guid.Parse("de95fe4c-a212-41aa-8b81-bd18458a0d39"), Type = TextBlockType.Text, Text = "In your mind's eye, you see a path northward. You immediately know which direction is north (if it exists at your current location)." };
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

        public override void GetTraits(ITraitBindingBuilder<SpellTraitBinding, Spell> builder)
        {
            builder.Add(Guid.Parse("37a3b66d-e726-4c1e-aeca-b3a2147fff28"), Traits.Instances.Cantrip.ID);
            builder.Add(Guid.Parse("55c189b6-fdfc-49c5-8b00-985cef87ba52"), Traits.Instances.Detection.ID);
            builder.Add(Guid.Parse("e08da0ce-d4cf-4c12-bd63-511884df4695"), Traits.Instances.Divination.ID);
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
