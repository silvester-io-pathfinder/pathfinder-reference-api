using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.Traits;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Spells.Instances
{
    public class DiabolicEdict : Template
    {
        public static readonly Guid ID = Guid.Parse("7f8f42d4-01fb-4e31-ab71-f7d546c1afab");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Diabolic Edict",
                Level = 1,
                Range = "30 feet.",
                Duration = "1 round.",
                Targets = "1 willing living creature.",
                ActionTypeId = ActionTypes.Instances.OneAction.ID,
                ClassId = Classes.Instances.Sorcerer.ID,
                SpellTypeId = SpellTypes.Instances.Focus.ID,
                MagicSchoolId = MagicSchools.Instances.Enchantment.ID
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("716a9919-6355-42fd-89a3-37e7e453d185"), Type = TextBlockType.Text, Text = "You issue a diabolic edict, demanding the target perform a particular task and offering rewards for its fulfillment. It gains a +1 status bonus to attack rolls and skill checks related to performing the task. If it refuses to perform the task you proclaimed, it instead takes a –1 status penalty to all its attack rolls and skill checks." };
        }

        public override IEnumerable<Guid> GetSpellComponents()
        {
            yield return SpellComponents.Instances.Verbal.ID;
        }

        public override void GetTraits(ITraitBindingBuilder<SpellTraitBinding, Spell> builder)
        {
            builder.Add(Guid.Parse("1565610e-6e88-4df9-8e95-e97160b529e4"), Traits.Instances.Uncommon.ID);
            builder.Add(Guid.Parse("1e4b973f-da92-40c1-85c5-5e20bd8ded31"), Traits.Instances.Enchantment.ID);
            builder.Add(Guid.Parse("09c49e42-be4a-452f-8731-96fdff9a01d8"), Traits.Instances.Sorcerer.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("0b200545-253a-4ec0-a524-e86e7f7e4e1c"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 403
            };
        }
    }
}
