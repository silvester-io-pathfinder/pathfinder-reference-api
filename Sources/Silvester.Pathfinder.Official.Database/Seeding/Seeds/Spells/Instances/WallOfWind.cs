using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Spells.Instances
{
    public class WallOfWind : Template
    {
        public static readonly Guid ID = Guid.Parse("");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Wall of Wind",
                Level = 3,
                Range = "120 feet.",
                Duration = "1 minute.",
                SpellTypeId = SpellTypes.Instances.Focus.ID,
                ActionTypeId = ActionTypes.Instances.ThreeActions.ID,
                MagicSchoolId = MagicSchools.Instances.Evocation.ID
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Text, Text = "You create a barrier of gusting winds that hinders anything moving through it. The wall of swirling winds is 5 feet thick, 60 feet long, and 30 feet high. The wall stands vertically, but you can shape its path. Though the wall of wind distorts the air, it does not hamper sight. The wall has the following effects." };
            yield return new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Enumeration, Text = "Ammunition from physical ranged attacks—such as arrows, bolts, sling bullets, and other objects of similar size—can’t pass through the wall. Attacks with bigger ranged weapons, such as javelins, take a –2 circumstance penalty to their attack rolls if their paths pass through the wall. Massive ranged weapons and spell effects that don’t create physical objects pass through the wall with no penalty." };
            yield return new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Enumeration, Text = "The wall is difficult terrain to creatures attempting to move overland through it. Gases, including creatures in gaseous form, can’t pass through the wall." };
            yield return new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Enumeration, Text = "A creature that attempts to fly through the wall using a move action must attempt a Fortitude save." };
        }

        public override RollableEffect? GetRollableEffect()
        {
            return new RollableEffect
            {
                Id = Guid.Parse(""),
                CriticalSuccess = "The creature can move through the wall normally this turn.",
                Success = "The flying creature can move through the wall this turn, but the wall is difficult terrain.",
                Failure = "The wall stops the movement of the flying creature, and any remaining movement from its current action is wasted.",
                CriticalFailure = "As failure, and the creature is pushed 10 feet away from the wall."
            };
        }

        public override IEnumerable<Guid> GetSpellComponents()
        {
            yield return SpellComponents.Instances.Material.ID;
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
            yield return Traits.Instances.Air.ID;
            yield return Traits.Instances.Evocation.ID;
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse(""),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 383
            };
        }
    }
}
