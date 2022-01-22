using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class KnowledgeIsPower : Template
    {
        public static readonly Guid ID = Guid.Parse("044c49d2-3f0e-465e-8885-f993a60e9b45");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Knowledge is Power",
                Level = 6,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("7da274ff-2db0-4df0-a9b5-0302330d820f"), Type = TextBlockType.Text, Text = $"When you critically succeed at a {ToMarkdownLink<Models.Entities.SkillAction>("Recall Knowledge", SkillActions.Instances.RecallKnowledge.ID)} check about a creature, you gain a +1 circumstance bonus to your next attack roll against the creature, to your AC against its next attack roll, and to your save against its next effect requiring a save. If you share this information with your allies, they gain the benefits as well. If not used, these bonuses end after 1 minute." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("4126b61d-8e6c-49af-82d1-80d7068f0640"),
                SourceId = Sources.Instances.SecretsOfMagic.ID,
                Page = -1
            };
        }
    }
}
