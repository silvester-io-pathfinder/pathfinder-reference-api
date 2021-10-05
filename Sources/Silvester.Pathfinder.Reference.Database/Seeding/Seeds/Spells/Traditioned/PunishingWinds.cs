using Silvester.Pathfinder.Reference.Database.Models;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Spells.Instances
{
    public class PunishingWinds : Template
    {
        public static readonly Guid ID = Guid.Parse("4a3691c4-497f-4009-aaf7-2ecf804feb9b");

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
                SpellTypeId = SpellTypes.Instances.Spell.ID,
                ActionTypeId = ActionTypes.Instances.ThreeActions.ID,
                MagicSchoolId = MagicSchools.Instances.Evocation.ID
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("8d8505b5-dfe4-48b6-b8bf-c633d7f9c473"), Type = TextBlockType.Text, Text = "Violent winds and a powerful downdraft fill the area, forming a cyclone. All flying creatures in the area descend 40 feet. The entire area is greater difficult terrain for Flying creatures, and difficult terrain for creatures on the ground or Climbing. Any creature that ends its turn Flying within the area descends 20 feet. Any creature pushed into a surface by this spell’s winds takes bludgeoning damage as though it had fallen." };
            yield return new TextBlock { Id = Guid.Parse("27a36046-97dd-440d-bfb2-71c2331c03c6"), Type = TextBlockType.Text, Text = "The squares at the outside vertical edges of the cylinder prevent creatures from leaving. These squares are greater difficult terrain, and a creature attempting to push through must succeed at an Athletics check or Acrobatics check to Maneuver in Flight against your spell DC to get through. A creature that fails ends its current action but can try again." };
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
                Id = Guid.Parse("b13ae30e-5ea7-449c-91a8-47abca7784c3"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 361
            };
        }
    }
}
