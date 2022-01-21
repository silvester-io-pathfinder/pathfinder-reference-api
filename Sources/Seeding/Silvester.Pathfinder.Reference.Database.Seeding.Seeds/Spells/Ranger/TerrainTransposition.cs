using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.Traits;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Spells.Instances
{
    public class TerrainTransposition : Template
    {
        public static readonly Guid ID = Guid.Parse("194ae206-fd26-4e82-9389-f409d2e9c4a9");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Terrain Transposition",
                Level = 5,
                Range = "90 feet.",
                ActionTypeId = ActionTypes.Instances.TwoActions.ID,
                ClassId = Classes.Instances.Ranger.ID,
                SpellTypeId = SpellTypes.Instances.Focus.ID,
                MagicSchoolId = MagicSchools.Instances.Conjuration.ID,
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("ca7be53b-5b0d-4002-b2be-f5dfd5db9854"), Type = TextBlockType.Text, Text = "You mystically transpose your current location with another. While in a wilderness environment, you transport yourself and items you're holding to a clear space you can see within range. If you have Favored Terrain and both your starting and ending position are in your favored terrain, the range increases to 180 feet. If you have an animal companion and it is adjacent to you, you can transport it along with you to an adjacent open space, but if this spell would bring any other creature with you, even in an extradimensional container, the spell is lost." };
        }

        public override IEnumerable<Guid> GetSpellComponents()
        {
            yield return SpellComponents.Instances.Somatic.ID;
            yield return SpellComponents.Instances.Verbal.ID;
        }

        public override void GetTraits(ITraitBindingBuilder<SpellTraitBinding, Spell> builder)
        {
            builder.Add(Guid.Parse("a0021cb3-1de8-43e3-8ef6-78a49049614e"), Traits.Instances.Uncommon.ID);
            builder.Add(Guid.Parse("b8639e35-9dbe-4c29-a4c8-09fcd0ce5393"), Traits.Instances.Conjuration.ID);
            builder.Add(Guid.Parse("d15472b9-30ed-4751-86af-9345bf7ba3f8"), Traits.Instances.Ranger.ID);
            builder.Add(Guid.Parse("1fff4c59-1eca-4e80-b8a7-9e6de555780a"), Traits.Instances.Teleportation.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("b7fa56bc-8639-457c-92eb-554d8beccda8"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = 235
            };
        }
    }
}
