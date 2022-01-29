using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.Traits;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Spells.Instances
{
    public class PersistentServant : Template
    {
        public static readonly Guid ID = Guid.Parse("825f655e-bab2-42c2-a07b-79cba67f1116");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Persistent Servant",
                Level = 2,
                Range = "120 feet.",
                Duration = "Until your next daily preparations.",
                Area = "60-foot burst.",
                CastTime = "1 minute.",
                SpellTypeId = SpellTypes.Instances.Spell.ID,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                MagicSchoolId = MagicSchools.Instances.Conjuration.ID,
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("cdfda498-190f-453d-8869-a8abe4269bcb"), Type = TextBlockType.Text, Text = "You call forth an unseen servant (Core Rulebook 380) and task it to perform a specific chore repeatedly. Choose a basic instruction, such as sweeping the floor, or picking up all objects from the floor and putting them in a designated bin. The servant performs the task over and over again throughout the duration, though it can't ever leave the spell's area." };
            yield return new TextBlock { Id = Guid.Parse("4d1945c4-381a-401f-a394-1323f41a2d0b"), Type = TextBlockType.Text, Text = "The servant isn't a minion, and you don't need to Sustain the Spell in order for it to continue to act. However, it acts on its own time, and thus can't accomplish anything useful during an encounter, even if an encounter happens within the spell's range." };
            yield return new TextBlock { Id = Guid.Parse("50e637e7-933a-4af0-a4a3-549bbf13d634"), Type = TextBlockType.Text, Text = "Tasks that rely on timing, discretion, or significant manual dexterity are doomed to failure. For instance, a servant tasked to pick objects off the floor won't discriminate between trash, misplaced treasure, or objects that are supposed to be on the floor, like a mousetrap." };
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
            builder.Add(Guid.Parse("4f45677c-8606-4024-9e3c-6b8551ce0e94"), Traits.Instances.Conjuration.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("3b8ef21e-94f3-42b9-bd85-8be253f71a14"),
                SourceId = Sources.Instances.SecretsOfMagic.ID,
                Page = 121
            };
        }
    }
}
