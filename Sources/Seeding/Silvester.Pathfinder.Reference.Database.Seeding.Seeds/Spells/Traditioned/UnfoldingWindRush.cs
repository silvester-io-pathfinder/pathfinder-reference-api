using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.Traits;
using System.Collections.Generic;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.TextBlocks;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Spells.Instances
{
    public class UnfoldingWindRush : Template
    {
        public static readonly Guid ID = Guid.Parse("1a4a396d-2874-46c5-9b08-556ab5143ca6");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Unfolding Wind Rush",
                Level = 3,
                SpellTypeId = SpellTypes.Instances.Focus.ID,
                ActionTypeId = ActionTypes.Instances.OneAction.ID,
                MagicSchoolId = MagicSchools.Instances.Evocation.ID,
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("d4af55db-5fba-4292-9194-1463b1ef3b40"), Type = TextBlockType.Text, Text = "You travel on a rushing wind. Move two times: two Strides, two Steps, or one Stride and one Step (in either order). You can Stride or Step into the air during this movement, moving upward at a 45-degree angle at most; if you end your movement in the air, you fall after taking one action or when your turn ends, whichever comes first. A wall of wind appears in all the spaces you left during this movement, lasting for 1 round." };
        }

        public override IEnumerable<Guid> GetSpellComponents()
        {
            yield return SpellComponents.Instances.Verbal.ID;
        }

        public override IEnumerable<Guid> GetMagicTraditions()
        {
            yield break;
        }

        public override IEnumerable<SpellHeightening> GetHeightenings()
        {
            yield return new SpellHeightening
            {
                Id = Guid.Parse("6e741648-ff67-4de3-b64c-5b9cffda6500"),
                Level = "5th",
                Details = new TextBlockBuilder()
                    .Text(Guid.Parse("9be4a72d-e7f1-425d-8096-883382a6005f"), "The wall of wind lasts 3 rounds.")
                    .Build()
            };
        }

        public override void GetTraits(ITraitBindingBuilder<SpellTraitBinding, Spell> builder)
        {
            builder.Add(Guid.Parse("9e7a2efe-5e6f-46e5-b6f3-9e1fed75e3b9"), Traits.Instances.Uncommon.ID);
            builder.Add(Guid.Parse("6e6015f2-8c1a-404d-9c76-f1bd4b5fbec6"), Traits.Instances.Evocation.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("d94ae56d-82d1-449e-bbfc-02d48ce21527"),
                SourceId = Sources.Instances.WorldGuide.ID,
                Page = 83
            };
        }
    }
}
