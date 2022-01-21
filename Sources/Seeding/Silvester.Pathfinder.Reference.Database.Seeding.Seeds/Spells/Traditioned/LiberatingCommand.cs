using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.Traits;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Spells.Instances
{
    public class LiberatingCommand : Template
    {
        public static readonly Guid ID = Guid.Parse("b4587f49-7814-4fff-ac74-40e50ebbf322");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Liberating Command",
                Level = 1,
                Range = "60 feet.",
                Targets = "1 creature.",
                SpellTypeId = SpellTypes.Instances.Spell.ID,
                ActionTypeId = ActionTypes.Instances.OneAction.ID,
                MagicSchoolId = MagicSchools.Instances.Enchantment.ID,
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("078774ce-7e22-4da1-bb0a-b4d5311468e5"), Type = TextBlockType.Text, Text = "You call out a liberating cry, urging an ally to break free of an effect that holds them in place. If the target is grabbed, immobilized, or restrained, it can immediately use a reaction to attempt to Escape." };
        }

        public override IEnumerable<Guid> GetSpellComponents()
        {
            yield return SpellComponents.Instances.Verbal.ID;
        }

        public override IEnumerable<Guid> GetMagicTraditions()
        {
            yield return MagicTraditions.Instances.Occult.ID;
        }

        public override void GetTraits(ITraitBindingBuilder<SpellTraitBinding, Spell> builder)
        {
            builder.Add(Guid.Parse("f60dbca1-7c33-46c8-bc99-38bdf512d50a"), Traits.Instances.Enchantment.ID);
            builder.Add(Guid.Parse("2bfa231e-33af-421f-8e48-d3ee891f9ffa"), Traits.Instances.Mechanical.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("8633a84d-a6ca-4349-9323-ff3fc5eeb5e1"),
                SourceId = Sources.Instances.LostOmensGodsAndMagic.ID,
                Page = 108
            };
        }
    }
}
