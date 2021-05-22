using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Spells.Instances
{
    public class Restoration : Template
    {
        public static readonly Guid ID = Guid.Parse("79da888e-0a2e-4268-b3ec-b42e0023ee38");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Restoration",
                Level = 2,
                CastTime = "1 minute.",
                Range = "Touch.",
                Targets = "1 creature.",
                SpellTypeId = SpellTypes.Instances.Spell.ID,
                ActionTypeId = ActionTypes.Instances.LongAction.ID,
                MagicSchoolId = MagicSchools.Instances.Necromancy.ID
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("918f29e5-879a-44eb-88d8-57521d2bff77"), Type = TextBlockType.Text, Text = "Restorative magic counters the effects of toxins or conditions that prevent a creature from functioning at its best. When you cast restoration, choose to either reduce a condition or lessen the effect of a toxin. A creature can benefit from only one restoration spell each day, and it can’t benefit from restoration more than once to reduce the stage of the same exposure to a given toxin." };
            yield return new TextBlock { Id = Guid.Parse("ed640758-61af-4c49-90b7-ba3a1bb6ee63"), Type = TextBlockType.Enumeration, Text = "Reduce a Condition - Reduce the value of the target’s clumsy, enfeebled, or stupefied condition by 2. You can instead reduce two of the listed conditions by 1 each." };
            yield return new TextBlock { Id = Guid.Parse("9dcb0a12-39a5-4269-baa6-51b58ebe8421"), Type = TextBlockType.Enumeration, Text = "Lessen a Toxin - Reduce the stage of one toxin the target suffers from by one stage. This can’t reduce the stage below stage 1 or cure the affliction." };
        }

        public override IEnumerable<SpellHeightening> GetHeightenings()
        {
            yield return new SpellHeightening
            {
                Id = Guid.Parse("fdc0ef06-9e2f-41b5-a707-7daeeb57d9dd"),
                Level = "4th",
                Details =
                {
                    new TextBlock { Id = Guid.Parse("502b90e5-e003-43c5-82be-f380289b31f8"), Type = TextBlockType.Text, Text = "Add drained to the list of conditions you can reduce. When you lessen a toxin, reduce the stage by two. You also gain a third option that allows you to reduce the target’s doomed value by 1. You can’t use this to reduce a permanent doomed condition." }
                }
            };

            yield return new SpellHeightening
            {
                Id = Guid.Parse("307ba749-a5a2-4992-8e5e-61ed7ab950ad"),
                Level = "6th",
                Details =
                {
                    new TextBlock { Id = Guid.Parse("ae1ac21e-37f0-4b97-8489-b794bc4ac034"), Type = TextBlockType.Text, Text = "As the 4th-level restoration, but you can reduce a permanent doomed condition if you add a spellcasting action and a material component while Casting the Spell, during which you provide 100 gp worth of diamond dust as a cost." }
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
            yield return MagicTraditions.Instances.Occult.ID;
        }

        public override IEnumerable<Guid> GetTraits()
        {
            yield return Traits.Instances.Healing.ID;
            yield return Traits.Instances.Necromancy.ID;
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("a9ff76c7-9564-4536-975c-cd8ac8e7bd65"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 364
            };
        }
    }
}
