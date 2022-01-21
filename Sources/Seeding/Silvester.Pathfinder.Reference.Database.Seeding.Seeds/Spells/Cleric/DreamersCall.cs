using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.Traits;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Spells.Instances
{
    public class DreamersCall : Template
    {
        public static readonly Guid ID = Guid.Parse("43383a1a-43cb-4de9-aa14-6d1915175e62");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Dreamer's Call",
                Level = 4,
                Range = "30 feet.",
                Duration = "Until the end of the target's next turn.",
                Targets = "1 creature.",
                IsSavingThrowBasic = false,
                SavingThrowStatId = SavingThrowStats.Instances.Will.ID,
                DomainId = Domains.Instances.Dreams.ID,
                ActionTypeId = ActionTypes.Instances.TwoActions.ID,
                ClassId = Classes.Instances.Cleric.ID,
                SpellTypeId = SpellTypes.Instances.Focus.ID,
                MagicSchoolId = MagicSchools.Instances.Enchantment.ID
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("dad501c9-9412-43bf-98e3-5ee79a0097e0"), Type = TextBlockType.Text, Text = "The target becomes distracted and suggestible, inundated by vivid daydreams." };
        }

        public override IEnumerable<RollableEffect> GetRollableEffects()
        {
            yield return new RollableEffect
            {
                Id = Guid.Parse("749c528f-62ef-4e65-bbef-ce951ddd121b"),
                CriticalSuccess = "The target is unaffected.",
                Success = "The target's attention wavers. It becomes flat-footed and fascinated by its daydreams.",
                Failure = "As success, except that you appear in the dream and give a suggestion. This can be to approach you, run away (as if it had the fleeing condition), Release what it's holding, Drop Prone, or stand in place. The creature follows this course of action as its first action after you Cast the Spell.",
                CriticalFailure = "As failure, but the target follows the course of action for as many actions as possible for the spell's duration, and it does nothing else."
            };
        }

        public override IEnumerable<Guid> GetSpellComponents()
        {
            yield return SpellComponents.Instances.Somatic.ID;
            yield return SpellComponents.Instances.Verbal.ID;
        }

        public override void GetTraits(ITraitBindingBuilder<SpellTraitBinding, Spell> builder)
        {
            builder.Add(Guid.Parse("5c44b589-827d-4210-83eb-75fd15356d15"), Traits.Instances.Uncommon.ID);
            builder.Add(Guid.Parse("e0735008-5a4b-4513-8763-60f6aa5e5054"), Traits.Instances.Cleric.ID);
            builder.Add(Guid.Parse("df1e2953-b260-4506-9844-afad55660f60"), Traits.Instances.Enchantment.ID);
            builder.Add(Guid.Parse("a813df25-f25b-4c69-944f-89380e02b085"), Traits.Instances.Incapacitation.ID);
            builder.Add(Guid.Parse("403d0df2-3bd2-413b-b8cd-7c26090a337d"), Traits.Instances.Mental.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("69f17de7-6da0-4c3d-b77a-0aacd8cade84"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 391
            };
        }
    }
}
