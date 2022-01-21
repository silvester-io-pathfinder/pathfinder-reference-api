using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.Traits;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Spells.Instances
{
    public class Protection : Template
    {
        public static readonly Guid ID = Guid.Parse("5d06dded-2209-4d4c-93f7-cea29784ce1e");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Protection",
                Level = 1,
                Range = "Touch.",
                Duration = "1 minute.",
                Targets = "1 creature.",
                SpellTypeId = SpellTypes.Instances.Spell.ID,
                ActionTypeId = ActionTypes.Instances.TwoActions.ID,
                MagicSchoolId = MagicSchools.Instances.Abjuration.ID
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("b8f7d2eb-8cb1-4457-950a-8e404b5c6370"), Type = TextBlockType.Text, Text = "You ward a creature against a specified alignment. Choose chaotic, evil, good, or lawful when you cast this spell. The target gains a +1 status bonus to Armor Class and saving throws against creatures and effects of the chosen alignment. This bonus increases to +3 against effects from such creatures that would directly control the target and against attacks made by summoned creatures of the chosen alignment." };
            yield return new TextBlock { Id = Guid.Parse("2139c3e4-89c2-4478-a01c-bd03f43993e7"), Type = TextBlockType.Text, Text = "This spell gains the trait that opposes the alignment you chose—if you choose chaos, this spell gains the lawful trait, and vice versa; if you choose evil, this spell gains the good trait, and vice versa." };
        }

        public override IEnumerable<Guid> GetSpellComponents()
        {
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
            builder.Add(Guid.Parse("370123ce-c7e0-4595-a0a8-48c3c6f605c3"), Traits.Instances.Uncommon.ID);
            builder.Add(Guid.Parse("b1f436c4-9ef5-4ca7-88cb-a72314585b35"), Traits.Instances.Abjuration.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("eae5e3ae-0c5a-48b0-a79d-23d93360d615"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 361
            };
        }
    }
}
