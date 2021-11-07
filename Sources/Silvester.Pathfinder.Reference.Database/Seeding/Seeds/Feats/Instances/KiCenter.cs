using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class KiCenter : Template
    {
        public static readonly Guid ID = Guid.Parse("724148c0-20af-4604-9373-88c19eb7ff97");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Ki Center",
                Level = 18,
                ActionTypeId = ActionTypes.Instances.FreeAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = "once per minute"
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("0780f97d-681d-4af0-9dc7-335f7788cad1"), Type = TextBlockType.Text, Text = "You center yourself with the universe and draw upon its vast power. You cast a single action ki spell with the stance trait, without spending a Focus Point." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveAnyKiSpells(Guid.Parse("55f73f72-767f-4719-a5a4-1e6734b99247"));
            builder.HaveSpecificFeat(Guid.Parse("5b81f915-1a5b-41a7-a888-e90a67559bf8"), Feats.Instances.MasterOfManyStyles.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("8e532389-706b-4165-a567-3fe5632ba46c"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
