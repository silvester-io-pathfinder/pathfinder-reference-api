using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class DebilitatingStrike : Template
    {
        public static readonly Guid ID = Guid.Parse("f4a88c8e-6df4-4c85-a788-f6810dcf7e0a");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Debilitating Strike",
                Level = -1,
                ActionTypeId = ActionTypes.Instances.FreeAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = "Your Strike hits a flat-footed creature and deals damage.",
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("f5708d44-7386-4cb1-b06d-fdcf8a4b791f"), Type = TextBlockType.Text, Text = "You apply one of the following debilitations, which lasts until the end of your next turn." };
            yield return new TextBlock { Id = Guid.Parse("d465a238-e14a-4ba8-9fbf-8d7a49d6e5a3"), Type = TextBlockType.Text, Text = "~ Debilitation: The target takes a -10-foot status penalty to its Speeds." };
            yield return new TextBlock { Id = Guid.Parse("13d02473-72d5-4f97-89f4-060adca36f82"), Type = TextBlockType.Text, Text = "~ Debilitation: The target becomes enfeebled 1." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("c2040d66-259a-463b-8078-f4ed839fa721"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
