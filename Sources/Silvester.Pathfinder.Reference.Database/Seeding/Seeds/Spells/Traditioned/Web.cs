using Silvester.Pathfinder.Reference.Database.Models;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Spells.Instances
{
    public class Web : Template
    {
        public static readonly Guid ID = Guid.Parse("d1767a35-390b-496c-b78d-b2dae7e06391");

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
                SpellTypeId = SpellTypes.Instances.Spell.ID,
                ActionTypeId = ActionTypes.Instances.ThreeActions.ID,
                MagicSchoolId = MagicSchools.Instances.Conjuration.ID
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("1c57e46a-a24e-4749-8c77-b406aacd8297"), Type = TextBlockType.Text, Text = "You create a sticky web in the area that impedes creatures’ movement each time they try to move through it. Squares filled with the web are difficult terrain. Each square can be cleared of the web by a single attack or effect that deals at least 5 slashing damage or 1 fire damage. A square has AC 5, and it automatically fails its saving throws." };
            yield return new TextBlock { Id = Guid.Parse("68e60de5-116b-48f0-a9b8-15b954854b49"), Type = TextBlockType.Text, Text = "Each time a creature in the web begins to use a move action or enters the web during a move action, it must attempt an Athletics check or Reflex save against your spell DC to avoid taking a circumstance penalty to its Speeds or becoming immobilized. A creature that gets out of the web ceases to take a circumstance penalty to its Speed from the web." };
        }

        public override IEnumerable<SpellHeightening> GetHeightenings()
        {
            yield return new SpellHeightening
            {
                Id = Guid.Parse("bd53069f-597a-4cd3-a4cc-37c9854ffe05"), 
                Level = "4th",
                Details =
                {
                    new TextBlock { Id = Guid.Parse("e9cf21f3-2585-40e8-bce5-685abb3c4339"), Type = TextBlockType.Text, Text = "The spell’s area increases to a 20-foot burst, and its range increases to 60 feet." }
                }
            };
        }

        public override IEnumerable<RollableEffect> GetRollableEffects()
        {
            yield return new RollableEffect
            {
                Id = Guid.Parse("4803d77d-c61f-4d85-9a81-89b1b6ba9e2b"),
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
                Id = Guid.Parse("ab3dde37-59fa-4325-aa41-90f889f5b1d4"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 384
            };
        }
    }
}
