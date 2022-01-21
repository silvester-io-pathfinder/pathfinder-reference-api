using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.Traits;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Spells.Instances
{
    public class ShadowWalk : Template
    {
        public static readonly Guid ID = Guid.Parse("b84acd00-95a3-4ad2-bb2b-51268626ca31");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Shadow Walk",
                Level = 5,
                CastTime = "1 minute.",
                Range = "Touch.",
                IsDismissable = true,
                Duration = "8 hours.",
                Targets = "You and up to 9 willing creatures touched.",
                SpellTypeId = SpellTypes.Instances.Spell.ID,
                ActionTypeId = ActionTypes.Instances.LongAction.ID,
                MagicSchoolId = MagicSchools.Instances.Conjuration.ID
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("712ee70b-612d-4398-814c-c7d1ef59627d"), Type = TextBlockType.Text, Text = "You access the Shadow Plane, using its warped nature to spread your travels. The targets enter the edge of the Shadow Plane where it borders the Material Plane. Targets can't see the Material Plane while on the Shadow Plane (although elements of that plane can sometimes be a hazy reflection of the Material Plane). While on the Shadow Plane, the targets are exposed to potential encounters with that plane's denizens. The shadows on the border between the planes bend space, speeding up your movement with respect to the Material Plane. Every 3 minutes the targets travel along this border, they move as far as they would through the Material Plane in 1 hour. At any point, a target can Dismiss the spell's effects, although this affects only that target. The shadow bending is inexact, so when the spell ends, the targets appear roughly 1 mile from their intended location on the Material Plane (though those who are traveling together and Dismiss the spell at the same point on the Plane of Shadow appear together)." };
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
            yield return MagicTraditions.Instances.Occult.ID;
        }

        public override void GetTraits(ITraitBindingBuilder<SpellTraitBinding, Spell> builder)
        {
            builder.Add(Guid.Parse("ca33a9de-059a-4a6c-8882-5f65f074853b"), Traits.Instances.Uncommon.ID);
            builder.Add(Guid.Parse("8b6fdafd-fb4e-4112-87dc-35603cf5cc84"), Traits.Instances.Conjuration.ID);
            builder.Add(Guid.Parse("1b8369fe-f037-4225-b0d1-6d053fdd8ae3"), Traits.Instances.Shadow.ID);
            builder.Add(Guid.Parse("0ac91eb1-368d-4800-9660-94b27ccf8305"), Traits.Instances.Teleportation.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("0efef3f4-4656-4813-82be-20c198f0e894"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 368
            };
        }
    }
}
