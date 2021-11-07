using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class StormyHeart : Template
    {
        public static readonly Guid ID = Guid.Parse("79e6ee60-0f5c-4cea-95ee-a7d74ca1e20d");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Stormy Heart",
                Level = 17,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("7d74e53d-ba61-4ce2-9e7e-9f33333c64bf"), Type = TextBlockType.Text, Text = "The elemental power in your blood is a raging storm. You can (feat: Invoke the Elements) with a frequency of once per 10 minutes, rather than once per day." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("8c9ac69a-cbbd-43c4-8035-57da8a39350d"), Feats.Instances.InvokeTheElements.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("e250d880-4200-4afa-98d2-71d823e10e7a"),
                SourceId = Sources.Instances.LostOmensAncestryGuide.ID,
                Page = -1
            };
        }
    }
}
