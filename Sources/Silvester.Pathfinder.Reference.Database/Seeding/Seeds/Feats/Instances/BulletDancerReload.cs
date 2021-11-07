using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class BulletDancerReload : Template
    {
        public static readonly Guid ID = Guid.Parse("cbde1c7b-a615-464f-b3d1-aef54bbb3972");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Bullet Dancer Reload",
                Level = 12,
                ActionTypeId = ActionTypes.Instances.OneAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("745e5756-f2e1-4571-b843-5319a609e48a"), Type = TextBlockType.Text, Text = "You’ve learned to reload your simple firearms with uncanny grace, the ammunition simply falling into place as though part of a well-practiced kata. You (action: Strike) with a simple firearm, and then (action: Interact) to reload that same firearm. You don’t need a free hand to reload your simple firearm in this way" };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("eaff1d1d-c353-41d3-84fc-eb1264999af1"), Feats.Instances.BulletDancerBurn.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("36361d22-c4f7-4074-9192-47dee50c1886"),
                SourceId = Sources.Instances.GunsAndGears.ID,
                Page = -1
            };
        }
    }
}
