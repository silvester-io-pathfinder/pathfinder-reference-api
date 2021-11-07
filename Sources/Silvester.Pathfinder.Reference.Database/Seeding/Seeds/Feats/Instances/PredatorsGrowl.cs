using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class PredatorsGrowl : Template
    {
        public static readonly Guid ID = Guid.Parse("255ea665-c39c-470e-8411-a81e76295350");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Predator's Growl",
                Level = 9,
                ActionTypeId = ActionTypes.Instances.Reaction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = "You successfully Seek a hidden or undetected creature.",
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("55d453b0-14de-48d2-8c64-1aa9cdc75c41"), Type = TextBlockType.Text, Text = "You give a throaty growl to attempt to (action: Demoralize) a creature you just found. You don’t take the –4 penalty for not sharing a language with the creature." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificSkillProficiency(Guid.Parse("9b1955bf-646a-41e5-abc0-902267de915e"), Proficiencies.Instances.Expert.ID, Skills.Instances.Intimidation.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("dbbdc805-c4bc-4eeb-881b-98f9c1e670d3"),
                SourceId = Sources.Instances.LostOmensAncestryGuide.ID,
                Page = -1
            };
        }
    }
}
