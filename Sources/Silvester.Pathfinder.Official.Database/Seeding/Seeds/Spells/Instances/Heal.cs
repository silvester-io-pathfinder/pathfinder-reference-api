using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Spells.Instances
{
    public class Heal : Template
    {
        public static readonly Guid ID = Guid.Parse("");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Heal",
                Level = 1,
                Range = "Varies.",
                Targets = "1 willing living creature or 1 undead creature.",
                SpellTypeId = SpellTypes.Instances.Focus.ID,
                ActionTypeId = ActionTypes.Instances.OneToThreeActions.ID,
                MagicSchoolId = MagicSchools.Instances.Necromancy.ID
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Text, Text = "You channel positive energy to heal the living or damage the undead. If the target is a willing living creature, you restore 1d8 Hit Points. If the target is undead, you deal that amount of positive damage to it, and it gets a basic Fortitude save. The number of actions you spend when Casting this Spell determines its targets, range, area, and other parameters." };
        }

        public override IEnumerable<SpellHeightening> GetHeightenings()
        {
            yield return new SpellHeightening
            {
                Id = Guid.Parse(""), 
                Level = "+1",
                Details =
                {
                    new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Text, Text = "The amount of healing or damage increases by 1d8, and the extra healing for the 2-action version increases by 8." }
                }
            };
        }

        protected override IEnumerable<ActionEffect> GetActionEffects()
        {
            yield return new ActionEffect
            {
                Id = Guid.Parse(""),
                Name = "Somatic",
                ActionTypeId = ActionTypes.Instances.OneAction.ID,
                Effects = new TextBlock[]
                {
                    new TextBlock {Id = Guid.Parse (""), Type = TextBlockType.Text, Text = "The spell has a range of touch."},
                }
            };
            yield return new ActionEffect
            {
                Id = Guid.Parse(""),
                Name = "Somatic, Verbal",
                ActionTypeId = ActionTypes.Instances.TwoActions.ID,
                Effects = new TextBlock[]
                {
                    new TextBlock {Id = Guid.Parse (""), Type = TextBlockType.Text, Text = "The spell has a range of 30 feet. If you’re healing a living creature, increase the Hit Points restored by 8."},
                }
            };
            yield return new ActionEffect
            {
                Id = Guid.Parse(""),
                Name = "Material, Somatic, Verbal",
                ActionTypeId = ActionTypes.Instances.ThreeActions.ID,
                Effects = new TextBlock[]
                {
                    new TextBlock {Id = Guid.Parse (""), Type = TextBlockType.Text, Text = "You disperse positive energy in a 30-foot emanation. This targets all living and undead creatures in the burst."},
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
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse(""),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 343
            };
        }
    }
}
