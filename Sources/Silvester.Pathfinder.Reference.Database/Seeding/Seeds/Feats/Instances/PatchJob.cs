using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class PatchJob : Template
    {
        public static readonly Guid ID = Guid.Parse("924313c6-6897-46b1-9845-03655c173ee3");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Patch Job",
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
            yield return new TextBlock { Id = Guid.Parse("8744011b-2188-4cf0-bbea-1dc64773360e"), Type = TextBlockType.Text, Text = "You can patch up damage to an object with a quick fix. You gain the (feat: Improvised Repair) general feat. When you use (feat: Improvised Repair), you can attempt a Crafting check with the same DC as (action: Repair). If you succeed, you can use the object as a normal object of its type until it takes damage rather than as a shoddy object of its type." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("c94a66fd-bf41-46b3-9e74-f684498e08a3"), Feats.Instances.VehicleMechanicDedication.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("8534eaff-775d-49c3-afa8-b8e4d94e2887"),
                SourceId = Sources.Instances.GunsAndGears.ID,
                Page = -1
            };
        }
    }
}
