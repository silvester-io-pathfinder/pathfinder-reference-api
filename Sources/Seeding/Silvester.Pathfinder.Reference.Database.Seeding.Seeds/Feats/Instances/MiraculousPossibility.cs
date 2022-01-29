using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class MiraculousPossibility : Template
    {
        public static readonly Guid ID = Guid.Parse("7ba6d69c-589c-41b5-b6b1-e5b265b456c7");

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
            yield return new TextBlock { Id = Guid.Parse("aeffb1bd-d088-46cf-9317-1311cb3728c9"), Type = TextBlockType.Text, Text = $"Your deity empowers you to perform minor miracles, allowing you to readily adapt to the fluctuating needs of your duties. Once during your daily preparations, you can use a spell slot to hold sheer divine potential, rather than using it to prepare a spell. You can use this spell slot to cast any spell you know from the divine spell list that's at least 2 levels lower than the slot you designate. The spell acts in all ways as a spell of 2 levels lower. You don't have any particular spell prepared in that slot until you cast it." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("fb20d456-c47a-4be6-848d-cf95c665c81a"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
