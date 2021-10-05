using Silvester.Pathfinder.Reference.Database.Models;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Spells.Instances
{
    public class Shatter : Template
    {
        public static readonly Guid ID = Guid.Parse("c902051a-93c6-4cb1-94d6-b9e95d2df8a5");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Shatter",
                Level = 2,
                Range = "30 feet.",
                Targets = "1 unattended object.",
                SpellTypeId = SpellTypes.Instances.Spell.ID,
                ActionTypeId = ActionTypes.Instances.TwoActions.ID,
                MagicSchoolId = MagicSchools.Instances.Evocation.ID
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("1344f717-2d4b-4346-8a5a-ac2c9ff6b140"), Type = TextBlockType.Text, Text = "A high-frequency sonic attack shatters a nearby object. You deal 2d10 sonic damage to the object, ignoring the object’s Hardness if it is 4 or lower." };
        }

        public override IEnumerable<SpellHeightening> GetHeightenings()
        {
            yield return new SpellHeightening
            {
                Id = Guid.Parse("b64f337c-7582-42ce-9a12-e0579cabb9a5"), 
                Level = "+1",
                Details =
                {
                    new TextBlock { Id = Guid.Parse("9292175c-0f54-438c-a323-13563b678103"), Type = TextBlockType.Text, Text = "The damage increases by 1d10, and the Hardness the spell ignores increases by 2." }
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
            yield return MagicTraditions.Instances.Primal.ID;
            yield return MagicTraditions.Instances.Occult.ID;
        }

        public override IEnumerable<Guid> GetTraits()
        {
            yield return Traits.Instances.Evocation.ID;
            yield return Traits.Instances.Sonic.ID;
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("206ace0e-0b48-47e3-84a8-1a0ee3a54ebb"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 368
            };
        }
    }
}
