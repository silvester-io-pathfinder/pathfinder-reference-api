using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class PersistentBoost : Template
    {
        public static readonly Guid ID = Guid.Parse("c9f81816-7b04-4546-ab24-a9f77e7167a8");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Persistent Boost",
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
            yield return new TextBlock { Id = Guid.Parse("aa226389-9bfb-4e36-b7c9-953fff5b9f44"), Type = TextBlockType.Text, Text = "Your innovation sets foes on fire, covers them in acid, leaves barbed thorns behind, or otherwise deals persistent damage to your foes that sticks around long after you deliver your boosted attack. When you or your construct innovation damage a foe with offensive boost, that foe also takes 1d8 persistent damage of the same damage type as the offensive boost damage." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificClassFeature(Guid.Parse("0efe0853-edd9-46d5-bbe0-3a849637deab"), ClassFeatures.Gunslingers.OffensiveBoost.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("7ac45cb5-5f5d-423d-bc8d-d9e8fac85bed"),
                SourceId = Sources.Instances.GunsAndGears.ID,
                Page = -1
            };
        }
    }
}
