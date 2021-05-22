using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Spells.Instances
{
    public class WallOfFlesh : Template
    {
        public static readonly Guid ID = Guid.Parse("2f5f79d1-e104-45b1-bfa6-a56f13329f7c");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Wall of Flesh",
                Level = 5,
                Range = "20 feet.",
                Duration = "10 minutes.",
                SpellTypeId = SpellTypes.Instances.Spell.ID,
                ActionTypeId = ActionTypes.Instances.TwoActions.ID,
                MagicSchoolId = MagicSchools.Instances.Necromancy.ID
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("2f5f79d1-e104-45b1-bfa6-a56f13329f7c"), Type = TextBlockType.Text, Text = "You craft a 20-foot-tall wall of living flesh in a straight line up to 30 feet long. The wall is 3 feet thick, and each 5-foot-long section has AC 10 and 75 HP. If you wish, the wall can be of a smaller length or height. You must create the wall in an unbroken open space so its edges don’t pass through any creatures or objects, or the spell is lost. The wall can’t be Repaired but can be healed by positive energy and healing spells and abilities." };
            yield return new TextBlock { Id = Guid.Parse("2f5f79d1-e104-45b1-bfa6-a56f13329f7c"), Type = TextBlockType.Text, Text = "When you Cast the Spell, choose one of the following features for your wall." };
            yield return new TextBlock { Id = Guid.Parse("2f5f79d1-e104-45b1-bfa6-a56f13329f7c"), Type = TextBlockType.Enumeration, Text = "Mouths -The wall has countless toothy mouths along its surface. The mouths Strike any creature that ends its turn within 5 feet of the wall, using your spell attack roll for these Strikes and dealing piercing damage equal to 1d6 + your spellcasting ability modifier. The mouths are capable of consuming potions; since the wall is alive, it can recover Hit Points from a potion of healing, but it can’t benefit from any effect that would give it the ability to move. Otherwise, the GM determines which potions can affect the wall." };
            yield return new TextBlock { Id = Guid.Parse("2f5f79d1-e104-45b1-bfa6-a56f13329f7c"), Type = TextBlockType.Enumeration, Text = "Eyes - The wall sprouts hundreds of unblinking eyes. You can see through these eyes, gaining a +2 circumstance bonus to visual Perception checks within the wall’s line of sight. You can also use the eyes for determining line of sight for ranged attacks and spells, but you don’t have line of effect through the wall." };
            yield return new TextBlock { Id = Guid.Parse("2f5f79d1-e104-45b1-bfa6-a56f13329f7c"), Type = TextBlockType.Enumeration, Text = "Arms - The wall is a mass of grasping arms. Any creature that ends its turn within 5 feet of the wall must attempt a Reflex save." };
        }

        public override IEnumerable<RollableEffect> GetRollableEffects()
        {
            yield return new RollableEffect
            {
                Id = Guid.Parse("2f5f79d1-e104-45b1-bfa6-a56f13329f7c"),
                Success = "The creature is unaffected.",
                Failure = "The creature is grabbed by the wall for 1 round or until it Escapes against your spell DC, whichever comes first.",
                CriticalFailure = "The creature is restrained by the wall for 1 round or until it Escapes against your spell DC, whichever comes first."
            };
        }

        public override IEnumerable<Guid> GetSpellComponents()
        {
            yield return SpellComponents.Instances.Material.ID;
            yield return SpellComponents.Instances.Somatic.ID;
        }

        public override IEnumerable<Guid> GetMagicTraditions()
        {
            yield return MagicTraditions.Instances.Divine.ID;
            yield return MagicTraditions.Instances.Primal.ID;
            yield return MagicTraditions.Instances.Occult.ID;
        }

        public override IEnumerable<Guid> GetTraits()
        {
            yield return Traits.Instances.Necromancy.ID;
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("2f5f79d1-e104-45b1-bfa6-a56f13329f7c"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = 227
            };
        }
    }
}
