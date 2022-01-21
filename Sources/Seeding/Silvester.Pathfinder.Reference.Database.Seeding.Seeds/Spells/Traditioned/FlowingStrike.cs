using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.Traits;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Spells.Instances
{
    public class FlowingStrike : Template
    {
        public static readonly Guid ID = Guid.Parse("09f875d6-6042-4503-96c6-dd2c7f028662");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Flowing Strike",
                Level = 5,
                SpellTypeId = SpellTypes.Instances.Spell.ID,
                ActionTypeId = ActionTypes.Instances.ThreeActions.ID,
                MagicSchoolId = MagicSchools.Instances.Evocation.ID,
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("9da91d44-66af-40f6-a5b5-f4264fff2b92"), Type = TextBlockType.Text, Text = "A wave of flowing water rushes behind you like an elegant river, pushing you across the battlefield with fluid grace. You Stride up to 50 feet. This movement doesn�t trigger reactions. You can make a Strike at any point during your Stride. If your Strike hits, the wave flows after you to batter the target of your Strike as well, dealing 2d10 bludgeoning damage and pushing it 10 feet in a direction of your choice." };
        }

        public override IEnumerable<Guid> GetSpellComponents()
        {
            yield return SpellComponents.Instances.Material.ID;
            yield return SpellComponents.Instances.Somatic.ID;
            yield return SpellComponents.Instances.Verbal.ID;
        }

        public override IEnumerable<Guid> GetMagicTraditions()
        {
            yield return MagicTraditions.Instances.Arcane.ID;
            yield return MagicTraditions.Instances.Primal.ID;
        }

        public override void GetTraits(ITraitBindingBuilder<SpellTraitBinding, Spell> builder)
        {
            builder.Add(Guid.Parse("f14280a2-75b9-4109-9d30-d217060c0c55"), Traits.Instances.Evocation.ID);
            builder.Add(Guid.Parse("51d11667-53fb-4237-b143-ff0884d78170"), Traits.Instances.Water.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("2ef90cd8-c375-440e-b5e2-258cd84c1910"),
                SourceId = Sources.Instances.SecretsOfMagic.ID,
                Page = 106
            };
        }
    }
}
