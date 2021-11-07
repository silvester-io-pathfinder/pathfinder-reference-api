using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class JellyfishStance : Template
    {
        public static readonly Guid ID = Guid.Parse("e748f94e-7549-4069-83a1-6882fb01a762");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Jellyfish Stance",
                Level = 6,
                ActionTypeId = ActionTypes.Instances.OneAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("defd9af5-9db9-46e7-8e78-b3f97c949eb2"), Type = TextBlockType.Text, Text = "You relax your posture and loosen your joints, allowing yourself to move with incredible fluidity. You can make stinging lash attacks that deal 1d8 slashing damage. These attacks are in the brawling group, and have the (trait: finesse), (trait: nonlethal), (trait: reach), and (trait: unarmed) traits." };
            yield return new TextBlock { Id = Guid.Parse("ff85f4c6-3651-4454-a6df-640ed325802a"), Type = TextBlockType.Text, Text = "While in Jellyfish Stance, you gain a +2 circumstance bonus to Reflex saves and on checks to (action: Escape) and (action: Squeeze)." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("dfc32020-eea6-4a74-afc5-1da0e7e2be00"),
                SourceId = Sources.Instances.FistOfTheRubyPhoenix.ID,
                Page = -1
            };
        }
    }
}
