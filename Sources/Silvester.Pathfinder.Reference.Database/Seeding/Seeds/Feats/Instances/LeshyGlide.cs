using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class LeshyGlide : Template
    {
        public static readonly Guid ID = Guid.Parse("e21ca347-438f-4bf2-a9b3-4726a4bf3898");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Leshy Glide",
                Level = 5,
                ActionTypeId = ActionTypes.Instances.OneAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("e9ab7aa6-94eb-4b87-bd77-dc12c405b093"), Type = TextBlockType.Text, Text = "Using your own leaves, you can control your descent. You glide slowly toward the ground, 5 feet down and up to 25 feet forward through the air. As long as you spend at least 1 action gliding each round and have not yet reached the ground, you remain in the air at the end of your turn." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.AddOr(Guid.Parse("183e6ca3-e684-452e-8a66-bfa1b4b74936"), or => 
            {
                or.HaveSpecificHeritage(Guid.Parse("3aae02c9-67bf-4c12-bc3a-bd0ccac81ee7"), Heritages.Instances.LeafLeshy.ID);
                or.HaveSpecificFeat(Guid.Parse("7d615954-79e0-4684-adb9-71f818eb55ce"), Feats.Instances.CatFall.ID);
            });
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("d515ee36-6c0d-4059-8d70-182cd577fe77"),
                SourceId = Sources.Instances.LostOmensCharacterGuide.ID,
                Page = -1
            };
        }
    }
}
