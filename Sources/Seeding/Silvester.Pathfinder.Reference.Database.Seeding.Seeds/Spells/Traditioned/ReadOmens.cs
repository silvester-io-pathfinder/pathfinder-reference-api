using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.Traits;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Spells.Instances
{
    public class ReadOmens : Template
    {
        public static readonly Guid ID = Guid.Parse("74baea8f-7f2f-4486-adaa-d924b667c512");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Read Omens",
                Level = 4,
                CastTime = "10 minutes.",
                SpellTypeId = SpellTypes.Instances.Spell.ID,
                ActionTypeId = ActionTypes.Instances.LongAction.ID,
                MagicSchoolId = MagicSchools.Instances.Divination.ID
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("784ea015-2dff-4fcf-8e59-a29fc8fdce90"), Type = TextBlockType.Text, Text = "You peek into the future. Choose a particular goal or activity you plan to engage in within 1 week, or an event you expect might happen within 1 week. You learn a cryptic clue or piece of advice that could help with the chosen event, often in the form of a rhyme or omen." };
        }

        public override IEnumerable<Guid> GetSpellComponents()
        {
            yield return SpellComponents.Instances.Material.ID;
            yield return SpellComponents.Instances.Somatic.ID;
            yield return SpellComponents.Instances.Verbal.ID;
        }

        public override IEnumerable<Guid> GetMagicTraditions()
        {
            yield return MagicTraditions.Instances.Divine.ID;
            yield return MagicTraditions.Instances.Occult.ID;
        }

        public override void GetTraits(ITraitBindingBuilder<SpellTraitBinding, Spell> builder)
        {
            builder.Add(Guid.Parse("27fe2a5d-639d-40f0-90b1-199aecbb8351"), Traits.Instances.Uncommon.ID);
            builder.Add(Guid.Parse("0accf73b-5f61-40c2-b6de-20a0d6cd36bd"), Traits.Instances.Divination.ID);
            builder.Add(Guid.Parse("6c5d2fe2-fe09-45b4-9ff4-cdbff4f7718e"), Traits.Instances.Prediction.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("97cac76c-c57d-4942-8a70-2bb09247867a"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 363
            };
        }
    }
}