using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class ScouringRage : Template
    {
        public static readonly Guid ID = Guid.Parse("44830daa-33b7-450d-b7cb-bedd4bc6f662");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Scouring Rage",
                Level = 6,
                ActionTypeId = ActionTypes.Instances.FreeAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = "You Rage.",
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("4477a429-5de5-4739-a414-95856604773a"), Type = TextBlockType.Text, Text = "You emit a powerful surge of instinctual energy when you unleash your potential. Each adjacent creature takes damage equal to your level (basic Fortitude save against your class DC) of the same type as your additional damage during that (action: Rage)." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            //TODO: Add prerequisites.
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("f27d5429-741d-454c-baa2-ef281e064efb"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
