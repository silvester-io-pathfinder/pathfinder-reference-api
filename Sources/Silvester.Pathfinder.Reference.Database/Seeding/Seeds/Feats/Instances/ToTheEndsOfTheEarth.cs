using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class ToTheEndsOfTheEarth : Template
    {
        public static readonly Guid ID = Guid.Parse("c79ca526-36b7-4b51-a946-580d0ea9f83d");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "To the Ends of the Earth",
                Level = 20,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("cdb923cf-54fa-41fa-9346-1d9ac89538d3"), Type = TextBlockType.Text, Text = "Your ability to track your prey has surpassed explanation, allowing you to trace your prey’s movements and predict its location with ease. When you use (feat: Hunt Prey) on a creature within 100 feet, you can follow that creature’s movements, allowing you to know the creature’s exact location no matter how far away it becomes, as long as it remains your prey. You must be legendary in Nature to track your prey’s location across teleportation or planar travel. This feat gains the (trait: detection), (trait: divination), and (trait: primal) traits if you’re legendary in Nature." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificSkillProficiency(Guid.Parse("98be33f5-a377-471e-9892-5dd01da7f123"), Proficiencies.Instances.Legendary.ID, Skills.Instances.Survival.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("f3c156ff-e496-4cbd-85fb-af8c8510a8c0"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
