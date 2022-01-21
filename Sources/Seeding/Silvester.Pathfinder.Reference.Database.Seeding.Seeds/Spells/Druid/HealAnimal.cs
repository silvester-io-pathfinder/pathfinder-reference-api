using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.Traits;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Spells.Instances
{
    public class HealAnimal : Template
    {
        public static readonly Guid ID = Guid.Parse("3db9b6ca-f709-478e-8687-0a1a2f976299");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Heal Animal",
                Level = 1,
                Range = "Touch or 30 feet (see description).",
                Targets = "1 willing living animal creature.",
                ActionTypeId = ActionTypes.Instances.OneOrTwoActions.ID,
                ClassId = Classes.Instances.Druid.ID,
                SpellTypeId = SpellTypes.Instances.Focus.ID,
                MagicSchoolId = MagicSchools.Instances.Necromancy.ID
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("980b6d6c-efa8-4c88-bba0-bf40de62d090"), Type = TextBlockType.Text, Text = "You heal an animal's wounds, restoring 1d8 Hit Points to the target. The number of actions spent Casting this Spell determines its effect." };
            yield return new TextBlock { Id = Guid.Parse("90ea1170-4f91-4335-aede-e662f1022afb"), Type = TextBlockType.Enumeration, Text = "[one-action] Somatic - The spell has a range of touch." };
            yield return new TextBlock { Id = Guid.Parse("ddc9439f-bc13-42ab-97f0-8f2d3996983a"), Type = TextBlockType.Enumeration, Text = "[two-actions] Somatic, Verbal - The spell has a range of 30 feet and restores an additional 8 Hit Points to the target." };
        }

        public override IEnumerable<SpellHeightening> GetHeightenings()
        {
            yield return new SpellHeightening
            {
                Id = Guid.Parse("4ae1bb3a-803b-460d-9af4-8c1f226c4198"),
                Level = "+1",
                Details =
                {
                    new TextBlock { Id = Guid.Parse("434abe8f-ce98-4bb1-9f68-1cfa0a1e470a"), Type = TextBlockType.Text, Text = "The amount of healing increases by 1d8, and the additional healing for the 2-action version increases by 8." }
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
            builder.Add(Guid.Parse("d570a1ce-ba13-4745-82a3-39d24a631c11"), Traits.Instances.Uncommon.ID);
            builder.Add(Guid.Parse("5e683d0d-dac3-45c6-8c3b-045c93d23c14"), Traits.Instances.Druid.ID);
            builder.Add(Guid.Parse("99b5383a-6eb4-4ad8-9a7e-94868abb6e8c"), Traits.Instances.Healing.ID);
            builder.Add(Guid.Parse("95094dde-9b94-4f46-9e82-829e1b2a41cc"), Traits.Instances.Necromancy.ID);
            builder.Add(Guid.Parse("f91f7a47-c4c8-44bd-aec3-4359bc8c6449"), Traits.Instances.Positive.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("e9abb2fd-7ef3-4207-bc1e-b4ad109ff707"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 399
            };
        }
    }
}
