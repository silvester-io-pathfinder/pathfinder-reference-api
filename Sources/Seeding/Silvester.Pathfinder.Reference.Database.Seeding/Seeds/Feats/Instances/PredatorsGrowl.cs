using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class PredatorsGrowl : Template
    {
        public static readonly Guid ID = Guid.Parse("6fe10bcf-bed9-4fa4-b291-d84f8f1b5eaf");

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
            yield return new TextBlock { Id = Guid.Parse("54d10e5d-a6bf-481f-a8d1-d0ff17edbfb1"), Type = TextBlockType.Text, Text = "You give a throaty growl to attempt to (action: Demoralize) a creature you just found. You don’t take the –4 penalty for not sharing a language with the creature." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificSkillProficiency(Guid.Parse("55001444-b929-495c-9ecd-9d3dce6f00d6"), Proficiencies.Instances.Expert.ID, Skills.Instances.Intimidation.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("6d2848c7-e63c-4fb9-a19e-7708a6623371"),
                SourceId = Sources.Instances.LostOmensAncestryGuide.ID,
                Page = -1
            };
        }
    }
}
