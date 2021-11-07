using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class DisturbingKnowledge : Template
    {
        public static readonly Guid ID = Guid.Parse("f45b07be-e471-4c79-8edd-d7e104370d2a");

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
            yield return new TextBlock { Id = Guid.Parse("d001022e-5fdf-47f8-9e70-8d5b0df1da6f"), Type = TextBlockType.Text, Text = "You utter a litany of dreadful names, prophecies, and descriptions of realms beyond mortal comprehension, drawn from your study of forbidden tomes and scrolls. Even those who don’t understand your language are unsettled by these dire secrets. Attempt an Occultism check and compare the result to the Will DC of an enemy within 30 feet, or to the Will DCs of any number of enemies within 30 feet if you are legendary in Occultism. Those creatures are temporarily immune for 24 hours." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificSkillProficiency(Guid.Parse("7c3cabdd-300f-464b-8315-f516c6322531"), Proficiencies.Instances.Master.ID, Skills.Instances.Occultism.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }

        protected override RollableEffect? GetRollableEffect()
        {
            return new RollableEffect
            {
                Id = Guid.Parse("ec8232bb-b167-46df-86f0-a7e363db4c9e"),
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
                Id = Guid.Parse("30e1e4be-6a73-41a2-8946-8f775ec79c59"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
