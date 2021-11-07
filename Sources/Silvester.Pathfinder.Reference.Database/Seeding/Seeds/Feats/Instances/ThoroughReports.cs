using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class ThoroughReports : Template
    {
        public static readonly Guid ID = Guid.Parse("9667d38c-8ce7-4b9b-9b67-c32326c00c12");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Thorough Reports",
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
            yield return new TextBlock { Id = Guid.Parse("47ed91ca-7ea8-42d7-8ef3-8ba87580c9fe"), Type = TextBlockType.Text, Text = "Your reports are thorough and informative, and putting your thoughts to paper helps you retain the information. Keep track of each type of creature you successfully identify with (action: Recall Knowledge). When attempting (action: Recall Knowledge) checks against creatures on your list in later encounters, you gain a +2 circumstance bonus, and you learn an additional fact about such creatures on a success." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("04d594d0-e374-46ba-9ea1-b1d56f2839a2"), Feats.Instances.PathfinderAgentDedication.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("70bbcdf7-fabe-4aa7-af44-ada2b0bae2aa"),
                SourceId = Sources.Instances.LostOmensCharacterGuide.ID,
                Page = -1
            };
        }
    }
}
