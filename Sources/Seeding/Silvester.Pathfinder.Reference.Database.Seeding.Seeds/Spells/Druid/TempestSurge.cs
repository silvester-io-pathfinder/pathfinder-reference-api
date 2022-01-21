using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.Traits;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Spells.Instances
{
    public class TempestSurge : Template
    {
        public static readonly Guid ID = Guid.Parse("01f09cc1-08fc-461b-a98c-cda84eb402f1");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Tempest Surge",
                Level = 1,
                Range = "30 feet.",
                Targets = "1 creature.",
                IsSavingThrowBasic = false,
                SavingThrowStatId = SavingThrowStats.Instances.Reflex.ID,
                ActionTypeId = ActionTypes.Instances.TwoActions.ID,
                ClassId = Classes.Instances.Druid.ID,
                SpellTypeId = SpellTypes.Instances.Focus.ID,
                MagicSchoolId = MagicSchools.Instances.Evocation.ID
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("d8e56efd-1c89-46b4-8857-c33a1c931c77"), Type = TextBlockType.Text, Text = "You surround a foe in a swirling storm of violent winds, roiling clouds, and crackling lightning. The storm deals 1d12 electricity damage. The target must attempt a basic Reflex save. On a failure, the target also is clumsy 2 for 1 round and takes 1 persistent electricity damage." };
        }

        public override IEnumerable<SpellHeightening> GetHeightenings()
        {
            yield return new SpellHeightening
            {
                Id = Guid.Parse("2d6a2cf6-00ff-40d4-91a9-ef790695c8a2"),
                Level = "+1",
                Details =
                {
                    new TextBlock { Id = Guid.Parse("71ffb91c-dc6a-459a-90ad-b90d1200b32a"), Type = TextBlockType.Text, Text = "The initial damage increases by 1d12, and the persistent electricity damage on a failure increases by 1." }
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
            builder.Add(Guid.Parse("c32c2f57-37f4-4a64-879d-719240175644"), Traits.Instances.Uncommon.ID);
            builder.Add(Guid.Parse("81c2808f-842a-47d2-b786-f872718ce184"), Traits.Instances.Air.ID);
            builder.Add(Guid.Parse("049c73e2-14d9-470b-851b-a1ee195ee749"), Traits.Instances.Druid.ID);
            builder.Add(Guid.Parse("14a443c0-d5e2-413a-930d-79a9e8e01cc7"), Traits.Instances.Electricity.ID);
            builder.Add(Guid.Parse("8f76aec8-cc81-486e-8914-8981893f4455"), Traits.Instances.Evocation.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("4aacbbdb-01a2-425f-990e-3b46589add36"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 400
            };
        }
    }
}
