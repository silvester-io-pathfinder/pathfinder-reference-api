using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class Acclimatization : Template
    {
        public static readonly Guid ID = Guid.Parse("457e802a-ed54-45ba-9cc6-18ed9f388b68");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Acclimatization",
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
            yield return new TextBlock { Id = Guid.Parse("41247174-5281-4991-a59e-64666d123406"), Type = TextBlockType.Text, Text = "Your time spent in the hostile parts of the world has inured you to extreme climates. In your favored terrain, you gain resistance equal to half your level to all environmental damage and are affected by temperature effects as though they were one step less severe (incredible heat or cold becomes extreme, extreme heat or cold becomes severe, and so on). When other creatures (action: Follow the Expert) with you as a guide in your favored terrain, they too treat temperature effects as one step less severe." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("0b992fd1-772b-497f-bf6a-156cc9e04f0d"), Feats.Instances.HorizonWalkerDedication.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("9c64eb2e-e645-47e7-a4b2-23690c035240"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
