using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Spells.Instances
{
    public class TransmuteRockAndMud : Template
    {
        public static readonly Guid ID = Guid.Parse("b9fd290e-2117-4010-9659-a50f52165898");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Transmute Rock and Mud",
                Level = 5,
                Range = "60 feet.",
                Area = "2 adjecent 10-foot cubes.",
                SpellTypeId = SpellTypes.Instances.Spell.ID,
                ActionTypeId = ActionTypes.Instances.ThreeActions.ID,
                MagicSchoolId = MagicSchools.Instances.Transmutation.ID
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("b9fd290e-2117-4010-9659-a50f52165898"), Type = TextBlockType.Text, Text = "You warp the structure of earthen material, turning rock into mud or mud into rock. Choose one of these two options when you Cast the Spell." };
            yield return new TextBlock { Id = Guid.Parse("b9fd290e-2117-4010-9659-a50f52165898"), Type = TextBlockType.Enumeration, Text = "Rock to Mud - You transform non-magical, unworked, and unattended stone in the area into an equal volume of mud. If you Cast this Spell on a stone floor, it becomes difficult terrain; if the resulting mud is at least 3 feet deep, it is greater difficult terrain, or the creature can try to Swim through it (DC 10 Athletics). If the mud is deep enough that a creature can’t reach the bottom, the creature must Swim to move through it. If you Cast this Spell on a ceiling, the falling mud deals 8d6 bludgeoning damage (basic Reflex save) and spreads out, creating difficult terrain in an area 10 feet larger in radius than the original spell’s area. Once the rock is transformed into mud, the mud is non-magical and remains until natural conditions cause it to dry out or otherwise disperse." };
            yield return new TextBlock { Id = Guid.Parse("b9fd290e-2117-4010-9659-a50f52165898"), Type = TextBlockType.Enumeration, Text = "Mud to Rock - Mud in the area turns into unworked stone. If creatures are in the mud when it is transformed to stone, they must attempt a Reflex saving throw." };
        }

        public override IEnumerable<SpellHeightening> GetHeightenings()
        {
            yield return new SpellHeightening
            {
                Id = Guid.Parse("b9fd290e-2117-4010-9659-a50f52165898"), 
                Level = "+2",
                Details =
                {
                    new TextBlock { Id = Guid.Parse("b9fd290e-2117-4010-9659-a50f52165898"), Type = TextBlockType.Text, Text = "Add an additional 10-foot cube to the area, adjacent to at least one of the other cubes." }
                }
            };
        }

        public override IEnumerable<RollableEffect> GetRollableEffects()
        {
            yield return new RollableEffect
            {
                Id = Guid.Parse("b9fd290e-2117-4010-9659-a50f52165898"),
                Name = "Mud to Rock",
                CriticalSuccess = "The creature escapes the mud and is atop the stone, unaffected.",
                Success = "The creature climbs out of the mud as it turns to rock and is prone atop the stone.",
                Failure = "The creature is partially stuck in the mud and is grabbed for 1 round or until it Escapes, whichever comes first.",
                CriticalFailure = "The creature is entirely stuck. It is restrained for 1 round or until it Escapes, whichever comes first."
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
            yield return Traits.Instances.Earth.ID;
            yield return Traits.Instances.Transmutation.ID;
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("b9fd290e-2117-4010-9659-a50f52165898"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = 226
            };
        }
    }
}
