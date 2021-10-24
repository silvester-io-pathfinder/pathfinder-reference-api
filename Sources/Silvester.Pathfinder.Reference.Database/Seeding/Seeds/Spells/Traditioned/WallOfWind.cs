using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Spells.Instances
{
    public class WallOfWind : Template
    {
        public static readonly Guid ID = Guid.Parse("82285375-7f60-4f6e-953c-747f79584516");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Wall of Wind",
                Level = 3,
                Range = "120 feet.",
                Duration = "1 minute.",
                SpellTypeId = SpellTypes.Instances.Spell.ID,
                ActionTypeId = ActionTypes.Instances.ThreeActions.ID,
                MagicSchoolId = MagicSchools.Instances.Evocation.ID
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("dde7d37a-3e6f-44ec-b584-aaa35bef6899"), Type = TextBlockType.Text, Text = "You create a barrier of gusting winds that hinders anything moving through it. The wall of swirling winds is 5 feet thick, 60 feet long, and 30 feet high. The wall stands vertically, but you can shape its path. Though the wall of wind distorts the air, it does not hamper sight. The wall has the following effects." };
            yield return new TextBlock { Id = Guid.Parse("5f0062cc-68cd-4569-857e-c88e1b0c2389"), Type = TextBlockType.Enumeration, Text = "Ammunition from physical ranged attacks—such as arrows, bolts, sling bullets, and other objects of similar size—can’t pass through the wall. Attacks with bigger ranged weapons, such as javelins, take a –2 circumstance penalty to their attack rolls if their paths pass through the wall. Massive ranged weapons and spell effects that don’t create physical objects pass through the wall with no penalty." };
            yield return new TextBlock { Id = Guid.Parse("0f14535a-97e5-4d2f-b561-59e10229a299"), Type = TextBlockType.Enumeration, Text = "The wall is difficult terrain to creatures attempting to move overland through it. Gases, including creatures in gaseous form, can’t pass through the wall." };
            yield return new TextBlock { Id = Guid.Parse("e1c5327a-a42c-4772-8a9b-58a6c7d7f153"), Type = TextBlockType.Enumeration, Text = "A creature that attempts to fly through the wall using a move action must attempt a Fortitude save." };
        }

        public override IEnumerable<RollableEffect> GetRollableEffects()
        {
            yield return new RollableEffect
            {
                Id = Guid.Parse("a437792d-be5e-4889-a6d6-209bd489e3c4"),
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
                Id = Guid.Parse("6cb68599-d488-47af-a3d0-94d401e16810"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 383
            };
        }
    }
}
