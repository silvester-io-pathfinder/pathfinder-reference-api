using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Spells.Instances
{
    public class CleansingFlames : Template
    {
        public static readonly Guid ID = Guid.Parse("357aa1e5-235f-4c47-be20-9294dce2ec2d");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Cleansing Flames",
                Level = 5,
                Range = "Touch.",
                ActionTypeId = ActionTypes.Instances.TwoActions.ID,
                ClassId = Classes.Instances.Sorcerer.ID,
                SpellTypeId = SpellTypes.Instances.Focus.ID,
                MagicSchoolId = MagicSchools.Instances.Necromancy.ID
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("7bf2b483-8c75-4be0-958f-bf5bbffc2493"), Type = TextBlockType.Text, Text = "You wrap the target in purifying flames. You can attempt to counteract a single poison or non-curse effect imparting the clumsy, dazzled, enfeebled, fatigued, frightened, paralyzed, sickened, or stupefied condition. The target can choose to empower the flames with their life force, becoming drained 1 (or increasing their drained value by 1, if already under the condition) to grant you a +1 circumstance bonus to your counteract check." };
        }

        public override IEnumerable<Guid> GetSpellComponents()
        {
            yield return SpellComponents.Instances.Somatic.ID;
            yield return SpellComponents.Instances.Verbal.ID;
        }

        public override IEnumerable<Guid> GetTraits()
        {
            yield return Traits.Instances.Uncommon.ID;
            yield return Traits.Instances.Fire.ID;
            yield return Traits.Instances.Healing.ID;
            yield return Traits.Instances.Necromancy.ID;
            yield return Traits.Instances.Sorcerer.ID;
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("849a5e6b-3af6-4c35-8508-534039976d07"),
                SourceId = Sources.Instances.Pathfinder168.ID,
                Page = 74
            };
        }
    }
}
