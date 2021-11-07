using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class EverstandStrike : Template
    {
        public static readonly Guid ID = Guid.Parse("da9e9fdf-6c6c-4732-a193-caee576ae31a");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Everstand Strike",
                Level = 4,
                ActionTypeId = ActionTypes.Instances.OneAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("b3e5deb0-2368-479c-a4a1-2c667c918aee"), Type = TextBlockType.Text, Text = "~ Access: The following class feat is available to Knights of Lastwall." };
            yield return new TextBlock { Id = Guid.Parse("95e9abe4-74fc-49f0-87e8-a035071799d8"), Type = TextBlockType.Text, Text = "Your follow-up blow leaves you an opening to set your shield. Make a (action: Strike) with the wielded shield. If the (action: Strike) hits and deals damage, you also (action: Raise your Shield | Raise a Shield)." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("7a564901-1499-4433-9a63-dfbf735edc63"), Feats.Instances.EverstandStance.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("a61a4f80-5c5f-46b0-ad13-22a8b3dce7bb"),
                SourceId = Sources.Instances.LostOmensCharacterGuide.ID,
                Page = -1
            };
        }
    }
}
