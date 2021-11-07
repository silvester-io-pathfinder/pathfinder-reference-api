using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class LengthyDiversion : Template
    {
        public static readonly Guid ID = Guid.Parse("14bbfa79-13a0-464f-8850-d568ee5f1a96");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Lengthy Diversion",
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
            yield return new TextBlock { Id = Guid.Parse("201cdfb7-6e74-47f8-9fea-e2a2b3dd26fe"), Type = TextBlockType.Text, Text = "When you critically succeed to (action: Create a Diversion), you continue to remain hidden after the end of your turn. This effect lasts for an amount of time that depends on the diversion and situation, as determined by the GM (minimum 1 additional round)." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificSkillProficiency(Guid.Parse("7b231cac-21f4-4002-be06-8c81c4950819"), Proficiencies.Instances.Trained.ID, Skills.Instances.Crafting.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("fc513349-fbde-45af-ae0e-8f4df914636d"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
