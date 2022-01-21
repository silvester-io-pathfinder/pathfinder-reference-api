using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class MightyDragonShape : Template
    {
        public static readonly Guid ID = Guid.Parse("052d913a-b940-4005-91fc-6a727fd3c580");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Mighty Dragon Shape",
                Level = 18,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("51cd2d82-83d1-454c-836e-e21144f094ae"), Type = TextBlockType.Text, Text = "You've practiced and increased your draconic might, allowing you to take your draconic form more often. You can use (feat: Shape of the Dragon) once per hour instead of once per day." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("1d00c1e3-98f9-483a-b8b1-266f6087c6a3"), Feats.Instances.ShapeOfTheDragon.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("6c4f2bb3-beca-4be9-8bb9-5bdfdd4752e7"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
