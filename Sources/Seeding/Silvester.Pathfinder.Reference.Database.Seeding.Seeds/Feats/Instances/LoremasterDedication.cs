using Silvester.Pathfinder.Reference.Database.Seeding.Builders.TextBlocks;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.Traits;
using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class LoremasterDedication : Template
    {
        public static readonly Guid ID = Guid.Parse("babec88d-cc20-4539-8816-7c7157afae2e");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Loremaster Dedication",
                Level = 2,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = "You can't select another dedication feat until you have gained two other feats from the loremaster archetype.",
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("9a2dec16-81ec-41bc-846b-5da3f646889e"), Type = TextBlockType.Text, Text = $"You've compiled a vast repository of information that touches on nearly every subject. You are trained in Loremaster Lore, a special Lore skill that can be used only to {ToMarkdownLink<Models.Entities.SkillAction>("Recall Knowledge", SkillActions.Instances.RecallKnowledge.ID)}, but on any topic. If you have legendary proficiency in a skill used to {ToMarkdownLink<Models.Entities.SkillAction>("Decipher Writing", SkillActions.Instances.DecipherWriting.ID)}, you gain expert proficiency in Loremaster Lore, but you can't increase your proficiency rank in Loremaster Lore by any other means." };
            yield return new TextBlock { Id = Guid.Parse("8eebe1fe-7897-40a8-9139-53709b9816a8"), Type = TextBlockType.Text, Text = $"If you have the {ToMarkdownLink<Models.Entities.Feat>("Bardic Lore", Feats.Instances.BardicLore.ID)} class feat, you gain a +1 circumstance bonus to skill checks with Bardic Lore." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            //TODO: Add prerequisites.
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("d9fff14b-5db0-4c67-80af-07669710a387"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
