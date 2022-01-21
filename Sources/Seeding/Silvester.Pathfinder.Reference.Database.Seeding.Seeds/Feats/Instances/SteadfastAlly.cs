using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class SteadfastAlly : Template
    {
        public static readonly Guid ID = Guid.Parse("8e637830-d6d1-4e25-a94d-a55fe7139958");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Steadfast Ally",
                Level = 13,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("2ef98ebf-93ce-43fb-9797-25ac118f9dff"), Type = TextBlockType.Text, Text = "Your presence alone is enough to provide your allies with emotional support. You can use the (Action: Aid) reaction to grant a bonus to another creature's Will saving throw even when you haven't prepared to help." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("6720962d-0d85-4491-8a3b-5cdcbf72cef7"), Feats.Instances.LoyalEmpath.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("f1f909e4-f068-41ac-921d-8097fa671d95"),
                SourceId = Sources.Instances.ExtinctionCurse.ID,
                Page = -1
            };
        }
    }
}
