using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class BulletDancerReload : Template
    {
        public static readonly Guid ID = Guid.Parse("40ce74e9-51c9-4791-a9eb-7860854d2d03");

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
            yield return new TextBlock { Id = Guid.Parse("8296977f-45ec-4a8c-b729-a66d0646730c"), Type = TextBlockType.Text, Text = "You've learned to reload your simple firearms with uncanny grace, the ammunition simply falling into place as though part of a well-practiced kata. You (action: Strike) with a simple firearm, and then (action: Interact) to reload that same firearm. You don't need a free hand to reload your simple firearm in this way" };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("40cd2311-b181-4189-b2c4-9e99d7660898"), Feats.Instances.BulletDancerBurn.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("07702192-b2d2-4742-993b-c05f0db77a6c"),
                SourceId = Sources.Instances.GunsAndGears.ID,
                Page = -1
            };
        }
    }
}
