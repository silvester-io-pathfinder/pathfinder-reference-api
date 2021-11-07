using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class BreathLikeHoney : Template
    {
        public static readonly Guid ID = Guid.Parse("90f2db9d-609f-4c77-9c9b-cb63e8d57e01");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Breath Like Honey",
                Level = 9,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("18958e54-afe3-4f54-85a9-d598e835a754"), Type = TextBlockType.Text, Text = "You smell of honey and savory things. You can cast (spell: enthrall) as a 3rd-level occult innate spell once per day, except the spell has a range of 30 feet and the (trait: inhaled) trait instead of the (trait: auditory) trait. Targets don’t gain any circumstance bonus for disagreeing with you. Your circumstance bonus to checks to (action: Make an Impression) if the target can smell your breath increases to +2." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificHeritage(Guid.Parse("25f5902c-f6d9-4a0b-9d31-d431842d8217"), Heritages.Instances.SweetbreathGnoll.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("9009f729-cef6-45f9-84fe-6f97245dd45a"),
                SourceId = Sources.Instances.LostOmensMwangiExpanse.ID,
                Page = -1
            };
        }
    }
}
