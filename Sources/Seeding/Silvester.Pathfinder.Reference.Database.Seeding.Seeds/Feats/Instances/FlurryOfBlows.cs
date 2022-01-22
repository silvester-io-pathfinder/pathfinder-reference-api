using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class FlurryOfBlows : Template
    {
        public static readonly Guid ID = Guid.Parse("1d09a165-b1a6-46a2-a54e-a026a015ce83");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Flurry of Blows",
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
            yield return new TextBlock { Id = Guid.Parse("81ebeced-369d-4325-9cbe-e51018288c7e"), Type = TextBlockType.Text, Text = $"Make two unarmed {ToMarkdownLink<Models.Entities.Action>("Strikes", Actions.Instances.Strike.ID)}. If both hit the same creature, combine their damage for the purpose of resistances and weaknesses. Apply your multiple attack penalty to the {ToMarkdownLink<Models.Entities.Action>("Strikes", Actions.Instances.Strike.ID)} normally. As it has the {ToMarkdownLink<Models.Entities.Trait>("flourish", Traits.Instances.Flourish.ID)} trait, you can use Flurry of Blows only once per turn." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("ba7ecd85-4180-47c0-8c26-c44d29400475"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
