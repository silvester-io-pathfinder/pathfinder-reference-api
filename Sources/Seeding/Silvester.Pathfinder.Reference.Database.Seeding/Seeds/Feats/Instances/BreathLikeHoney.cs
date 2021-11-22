using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class BreathLikeHoney : Template
    {
        public static readonly Guid ID = Guid.Parse("2236c54e-45d0-46c7-8f47-366675fdf327");

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
            yield return new TextBlock { Id = Guid.Parse("5be61222-f7f5-4ff0-89f1-9417dbcbed69"), Type = TextBlockType.Text, Text = "You smell of honey and savory things. You can cast (spell: enthrall) as a 3rd-level occult innate spell once per day, except the spell has a range of 30 feet and the (trait: inhaled) trait instead of the (trait: auditory) trait. Targets don't gain any circumstance bonus for disagreeing with you. Your circumstance bonus to checks to (action: Make an Impression) if the target can smell your breath increases to +2." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificHeritage(Guid.Parse("4ccc2ed2-48a6-41d8-a02c-ebe81481103c"), Heritages.Instances.SweetbreathGnoll.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("b561a7c0-01e2-4530-8416-662287ee1681"),
                SourceId = Sources.Instances.LostOmensMwangiExpanse.ID,
                Page = -1
            };
        }
    }
}
