using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.Traits;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Spells.Instances
{
    public class DreamCouncil : Template
    {
        public static readonly Guid ID = Guid.Parse("8f57f735-9139-4582-b54f-75bc96dbd515");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Dream Council",
                Level = 8,
                CastTime = "10 minutes.",
                Range = "Planetary.",
                IsDismissable = true,
                Duration = "1 hour.",
                Targets = "Up to 12 creature you know by name and have met in person.",
                SpellTypeId = SpellTypes.Instances.Spell.ID,
                ActionTypeId = ActionTypes.Instances.LongAction.ID,
                MagicSchoolId = MagicSchools.Instances.Illusion.ID
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("c2da22f8-00ee-4116-9bf5-0ec7f5f8beef"), Type = TextBlockType.Text, Text = "When you Cast this Spell, any targets (including you) can choose to immediately fall asleep. The spell ends for any creatures that don't choose to fall asleep. Sleepers join a shared dream, where they can communicate with one another as though they were in the same room. Individual targets leave this shared dream upon awakening, and if all the targets awaken, the spell ends." };
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
            builder.Add(Guid.Parse("e66a7f10-30ac-496a-80a9-89dbeef085e8"), Traits.Instances.Illusion.ID);
            builder.Add(Guid.Parse("f2907aae-15be-44f8-8613-6ac7928e04c6"), Traits.Instances.Mental.ID);
            builder.Add(Guid.Parse("cd6a0d13-cae5-47d7-99a9-0bba2a69988d"), Traits.Instances.Sleep.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("f8850286-3790-4dd2-ad77-4d01e0c3943f"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 333
            };
        }
    }
}
