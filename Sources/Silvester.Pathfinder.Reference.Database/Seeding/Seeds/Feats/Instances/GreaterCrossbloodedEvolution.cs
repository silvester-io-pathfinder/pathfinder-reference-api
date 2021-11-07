using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class GreaterCrossbloodedEvolution : Template
    {
        public static readonly Guid ID = Guid.Parse("56404274-a770-46b7-b5a0-51b33aa5bd88");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Greater Crossblooded Evolution",
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
            yield return new TextBlock { Id = Guid.Parse("c8f06ef6-bd37-4f2e-866f-e3052c42af96"), Type = TextBlockType.Text, Text = "Your bloodline is extraordinarily complex. You can have up to three spells from other traditions in your spell repertoire, rather than just one. These spells must each be of a different spell level, but they don’t need to be from the same tradition." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("2dd12343-e343-4010-8fb9-523da7073809"), Feats.Instances.CrossbloodedEvolution.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("36d56a1d-0bbf-44ba-adcf-5c7f66c5bd7a"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
