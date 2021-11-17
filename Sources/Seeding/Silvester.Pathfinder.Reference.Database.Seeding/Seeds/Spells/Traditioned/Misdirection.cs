using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Spells.Instances
{
    public class Misdirection : Template
    {
        public static readonly Guid ID = Guid.Parse("5a7e9082-570d-4795-ad83-934b17d8bc5e");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Misdirection",
                Level = 2,
                CastTime = "1 minute.",
                Range = "30 feet.",
                Duration = "Until the next time you make your daily preparations.",
                Targets = "2 creatures or objects.",
                SpellTypeId = SpellTypes.Instances.Spell.ID,
                ActionTypeId = ActionTypes.Instances.LongAction.ID,
                MagicSchoolId = MagicSchools.Instances.Illusion.ID
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("1b0d5462-7d23-4e5d-a663-54e2944557db"), Type = TextBlockType.Text, Text = "You reshape the magic aura of one creature or object to resemble that of another. You designate one target as the primary target and the other as the secondary target. Effects that would detect auras on the primary target instead detect the same types of auras from the secondary target. A creature reading the aura can attempt to disbelieve the illusion. You can Dismiss the spell from up to a mile away." };
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

        public override IEnumerable<Guid> GetTraits()
        {
            yield return Traits.Instances.Illusion.ID;
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("171d588a-b840-4e93-a056-649a5047aefc"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 352
            };
        }
    }
}
