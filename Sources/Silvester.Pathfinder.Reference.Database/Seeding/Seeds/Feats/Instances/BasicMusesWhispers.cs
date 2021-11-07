using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class BasicMusesWhispers : Template
    {
        public static readonly Guid ID = Guid.Parse("b5ad790c-3db6-4d3e-860e-dc9b65901358");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Basic Muse's Whispers",
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
            yield return new TextBlock { Id = Guid.Parse("a9b96d43-e18d-445c-91ed-54b43b9dac87"), Type = TextBlockType.Text, Text = "You gain a 1st- or 2nd-level bard feat." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("d8bd708b-65f8-48ea-a479-a605aed96d7b"), Feats.Instances.BardDedication.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("d4415070-4846-4257-be86-5f33adccb2a8"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
