using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Spells.Instances
{
    public class Moonbeam : Template
    {
        public static readonly Guid ID = Guid.Parse("cfbc43c2-20e0-4693-bb22-6cea19de9663");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Moonbeam",
                Level = 1,
                Range = "120 feet.",
                Targets = "1 creature.",
                DomainId = Domains.Instances.Moon.ID,
                ActionTypeId = ActionTypes.Instances.TwoActions.ID,
                ClassId = Classes.Instances.Cleric.ID,
                SpellTypeId = SpellTypes.Instances.Focus.ID,
                MagicSchoolId = MagicSchools.Instances.Evocation.ID
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("9511d280-6294-4066-a476-5c96b395c7ec"), Type = TextBlockType.Text, Text = "You shine a ray of moonlight. Make a spell attack roll. The beam of light deals 1d6 fire damage. Moonbeam deals silver damage for the purposes of weaknesses, resistances, and the like." };
        }

        public override IEnumerable<SpellHeightening> GetHeightenings()
        {
            yield return new SpellHeightening
            {
                Id = Guid.Parse("e9b9de5b-84f6-4438-84c0-a25e670a7643"),
                Level = "+1",
                Details =
                {
                    new TextBlock { Id = Guid.Parse("66aec60a-6b67-4ac2-b7ef-60f1a39c31fe"), Type = TextBlockType.Text, Text = "The ray’s damage increases by 1d6." }
                }
            };
        }

        public override IEnumerable<RollableEffect> GetRollableEffects()
        {
            yield return new RollableEffect
            {
                Id = Guid.Parse("c67881ff-350a-41d8-b0c6-a3ab5078c1b4"),
                CriticalSuccess = "The beam deals double damage, and the target is dazzled for 1 minute.",
                Success = "The beam deals full damage, and the target is dazzled for 1 round.",
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
            yield return Traits.Instances.Light.ID;
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("28c2b79b-e162-464b-ba5d-897d2eadcb9a"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 394
            };
        }
    }
}
