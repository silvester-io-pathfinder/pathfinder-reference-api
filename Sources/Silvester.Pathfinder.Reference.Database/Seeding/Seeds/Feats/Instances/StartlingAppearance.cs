using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class StartlingAppearance : Template
    {
        public static readonly Guid ID = Guid.Parse("1a8c3714-22df-4bce-a345-13ebb8639683");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Startling Appearance",
                Level = 1,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("4d5e8154-8f2e-4a33-b79f-a0d9ca5ba85e"), Type = TextBlockType.Text, Text = "You are trained in Intimidation (or another skill of your choice, if you were already trained in Intimidation) and gain the (feat: Intimidating Glare) skill feat as a bonus feat." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("317a28ae-da6c-415d-88d5-46fd2c903ec8"),
                SourceId = Sources.Instances.LostOmensAncestryGuide.ID,
                Page = -1
            };
        }
    }
}
