using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class PushIt : Template
    {
        public static readonly Guid ID = Guid.Parse("886979d3-748b-4562-a7d4-6ce6569da077");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Push It",
                Level = 7,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("71822b88-510b-4a18-9249-caca9b5617af"), Type = TextBlockType.Text, Text = "You can push your vehicle’s performance beyond the limits envisioned by its makers. Whenever you succeed at a piloting check, the vehicle you are piloting gains a +5-foot circumstance bonus to all its Speeds until the end of your turn. If you critically succeed, this bonus increases to +10 feet." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("d69dbe80-9cdf-4e7d-87b7-319b19d65502"), Feats.Instances.TrickDriverDedication.ID);
            builder.HaveSpecificLoreSpecificProficiency(Guid.Parse("d4bff390-a6f2-47c4-bffe-f4345e0b2c7b"), Proficiencies.Instances.Master.ID, Lores.Instances.Driving.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("99de2d81-8011-42dd-97d8-dd11ea62bd22"),
                SourceId = Sources.Instances.GunsAndGears.ID,
                Page = -1
            };
        }
    }
}
