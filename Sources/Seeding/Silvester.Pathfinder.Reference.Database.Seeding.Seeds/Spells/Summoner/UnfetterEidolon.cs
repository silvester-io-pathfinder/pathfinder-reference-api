using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.Traits;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Spells.Instances
{
    public class UnfetterEidolon : Template
    {
        public static readonly Guid ID = Guid.Parse("1cbad3e1-e3a6-49b2-b62a-a59daeb86cbb");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Unfetter Eidolon",
                Level = 1,
                Range = "100 feet.",
                Targets = "Your eidolon.",
                Duration = "1 minute.",
                ActionTypeId = ActionTypes.Instances.TwoActions.ID,
                SpellTypeId = SpellTypes.Instances.Focus.ID,
                MagicSchoolId = MagicSchools.Instances.Conjuration.ID,
                ClassId = Classes.Instances.Summoner.ID
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("5c933ce5-46e0-46bc-9fd9-a592d4006caa"), Type = TextBlockType.Text, Text = "You loosen the link between yourself and your eidolon, allowing it to travel farther from you for a short period of time. While the spell is active, your eidolon can travel an unlimited distance away from you. When the spell ends, if your eidolon is more than 100 feet away from you, it unmanifests." };
        }

        public override IEnumerable<Guid> GetSpellComponents()
        {
            yield return SpellComponents.Instances.Somatic.ID;
            yield return SpellComponents.Instances.Verbal.ID;
        }

        public override void GetTraits(ITraitBindingBuilder<SpellTraitBinding, Spell> builder)
        {
            builder.Add(Guid.Parse("f496f4cd-9e1e-4447-9637-e7e620e1fca7"), Traits.Instances.Uncommon.ID);
            builder.Add(Guid.Parse("27c88fac-aa62-40f2-a5c3-ad76fb2c9ac3"), Traits.Instances.Abjuration.ID);
            builder.Add(Guid.Parse("5b201c2f-aef5-4b06-ab6d-201e2fda6d5b"), Traits.Instances.Summoner.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("32fb381a-5d5d-4f06-a833-aaa5709a5f86"),
                SourceId = Sources.Instances.SecretsOfMagic.ID,
                Page = 145
            };
        }
    }
}
