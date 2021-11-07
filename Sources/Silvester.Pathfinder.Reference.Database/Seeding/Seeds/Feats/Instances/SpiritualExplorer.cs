using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class SpiritualExplorer : Template
    {
        public static readonly Guid ID = Guid.Parse("ff2c93c4-6254-4835-aaff-e1a26f3f9e40");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Spiritual Explorer",
                Level = 4,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("1aabd930-d7e6-49f4-8d27-8887c6c6ceac"), Type = TextBlockType.Text, Text = "You&#39;re familiar with the danger that lingering spirits can pose to an unwary adventurer, and you&#39;re particularly attuned to their presence. Even if you aren&#39;t (action: Searching | Search) in exploration mode, you can attempt a check to find haunts that normally require you to (action: Search) for them. You still need to meet any other requirements to find a particular haunt." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("66cd8ee8-68aa-4a41-a066-5f7e5a4ade40"), Feats.Instances.PathfinderAgentDedication.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("c938b32d-c252-4022-af7f-3675883c1d00"),
                SourceId = Sources.Instances.LostOmensSocietyGuide.ID,
                Page = -1
            };
        }
    }
}
