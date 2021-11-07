using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class AbleRitualist : Template
    {
        public static readonly Guid ID = Guid.Parse("c53cf88e-79e6-478b-8d02-4b97b104d428");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Able Ritualist",
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
            yield return new TextBlock { Id = Guid.Parse("8e6ffd06-1d8a-4173-b144-a172859549a5"), Type = TextBlockType.Text, Text = "Your readings on rituals make you a skilled participant. You gain a +2 circumstance bonus to primary and secondary checks you attempt as part of casting a ritual." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("ed867132-cc05-4eca-94df-cc51cece207f"), Feats.Instances.EldritchResearcherDedication.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("eefa11e3-3ec6-4117-b670-705fb015ee49"),
                SourceId = Sources.Instances.AbominationVaults.ID,
                Page = -1
            };
        }
    }
}
