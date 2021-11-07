using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class GravesVoice : Template
    {
        public static readonly Guid ID = Guid.Parse("57e385cc-0665-41ce-9e11-f93b58506ef6");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Grave's Voice",
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
            yield return new TextBlock { Id = Guid.Parse("066cb053-34b8-4bf8-9739-0450bff14531"), Type = TextBlockType.Text, Text = "You can use your choice of Spirit Lore or Haunt Lore to (action: Make an Impression) or (action: Request) things of incorporeal creatures. At the GM&#39;s discretion, an incorporeal spirit might be willing to hear you out." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("0f992026-57be-4f32-a891-a7c4fc73ae1a"), Feats.Instances.GhostHunterDedication.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("89f369a5-45bf-4552-b9a4-1a66f40e7405"),
                SourceId = Sources.Instances.AbominationVaults.ID,
                Page = -1
            };
        }
    }
}
