using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class JuggernautsFortitude : Template
    {
        public static readonly Guid ID = Guid.Parse("919696cb-b689-4bad-9b04-0cfd0dcd1694");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Juggernaut's Fortitude",
                Level = 12,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("6bdfd342-cc1a-4457-91e3-0729229c5209"), Type = TextBlockType.Text, Text = "Your proficiency rank in Fortitude saves increases to master." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("6fd86c67-00a5-443f-b2a1-291a6a95fbac"), Feats.Instances.BarbarianDedication.ID);
            builder.HaveSpecificSavingThrowSpecificProficiency(Guid.Parse("ab193c7f-8361-4a08-84ce-5ebfe2a8b025"), Proficiencies.Instances.Expert.ID, SavingThrowStats.Instances.Fortitude.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("5a187a3e-e56a-40d0-a97d-a75bfe6c21f4"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
