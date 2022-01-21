using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.Traits;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Spells.Instances
{
    public class ImpalingBriars : Template
    {
        public static readonly Guid ID = Guid.Parse("8e4c52b9-d093-4066-82fb-9a0f21b14abe");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Impaling Briars",
                Level = 8,
                Area = "Ground within a 100-foot emanation.",
                IsDismissable = true,
                Duration = "Sustained up to 1 minute.",
                ActionTypeId = ActionTypes.Instances.TwoActions.ID,
                ClassId = Classes.Instances.Druid.ID,
                SpellTypeId = SpellTypes.Instances.Focus.ID,
                MagicSchoolId = MagicSchools.Instances.Conjuration.ID
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("3b3dded3-4342-434a-8d86-5a5567e6d60f"), Type = TextBlockType.Text, Text = "The ground within the area transforms into a mass of dangerous briars that assault and impede your foes. The first time each round you Sustain the Spell, you can select one of the following effects to occur in the area." };
            yield return new TextBlock { Id = Guid.Parse("4adb9aee-1b88-4ab8-8c18-9dee868f2c42"), Type = TextBlockType.Enumeration, Text = "Ensnare - The briars clump around your foes, attempting to hold them in place. A foe within the area (or flying at most 20 feet above the area) must attempt a Reflex save. On a failure, it takes a –10-foot circumstance penalty to all Speeds for 1 round, and on a critical failure, it is immobilized for 1 round unless it Escapes." };
            yield return new TextBlock { Id = Guid.Parse("e66fcbba-94df-47f9-9c16-3fced0285790"), Type = TextBlockType.Enumeration, Text = "Impede - The briars twist and writhe, making the entire area difficult terrain." };
            yield return new TextBlock { Id = Guid.Parse("44948da4-9036-47a9-bfbc-6435441c5204"), Type = TextBlockType.Enumeration, Text = "Wall - A wall of thorns appears in the area, lasting for 1 round. The wall is greater difficult terrain instead of difficult terrain." };
            yield return new TextBlock { Id = Guid.Parse("fcc7cf18-07bf-462d-98c0-0090db9c269d"), Type = TextBlockType.Text, Text = "In addition, once per round you can direct the briars to impale any target in the area (or flying up to 20 feet above the area) that you can see by using a single action, which has the concentrate and manipulate traits. Make a spell attack roll. On a success, the target takes 10d6 piercing damage and takes a –10-foot circumstance penalty to all Speeds for 1 round; on a critical success, the target is immobilized for 1 round unless it Escapes." };
        }

        public override IEnumerable<Guid> GetSpellComponents()
        {
            yield return SpellComponents.Instances.Somatic.ID;
            yield return SpellComponents.Instances.Verbal.ID;
        }

        public override void GetTraits(ITraitBindingBuilder<SpellTraitBinding, Spell> builder)
        {
            builder.Add(Guid.Parse("09db5e23-12d6-4ab0-bd5d-34c64faa6b38"), Traits.Instances.Uncommon.ID);
            builder.Add(Guid.Parse("95df896b-9a28-4d0f-a03f-e4e49e6006cc"), Traits.Instances.Conjuration.ID);
            builder.Add(Guid.Parse("2cb495fd-cc1d-47ee-93d9-f730eb9b0e47"), Traits.Instances.Druid.ID);
            builder.Add(Guid.Parse("2519005d-466f-4bae-806b-b5eef067867d"), Traits.Instances.Plant.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("4dc5f768-b768-4a44-840c-229ea4c2951f"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 400
            };
        }
    }
}
