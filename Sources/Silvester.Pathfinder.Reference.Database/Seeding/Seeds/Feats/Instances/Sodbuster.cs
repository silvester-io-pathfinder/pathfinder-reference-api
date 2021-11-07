using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class Sodbuster : Template
    {
        public static readonly Guid ID = Guid.Parse("37008a03-9276-4246-81e0-c1f23dd59390");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Sodbuster",
                Level = 9,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("9f833b07-f127-4f81-910b-74103d0578a5"), Type = TextBlockType.Text, Text = "Years toiling in soil have made you an expert digger. You gain a burrow Speed of 10 feet through loose soil or dirt." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("91251f87-3284-4d44-aecf-08126d1df592"), Feats.Instances.DigQuickly.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("be062717-1b6b-4c36-8dc2-507f8d2c698c"),
                SourceId = Sources.Instances.ExtinctionCurse.ID,
                Page = -1
            };
        }
    }
}
