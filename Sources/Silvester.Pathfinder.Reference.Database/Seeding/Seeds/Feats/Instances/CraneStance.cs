using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class CraneStance : Template
    {
        public static readonly Guid ID = Guid.Parse("c1a15111-887b-4686-8fec-1c5d449d571e");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Crane Stance",
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
            yield return new TextBlock { Id = Guid.Parse("02d828c8-cdd8-48e9-8789-03d49fe85593"), Type = TextBlockType.Text, Text = "You enter the stance of a crane, holding your arms in an imitation of a crane’s wings and using flowing, defensive motions. You gain a +1 circumstance bonus to AC, but the only (action: Strikes | Strike) you can make are crane wing attacks. These deal 1d6 bludgeoning damage; are in the brawling group; and have the (trait: agile), (trait: finesse), (trait: nonlethal), and (trait: unarmed) traits." };
            yield return new TextBlock { Id = Guid.Parse("239dca01-5b4f-416c-b72d-53522a820b2b"), Type = TextBlockType.Text, Text = "While in Crane Stance, reduce the DC for (action: High Jump) and (action: Long Jump) by 5, and when you (action: Leap), you can move an additional 5 feet horizontally or 2 feet vertically." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("b625542d-1549-40ad-ac8f-65d2167cea55"), Feats.Instances.MartialArtistDedication.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("6d4821a9-228b-4a05-8b95-88edaa81abc3"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
