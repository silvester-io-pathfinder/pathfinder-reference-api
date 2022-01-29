using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.Traits;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Spells.Instances
{
    public class PocketLibrary : Template
    {
        public static readonly Guid ID = Guid.Parse("99cf2290-85db-4c26-8939-7bb393102a11");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Pocket Library",
                Level = 1,
                Duration = "24 hours.",
                SpellTypeId = SpellTypes.Instances.Spell.ID,
                ActionTypeId = ActionTypes.Instances.ThreeActions.ID,
                MagicSchoolId = MagicSchools.Instances.Divination.ID,
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("f786b1a6-b475-4364-956e-5f20be661ff9"), Type = TextBlockType.Text, Text = "You collect information from the world's libraries about a particular subject and store it in an extradimensional library. When you Cast this Spell, choose any skill in which you are at least trained that has the Recall Knowledge action." };
            yield return new TextBlock { Id = Guid.Parse("815dbbb4-e1c9-4066-a277-473654a5ac3a"), Type = TextBlockType.Text, Text = "During the duration of this spell, you can call forth a tome from the extradimensional library when attempting a Recall Knowledge check using your chosen skill. This is part of the action to Recall Knowledge. You must have a hand free to do so. The tome appears in your hand, open to an appropriate page. This grants you a +1 status bonus on the Recall Knowledge check. If you roll a critical failure on this check, you get a failure instead. If the roll is successful and the subject is a creature, you gain additional information or context about the creature. Once you reference a book from your pocket library, the spell ends." };
        }

        public override IEnumerable<SpellHeightening> GetHeightenings()
        {
            yield return new SpellHeightening
            {
                Id = Guid.Parse("75d6f730-8a77-490f-8807-3f2625510098"),
                Level = "3rd",
                Details = new TextBlock[]
                {
                    new TextBlock {Id = Guid.Parse("bf56bcd7-0bad-42ea-af62-d17cd6fec4b2"), Type = TextBlockType.Text, Text = "The status bonus increases to +2 and you can reference your pocket library twice before the spell ends." }
                }
            };

            yield return new SpellHeightening
            {
                Id = Guid.Parse("7241de3d-c072-4e1a-aa46-55739d6a07d1"),
                Level = "6th",
                Details = new TextBlock[]
                {
                    new TextBlock {Id = Guid.Parse("d114aac2-2380-4bcf-87d0-82e321567fd1"), Type = TextBlockType.Text, Text = "The status bonus increases to +3 you can reference your pocket library three times before the spell ends." }
                }
            };

            yield return new SpellHeightening
            {
                Id = Guid.Parse("43c05944-7913-4ec9-9b82-6b24a99f4620"),
                Level = "9th",
                Details = new TextBlock[]
                {
                    new TextBlock {Id = Guid.Parse("f1f2ca3f-d5d1-4498-8b5a-b450598b14f5"), Type = TextBlockType.Text, Text = "The status bonus increases to +4 and you can reference your pocket library four times before the spell ends." }
                }
            };
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
            builder.Add(Guid.Parse("931bfec9-cfe7-4a82-a78e-419e7f3afbbe"), Traits.Instances.Divination.ID);
            builder.Add(Guid.Parse("d8bf1f20-64ad-47ff-93d5-3e08e2c8d234"), Traits.Instances.Extradimensional.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("27f08c40-6998-4cd7-a719-8ba2ec9178af"),
                SourceId = Sources.Instances.SecretsOfMagic.ID,
                Page = 122
            };
        }
    }
}
