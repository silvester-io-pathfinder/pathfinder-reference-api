using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.Traits;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Spells.Instances
{
    public class SuddenBlight : Template
    {
        public static readonly Guid ID = Guid.Parse("ca24f0d7-be39-45e0-9595-bdb1ac2ca7c4");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Sudden Blight",
                Level = 2,
                Range = "120 feet.",
                Area = "20-foot burst.",
                IsSavingThrowBasic = true,
                SavingThrowStatId = SavingThrowStats.Instances.Fortitude.ID,
                SpellTypeId = SpellTypes.Instances.Spell.ID,
                ActionTypeId = ActionTypes.Instances.TwoActions.ID,
                MagicSchoolId = MagicSchools.Instances.Necromancy.ID
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("085c198d-f819-4a2a-a7c8-351cbf0a488b"), Type = TextBlockType.Text, Text = "You accelerate the processes of decay in the area. Each living creature in the area takes 2d10 negative damage (basic Fortitude save). A creature afflicted by a disease takes a –2 circumstance penalty to this save." };
            yield return new TextBlock { Id = Guid.Parse("de9a51ed-b319-4fd8-9ec6-cc4c594b57b8"), Type = TextBlockType.Text, Text = "You can also direct the blight to rot all Small and Tiny non-creature plants in the area, eliminating non-magical undergrowth and any resulting difficult terrain, cover, and concealment. Sudden blight attempts to counteract any magical effect on the plants before withering them." };
        }

        public override IEnumerable<SpellHeightening> GetHeightenings()
        {
            yield return new SpellHeightening
            {
                Id = Guid.Parse("ed20a0c2-40da-4161-b1bd-be652af823d8"), 
                Level = "+1",
                Details =
                {
                    new TextBlock { Id = Guid.Parse("83a75abe-c811-46e3-a42e-383655a5503b"), Type = TextBlockType.Text, Text = "The damage increases by 1d10." }
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
            yield return MagicTraditions.Instances.Divine.ID;
            yield return MagicTraditions.Instances.Primal.ID;
        }

        public override void GetTraits(ITraitBindingBuilder<SpellTraitBinding, Spell> builder)
        {
            builder.Add(Guid.Parse("c0ced26f-74c5-4e4d-a770-235a993a7bfd"), Traits.Instances.Necromancy.ID);
            builder.Add(Guid.Parse("511cc963-7e85-4f73-90c5-34fcd16191cb"), Traits.Instances.Negative.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("ea69128d-9ecd-4028-9f58-944fa9a93201"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = 226
            };
        }
    }
}
