using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.Traits;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Spells.Instances
{
    public class GravitationalPull : Template
    {
        public static readonly Guid ID = Guid.Parse("7f206aa8-5a5d-4f07-868b-5b16d85813ed");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Gravitational Pull",
                Level = 1,
                Range = "30 feet.",
                Targets = "1 creature.",
                IsSavingThrowBasic = false,
                SavingThrowStatId = SavingThrowStats.Instances.Fortitude.ID,
                SpellTypeId = SpellTypes.Instances.Spell.ID,
                ActionTypeId = ActionTypes.Instances.OneToThreeActions.ID,
                MagicSchoolId = MagicSchools.Instances.Evocation.ID,
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("6ef9ebdb-bc56-4cc0-a755-bb48382938e1"), Type = TextBlockType.Text, Text = "By suddenly altering gravity, you pull the target toward you. The target is pulled 10 feet closer to you unless it succeeds at a Fortitude save. On a critical failure, it�s also knocked prone. The effects of this spell change depending on the number of actions you spend when you Cast this Spell." };
            yield return new TextBlock { Id = Guid.Parse("de1ff7dc-3494-4c4b-996f-1fda2edcd985"), Type = TextBlockType.Enumeration, Text = "[one-action] (somatic) The spell targets one creature." };
            yield return new TextBlock { Id = Guid.Parse("ed9774a9-c7aa-4cc2-855f-d24276c0491e"), Type = TextBlockType.Enumeration, Text = "[two-actions] (somatic, verbal) The spell targets one creature and pulls the target 20 feet instead of 10." };
            yield return new TextBlock { Id = Guid.Parse("2f8f4376-3e28-4d11-90b8-2d22f851059e"), Type = TextBlockType.Enumeration, Text = "[three-actions] (material, somatic, verbal) The spell targets up to 5 creatures." };
        }

        public override IEnumerable<Guid> GetSpellComponents()
        {
            yield return SpellComponents.Instances.Material.ID;
            yield return SpellComponents.Instances.Somatic.ID;
            yield return SpellComponents.Instances.Verbal.ID;
        }

        public override IEnumerable<Guid> GetMagicTraditions()
        {
            yield return MagicTraditions.Instances.Arcane.ID;
            yield return MagicTraditions.Instances.Occult.ID;
        }

        public override void GetTraits(ITraitBindingBuilder<SpellTraitBinding, Spell> builder)
        {
            builder.Add(Guid.Parse("304de1d5-a0c9-4439-b9b7-9ad9199e0c30"), Traits.Instances.Evocation.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("accb2418-d695-4de1-b80a-6f9758d3a8e0"),
                SourceId = Sources.Instances.SecretsOfMagic.ID,
                Page = 109
            };
        }
    }
}
