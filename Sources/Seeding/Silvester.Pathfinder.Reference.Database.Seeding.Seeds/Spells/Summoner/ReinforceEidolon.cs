using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.Traits;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Spells.Instances
{
    public class ReinforceEidolon : Template
    {
        public static readonly Guid ID = Guid.Parse("4c34e2dc-9589-49bf-9a6b-d68e31387374");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Rïnforce Eidolon",
                Level = 1,
                Range = "100 feet.",
                Targets = "Your eidolon.",
                Duration = "1 round.",
                ActionTypeId = ActionTypes.Instances.OneAction.ID,
                SpellTypeId = SpellTypes.Instances.Cantrip.ID,
                MagicSchoolId = MagicSchools.Instances.Abjuration.ID,
                ClassId = Classes.Instances.Summoner.ID
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("d5558a24-eb63-4637-ace0-6dff79b64780"), Type = TextBlockType.Text, Text = "You focus deeply on the link between you and your eidolon and reinforce your eidolon's defenses. Your eidolon gains a +1 status bonus to AC and saving throws, plus resistance to all damage equal to half the spell's level. Your eidolon can benefit from either boost eidolon or reinforce eidolon, but not both; if you cast one of these spells during the other's duration, the newer spell replaces the older one." };
        }

        public override IEnumerable<Guid> GetSpellComponents()
        {
            yield return SpellComponents.Instances.Verbal.ID;
        }

        public override void GetTraits(ITraitBindingBuilder<SpellTraitBinding, Spell> builder)
        {
            builder.Add(Guid.Parse("97850275-f0ce-43f8-a9f1-812a08a12459"), Traits.Instances.Uncommon.ID);
            builder.Add(Guid.Parse("a5d11741-9816-4483-bc99-c405724a21b6"), Traits.Instances.Abjuration.ID);
            builder.Add(Guid.Parse("87514d6f-6aa8-4145-a541-936db5ae70ad"), Traits.Instances.Cantrip.ID);
            builder.Add(Guid.Parse("ece74dd0-99a9-4cb8-bb6f-120a7beda271"), Traits.Instances.Summoner.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("6d9c352c-6a0f-4e0f-97c8-e4f810740e0e"),
                SourceId = Sources.Instances.SecretsOfMagic.ID,
                Page = 145
            };
        }
    }
}
