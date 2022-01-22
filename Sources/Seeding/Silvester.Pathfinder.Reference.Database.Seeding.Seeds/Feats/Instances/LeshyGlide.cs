using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class LeshyGlide : Template
    {
        public static readonly Guid ID = Guid.Parse("4d72380a-654d-45f9-930f-c8a4279b60ea");

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
            yield return new TextBlock { Id = Guid.Parse("acc5924f-61b6-4c90-92c2-cd99890a7e6c"), Type = TextBlockType.Text, Text = $"Using your own leaves, you can control your descent. You glide slowly toward the ground, 5 feet down and up to 25 feet forward through the air. As long as you spend at least 1 action gliding each round and have not yet reached the ground, you remain in the air at the end of your turn." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.AddOr(Guid.Parse("25d2b9c3-c3f9-4c86-87c7-a31afb99f3b7"), or => 
            {
                or.HaveSpecificHeritage(Guid.Parse("7576d2d2-62c4-4ab7-b5d7-8a7b949921dd"), Heritages.Instances.LeafLeshy.ID);
                or.HaveSpecificFeat(Guid.Parse("7db6d757-20b2-4d28-8847-e72a7ea0f716"), Feats.Instances.CatFall.ID);
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
                Id = Guid.Parse("6a294777-b04e-4ca9-9330-4fd3ecfe21b5"),
                SourceId = Sources.Instances.LostOmensCharacterGuide.ID,
                Page = -1
            };
        }
    }
}
