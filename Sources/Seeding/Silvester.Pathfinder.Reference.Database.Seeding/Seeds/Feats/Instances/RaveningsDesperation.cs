using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class RaveningsDesperation : Template
    {
        public static readonly Guid ID = Guid.Parse("1b70c74d-79c6-44ce-842f-12d635fdbb84");

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
            yield return new TextBlock { Id = Guid.Parse("cbf90b35-61d5-450c-b183-c66e028b9c46"), Type = TextBlockType.Text, Text = "Your study of the Beast of Gluttondark has taught you how to make do in the most trying of circumstances rather than succumb to weakness. As long as your current Hit Points are less than half your maximum Hit Points, you gain a +1 circumstance bonus to Survival and Stealth checks. If your current Hit Points are less than a quarter your maximum Hit Points, the circumstance bonus is +2 instead." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificLoreSpecificProficiency(Guid.Parse("15d08d7c-0faf-49d2-b1a8-9bbe55af02e7"), Proficiencies.Instances.Trained.ID, Lores.Instances.Zevgavizeb.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("d85272e2-8833-4c1a-8bf7-4baac2ab54c6"),
                SourceId = Sources.Instances.ExtinctionCurse.ID,
                Page = -1
            };
        }
    }
}
