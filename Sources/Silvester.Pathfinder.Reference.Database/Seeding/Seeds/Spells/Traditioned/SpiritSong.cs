using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Spells.Instances
{
    public class SpiritSong : Template
    {
        public static readonly Guid ID = Guid.Parse("cd8243b1-6bea-41a0-b8d9-b7bdc4dc7004");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Spirit Song",
                Level = 8,
                Area = "60-foot cone.",
                IsSavingThrowBasic = true,
                SavingThrowStatId = SavingThrowStats.Instances.Fortitude.ID,
                SpellTypeId = SpellTypes.Instances.Spell.ID,
                ActionTypeId = ActionTypes.Instances.TwoActions.ID,
                MagicSchoolId = MagicSchools.Instances.Necromancy.ID
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("0a58c5cc-1e3f-46ee-a1e9-cf1445e45fb4"), Type = TextBlockType.Text, Text = "Your eldritch song sends pulsing waves of ethereal energy to attack creatures’ spirits in the area, dealing 18d6 force damage. Because spirit song affects creatures’ spirits, it can damage a target projecting its consciousness (such as via project image) or possessing another creature even if the target’s body is elsewhere. The vibrating waves of spiritual song penetrate into, but not through, solid barriers, damaging incorporeal creatures hiding in solid objects in the area but not passing onward to damage creatures in other rooms. Possessed creatures aren’t harmed by the song. The song doesn’t harm creatures that have no spirit, such as constructs." };
        }

        public override IEnumerable<SpellHeightening> GetHeightenings()
        {
            yield return new SpellHeightening
            {
                Id = Guid.Parse("241261b0-11f8-4a79-a841-f58f90f2e96c"), 
                Level = "+1",
                Details =
                {
                    new TextBlock { Id = Guid.Parse("6b4f842b-0f56-4fb9-a05d-8295d94bf47c"), Type = TextBlockType.Text, Text = "The damage increases by 2d6." }
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
            yield return MagicTraditions.Instances.Occult.ID;
        }

        public override IEnumerable<Guid> GetTraits()
        {
            yield return Traits.Instances.Force.ID;
            yield return Traits.Instances.Necromancy.ID;
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("69138ab3-03ff-4ad8-b447-11e03bf498d6"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 372
            };
        }
    }
}
