using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
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

        public override IEnumerable<Guid> GetTraits()
        {
            yield return Traits.Instances.Uncommon.ID;
            yield return Traits.Instances.Conjuration.ID;
            yield return Traits.Instances.Ranger.ID;
            yield return Traits.Instances.Teleportation.ID;
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
