using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class TenseNegotiator : Template
    {
        public static readonly Guid ID = Guid.Parse("c159bcd0-38ad-4322-a32a-de90db4b5550");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Tense Negotiator",
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
            yield return new TextBlock { Id = Guid.Parse("792f8e6b-e200-4965-a86b-2ab4ac87c827"), Type = TextBlockType.Text, Text = "You often find that the best way to win a conflict means avoiding a fight in the first place. You&#39;re good at talking to potential opponents without making things worse. If you would critically fail at a check to (action: Make an Impression), you instead fail. You can attempt checks to make (action: Requests | Request) of creatures who&#39;re indifferent or unfriendly toward you." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("0be8251b-88d5-4329-b57f-7b6a741b185f"), Feats.Instances.SwordmasterDedication.ID);
            builder.HaveSpecificSkillProficiency(Guid.Parse("8c6b9b2f-b190-42f4-8eef-ff3367d852c3"), Proficiencies.Instances.Master.ID, Skills.Instances.Diplomacy.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("c8942f73-35e5-47e2-9d91-d5d82759d2f8"),
                SourceId = Sources.Instances.LostOmensSocietyGuide.ID,
                Page = -1
            };
        }
    }
}
