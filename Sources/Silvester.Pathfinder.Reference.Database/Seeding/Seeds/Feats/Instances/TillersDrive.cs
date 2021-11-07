using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class TillersDrive : Template
    {
        public static readonly Guid ID = Guid.Parse("bb97f100-de44-4002-b6a0-7b03ccf5d700");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Tiller's Drive",
                Level = 10,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("4164ca2a-dedc-4cea-92de-ec9f06dd45fb"), Type = TextBlockType.Text, Text = "Your Speed bonus from (feat: Bellflower Tiller Dedication) increases to +10 feet. Members of your crop receive a +5-foot circumstance bonus to Speed." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("2e8138f7-51d5-488c-96c7-d18f611c68b7"), Feats.Instances.BellflowerTillerDedication.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("307da52e-48eb-4e22-8040-5b7015b50924"),
                SourceId = Sources.Instances.AgeOfAshes.ID,
                Page = -1
            };
        }
    }
}
