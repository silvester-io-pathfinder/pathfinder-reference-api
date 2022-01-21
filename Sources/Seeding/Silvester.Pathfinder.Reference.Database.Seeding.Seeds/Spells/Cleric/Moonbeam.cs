using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.Traits;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Spells.Instances
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
                    new TextBlock { Id = Guid.Parse("66aec60a-6b67-4ac2-b7ef-60f1a39c31fe"), Type = TextBlockType.Text, Text = "The ray's damage increases by 1d6." }
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

        public override void GetTraits(ITraitBindingBuilder<SpellTraitBinding, Spell> builder)
        {
            builder.Add(Guid.Parse("43224932-4755-4e21-84d0-8cb178b47248"), Traits.Instances.Uncommon.ID);
            builder.Add(Guid.Parse("d858ec81-398b-4d88-a7a8-dac68ff042a9"), Traits.Instances.Attack.ID);
            builder.Add(Guid.Parse("b6aae3df-b69e-42d4-a050-84615575ab7d"), Traits.Instances.Cleric.ID);
            builder.Add(Guid.Parse("f7043fd8-1fbb-4380-a217-7a311693090b"), Traits.Instances.Evocation.ID);
            builder.Add(Guid.Parse("7354cb9e-f03a-46ef-985a-d6eaac6ca266"), Traits.Instances.Fire.ID);
            builder.Add(Guid.Parse("f92179e3-10c4-47e5-aa9c-d02f8b34dbd3"), Traits.Instances.Light.ID);
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
