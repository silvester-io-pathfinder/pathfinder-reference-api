using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class MagicWarriorDedication : Template
    {
        public static readonly Guid ID = Guid.Parse("67989647-e61d-4753-a37c-34fed68b39ed");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Magic Warrior Dedication",
                Level = 2,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = "You cannot select another dedication feat until you have gained two other feats from the magic warrior archetype.",
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("158b3729-a8fa-450a-8766-2293bc57fb5b"), Type = TextBlockType.Text, Text = "~ Access: You are from the Mwangi Expanse." };
            yield return new TextBlock { Id = Guid.Parse("3e4cf4f0-cc1c-47e3-89a8-2459befabdee"), Type = TextBlockType.Text, Text = "You have taken up a nameless mask and sworn the oath of the magic warriors. You become trained in your choice of Arcana or Nature and in Magic Warrior Lore; if you were already trained in the skill, you become an expert instead." };
            yield return new TextBlock { Id = Guid.Parse("c7f0ce55-39a4-40e3-a568-94a4f54fe656"), Type = TextBlockType.Text, Text = "You hide your identity behind a mask representing an animal of your choice, corresponding to one of the general animal types in the (spell: animal form) spell. You gain a +1 circumstance bonus to saves against (trait: divination) effects, though sometimes refusing to remove your mask can cause issues in areas that don't respect or understand the magic warrior tradition." };
            yield return new TextBlock { Id = Guid.Parse("10fb3e0a-9156-4887-b547-cc5fc4496e0a"), Type = TextBlockType.Text, Text = "Once you take this feat, if another creature ever learns your true face or name, you lose your abilities from this archetype. Close allies who knew of your decision to take the mask before your dedication don't break this taboo unless they tell someone else. To regain your abilities, you must discard your mask and obtain a new one of a different animal, then retrain Magic Warrior Dedication into a new Magic Warrior Dedication with your new mask. Your focus spells from the magic warrior archetype are the same tradition as your other spells (choose one if you have spells from multiple traditions)." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveFocusPool(Guid.Parse("1c575ce3-6f69-4bf9-a272-8521d7639375"));
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("0f044275-4327-4b79-a7c7-f63e73be15dc"),
                SourceId = Sources.Instances.LostOmensWorldGuide.ID,
                Page = -1
            };
        }
    }
}
