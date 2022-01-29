using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.Traits;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Spells.Instances
{
    public class ExtendBoost : Template
    {
        public static readonly Guid ID = Guid.Parse("3f3aae26-1b00-4d33-9654-7ecb38cda9ae");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Extend Boost",
                Level = 1,
                ActionTypeId = ActionTypes.Instances.FreeAction.ID,
                SpellTypeId = SpellTypes.Instances.Focus.ID,
                MagicSchoolId = MagicSchools.Instances.Divination.ID,
                ClassId = Classes.Instances.Summoner.ID
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("925c124c-d47f-4052-a550-f6c8589e33d1"), Type = TextBlockType.Text, Text = "You focus on the intricacies of the magic binding you to your eidolon to extend the duration of your boost eidolon or reinforce eidolon spell. If your next action is to cast boost eidolon or reinforce eidolon, attempt a skill check with the skill associated with the tradition of magic you gain from your eidolon (such as Nature for a primal eidolon). The DC is usually a standard-difficulty DC of your level, but the GM can assign a different DC based on the circumstances. The effect depends on the result of your check." };
        }

        public override IEnumerable<RollableEffect> GetRollableEffects()
        {
            yield return new RollableEffect
            {
                Id = Guid.Parse("60174b0c-09c1-4104-8526-42dc06669ba6"),
                CriticalSuccess = "The spell lasts 4 rounds.",
                Success = "The spell lasts 3 rounds.",
                Failure = "The spell lasts 1 round, but you don't spend the Focus Point for casting this spell.",
            };
        }

        public override IEnumerable<Guid> GetSpellComponents()
        {
            yield return SpellComponents.Instances.Verbal.ID;
        }

        public override void GetTraits(ITraitBindingBuilder<SpellTraitBinding, Spell> builder)
        {
            builder.Add(Guid.Parse("c6e0ce02-a226-4d84-b6f7-e62babc3ab32"), Traits.Instances.Uncommon.ID);
            builder.Add(Guid.Parse("e51b2658-c965-466a-bce8-924993984297"), Traits.Instances.Divination.ID);
            builder.Add(Guid.Parse("df3e07c1-68c3-44d9-841a-84cc79bfd27f"), Traits.Instances.Metamagic.ID);
            builder.Add(Guid.Parse("45036d5f-7e87-4f43-8261-445044b48df4"), Traits.Instances.Summoner.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("d96fa3b9-3ab7-4bac-aacf-54235a81cfda"),
                SourceId = Sources.Instances.SecretsOfMagic.ID,
                Page = 145
            };
        }
    }
}
