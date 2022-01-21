using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.Traits;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Spells.Instances
{
    public class Shillelagh : Template
    {
        public static readonly Guid ID = Guid.Parse("e7c926f9-36e7-42a3-bd12-16f03c965b86");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Shillelagh",
                Level = 1,
                Range = "Touch.",
                Duration = "1 minute.",
                Targets = "1 non-magical club or staff you hold.",
                SpellTypeId = SpellTypes.Instances.Spell.ID,
                ActionTypeId = ActionTypes.Instances.TwoActions.ID,
                MagicSchoolId = MagicSchools.Instances.Transmutation.ID
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("e7bb7a0f-5e48-4040-bdc2-75c79857df31"), Type = TextBlockType.Text, Text = "The target grows vines and leaves, brimming with primal energy. The target becomes a +1 striking weapon while in your hands, gaining a +1 item bonus to attack rolls and increasing the number of weapon damage dice to two. Additionally, as long as you are on your home plane, attacks you make with the target against aberrations, extraplanar creatures, and undead increase the number of weapon damage dice to three." };
        }

        public override IEnumerable<Guid> GetSpellComponents()
        {
            yield return SpellComponents.Instances.Somatic.ID;
            yield return SpellComponents.Instances.Verbal.ID;
        }

        public override IEnumerable<Guid> GetMagicTraditions()
        {
            yield return MagicTraditions.Instances.Primal.ID;
        }

        public override void GetTraits(ITraitBindingBuilder<SpellTraitBinding, Spell> builder)
        {
            builder.Add(Guid.Parse("8652c1a7-3bcc-4af8-a446-9e507ae6dffe"), Traits.Instances.Plant.ID);
            builder.Add(Guid.Parse("92d2e6c0-db5c-4696-b775-d351b7d52643"), Traits.Instances.Transmutation.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("0d52b0e7-042b-4b35-af2f-228e6d157340"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 369
            };
        }
    }
}
