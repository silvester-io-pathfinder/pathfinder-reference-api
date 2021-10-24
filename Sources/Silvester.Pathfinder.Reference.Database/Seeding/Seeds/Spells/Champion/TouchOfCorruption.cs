using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Spells.Instances
{
    public class TouchOfCorruption : Template
    {
        public static readonly Guid ID = Guid.Parse("9c98348b-94c5-4ed2-95cd-80352113e938");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Touch of Corruption",
                Level = 1,
                Range = "Touch.",
                Targets = "1 willing undead creature or 1 living creature.",
                ActionTypeId = ActionTypes.Instances.OneAction.ID,
                ClassId = Classes.Instances.Champion.ID,
                SpellTypeId = SpellTypes.Instances.Focus.ID,
                MagicSchoolId = MagicSchools.Instances.Necromancy.ID
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("e2416503-07a9-41fe-9d60-6872faec7726"), Type = TextBlockType.Text, Text = "You infuse the target with negative energy. If the target is living, this deals 1d6 negative damage (basic Fortitude save); on a failed save, the target also takes a –2 status penalty to AC for 1 round." };
            yield return new TextBlock { Id = Guid.Parse("a0ec8ee6-4431-46be-927a-2f475341c7e2"), Type = TextBlockType.Text, Text = "If the target is a willing undead creature, the target instead regains 6 Hit Points, and if you are the undead target, you also gain a +2 status bonus to damage rolls for 1 round." };
        }

        public override IEnumerable<SpellHeightening> GetHeightenings()
        {
            yield return new SpellHeightening
            {
                Id = Guid.Parse("918f8979-d0ca-446f-9a3f-256c15bafc52"),
                Level = "+1",
                Details =
                {
                    new TextBlock { Id = Guid.Parse("927cf1a2-8c51-463a-b45f-06ded6155878"), Type = TextBlockType.Text, Text = "Increase the damage dealt to a living creature by 1d6 or increase the Hit Points regained by undead by 6." }
                }
            };
        }

        public override IEnumerable<Guid> GetSpellComponents()
        {
            yield return SpellComponents.Instances.Somatic.ID;
        }

        public override IEnumerable<Guid> GetTraits()
        {
            yield return Traits.Instances.Uncommon.ID;
            yield return Traits.Instances.Champion.ID;
            yield return Traits.Instances.Necromancy.ID;
            yield return Traits.Instances.Negative.ID;
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("c2d38091-8077-4e8c-95b1-a699453b599a"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = 229
            };
        }
    }
}
