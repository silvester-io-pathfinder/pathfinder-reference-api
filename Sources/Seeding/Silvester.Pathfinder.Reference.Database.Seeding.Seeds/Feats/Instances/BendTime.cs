using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class BendTime : Template
    {
        public static readonly Guid ID = Guid.Parse("b1f3df9a-b345-461f-a6ad-9153b2bd6d77");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Bend Time",
                Level = -1,
                ActionTypeId = ActionTypes.Instances.FreeAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = "Your turn begins.",
                Frequency = "once per day"
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("fd6ccb92-6f2b-49dd-a66b-8894676eef5c"), Type = TextBlockType.Text, Text = $"You are quickened this turn. You can use your extra action only to {ToMarkdownLink<Models.Entities.Action>("Stride", Actions.Instances.Stride.ID)}." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("21432397-b6ce-44de-9dc9-147674636e84"),
                SourceId = Sources.Instances.SecretsOfMagic.ID,
                Page = -1
            };
        }
    }
}
