using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class MiraculousPossibility : Template
    {
        public static readonly Guid ID = Guid.Parse("8ccf0a42-f53b-4cb9-8747-c92ad6053202");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Miraculous Possibility",
                Level = 18,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("59cffa59-554f-46d7-b389-4298e3d55ae6"), Type = TextBlockType.Text, Text = "Your deity empowers you to perform minor miracles, allowing you to readily adapt to the fluctuating needs of your duties. Once during your daily preparations, you can use a spell slot to hold sheer divine potential, rather than using it to prepare a spell. You can use this spell slot to cast any spell you know from the divine spell list that’s at least 2 levels lower than the slot you designate. The spell acts in all ways as a spell of 2 levels lower. You don’t have any particular spell prepared in that slot until you cast it." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("08ab0ad2-4eca-46a1-abf8-3369cf0d442c"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
