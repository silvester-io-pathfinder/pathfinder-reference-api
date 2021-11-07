using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class ImplausibleInfiltration : Template
    {
        public static readonly Guid ID = Guid.Parse("04738aaf-10b1-4c9c-9efd-1a341cac7fe2");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Implausible Infiltration",
                Level = 18,
                ActionTypeId = ActionTypes.Instances.TwoActions.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("81a47f79-b8fe-4a34-8531-d3e1d035a0e3"), Type = TextBlockType.Text, Text = "You find tiny holes or imperfections that no one else could see and try to somehow fit yourself through them, possibly moving directly through the wall or floor from one side to the other. Your movement attempt fails if the wall or floor is made of something other than wood, plaster, or stone; is thicker than 10 feet; or contains even a thin layer of metal. If you have a climb Speed, you can use this ability to attempt to move through a ceiling." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificSkillProficiency(Guid.Parse("bff10e43-44e6-4ded-8af7-83f8c6bf473b"), Proficiencies.Instances.Legendary.ID, Skills.Instances.Acrobatics.ID);
            builder.HaveSpecificFeat(Guid.Parse("9a8f4c4b-bf6a-42f3-b403-d800bc77614c"), Feats.Instances.QuickSqueeze.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("a07eba8c-e27f-481e-aba1-0c9fc1120c79"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
