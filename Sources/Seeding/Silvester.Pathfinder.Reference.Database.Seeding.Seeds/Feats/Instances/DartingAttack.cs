using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class DartingAttack : Template
    {
        public static readonly Guid ID = Guid.Parse("0b6a772e-b921-4b14-bd5c-25b328014b52");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Darting Attack",
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
            yield return new TextBlock { Id = Guid.Parse("cb720d20-d0ed-4df2-aa49-c8283b035853"), Type = TextBlockType.Text, Text = $"The raptor {ToMarkdownLink<Models.Entities.Action>("Steps", Actions.Instances.Step.ID)} up to 10 feet and then {ToMarkdownLink<Models.Entities.Action>("Strikes", Actions.Instances.Strike.ID)}, or {ToMarkdownLink<Models.Entities.Action>("Strikes", Actions.Instances.Strike.ID)} and then {ToMarkdownLink<Models.Entities.Action>("Steps", Actions.Instances.Step.ID)} up to 10 feet." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("40ec6b2e-0d5d-4c4d-97e9-7818e28763c5"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
