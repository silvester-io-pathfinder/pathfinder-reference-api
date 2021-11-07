using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class TrespassTeleportation : Template
    {
        public static readonly Guid ID = Guid.Parse("11ae56e3-458e-454b-a664-22c097d3544f");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Trespass Teleportation",
                Level = 16,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = "The subject of your Esoteric Antithesis uses a teleportation effect and is within 120 feet.",
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("13535373-a985-4cef-b6bc-d5b81675cc10"), Type = TextBlockType.Text, Text = "Your mystical connection to your foe is so strong that you can follow them to the ends of this world, or any other. You teleport along with the foe, appearing the same direction and distance from it as you were before it teleported away (or the nearest unoccupied space if your destination is occupied)." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("cac1e53d-bb41-4025-83ac-42e3817cd003"), Feats.Instances.EsotericAntithesis.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("e522862a-67e8-4d4f-b75b-4e590f22dcca"),
                SourceId = Sources.Instances.DarkArchive.ID,
                Page = -1
            };
        }
    }
}
