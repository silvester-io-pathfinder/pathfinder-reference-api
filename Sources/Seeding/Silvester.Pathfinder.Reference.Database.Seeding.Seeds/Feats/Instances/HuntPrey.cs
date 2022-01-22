using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class HuntPrey : Template
    {
        public static readonly Guid ID = Guid.Parse("a5f60af1-a46c-491a-abc4-67e4e4458275");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Hunt Prey",
                Level = -1,
                ActionTypeId = ActionTypes.Instances.OneAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("09679b5b-6255-4e24-a785-302aa64e8a2a"), Type = TextBlockType.Text, Text = $"You designate a single creature as your prey and focus your attacks against that creature. You must be able to see or hear the prey, or you must be {ToMarkdownLink<Models.Entities.SkillAction>("Tracking", SkillActions.Instances.Track.ID)} the prey during exploration." };
            yield return new TextBlock { Id = Guid.Parse("5a4e0b18-1abf-4e9c-8503-c2522cd01d5d"), Type = TextBlockType.Text, Text = $"You gain a +2 circumstance bonus to Perception checks when you {ToMarkdownLink<Models.Entities.Action>("Seek", Actions.Instances.Seek.ID)} your prey and a +2 circumstance bonus to Survival checks when you {ToMarkdownLink<Models.Entities.SkillAction>("Track", SkillActions.Instances.Track.ID)} your prey. You also ignore the penalty for making ranged attacks within your second range increment against the prey you're hunting." };
            yield return new TextBlock { Id = Guid.Parse("87b40538-701d-4d5a-8ae5-38e557aad812"), Type = TextBlockType.Text, Text = $"You can have only one creature designated as your prey at a time. If you use Hunt Prey against a creature when you already have a creature designated, the prior creature loses the designation and the new prey gains the designation. Your designation lasts until your next daily preparations." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("238fe77c-fbbd-4264-a5f7-d5400fe75ee5"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
