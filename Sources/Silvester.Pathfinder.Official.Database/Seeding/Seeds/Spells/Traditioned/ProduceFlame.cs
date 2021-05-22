using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Spells.Instances
{
    public class ProduceFlame : Template
    {
        public static readonly Guid ID = Guid.Parse("a6374c8f-0a48-42b8-80a9-5c9f39447e3b");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Produce Flame",
                Level = 1,
                Range = "30 feet.",
                Targets = "1 creature.",
                SpellTypeId = SpellTypes.Instances.Cantrip.ID,
                ActionTypeId = ActionTypes.Instances.TwoActions.ID,
                MagicSchoolId = MagicSchools.Instances.Evocation.ID
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("f1b5871a-4266-4915-82e7-37e51cf02b2e"), Type = TextBlockType.Text, Text = "A small ball of flame appears in the palm of your hand, and you lash out with it either in melee or at range. Make a spell attack roll against your target’s AC. This is normally a ranged attack, but you can also make a melee attack against a creature in your unarmed reach. On a success, you deal 1d4 fire damage plus your spellcasting ability modifier. On a critical success, the target takes double damage and 1d4 persistent fire damage." };
        }

        public override IEnumerable<SpellHeightening> GetHeightenings()
        {
            yield return new SpellHeightening
            {
                Id = Guid.Parse("cee86192-e818-440d-94af-a838f38e6515"), 
                Level = "+1",
                Details =
                {
                    new TextBlock { Id = Guid.Parse("535412d6-3361-4caa-9bb5-470a2bc7fef2"), Type = TextBlockType.Text, Text = "Increase the damage by 1d4 and the persistent damage on a critical hit by 1d4." }
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
            yield return MagicTraditions.Instances.Primal.ID;
        }

        public override IEnumerable<Guid> GetTraits()
        {
            yield return Traits.Instances.Attack.ID;
            yield return Traits.Instances.Cantrip.ID;
            yield return Traits.Instances.Evocation.ID;
            yield return Traits.Instances.Fire.ID;
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("f9800252-5fb5-47ff-a93b-958e8b22868d"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 360
            };
        }
    }
}
