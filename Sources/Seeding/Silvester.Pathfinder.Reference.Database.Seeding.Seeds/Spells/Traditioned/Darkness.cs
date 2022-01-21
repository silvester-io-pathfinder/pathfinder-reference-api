using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.Traits;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Spells.Instances
{
    public class Darkness : Template
    {
        public static readonly Guid ID = Guid.Parse("0f86cd9a-76b2-4bb4-bebe-ea638643fc3e");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Darkness",
                Level = 2,
                Range = "120 feet.",
                Area = "20-foot burst.",
                Duration = "1 minute.",
                SpellTypeId = SpellTypes.Instances.Spell.ID,
                ActionTypeId = ActionTypes.Instances.ThreeActions.ID,
                MagicSchoolId = MagicSchools.Instances.Evocation.ID,
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("3d55aeb6-b47c-4221-a8b0-7117c09da7fe"), Type = Utilities.Text.TextBlockType.Text, Text = "You create a shroud of darkness that prevents light from penetrating or emanating within the area. Light does not enter the area and any non-magical light sources, such as a torch or lantern, do not emanate any light while inside the area, even if their light radius would extend beyond the darkness. This also suppresses magical light of your darkness spell's level or lower. Light can't pass through, so creatures in the area can't see outside. From outside, it appears as a globe of pure darkness." };
        }

        public override IEnumerable<SpellHeightening> GetHeightenings()
        {
            yield return new SpellHeightening
            { 
                Id = Guid.Parse("9d5aaa18-2a33-4468-b219-bf3429228901"), 
                Level = "4th", 
                Details =
                {
                    new TextBlock { Id = Guid.Parse("179d71a1-ba70-4709-bf82-5905bf06341f"), Type = Utilities.Text.TextBlockType.Text, Text = "Even creatures with darkvision (but not greater darkvision) can barely see through the darkness. They treat targets seen through the darkness as concealed." }
                }
            };
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
            yield return MagicTraditions.Instances.Divine.ID;
            yield return MagicTraditions.Instances.Occult.ID;
            yield return MagicTraditions.Instances.Primal.ID;
        }

        public override void GetTraits(ITraitBindingBuilder<SpellTraitBinding, Spell> builder)
        {
            builder.Add(Guid.Parse("2e7e588c-d01e-429c-a96d-accfaf8c9bb9"), Traits.Instances.Darkness.ID);
            builder.Add(Guid.Parse("e954bffe-022a-42c4-bb1f-4226dc7881c9"), Traits.Instances.Evocation.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("969b250d-456a-49f2-8f25-8c0fa324d55a"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 327
            };
        }
    }
}
