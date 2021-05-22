using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Spells.Instances
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

        public override IEnumerable<Guid> GetTraits()
        {
            yield return Traits.Instances.Uncommon.ID;
            yield return Traits.Instances.Air.ID;
            yield return Traits.Instances.Druid.ID;
            yield return Traits.Instances.Electricity.ID;
            yield return Traits.Instances.Evocation.ID;
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
