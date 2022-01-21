using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.Traits;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Spells.Instances
{
    public class StoneToFlesh : Template
    {
        public static readonly Guid ID = Guid.Parse("568227e8-aaba-4cbd-9db1-6278cb9c3e9b");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Stone to Flesh",
                Level = 6,
                Range = "Touch.",
                Targets = "Petrified creature or human-size stone object.",
                SpellTypeId = SpellTypes.Instances.Spell.ID,
                ActionTypeId = ActionTypes.Instances.TwoActions.ID,
                MagicSchoolId = MagicSchools.Instances.Transmutation.ID
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("9374ed73-e410-426d-9175-e04b4237a7b9"), Type = TextBlockType.Text, Text = "Manipulating the fundamental particles of matter, you convert stone into flesh and blood. You restore a petrified creature to its normal state or transform a stone object into a mass of inert flesh (without stone's Hardness) in roughly the same shape." };
        }

        public override IEnumerable<Guid> GetSpellComponents()
        {
            yield return SpellComponents.Instances.Somatic.ID;
            yield return SpellComponents.Instances.Verbal.ID;
        }

        public override IEnumerable<Guid> GetMagicTraditions()
        {
            yield return MagicTraditions.Instances.Divine.ID;
            yield return MagicTraditions.Instances.Primal.ID;
        }

        public override void GetTraits(ITraitBindingBuilder<SpellTraitBinding, Spell> builder)
        {
            builder.Add(Guid.Parse("e0811abe-1837-49fd-9194-99fb7d7ceb38"), Traits.Instances.Earth.ID);
            builder.Add(Guid.Parse("7b6617cc-eff6-4cac-be76-f6de8f8bf1ae"), Traits.Instances.Transmutation.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("01156cd2-d540-4dfd-a9b1-21dfbdcbfb79"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 374
            };
        }
    }
}
