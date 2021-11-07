using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class MartialPerformance : Template
    {
        public static readonly Guid ID = Guid.Parse("c2a2949e-0d10-4ab0-bb40-7a775ba8d15d");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Martial Performance",
                Level = 1,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("dc83908b-8b61-4e59-8e63-5130a351fb6c"), Type = TextBlockType.Text, Text = "Your muse has taught you how to handle a wider variety of weapons than most bards, empowering you to effortlessly blend your performance into combat even with the most inelegant tools. You become trained with all martial weapons. If you gain the bard weapon expertise class feature, your proficiency rank with martial weapons increases to expert." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificMuse(Guid.Parse("5d68010d-cb2f-434d-9d7c-cafaf828c625"), Muses.Instances.Warrior.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("0ce00594-c628-4bf7-9e77-75ab78eb706b"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
