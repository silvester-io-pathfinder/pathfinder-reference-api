using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.Traits;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Spells.Instances
{
    public class DiscernLies : Template
    {
        public static readonly Guid ID = Guid.Parse("d8cf6802-13fb-4518-a463-538b28bed2da");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Discern Lies",
                Level = 4,
                Duration = "10 minutes",
                SpellTypeId = SpellTypes.Instances.Spell.ID,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                MagicSchoolId = MagicSchools.Instances.Divination.ID,
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("cdd7d66f-a83c-40bb-ba6e-ae203c64829a"), Type = Utilities.Text.TextBlockType.Text, Text = "Falsehoods ring in your ears like discordant notes. You gain a +4 status bonus to Perception checks when someone Lies." };
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
            builder.Add(Guid.Parse("390678e6-1608-43a1-b6e2-a2eec81e27e6"), Traits.Instances.Uncommon.ID);
            builder.Add(Guid.Parse("64b87768-292b-4594-b121-397af20106d3"), Traits.Instances.Divination.ID);
            builder.Add(Guid.Parse("ed9346e2-3470-4d42-b792-8095b18dca56"), Traits.Instances.Mental.ID);
            builder.Add(Guid.Parse("80ef747e-f481-4966-b171-55113c3e96f4"), Traits.Instances.Revelation.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("5ce2fd4c-56dc-4d41-ba00-1bb6076e4b28"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 330
            };
        }
    }
}
