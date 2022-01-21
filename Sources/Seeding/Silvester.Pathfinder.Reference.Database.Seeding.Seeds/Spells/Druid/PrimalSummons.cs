using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.Traits;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Spells.Instances
{
    public class PrimalSummons : Template
    {
        public static readonly Guid ID = Guid.Parse("498f92df-8e2f-40a3-b93c-963ce144a79c");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Primal Summons",
                Level = 6,
                ActionTypeId = ActionTypes.Instances.FreeAction.ID,
                ClassId = Classes.Instances.Druid.ID,
                SpellTypeId = SpellTypes.Instances.Focus.ID,
                MagicSchoolId = MagicSchools.Instances.Conjuration.ID
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("35997cda-93ce-4310-bf7b-c801325c0a3c"), Type = TextBlockType.Text, Text = "You enhance a summoned creature with the power of the elements. If your next action is to cast either summon animal or summon plant or fungus, choose air, earth, fire, or water, and the creature you summon gains the corresponding abilities." };
            yield return new TextBlock { Id = Guid.Parse("4850e664-3902-406d-8748-9439c18475c9"), Type = TextBlockType.Enumeration, Text = "Air - The creature gains a fly Speed of 60 feet." };
            yield return new TextBlock { Id = Guid.Parse("3c474e17-dbe5-4d42-9f96-78bf69285d90"), Type = TextBlockType.Enumeration, Text = "Earth - The creature gains a burrow Speed of 20 feet, reduces its land Speed by 10 feet (minimum 5 feet), and gains resistance 5 to physical damage." };             
            yield return new TextBlock { Id = Guid.Parse("51c6c4e7-0ba4-4b47-8041-4d487c86dc58"), Type = TextBlockType.Enumeration, Text = "Fire - The creature's attacks deal 1d6 extra fire damage, and it gains resistance 10 to fire and weakness 5 to cold and water." };
            yield return new TextBlock { Id = Guid.Parse("93cd51b6-da22-412a-b9d7-b690991c4fd7"), Type = TextBlockType.Enumeration, Text = "Water - The creature gains a swim Speed of 60 feet, can spend 1 action after a melee attack to attempt a Shove (ignoring multiple attack penalty), and gains resistance 5 to fire." };
        }

        public override IEnumerable<Guid> GetSpellComponents()
        {
            yield return SpellComponents.Instances.Verbal.ID;
        }

        public override void GetTraits(ITraitBindingBuilder<SpellTraitBinding, Spell> builder)
        {
            builder.Add(Guid.Parse("326013b9-fbc4-46b3-9cea-468e8966f416"), Traits.Instances.Uncommon.ID);
            builder.Add(Guid.Parse("ff051462-824b-4c2b-8d9d-99e17f7758dc"), Traits.Instances.Conjuration.ID);
            builder.Add(Guid.Parse("ae10fae0-f6d0-4e8b-b219-8290b37cc407"), Traits.Instances.Druid.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("ad3be29c-9272-4204-b7c7-20001e9dbe2e"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 400
            };
        }
    }
}
