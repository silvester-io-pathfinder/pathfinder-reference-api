using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class CourageousOnslaught : Template
    {
        public static readonly Guid ID = Guid.Parse("c37ac2f3-9a0a-4ec3-83ac-63cd4dbbf5af");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Courageous Onslaught",
                Level = 16,
                ActionTypeId = ActionTypes.Instances.OneAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("9fa1be4b-463e-49eb-aa20-44dd4dd0203e"), Type = TextBlockType.Text, Text = "You use your performance to orchestrate an onslaught against your enemies. If your next action is to cast the (spell: inspire courage) composition cantrip, one ally who gains a status bonus from the spell can immediately use a reaction to (action: Stride) and then make a melee (action: Strike)." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("022af4d5-05b3-4371-bde6-3f1c6e5f58c4"), Feats.Instances.CourageousAdvance.ID);
            builder.HaveSpecificFeat(Guid.Parse("de8e05c3-0fd4-4b9c-9116-6bbc99590980"), Feats.Instances.CourageousAssault.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("5fdf0466-819f-4a63-b20f-1a20c292bba7"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}