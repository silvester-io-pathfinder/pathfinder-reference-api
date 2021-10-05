using Silvester.Pathfinder.Reference.Database.Models;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Spells.Instances
{
    public class HeatMetal : Template
    {
        public static readonly Guid ID = Guid.Parse("1a02e573-b5c3-4c90-a480-b5bfbb84cfac");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Heat Metal",
                Level = 2,
                Range = "30 feet.",
                Targets = "1 metal item or metal creature.",
                SpellTypeId = SpellTypes.Instances.Spell.ID,
                ActionTypeId = ActionTypes.Instances.TwoActions.ID,
                MagicSchoolId = MagicSchools.Instances.Evocation.ID
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("bd5504dc-652e-4327-9957-3f748bb3dc96"), Type = TextBlockType.Text, Text = "This spell heats the targeted metal to become red-hot for a moment. This is usually harmless to an unattended metal item, which doesn’t get a saving throw, though the GM might rule that flammable materials connected to the object catch fire or melt. If you target an item worn or carried by a creature, or you target a creature made primarily of metal, the heat deals 4d6 fire damage and 2d4 persistent fire damage to the creature, which must attempt a Reflex saving throw." };
            yield return new TextBlock { Id = Guid.Parse("199ca86e-f67f-4dd7-ae12-741acbd56d95"), Type = TextBlockType.Text, Text = "If you target an item held by the creature, the creature can Release the item to improve their degree of success by one step from the result of their saving throw. The persistent damage is associated with the object and damages whichever creature is holding or wearing it. It has no effect if no one is holding the item, but you continue to attempt flat checks to end the persistent damage as normal, since the item remains hot and can sear someone who picks it up." };
        }

        public override IEnumerable<SpellHeightening> GetHeightenings()
        {
            yield return new SpellHeightening
            {
                Id = Guid.Parse("ded22497-3402-416a-8bc0-49871f6649bd"), 
                Level = "+1",
                Details =
                {
                    new TextBlock { Id = Guid.Parse("5e9eb69f-c4f6-4d4b-b6a7-4e3f0fbee7ff"), Type = TextBlockType.Text, Text = "The initial damage increases by 2d6 and the persistent damage increases by 1d4." }
                }
            };
        }

        public override IEnumerable<RollableEffect> GetRollableEffects()
        {
            yield return new RollableEffect
            {
                Id = Guid.Parse("91e56a2f-2979-40b0-b292-d0fa922fc13e"),
                CriticalSuccess = "The creature is unaffected.",
                Success = "The creature takes half damage and the object deals no persistent fire damage.",
                Failure = "The creature takes full damage and the object deals full persistent damage.",
                CriticalFailure = "As failure, but the creature takes double damage and the object deals double persistent damage."
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
                Id = Guid.Parse("409a9c79-1ba2-4f81-9943-1df707a5658b"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = 220
            };
        }
    }
}
