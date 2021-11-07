using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class Sodbuster : Template
    {
        public static readonly Guid ID = Guid.Parse("995ce3ee-3d1e-49f6-a28b-603f9dec8932");

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
            yield return new TextBlock { Id = Guid.Parse("205af745-487f-493a-a251-3609be38b174"), Type = TextBlockType.Text, Text = "Years toiling in soil have made you an expert digger. You gain a burrow Speed of 10 feet through loose soil or dirt." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("8fc933a5-ee35-4ec5-b579-c5653191c9fd"), Feats.Instances.DigQuickly.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("0c22b23f-fa13-47a8-9f0a-a644bc09c754"),
                SourceId = Sources.Instances.ExtinctionCurse.ID,
                Page = -1
            };
        }
    }
}
