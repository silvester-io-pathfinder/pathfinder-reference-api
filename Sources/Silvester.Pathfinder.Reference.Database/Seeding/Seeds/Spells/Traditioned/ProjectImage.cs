using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Spells.Instances
{
    public class ProjectImage : Template
    {
        public static readonly Guid ID = Guid.Parse("0d977f3d-7ee1-4691-a8a8-2e4f47af3f27");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Project Image",
                Level = 7,
                Range = "30 feet.",
                IsDismissable = true,
                Duration = "Sustained up to 1 minute.",
                SpellTypeId = SpellTypes.Instances.Spell.ID,
                ActionTypeId = ActionTypes.Instances.TwoActions.ID,
                MagicSchoolId = MagicSchools.Instances.Illusion.ID
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("11d02568-6243-4b28-bdd5-0fdcf845b6f2"), Type = TextBlockType.Text, Text = "You project an illusory image of yourself. You must stay within range of the image, and if at any point you can’t see the image, the spell ends. Whenever you Cast a Spell other than one whose area is an emanation, you can cause the spell effect to originate from either yourself or the image. Because the image is an illusion, it can’t benefit from spells, though visual manifestations of the spell appear. The image has the same AC and saves as you. If it is hit by an attack or fails a save, the spell ends." };
        }

        public override IEnumerable<SpellHeightening> GetHeightenings()
        {
            yield return new SpellHeightening
            {
                Id = Guid.Parse("4ea4aa30-b566-4a2e-80a0-b1e6998b47ad"), 
                Level = "+2",
                Details =
                {
                    new TextBlock { Id = Guid.Parse("6f170dec-0c88-4780-81e7-63dadc964887"), Type = TextBlockType.Text, Text = "The maximum duration you can Sustain the Spell increases to 10 minutes." }
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
            yield return MagicTraditions.Instances.Occult.ID;
        }

        public override IEnumerable<Guid> GetTraits()
        {
            yield return Traits.Instances.Illusion.ID;
            yield return Traits.Instances.Mental.ID;
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("e1663d7f-b0f8-4f21-a97a-4ff2bdc1327a"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 360
            };
        }
    }
}
