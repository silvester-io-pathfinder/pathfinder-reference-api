using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.Traits;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Spells.Instances
{
    public class JealousHex : Template
    {
        public static readonly Guid ID = Guid.Parse("ec613e4a-7d8a-4081-822f-cb21d81bcbcc");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Jealous Hex",
                Level = 1,
                Range = "30 feet.",
                Targets = "1 creature.",
                IsSavingThrowBasic = false,
                SavingThrowStatId = SavingThrowStats.Instances.Will.ID,
                ActionTypeId = ActionTypes.Instances.OneAction.ID,
                ClassId = Classes.Instances.Sorcerer.ID,
                SpellTypeId = SpellTypes.Instances.Focus.ID,
                MagicSchoolId = MagicSchools.Instances.Necromancy.ID
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("8f6d8400-e9b0-46cf-b0c8-badfda6f87ee"), Type = TextBlockType.Text, Text = "You draw forth a hag's innate jealousy to deny a target its greatest attribute. The target is cursed with an adverse condition depending on its highest ability modifier: Strength (enfeebled); Dexterity (clumsy); Constitution (drained); or Intelligence, Wisdom, or Charisma (stupefied). On a tie, the creature decides which of the conditions associated with the tied ability modifiers to take. The target must attempt a Will save." };
            yield return new TextBlock { Id = Guid.Parse("e057d88a-f0eb-489d-88a5-3ab44688b70e"), Type = TextBlockType.Text, Text = "At the start of each of your turns, the target can attempt another Will save, ending the effect on a success." };
        }

        public override IEnumerable<RollableEffect> GetRollableEffects()
        {
            yield return new RollableEffect
            {
                Id = Guid.Parse("264f257d-1f6e-4fae-855b-e51857547510"),
                Success = "The target is unaffected.",
                Failure = "The condition's value is 1.",
                CriticalFailure = "The condition's value is 2."
            };
        }

        public override IEnumerable<Guid> GetSpellComponents()
        {
            yield return SpellComponents.Instances.Verbal.ID;
        }

        public override void GetTraits(ITraitBindingBuilder<SpellTraitBinding, Spell> builder)
        {
            builder.Add(Guid.Parse("10dd5f78-bf9f-4681-b8c5-7170d04b952b"), Traits.Instances.Uncommon.ID);
            builder.Add(Guid.Parse("9a8cccd3-a5f4-4323-9672-faad211702cb"), Traits.Instances.Curse.ID);
            builder.Add(Guid.Parse("848fed4a-f980-4866-9ae2-430855b909f6"), Traits.Instances.Necromancy.ID);
            builder.Add(Guid.Parse("5f97d624-44fa-4402-94ad-4802404bd8a9"), Traits.Instances.Sorcerer.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("30222a00-f2c1-422f-9057-88e30624b780"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 405
            };
        }
    }
}
