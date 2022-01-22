using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class HuntedShot : Template
    {
        public static readonly Guid ID = Guid.Parse("07fd6e56-03b1-4868-a2b1-0193bd5b7f5b");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Hunted Shot",
                Level = 1,
                ActionTypeId = ActionTypes.Instances.OneAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = "once per round"
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("f7299409-e8c7-4843-8976-2daaa8ea975a"), Type = TextBlockType.Text, Text = $"You take two quick shots against the one you hunt. Make two {ToMarkdownLink<Models.Entities.Action>("Strikes", Actions.Instances.Strike.ID)} against your prey with the required weapon. If both hit the same creature, combine their damage for the purpose of resistances and weaknesses. Apply your multiple attack penalty to each {ToMarkdownLink<Models.Entities.Action>("Strike", Actions.Instances.Strike.ID)} normally." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("2c00b969-c34f-4ace-a863-62ef974cde13"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
