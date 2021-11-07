using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class ShatteringBlows : Template
    {
        public static readonly Guid ID = Guid.Parse("0136b61a-49ff-4ca2-aee1-ab71978bbb21");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Shattering Blows",
                Level = 16,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("0aec98e8-3f99-4cf5-8b46-9007e29f8e08"), Type = TextBlockType.Text, Text = "Your forceful blows shatter objects with ease. While you are raging, your melee (action: Strikes | Strike) ignore 5 points of an object’s Hardness. If you have the devastator class feature, you instead ignore 10 points of an object’s Hardness." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("39cab311-4f32-4145-aa58-dd2f9bf307cd"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
