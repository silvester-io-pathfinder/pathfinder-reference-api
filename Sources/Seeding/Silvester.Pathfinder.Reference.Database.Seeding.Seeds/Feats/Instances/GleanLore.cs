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
    public class GleanLore : Template
    {
        public static readonly Guid ID = Guid.Parse("6dc5b71f-463c-425f-9635-dce3c68d6a8b");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Glean Lore",
                Level = 1,
                ActionTypeId = ActionTypes.Instances.OneAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("340704c5-58a3-4fda-a748-4f1fdf06e9e4"), Type = TextBlockType.Text, Text = $"You tap into the collected lore of the divine, accessing a variety of potentially useful information. Attempt a Religion check to understand the information you gain. The GM sets the DC (similar to the DC to {ToMarkdownLink<Models.Entities.SkillAction>("Recall Knowledge", SkillActions.Instances.RecallKnowledge.ID)}), potentially adjusting the DC of the check for topics far removed from your mystery." };
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {
            builder.Add(Guid.Parse("d8d1325c-0e6b-4381-9005-6e510ee73ac0"), Traits.Instances.Divination.ID);
            builder.Add(Guid.Parse("f51bf11d-87d8-4eca-9ed5-db7afc9673c2"), Traits.Instances.Divine.ID);
            builder.Add(Guid.Parse("cc473ae8-2110-4a57-b76d-167b84cfb2ec"), Traits.Instances.Oracle.ID);
            builder.Add(Guid.Parse("ed6c149f-7a8d-44d2-8461-77641bafdf36"), Traits.Instances.Secret.ID);

        }

        protected override RollableEffect? GetRollableEffect()
        {
            return new RollableEffect
            {
                Id = Guid.Parse("f9b179dd-2daa-47da-841d-5c04a5979d11"),
                CriticalSuccess = "You comprehend the lore accurately or gain a useful clue from the divine about your situation.",
                Success = "You learn two pieces of information about the topic, one true and one erroneous, but you don't know which is which.",
                Failure = "You recall incorrect information or gain an erroneous or misleading clue.",
                CriticalFailure = "You recall two pieces of incorrect information or gain two erroneous or misleading clues.", 
            };
        }
            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("5a10be3c-5130-40bd-962d-27bd01565750"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
