using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class RaveningsDesperation : Template
    {
        public static readonly Guid ID = Guid.Parse("d7b00c5c-4cb4-4a16-a460-d51d7d5d7031");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Ravening's Desperation",
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
            yield return new TextBlock { Id = Guid.Parse("ff2bd977-38b3-4c41-a8e9-e5bb0e2e4a2f"), Type = TextBlockType.Text, Text = "Your study of the Beast of Gluttondark has taught you how to make do in the most trying of circumstances rather than succumb to weakness. As long as your current Hit Points are less than half your maximum Hit Points, you gain a +1 circumstance bonus to Survival and Stealth checks. If your current Hit Points are less than a quarter your maximum Hit Points, the circumstance bonus is +2 instead." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificLoreSpecificProficiency(Guid.Parse("f7e4b8b6-bd4e-4a4e-a8b5-6d796df5fa1f"), Proficiencies.Instances.Trained.ID, Lores.Instances.Zevgavizeb.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("ceb4c966-94c1-4c9b-931f-bf9794746885"),
                SourceId = Sources.Instances.ExtinctionCurse.ID,
                Page = -1
            };
        }
    }
}
