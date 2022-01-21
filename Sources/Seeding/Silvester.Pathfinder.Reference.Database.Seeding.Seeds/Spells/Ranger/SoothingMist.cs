using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.Traits;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Spells.Instances
{
    public class SoothingMist : Template
    {
        public static readonly Guid ID = Guid.Parse("2bf89058-1276-4f86-a62c-f41b8a6a8dfa");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Soothing Mist",
                Level = 2,
                Range = "30 feet.",
                Targets = "1 willing living creature or 1 undead creature.",
                ActionTypeId = ActionTypes.Instances.TwoActions.ID,
                ClassId = Classes.Instances.Ranger.ID,
                SpellTypeId = SpellTypes.Instances.Focus.ID,
                MagicSchoolId = MagicSchools.Instances.Necromancy.ID,
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("a17c6df8-7c8b-49a9-97d1-fb7dfb379964"), Type = TextBlockType.Text, Text = "You call forth a magical mist of positive energy that envelops a creature. The mist restores 2d8 Hit Points to a target living creature and ends one source of persistent acid, bleed, fire, negative, or poison damage affecting it. If the creature is taking persistent damage from multiple sources, you select which one is removed. Against an undead target, you deal 2d8 positive damage (basic Fortitude save); if it fails the save, it also takes 2 persistent positive damage." };
        }

        public override IEnumerable<SpellHeightening> GetHeightenings()
        {
            yield return new SpellHeightening
            {
                Id = Guid.Parse("c24c38ed-1c08-4878-a164-fc64cb6b1acf"),
                Level = "+1",
                Details =
                {
                    new TextBlock { Id = Guid.Parse("aed1debb-e71e-41a1-961a-64f8b902110f"), Type = TextBlockType.Text, Text = "The amount of healing (or damage to an undead target) increases by 1d8, and the persistent positive damage to an undead creature increases by 1." }
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
            builder.Add(Guid.Parse("7eed6aa9-4bfb-4f09-bd7b-38b78e5388b3"), Traits.Instances.Uncommon.ID);
            builder.Add(Guid.Parse("d18e86c6-d7ad-4b45-9380-6cf22046d45b"), Traits.Instances.Healing.ID);
            builder.Add(Guid.Parse("790b640c-be50-41ce-a9c9-57b897cee2bf"), Traits.Instances.Necromancy.ID);
            builder.Add(Guid.Parse("76a41312-88b4-4cf7-ba07-fe76f3e289f4"), Traits.Instances.Positive.ID);
            builder.Add(Guid.Parse("4652cc88-fd53-4b40-ab97-b3e4ce8235ae"), Traits.Instances.Ranger.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("992be818-7a11-4655-9a86-055367d4b533"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = 235
            };
        }
    }
}
