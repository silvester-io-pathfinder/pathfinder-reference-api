using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class DiscreetInquiry : Template
    {
        public static readonly Guid ID = Guid.Parse("78358b9b-2b4e-4503-b5ef-abf8f8ba6d81");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Discreet Inquiry",
                Level = 2,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("5137b4df-87b4-479a-8e61-ccccdb8c40b1"), Type = TextBlockType.Text, Text = "You are subtle in your efforts to learn the things you need to know. When (action: Gathering Information | Gather Information), you can hide the true subject of your inquiry among other topics of little interest to you without increasing the difficulty of the check or taking more time to (action: Gather Information). Anyone trying to (action: Gather Information) to determine if someone else was asking around about the topic in question must exceed your Deception DC or the normal DC to (action: Gather Information) about your inquiries, whichever is higher, or else they don’t learn of your efforts." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.AddOr(Guid.Parse("26d73db4-d5f9-4c1e-a3a9-2df8df1e71d1"), or => 
            {
                or.HaveSpecificSkillProficiency(Guid.Parse("48f65fb6-d6cc-4db8-9ff0-185474ab175b"), Proficiencies.Instances.Expert.ID, Skills.Instances.Deception.ID);
                or.HaveSpecificSkillProficiency(Guid.Parse("f4208753-a495-4d5e-aa34-f1c90ca451cb"), Proficiencies.Instances.Expert.ID, Skills.Instances.Diplomacy.ID);
            });
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("7f42394b-f994-4885-91d3-f51fdacba6b8"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
