using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
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

        public override IEnumerable<Guid> GetTraits()
        {
            yield return Traits.Instances.Uncommon.ID;
            yield return Traits.Instances.Abjuration.ID;
            yield return Traits.Instances.Summoner.ID;
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
