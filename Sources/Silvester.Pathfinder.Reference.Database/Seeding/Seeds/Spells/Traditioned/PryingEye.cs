using Silvester.Pathfinder.Reference.Database.Models;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Spells.Instances
{
    public class PryingEye : Template
    {
        public static readonly Guid ID = Guid.Parse("01319058-8d1e-44bd-9f9a-400b34827c1a");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Prying Eye",
                Level = 5,
                CastTime = "1 minute.",
                Range = "Varies.",
                IsDismissable = true,
                Duration = "Sustianed.",
                SpellTypeId = SpellTypes.Instances.Spell.ID,
                ActionTypeId = ActionTypes.Instances.LongAction.ID,
                MagicSchoolId = MagicSchools.Instances.Divination.ID
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("cead21a7-ec4b-4637-9df3-3595ea6248d9"), Type = TextBlockType.Text, Text = "You create an invisible, floating eye, 1 inch in diameter, at a location you can see within 500 feet. It sees in all directions with your normal visual senses and continuously transmits what it sees to you." };
            yield return new TextBlock { Id = Guid.Parse("ecfe31e3-e00d-4ac4-bfa9-d1c50f0c5b0a"), Type = TextBlockType.Text, Text = "The first time you Sustain the Spell each round, you can either move the eye up to 30 feet, seeing only things in front of the eye, or move it up to 10 feet, seeing everything in all directions around it. There is no limit to how far from you the eye can move, but the spell ends immediately if you and the eye ever cease to be on the same plane of existence. You can attempt Seek actions through the eye if you want to attempt Perception checks with it. Any damage dealt to the eye destroys it and ends the spell." };
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
            yield return MagicTraditions.Instances.Divine.ID;
            yield return MagicTraditions.Instances.Occult.ID;
        }

        public override IEnumerable<Guid> GetTraits()
        {
            yield return Traits.Instances.Divination.ID;
            yield return Traits.Instances.Scrying.ID;
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("863c72d0-d6bf-4cfd-87ee-663e0ab89ee6"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 361
            };
        }
    }
}
