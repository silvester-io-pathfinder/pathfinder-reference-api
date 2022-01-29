using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.Traits;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Spells.Instances
{
    public class TimelyTutor : Template
    {
        public static readonly Guid ID = Guid.Parse("454389ff-915e-494c-9228-f2134a847768");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Timely Tutor",
                Level = 2,
                Range = "Touch.",
                Duration = "Sustained up to 1 minute.",
                Targets = "Your eidolono or familiar.",
                IsDismissable = true,
                SpellTypeId = SpellTypes.Instances.Spell.ID,
                ActionTypeId = ActionTypes.Instances.OneAction.ID,
                MagicSchoolId = MagicSchools.Instances.Divination.ID,
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("9dff4690-cb96-4edd-bb62-6850919ffd08"), Type = TextBlockType.Text, Text = "You serve as an astral connection between your eidolon or familiar and the Akashic Record'a demiplane consisting of a comprehensive psychic library - then turn to the creature for advice. If you cast this spell on your familiar, your familiar adds your spellcasting ability modifier on checks to Recall Knowledge with the Lore skill of your choice, much like it does for Acrobatics and Stealth. Your familiar must have the speech familiar ability in order to share any information it learns with you. If you cast this spell on your eidolon, it instead becomes trained in the Lore skill." };
            yield return new TextBlock { Id = Guid.Parse("b05bde10-4978-4bf5-b7e7-79d952ae9f43"), Type = TextBlockType.Text, Text = "If you lose physical contact with the target, its connection to the Akashic Record is severed and timely tutor immediately ends." };
        }

        public override IEnumerable<Guid> GetSpellComponents()
        {
            yield return SpellComponents.Instances.Somatic.ID;
        }

        public override IEnumerable<Guid> GetMagicTraditions()
        {
            yield return MagicTraditions.Instances.Arcane.ID;
            yield return MagicTraditions.Instances.Occult.ID;
        }

        public override void GetTraits(ITraitBindingBuilder<SpellTraitBinding, Spell> builder)
        {
            builder.Add(Guid.Parse("c2992f32-f687-4f3b-ac5f-8dd36f844fb4"), Traits.Instances.Divination.ID);
            builder.Add(Guid.Parse("6f747661-a68f-44a8-a44c-3afa265a4615"), Traits.Instances.Mental.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("b5b0dd5e-4985-45ac-bc70-a632f63a8198"),
                SourceId = Sources.Instances.SecretsOfMagic.ID,
                Page = 137
            };
        }
    }
}
