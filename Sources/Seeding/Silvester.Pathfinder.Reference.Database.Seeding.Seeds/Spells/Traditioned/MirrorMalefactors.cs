using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.Traits;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Spells.Instances
{
    public class MirrorMalefactors : Template
    {
        public static readonly Guid ID = Guid.Parse("d88e7f92-0ec4-43b1-9b47-9310106f32b3");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Mirror Malefactors",
                Level = 5,
                Range = "30 feet.",
                Duration = "Sustained up to 1 minute.",
                Targets = "1 creature.",
                IsDismissable = true,
                IsSavingThrowBasic = true,
                SavingThrowStatId = SavingThrowStats.Instances.Will.ID,
                SpellTypeId = SpellTypes.Instances.Spell.ID,
                ActionTypeId = ActionTypes.Instances.TwoActions.ID,
                MagicSchoolId = MagicSchools.Instances.Illusion.ID,
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("6d4dd6bd-918a-4f0b-a13c-d496071d4541"), Type = TextBlockType.Text, Text = "You completely surround a Large or smaller creature in a shimmering ring of illusory mirrors that follows it as it moves, even when the creature moves outside the range of the spell. These mirrors reflect the target, though if the target has no reflection, like a vampire, it�s unaffected by mirror malefactors. As long as the target is surrounded by mirrors, it�s frightened 1, and it can�t reduce its frightened value." };
            yield return new TextBlock { Id = Guid.Parse("fb33a28a-7d8b-4e14-b3ab-8f838e5aa725"), Type = TextBlockType.Text, Text = "When you Cast the Spell, the reflections leap from the mirrors and attack the target, dealing 7d8 mental damage with a basic Will save. On subsequent turns, this effect repeats the first time you Sustain the spell that turn. If the target succeeds at any Will save it attempts against mirror malefactors, the illusory mirrors shatter and the spell ends." };
        }

        public override IEnumerable<SpellHeightening> GetHeightenings()
        {
            yield return new SpellHeightening
            {
                Id = Guid.Parse("a73ed30b-333a-4085-a2f7-cd7f92f6e52b"),
                Level = "+1",
                Details = new TextBlock[]
                {
                    new TextBlock {Id = Guid.Parse("be546135-0477-4c8e-8146-eca53795754a"), Type = TextBlockType.Text, Text = "The damage for both the initial effect and on subsequent turns increases by 1d8." }
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
            yield return MagicTraditions.Instances.Divine.ID;
            yield return MagicTraditions.Instances.Occult.ID;
        }

        public override void GetTraits(ITraitBindingBuilder<SpellTraitBinding, Spell> builder)
        {
            builder.Add(Guid.Parse("9dfcc11c-76a4-4c85-8144-afb9b218acc2"), Traits.Instances.Illusion.ID);
            builder.Add(Guid.Parse("33fa62be-e99b-47ab-a72c-46b4bd987cb5"), Traits.Instances.Mental.ID);
            builder.Add(Guid.Parse("07177f0b-5438-483c-b2a9-4a3ba4d6c02d"), Traits.Instances.Visual.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("53d17b3a-d245-481f-aadb-5ed299c2d339"),
                SourceId = Sources.Instances.SecretsOfMagic.ID,
                Page = 116
            };
        }
    }
}
