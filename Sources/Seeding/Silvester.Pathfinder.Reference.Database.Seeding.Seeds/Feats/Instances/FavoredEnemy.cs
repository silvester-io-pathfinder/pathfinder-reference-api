using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class FavoredEnemy : Template
    {
        public static readonly Guid ID = Guid.Parse("26cb164c-440e-4aa7-9a7f-bb8c6506d699");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Favored Enemy",
                Level = 4,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("2f7cd428-af52-455f-ac95-c48efa9f019b"), Type = TextBlockType.Text, Text = $"You have studied a specific type of wild creature and can hunt it more easily. When you gain this feat, choose animals, beasts, dragons, or both fungi and plants as your favored enemy. When you roll initiative and can see an enemy that belongs to the chosen category, you can {ToMarkdownLink<Models.Entities.Feat>("Hunt Prey", Feats.Instances.HuntPrey.ID)} as a free action, designating that enemy." };
            yield return new TextBlock { Id = Guid.Parse("57c88f78-dfbd-4796-9079-6cebbf1a1185"), Type = TextBlockType.Text, Text = $"You can use this free action even if you haven't identified the creature yet with {ToMarkdownLink<Models.Entities.SkillAction>("Recall Knowledge", SkillActions.Instances.RecallKnowledge.ID)}. The benefit doesn't apply against favored enemies disguised as other creatures, and the GM determines whether it applies against a creature disguised as a favored enemy." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("14b1e451-7b14-4722-a049-ac2cb980949f"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
