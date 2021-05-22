using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Spells.Instances
{
    public class Barkskin : Template
    {
        public static readonly Guid ID = Guid.Parse("41fcd185-b9ba-41aa-96cf-1a8bcb65a64d");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Barksin",
                Level = 2,
                Range = "Touch.",
                Targets = "1 willing creature.",
                Duration = "10 minutes.",
                SpellTypeId = SpellTypes.Instances.Spell.ID,
                ActionTypeId = ActionTypes.Instances.TwoActions.ID,
                MagicSchoolId = MagicSchools.Instances.Abjuration.ID,
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("d60b56d5-b4f6-4bb9-927b-5c26ebceaa33"), Type = Utilities.Text.TextBlockType.Text, Text = "The target’s skin becomes covered in bark. The target gains resistance 2 to bludgeoning and piercing damage and weakness 3 to fire. After the target takes fire damage, it can Dismiss the spell as a free action triggered by taking the damage; doing so doesn’t reduce the fire damage the target was dealt." };
        }

        public override IEnumerable<SpellHeightening> GetHeightenings()
        {
            yield return new SpellHeightening
            {
                Id = Guid.Parse("4a665729-f77d-4c8c-8f00-dd3fe078e3d8"),
                Level = "+2",
                Details =
                {
                    new TextBlock { Id = Guid.Parse("03056dae-e94d-4ffd-8cf1-f06172f6380c"), Type = Utilities.Text.TextBlockType.Text, Text = "The resistances increase by 2, and the weakness increases by 3." }
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
            yield return MagicTraditions.Instances.Primal.ID;
        }

        public override IEnumerable<Guid> GetTraits()
        {
            yield return Traits.Instances.Abjuration.ID;
            yield return Traits.Instances.Plant.ID;
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("c3c5ca83-05c3-4a25-8d39-aaf0734f4af7"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 320
            };
        }
    }
}
