using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Spells.Instances
{
    public class PunishingWinds : Template
    {
        public static readonly Guid ID = Guid.Parse("");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Punishing Winds",
                Level = 8,
                Range = "100 feet.",
                Area = "30-foot radius, 100-foot-tall cylinder.",
                IsDismissable = true,
                Duration = "Sustianed up to 1 minute.",
                SpellTypeId = SpellTypes.Instances.Focus.ID,
                ActionTypeId = ActionTypes.Instances.ThreeActions.ID,
                MagicSchoolId = MagicSchools.Instances.Evocation.ID
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Text, Text = "Violent winds and a powerful downdraft fill the area, forming a cyclone. All flying creatures in the area descend 40 feet. The entire area is greater difficult terrain for Flying creatures, and difficult terrain for creatures on the ground or Climbing. Any creature that ends its turn Flying within the area descends 20 feet. Any creature pushed into a surface by this spell’s winds takes bludgeoning damage as though it had fallen." };
            yield return new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Text, Text = "The squares at the outside vertical edges of the cylinder prevent creatures from leaving. These squares are greater difficult terrain, and a creature attempting to push through must succeed at an Athletics check or Acrobatics check to Maneuver in Flight against your spell DC to get through. A creature that fails ends its current action but can try again." };
        }

        public override IEnumerable<Guid> GetSpellComponents()
        {
            yield return SpellComponents.Instances.Material.ID;
            yield return SpellComponents.Instances.Somatic.ID;
            yield return SpellComponents.Instances.Verbal.ID;
        }

        public override IEnumerable<Guid> GetMagicTraditions()
        {
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
                Page = 361
            };
        }
    }
}
