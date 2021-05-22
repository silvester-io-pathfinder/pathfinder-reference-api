using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Spells.Instances
{
    public class FireRay : Template
    {
        public static readonly Guid ID = Guid.Parse("790901b2-edb3-46e3-bfcc-fdef8c10efaf");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Fire Ray",
                Level = 1,
                Range = "60 feet.",
                Targets = "1 creature.",
                DomainId = Domains.Instances.Fire.ID,
                ActionTypeId = ActionTypes.Instances.TwoActions.ID,
                ClassId = Classes.Instances.Cleric.ID,
                SpellTypeId = SpellTypes.Instances.Focus.ID,
                MagicSchoolId = MagicSchools.Instances.Evocation.ID
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("e592b767-da46-48f3-821a-96c3439278fb"), Type = TextBlockType.Text, Text = "A blazing band of fire arcs through the air. Make a spell attack roll. The ray deals 2d6 fire damage." };
        }

        public override IEnumerable<SpellHeightening> GetHeightenings()
        {
            yield return new SpellHeightening
            {
                Id = Guid.Parse("b6d01a8d-1b9e-485c-9e85-c6abc8002e30"),
                Level = "+1",
                Details =
                {
                    new TextBlock { Id = Guid.Parse("6f24b88d-aeb0-419e-9ef0-d7719aa0c0e8"), Type = TextBlockType.Text, Text = "The ray’s initial damage increases by 2d6, and the persistent fire damage on a critical success increases by 1d4." }
                }
            };
        }

        public override IEnumerable<RollableEffect> GetRollableEffects()
        {
            yield return new RollableEffect
            {
                Id = Guid.Parse("72fcfdb9-2202-461b-b322-afb311ce136f"),
                CriticalSuccess = "The ray deals double damage and 1d4 persistent fire damage.",
                Success = "The ray deals full damage",
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
            yield return Traits.Instances.Attack.ID;
            yield return Traits.Instances.Cleric.ID;
            yield return Traits.Instances.Evocation.ID;
            yield return Traits.Instances.Fire.ID;
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("ad36cfb7-1740-41fc-b2b5-f641e45a7a49"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 392
            };
        }
    }
}
