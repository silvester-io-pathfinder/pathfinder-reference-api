using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Spells.Instances
{
    public class MeteorSwarm : Template
    {
        public static readonly Guid ID = Guid.Parse("0eb99f7f-3a8b-4769-bcd7-06203011c84e");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Meteor Swarm",
                Level = 9,
                Range = "500 feet.",
                Area = "4 40-foot bursts.",
                IsSavingThrowBasic = true,
                SavingThrowStatId = SavingThrowStats.Instances.Reflex.ID,
                SpellTypeId = SpellTypes.Instances.Spell.ID,
                ActionTypeId = ActionTypes.Instances.TwoActions.ID,
                MagicSchoolId = MagicSchools.Instances.Evocation.ID
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("2c974f1b-c9b3-4c29-8652-42229a9b7ea9"), Type = TextBlockType.Text, Text = "You call down four meteors that explode in a fiery blast. Each meteor deals 6d10 bludgeoning damage to any creatures in the 10-foot burst at the center of its area of effect before exploding, dealing 14d6 fire damage to any creatures in its 40-foot burst. The meteors' central 10-foot bursts can't overlap, and a creature takes the same amount of fire damage no matter how many overlapping explosions it's caught in. The saving throw applies to both the bludgeoning and the fire damage." };
        }

        public override IEnumerable<SpellHeightening> GetHeightenings()
        {
            yield return new SpellHeightening
            {
                Id = Guid.Parse("e1f0d5e4-bfaa-4669-ad25-07f54855ca10"), 
                Level = "+1",
                Details =
                {
                    new TextBlock { Id = Guid.Parse("b8857c59-9bbf-496f-8702-8e59613af296"), Type = TextBlockType.Text, Text = "The bludgeoning damage increases by 1d10, and the fire damage increases by 2d6." }
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
            yield return Traits.Instances.Evocation.ID;
            yield return Traits.Instances.Fire.ID;
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("c3edb7f5-256e-4bbf-ac50-380713fe1799"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 351
            };
        }
    }
}
