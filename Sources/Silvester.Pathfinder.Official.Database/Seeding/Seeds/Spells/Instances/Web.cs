using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Spells.Instances
{
    public class Web : Template
    {
        public static readonly Guid ID = Guid.Parse("");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Web",
                Level = 2,
                Range = "30 feet.",
                Area = "10-foot burst.",
                Duration = "1 minute.",
                SpellTypeId = SpellTypes.Instances.Focus.ID,
                ActionTypeId = ActionTypes.Instances.ThreeActions.ID,
                MagicSchoolId = MagicSchools.Instances.Conjuration.ID
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Text, Text = "You create a sticky web in the area that impedes creatures’ movement each time they try to move through it. Squares filled with the web are difficult terrain. Each square can be cleared of the web by a single attack or effect that deals at least 5 slashing damage or 1 fire damage. A square has AC 5, and it automatically fails its saving throws." };
            yield return new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Text, Text = "Each time a creature in the web begins to use a move action or enters the web during a move action, it must attempt an Athletics check or Reflex save against your spell DC to avoid taking a circumstance penalty to its Speeds or becoming immobilized. A creature that gets out of the web ceases to take a circumstance penalty to its Speed from the web." };
        }

        public override IEnumerable<SpellHeightening> GetHeightenings()
        {
            yield return new SpellHeightening
            {
                Id = Guid.Parse(""), 
                Level = "4th",
                Details =
                {
                    new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Text, Text = "The spell’s area increases to a 20-foot burst, and its range increases to 60 feet." }
                }
            };
        }

        public override RollableEffect? GetRollableEffect()
        {
            return new RollableEffect
            {
                Id = Guid.Parse(""),
                CriticalSuccess = "The creature is unaffected, and it doesn’t need to attempt further Athletics checks or saving throws against the web this turn. If it used an Athletics check, it clears the web from every square it leaves after leaving the square.",
                Success = "The creature is unaffected during its action. If it used an Athletics check, it clears the web from every square it leaves after leaving the square.",
                Failure = "The creature takes a –10-foot circumstance penalty to its Speeds until the start of its next turn.",
                CriticalFailure = "The creature is immobilized until the start of its next turn, after which it takes a –10-foot circumstance penalty to its Speeds for 1 round. It can attempt to Escape to remove its immobilized condition."
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
            yield return Traits.Instances.Conjuration.ID;
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse(""),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 384
            };
        }
    }
}
