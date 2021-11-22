using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Spells.Instances
{
    public class Harm : Template
    {
        public static readonly Guid ID = Guid.Parse("82963894-a9f4-443c-af8e-504e256fda94");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Harm",
                Level = 1,
                Range = "Varies.",
                Targets = "1 living creature or 1 willing undead creature.",
                SpellTypeId = SpellTypes.Instances.Spell.ID,
                ActionTypeId = ActionTypes.Instances.OneToThreeActions.ID,
                MagicSchoolId = MagicSchools.Instances.Necromancy.ID
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("430292f7-5d21-4c7b-84c0-a68c3d3de175"), Type = TextBlockType.Text, Text = "You channel negative energy to harm the living or heal the undead. If the target is a living creature, you deal 1d8 negative damage to it, and it gets a basic Fortitude save. If the target is a willing undead creature, you restore that amount of Hit Points. The number of actions you spend when Casting this Spell determines its targets, range, area, and other parameters." };
        }

        public override IEnumerable<SpellHeightening> GetHeightenings()
        {
            yield return new SpellHeightening
            {
                Id = Guid.Parse("7ed06502-393d-4b18-8093-cc77defbf123"), 
                Level = "+1",
                Details =
                {
                    new TextBlock { Id = Guid.Parse("4c5d1fd8-a2b9-4325-bd46-ea098d019ec9"), Type = TextBlockType.Text, Text = "The amount of healing or damage increases by 1d8, and the extra healing for the 2-action version increases by 8." }
                }
            };
        }

        protected override IEnumerable<ActionEffect> GetActionEffects()
        {
            yield return new ActionEffect
            {
                Id = Guid.Parse("7b7059d8-e342-45e6-aa39-fbcbd7afe73c"),
                Name = "Somatic",
                ActionTypeId = ActionTypes.Instances.OneAction.ID,
                Effects = new TextBlock[]
                {
                    new TextBlock {Id = Guid.Parse("970fb534-9369-41e8-bc20-7cdbb7e7d795"), Type = TextBlockType.Text, Text = "The spell has a range of touch."},
                }
            };

            yield return new ActionEffect
            {
                Id = Guid.Parse("b292a617-3d9c-4710-88dd-a9320974309e"),
                Name = "Somatic, Verbal",
                ActionTypeId = ActionTypes.Instances.TwoActions.ID,
                Effects = new TextBlock[]
                {
                   new TextBlock {Id = Guid.Parse("8c462a78-74de-4210-9089-1835cf1efbaa"), Type = TextBlockType.Text, Text = "The spell has a range of 30 feet. If you're healing an undead creature, increase the Hit Points restored by 8."},
                }
            };

            yield return new ActionEffect
            {
                Id = Guid.Parse("126dfa60-527a-447c-9a44-85995e3f002f"),
                Name = "Material, Somatic, Verbal",
                ActionTypeId = ActionTypes.Instances.ThreeActions.ID,
                Effects = new TextBlock[]
                {
                    new TextBlock {Id = Guid.Parse("e50a00f4-7d4c-4adb-a70a-051a94492341"), Type = TextBlockType.Text, Text = "You disperse negative energy in a 30-foot emanation. This targets all living and undead creatures in the area."},
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
                Id = Guid.Parse("383d8bd1-7554-4de6-9d3e-87a39f46cf4e"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 343
            };
        }
    }
}
