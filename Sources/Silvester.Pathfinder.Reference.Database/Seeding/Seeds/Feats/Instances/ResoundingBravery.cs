using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class ResoundingBravery : Template
    {
        public static readonly Guid ID = Guid.Parse("01bbda50-3490-4884-a489-565c9c70b6a5");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Resounding Bravery",
                Level = 8,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("83755dc4-9339-44e2-b04d-fd977a5304a3"), Type = TextBlockType.Text, Text = "Even your fears serve as fuel for your fighting spirit. When you critically succeed at a Will save against a foe’s ability, you gain a +1 status bonus to saves and a number of temporary Hit Points equal to half your level for 1 minute. These benefits are doubled if you critically succeed against a (trait: fear) effect." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificClassFeature(Guid.Parse("9e5ad7cd-1443-4660-a08d-7af0e74bc39a"), ClassFeatures.Fighters.Bravery.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("ee019631-7361-4dbc-bb7c-85831ad8e064"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
