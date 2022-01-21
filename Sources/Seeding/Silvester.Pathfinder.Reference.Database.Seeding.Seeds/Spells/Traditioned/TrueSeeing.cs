using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.Traits;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Spells.Instances
{
    public class TrueSeeing : Template
    {
        public static readonly Guid ID = Guid.Parse("52f71378-b21c-4efb-a0d7-64981b5618e5");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "True Seeing",
                Level = 6,
                Duration = "10 minutes.",
                SpellTypeId = SpellTypes.Instances.Spell.ID,
                ActionTypeId = ActionTypes.Instances.TwoActions.ID,
                MagicSchoolId = MagicSchools.Instances.Divination.ID
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("43810ed1-6b68-4256-ae7a-f15e6a2ba52c"), Type = TextBlockType.Text, Text = "You see things within 60 feet as they actually are. The GM rolls a secret counteract check against any illusion or transmutation in the area, but only for the purpose of determining whether you see through it (for instance, if the check succeeds against a polymorph spell, you can see the creature's true form, but you don't end the polymorph spell)." };
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
            yield return MagicTraditions.Instances.Primal.ID;
            yield return MagicTraditions.Instances.Occult.ID;
        }

        public override void GetTraits(ITraitBindingBuilder<SpellTraitBinding, Spell> builder)
        {
            builder.Add(Guid.Parse("2a030796-4e92-49e1-82c0-83aba21d17f2"), Traits.Instances.Divination.ID);
            builder.Add(Guid.Parse("a35b00dd-2eef-413d-b5a5-83cc1bc44517"), Traits.Instances.Revelation.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("0fa46152-770d-4122-ac96-17c94e086a01"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 378
            };
        }
    }
}
