using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Spells.Instances
{
    public class MoonlightBridge : Template
    {
        public static readonly Guid ID = Guid.Parse("06fbe767-a12b-4030-97c7-ba82c1f75f4f");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Moonlight Bridge",
                Level = 6,
                Range = "30 feet.",
                IsDismissable = true,
                Duration = "10 minutes.",
                ActionTypeId = ActionTypes.Instances.TwoActions.ID,
                ClassId = Classes.Instances.Oracle.ID,
                SpellTypeId = SpellTypes.Instances.Focus.ID,
                MagicSchoolId = MagicSchools.Instances.Conjuration.ID,
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("f1cb16f5-c104-4d48-91c9-393ae8975d5c"), Type = TextBlockType.Text, Text = "You summon a bridge of radiant, shimmering moonlight. The 10-foot-wide span must start at the ground on a point within range, and it extends as a horizontal plane, either in a straight line or at any angle up to 45 degrees upward or downward, for up to 120 feet. This bridge has AC 10, Hardness 30, and 60 Hit Points, and it’s immune to critical hits and precision damage. You and your allies can cross the bridge normally, but other creatures simply pass through it if they try to do so. The bridge blocks physical, ethereal, and incorporeal attacks from crossing, whether from above or below. You can Dismiss the spell." };
        }

        public override IEnumerable<SpellHeightening> GetHeightenings()
        {
            yield return new SpellHeightening
            {
                Id = Guid.Parse("d5e10257-9196-43b1-8b72-cd4d7c2b5dc9"),
                Level = "+1",
                Details =
                {
                    new TextBlock { Id = Guid.Parse("919080d9-1930-4417-abbd-340cc0137089"), Type = TextBlockType.Text, Text = "The length of the bridge increases by 20 feet, and its Hit Points increase by 20." }
                }
            };
        }

        public override IEnumerable<Guid> GetSpellComponents()
        {
            yield return SpellComponents.Instances.Somatic.ID;
            yield return SpellComponents.Instances.Verbal.ID;
        }

        public override IEnumerable<Guid> GetTraits()
        {
            yield return Traits.Instances.Uncommon.ID;
            yield return Traits.Instances.Conjuration.ID;
            yield return Traits.Instances.Cursebound.ID;
            yield return Traits.Instances.Light.ID;
            yield return Traits.Instances.Oracle.ID;
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("c22fea51-decb-44d0-bc56-eba480ff1882"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = 233
            };
        }
    }
}
