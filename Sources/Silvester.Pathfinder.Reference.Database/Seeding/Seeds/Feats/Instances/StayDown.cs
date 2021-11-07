using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class StayDown : Template
    {
        public static readonly Guid ID = Guid.Parse("059bdb09-b81d-4303-82f6-548503504325");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Stay Down!",
                Level = 14,
                ActionTypeId = ActionTypes.Instances.Reaction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = "A prone foe within your reach Stands.",
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("822c49ce-1662-435a-8027-7860c40e7629"), Type = TextBlockType.Text, Text = "You have ways of keeping your foes down. Attempt an Athletics check against the triggering foe’s Fortitude DC. On a success, they don’t stand up and remain prone. On a critical success, they can’t (action: Stand | Stand / Drop Prone) until their next turn." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificSkillProficiency(Guid.Parse("b86e85ef-93a1-46f2-9abc-c4b6f142d36d"), Proficiencies.Instances.Master.ID, Skills.Instances.Athletics.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("ae064eaa-c1f4-4e26-86fc-8b422f7a881e"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
