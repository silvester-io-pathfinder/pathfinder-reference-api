using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.Traits;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Spells.Instances
{
    public class Passwall : Template
    {
        public static readonly Guid ID = Guid.Parse("d52d7b40-155d-479a-810e-8fcacba938dd");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Passwall",
                Level = 5,
                Area = "5-foot-wide, 10-foot-tall, 10-foot-deep section of wooden, plaster or stone wall.",
                Duration = "1 hour.",
                SpellTypeId = SpellTypes.Instances.Spell.ID,
                ActionTypeId = ActionTypes.Instances.TwoActions.ID,
                MagicSchoolId = MagicSchools.Instances.Conjuration.ID
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("2e877aaf-95a1-4bb0-9091-6c0425dfb4d6"), Type = TextBlockType.Text, Text = "You create a visible tunnel through the wall in the chosen area, replacing the area with empty space. If the wall is thicker than 10 feet, the tunnel ends 10 feet in. Even a small layer of metal in the wall prevents this spell from functioning. This spell doesn't reduce the integrity of the structure. When the spell ends, anyone inside the tunnel is shunted to the nearest exit." };
        }

        public override IEnumerable<SpellHeightening> GetHeightenings()
        {
            yield return new SpellHeightening
            {
                Id = Guid.Parse("370ff96a-6ae8-4b7b-9693-5b2b2c3a8dde"), 
                Level = "7th",
                Details =
                {
                    new TextBlock { Id = Guid.Parse("63ea6003-fe0b-47ac-8ff8-77e43f430d01"), Type = TextBlockType.Text, Text = "The tunnel can be up to 20 feet deep. The areas of the wall that contain your tunnel's entrance appear completely normal (unless viewed with true seeing or a similar effect), despite the tunnel's existence. The tunnel's entrance functions as a solid wall, but you can specify a password or a trigger (page 305), allowing creatures to enter the tunnel freely." }
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
            yield return MagicTraditions.Instances.Primal.ID;
        }

        public override void GetTraits(ITraitBindingBuilder<SpellTraitBinding, Spell> builder)
        {
            builder.Add(Guid.Parse("74df135e-4774-4c16-8f86-4aec3653e922"), Traits.Instances.Uncommon.ID);
            builder.Add(Guid.Parse("7ee2dd0f-516a-4486-b422-418e3fcdcc16"), Traits.Instances.Conjuration.ID);
            builder.Add(Guid.Parse("b213e3c2-e9f3-4016-8867-1eeef7cead68"), Traits.Instances.Earth.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("f9f1cc80-5dac-4a58-b28b-12d221bb9a0e"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 356
            };
        }
    }
}
