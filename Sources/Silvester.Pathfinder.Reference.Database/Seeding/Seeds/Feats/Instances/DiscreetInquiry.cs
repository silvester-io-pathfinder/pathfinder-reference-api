using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class DiscreetInquiry : Template
    {
        public static readonly Guid ID = Guid.Parse("31321d9e-58d4-4392-8b52-03439a5d0eb7");

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
            yield return new TextBlock { Id = Guid.Parse("b3057131-bfbc-455e-8275-d6272a845dc5"), Type = TextBlockType.Text, Text = "You are subtle in your efforts to learn the things you need to know. When (action: Gathering Information | Gather Information), you can hide the true subject of your inquiry among other topics of little interest to you without increasing the difficulty of the check or taking more time to (action: Gather Information). Anyone trying to (action: Gather Information) to determine if someone else was asking around about the topic in question must exceed your Deception DC or the normal DC to (action: Gather Information) about your inquiries, whichever is higher, or else they don’t learn of your efforts." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.AddOr(Guid.Parse("dff6ccbb-0146-4ee7-b416-f76c394d6195"), or => 
            {
                or.HaveSpecificSkillProficiency(Guid.Parse("600d9f1e-14f6-4b61-8be1-b6b35f09edb3"), Proficiencies.Instances.Expert.ID, Skills.Instances.Deception.ID);
                or.HaveSpecificSkillProficiency(Guid.Parse("ce6476d7-8b61-4c6d-99c9-d11850552799"), Proficiencies.Instances.Expert.ID, Skills.Instances.Diplomacy.ID);
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
                Id = Guid.Parse("ddc39a60-b35b-4335-ab68-d9287e30b46f"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
