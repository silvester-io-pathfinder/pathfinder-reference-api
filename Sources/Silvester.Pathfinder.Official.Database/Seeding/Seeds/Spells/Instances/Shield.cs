using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Spells.Instances
{
    public class Shield : Template
    {
        public static readonly Guid ID = Guid.Parse("");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Shield",
                Level = 1,
                Duration = "Until the start of your next turn.",
                SpellTypeId = SpellTypes.Instances.Cantrip.ID,
                ActionTypeId = ActionTypes.Instances.OneAction.ID,
                MagicSchoolId = MagicSchools.Instances.Abjuration.ID
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Text, Text = "You raise a magical shield of force. This counts as using the Raise a Shield action, giving you a +1 circumstance bonus to AC until the start of your next turn, but it doesn’t require a hand to use." };
            yield return new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Text, Text = "While the spell is in effect, you can use the Shield Block reaction with your magic shield (see the sidebar). The shield has Hardness 5. After you use Shield Block, the spell ends and you can’t cast it again for 10 minutes. Unlike a normal Shield Block, you can use the spell’s reaction against the magic missile spell." };
            yield return new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Text, Text = "Heightening the spell increases the shield’s Hardness." };
        }

        public override IEnumerable<SpellHeightening> GetHeightenings()
        {
            yield return new SpellHeightening
            {
                Id = Guid.Parse(""),
                Level = "3rd",
                Details =
                {
                    new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Text, Text = "The shield has Hardness 10." }
                }
            };

            yield return new SpellHeightening
            {
                Id = Guid.Parse(""),
                Level = "5th",
                Details =
                {
                    new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Text, Text = "The shield has Hardness 15." }
                }
            };

            yield return new SpellHeightening
            {
                Id = Guid.Parse(""),
                Level = "7th",
                Details =
                {
                    new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Text, Text = "The shield has Hardness 20." }
                }
            };

            yield return new SpellHeightening
            {
                Id = Guid.Parse(""),
                Level = "9th",
                Details =
                {
                    new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Text, Text = "The shield has Hardness 25." }
                }
            };
        }

        protected override IEnumerable<ActionEffect> GetActionEffects()
        {
            yield return new ActionEffect
            {
                Id = Guid.Parse(""),
                Name = "Shield Block",
                ActionTypeId = ActionTypes.Instances.Reaction.ID,
                Trigger = "While you have your shield raised, you take damage from a physical attack.",
                Effects = new TextBlock[]
                {
                    new TextBlock {Id = Guid.Parse (""), Type = TextBlockType.Text, Text = "You place your shield to ward off a blow. Your shield prevents you from taking an amount of damage up to the shield’s Hardness. You and the shield each take any remaining damage, possibly breaking or destroying the shield."},
                }
            };
        }

        public override IEnumerable<Guid> GetSpellComponents()
        {
            yield return SpellComponents.Instances.Verbal.ID;
        }

        public override IEnumerable<Guid> GetMagicTraditions()
        {
            yield return MagicTraditions.Instances.Arcane.ID;
            yield return MagicTraditions.Instances.Divine.ID;
            yield return MagicTraditions.Instances.Occult.ID;
        }

        public override IEnumerable<Guid> GetTraits()
        {
            yield return Traits.Instances.Abjuration.ID;
            yield return Traits.Instances.Cantrip.ID;
            yield return Traits.Instances.Force.ID;
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse(""),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 368
            };
        }
    }
}
