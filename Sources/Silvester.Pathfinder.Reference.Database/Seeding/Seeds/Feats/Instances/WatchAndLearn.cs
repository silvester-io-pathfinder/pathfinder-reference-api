using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class WatchAndLearn : Template
    {
        public static readonly Guid ID = Guid.Parse("8d7f7526-c86f-4c73-8547-37ad2ca8d997");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Watch and Learn",
                Level = 4,
                ActionTypeId = ActionTypes.Instances.Reaction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = "An ally you can see succeeds or critically succeeds at a Strength- or Dexterity-based skill check, using a skill in which you are untrained.",
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("408907be-120c-4ebb-b635-ec7638dcfae5"), Type = TextBlockType.Text, Text = "Pathfinder agents serve as members of diverse teams with complementary skill sets. You are practiced at following the example of a more skilled ally to accomplish a wide variety of tasks. For the next minute you can add your level as a proficiency bonus to the observed skill check, even though you are untrained. This does not allow you to attempt trained actions using that skill unless you would otherwise be able to do so." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("38694014-c0d1-43ff-98ab-ef613691fedc"), Feats.Instances.PathfinderAgentDedication.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("d91acb52-968b-4850-be4e-a945fbed5e27"),
                SourceId = Sources.Instances.LostOmensSocietyGuide.ID,
                Page = -1
            };
        }
    }
}
