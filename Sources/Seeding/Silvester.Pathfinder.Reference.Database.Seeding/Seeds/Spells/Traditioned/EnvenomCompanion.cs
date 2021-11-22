using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Spells.Instances
{
    public class EnvenomCompanion : Template
    {
        public static readonly Guid ID = Guid.Parse("1379110c-82a3-40df-9687-8a75f80afc08");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Envenom Companion",
                Level = 3, 
                Range = "30 feet.",
                Duration = "1 minute.",
                Targets = "Your companion or eidolon.",
                SpellTypeId = SpellTypes.Instances.Spell.ID,
                ActionTypeId = ActionTypes.Instances.TwoActions.ID,
                MagicSchoolId = MagicSchools.Instances.Necromancy.ID,
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("c8929e17-0e4d-4049-8e4c-719b8835b5d4"), Type = TextBlockType.Text, Text = "You envenom your companion or eidolon�s attacks, which drip with highly toxic venom for the spell�s duration. The first time each round the target hits a creature with an unarmed Strike that deals piercing or slashing damage, that Strike deals an additional 1d8 poison damage. A creature that is damaged by this poison must attempt a Fortitude save. On a failure, it�s also clumsy 1 for 1 round." };
            yield return new TextBlock { Id = Guid.Parse("14918198-74d8-49da-b37f-dea8814d391f"), Type = TextBlockType.Text, Text = "This spell can�t target familiars." };
        }

        public override IEnumerable<SpellHeightening> GetHeightenings()
        {
            yield return new SpellHeightening
            {
                Id = Guid.Parse("28bf6fb1-577c-4dd4-be6e-f30213d97a7d"),
                Level = "+3",
                Details = new TextBlock[]
                {
                    new TextBlock {Id = Guid.Parse("8fe8461e-0312-496e-a081-5043ba648430"), Type = TextBlockType.Text, Text = "The poison damage increases by 1d8 and the clumsy value imposed on a failed save increases by 1." }
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
            yield return MagicTraditions.Instances.Primal.ID;
        }

        public override IEnumerable<Guid> GetTraits()
        {
            yield return Traits.Instances.Necromancy.ID;
            yield return Traits.Instances.Poison.ID;
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("b678e147-9139-460b-8691-20d47851d493"),
                SourceId = Sources.Instances.SecretsOfMagic.ID,
                Page = 104
            };
        }
    }
}
