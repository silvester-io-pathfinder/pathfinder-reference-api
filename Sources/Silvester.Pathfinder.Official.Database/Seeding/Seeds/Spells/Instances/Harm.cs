using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Spells.Instances
{
    public class Harm : Template
    {
        public static readonly Guid ID = Guid.Parse("");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Harm",
                Level = 1,
                Range = "Varies.",
                Targets = "1 living creature or 1 willing undead creature.",
                SpellTypeId = SpellTypes.Instances.Focus.ID,
                ActionTypeId = ActionTypes.Instances.OneToThreeActions.ID,
                MagicSchoolId = MagicSchools.Instances.Necromancy.ID
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Text, Text = "You channel negative energy to harm the living or heal the undead. If the target is a living creature, you deal 1d8 negative damage to it, and it gets a basic Fortitude save. If the target is a willing undead creature, you restore that amount of Hit Points. The number of actions you spend when Casting this Spell determines its targets, range, area, and other parameters." };
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
                   new TextBlock {Id = Guid.Parse (""), Type = TextBlockType.Text, Text = "The spell has a range of 30 feet. If you’re healing an undead creature, increase the Hit Points restored by 8."},
                }
            };

            yield return new ActionEffect
            {
                Id = Guid.Parse(""),
                Name = "Material, Somatic, Verbal",
                ActionTypeId = ActionTypes.Instances.ThreeActions.ID,
                Effects = new TextBlock[]
                {
                    new TextBlock {Id = Guid.Parse (""), Type = TextBlockType.Text, Text = "You disperse negative energy in a 30-foot emanation. This targets all living and undead creatures in the area."},
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
        }

        public override IEnumerable<Guid> GetTraits()
        {
            yield return Traits.Instances.Necromancy.ID;
            yield return Traits.Instances.Negative.ID;
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
