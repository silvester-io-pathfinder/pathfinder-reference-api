using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.Traits;
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
            yield return new TextBlock { Id = Guid.Parse("f1cb16f5-c104-4d48-91c9-393ae8975d5c"), Type = TextBlockType.Text, Text = "You summon a bridge of radiant, shimmering moonlight. The 10-foot-wide span must start at the ground on a point within range, and it extends as a horizontal plane, either in a straight line or at any angle up to 45 degrees upward or downward, for up to 120 feet. This bridge has AC 10, Hardness 30, and 60 Hit Points, and it's immune to critical hits and precision damage. You and your allies can cross the bridge normally, but other creatures simply pass through it if they try to do so. The bridge blocks physical, ethereal, and incorporeal attacks from crossing, whether from above or below. You can Dismiss the spell." };
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

        public override void GetTraits(ITraitBindingBuilder<SpellTraitBinding, Spell> builder)
        {
            builder.Add(Guid.Parse("cbf9c035-5733-425d-b811-47ab7c7c1ef9"), Traits.Instances.Uncommon.ID);
            builder.Add(Guid.Parse("43920b94-67d5-427d-992b-ea6e5f4f9091"), Traits.Instances.Conjuration.ID);
            builder.Add(Guid.Parse("40faa3b7-7a08-4823-9736-760663cfc4c9"), Traits.Instances.Cursebound.ID);
            builder.Add(Guid.Parse("d2ee0fde-f0ca-46dd-8f07-b2fc207a1f4a"), Traits.Instances.Light.ID);
            builder.Add(Guid.Parse("b0793fcf-c5d9-4be0-9db7-c6ecd5620274"), Traits.Instances.Oracle.ID);
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
