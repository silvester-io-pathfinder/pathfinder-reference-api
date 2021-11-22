using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class DisturbingKnowledge : Template
    {
        public static readonly Guid ID = Guid.Parse("2ebeb205-083b-4d4a-bbd5-59918869d79e");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Disturbing Knowledge",
                Level = 7,
                ActionTypeId = ActionTypes.Instances.TwoActions.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("1a61735b-5674-4030-8c0a-45e65ff05a5c"), Type = TextBlockType.Text, Text = "You utter a litany of dreadful names, prophecies, and descriptions of realms beyond mortal comprehension, drawn from your study of forbidden tomes and scrolls. Even those who don't understand your language are unsettled by these dire secrets. Attempt an Occultism check and compare the result to the Will DC of an enemy within 30 feet, or to the Will DCs of any number of enemies within 30 feet if you are legendary in Occultism. Those creatures are temporarily immune for 24 hours." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificSkillProficiency(Guid.Parse("1044ed39-6511-44d2-95cb-65e802056f08"), Proficiencies.Instances.Master.ID, Skills.Instances.Occultism.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }

        protected override RollableEffect? GetRollableEffect()
        {
            return new RollableEffect
            {
                Id = Guid.Parse("d867f5b3-6b3e-4856-8209-78b860b6f8d4"),
                CriticalSuccess = "The target becomes confused for 1 round and frightened 1.",
                Success = "The target becomes frightened 1.",
                Failure = "The target is unaffected.",
                CriticalFailure = "You get overly caught up in your own words and become frightened 1.", 
            };
        }
            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("0badad46-9088-4042-a74b-3922c6916bbd"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
