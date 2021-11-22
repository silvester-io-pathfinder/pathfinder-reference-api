using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Spells.Instances
{
    public class SoothingSpring : Template
    {
        public static readonly Guid ID = Guid.Parse("8f7014eb-2256-48fc-8a8b-6a8b26c79f4d");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Soothing Spring",
                Level = 4,
                Range = "30 feet.",
                Duration = "1 hout.",
                CastTime = "1 minute.",
                SpellTypeId = SpellTypes.Instances.Spell.ID,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                MagicSchoolId = MagicSchools.Instances.Necromancy.ID,
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("fa6f4bed-b25c-4934-8185-63fe3589b090"), Type = TextBlockType.Text, Text = "Steam wisps into the air as a stone-lined pool appears in the ground and fills with hot water that bubbles up from the earth. The water is comfortably hot and smells mildly sulfurous in a not-unpleasant way. You are able to draw out the full energizing potential of the mineral-rich water. Any creature that spends the full hour soaking in the hot spring or basking in the mud from the bottom of the pit regains 10d8 Hit Points and feels refreshed, losing the fatigued condition. As normal for effects that remove fatigue, this doesn�t remove any underlying source of fatigue, such as lack of sleep, causing the condition to return if the underlying source isn�t addressed." };
            yield return new TextBlock { Id = Guid.Parse("a4f42671-7352-419b-b4b8-84647b278f61"), Type = TextBlockType.Text, Text = "The pool is 20 feet on each side, and it�s 5 feet deep. It can contain 16 Medium or smaller creatures at a time. A Large creature counts as eight Medium creatures and a Huge creature fills the entire pool. This pool has the structure trait and the same restrictions as magic items that create structures." };
        }

        public override IEnumerable<SpellHeightening> GetHeightenings()
        {
            yield return new SpellHeightening
            {
                Id = Guid.Parse("e012d4a8-da94-4c75-8791-8dd95d9ddddf"),
                Level = "+1",
                Details = new TextBlock[]
                {
                    new TextBlock {Id = Guid.Parse("0e5860b3-a5ad-4758-b31b-1b48424d7ee3"), Type = TextBlockType.Text, Text = "The healing increases by 2d8." }
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
            yield return MagicTraditions.Instances.Divine.ID;
            yield return MagicTraditions.Instances.Primal.ID;
        }

        public override IEnumerable<Guid> GetTraits()
        {
            yield return Traits.Instances.Healing.ID;
            yield return Traits.Instances.Necromancy.ID;
            yield return Traits.Instances.Positive.ID;
            yield return Traits.Instances.Water.ID;
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("7efb8119-3b37-4da1-bda8-3d707463924a"),
                SourceId = Sources.Instances.SecretsOfMagic.ID,
                Page = 129
            };
        }
    }
}
