using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.Traits;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Spells.Instances
{
    public class ChromaticArmor : Template
    {
        public static readonly Guid ID = Guid.Parse("c57e823c-abf7-4566-96e9-3988a6111a73");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Chromatic Armor",
                Level = 4,
                Range = "Touch.",
                Duration = "1 minute.",
                Targets = "1 willing creature.",
                SpellTypeId = SpellTypes.Instances.Spell.ID,
                ActionTypeId = ActionTypes.Instances.TwoOrThreeActions.ID,
                MagicSchoolId = MagicSchools.Instances.Abjuration.ID,
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("fe04df6b-1aa1-4bc8-a639-199962c193df"), Type = TextBlockType.Text, Text = "You wrap the target in armor made of sheets of colored light. The armor sheds bright light for 20 feet (and dim light for the next 20 feet). Whenever a creature attacks the target and is adjacent to it, the attacker must attempt a Will save at the end of its action. On a failure, it becomes dazzled until the end of its next turn. Regardless of the result of the save, the attacker is temporarily immune until the end of its next turn. The dazzling effect has the light and visual traits." };
            yield return new TextBlock { Id = Guid.Parse("d7715b53-e1e1-4fce-866d-23c7a117f1ec"), Type = TextBlockType.Text, Text = "When you cast the spell, roll 1d8 twice on the table below to see the armor�s colors (rerolling any duplicates). Each color grants resistance 5 to the indicated damage type. If you spend three actions to Cast the Spell, roll three times instead." };
            yield return new TextBlock { Id = Guid.Parse("ff01b136-7f18-4688-b362-5a1e349123e5"), Type = TextBlockType.Enumeration, Text = "1. Red - Fire" };
            yield return new TextBlock { Id = Guid.Parse("abeecde2-8bba-4523-bdcb-6e5f1b840ef0"), Type = TextBlockType.Enumeration, Text = "2. Orange - Acid" };
            yield return new TextBlock { Id = Guid.Parse("bd114d95-de4c-4b97-bbe3-8df0a9c9430f"), Type = TextBlockType.Enumeration, Text = "3. Yellow - Electricity" };
            yield return new TextBlock { Id = Guid.Parse("1c728214-ed8f-4c56-a43f-c28adeaffcb4"), Type = TextBlockType.Enumeration, Text = "4. Green - Poison" };
            yield return new TextBlock { Id = Guid.Parse("76051d1f-f389-41ec-96d8-a44ef4a50664"), Type = TextBlockType.Enumeration, Text = "5. Blue - Sonic" };
            yield return new TextBlock { Id = Guid.Parse("c01391a0-456b-415d-9092-ab8d479d8efc"), Type = TextBlockType.Enumeration, Text = "6. Indigo - Mental" };
            yield return new TextBlock { Id = Guid.Parse("f8a1f19c-3bb3-4060-9f1a-851aebcddac8"), Type = TextBlockType.Enumeration, Text = "7. Violet - Force" };
            yield return new TextBlock { Id = Guid.Parse("2cca635f-58c4-44da-81bb-4c4149ae8f97"), Type = TextBlockType.Enumeration, Text = "8. Matching Color - The armor becomes the color matching the type of damage the target took most recently in the past minute. If it didn�t take any of those seven types of damage or the armor is already that color, roll again, rerolling any results of 8." };
        }

        public override IEnumerable<SpellHeightening> GetHeightenings()
        {
            yield return new SpellHeightening
            {
                Id = Guid.Parse("560df358-85c6-4e75-a876-5814b4cd4521"),
                Level = "+3",
                Details = new TextBlock[]
                {
                    new TextBlock {Id = Guid.Parse("bf389a64-30ed-4d3d-969b-1f5f93694ae9"), Type = TextBlockType.Text, Text = "The resistance is increased by 5." }
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
            yield return MagicTraditions.Instances.Occult.ID;
        }

        public override void GetTraits(ITraitBindingBuilder<SpellTraitBinding, Spell> builder)
        {
            builder.Add(Guid.Parse("9cc08bd2-6326-4cce-9aca-bdca74496baa"), Traits.Instances.Abjuration.ID);
            builder.Add(Guid.Parse("1e3421c2-7b54-4f53-80e9-9561168308b4"), Traits.Instances.Light.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("89b4bd6a-b03c-480e-8abe-29f877f9f019"),
                SourceId = Sources.Instances.SecretsOfMagic.ID,
                Page = 95
            };
        }
    }
}
