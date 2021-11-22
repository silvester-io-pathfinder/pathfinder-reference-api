using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class DreadMarshalStance : Template
    {
        public static readonly Guid ID = Guid.Parse("859f8c85-4679-4c5b-bee7-d04733aa71dc");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Dread Marshal Stance",
                Level = 4,
                ActionTypeId = ActionTypes.Instances.OneAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("48970121-4467-4b2e-97c4-c7e4a656d528"), Type = TextBlockType.Text, Text = "Putting on a grim face for the battle ahead, you encourage your allies to strike fear into their foes with vicious attacks. When you use this action, attempt an Intimidation check. The DC is usually a standard-difficulty DC of your level, but the GM can assign a different DC based on the circumstances. The effect depends on the result of your check." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("447f249e-d55c-4d9a-aa93-ddfbf4213548"), Feats.Instances.MarshalDedication.ID);
            builder.HaveSpecificSkillProficiency(Guid.Parse("a8c1c6d5-9945-4e79-bcd7-b472c41186d2"), Proficiencies.Instances.Trained.ID, Skills.Instances.Intimidation.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }

        protected override RollableEffect? GetRollableEffect()
        {
            return new RollableEffect
            {
                Id = Guid.Parse("a2108d94-3974-4cf4-9767-e3c60c171a57"),
                CriticalSuccess = "Your marshal's aura increases to a 20-foot emanation, and it grants you and allies a status bonus to damage rolls equal to the number of weapon damage dice of the unarmed attack or weapon you are wielding that has the most weapon damage dice. When you or an ally in the aura critically hits an enemy with a (action: Strike), that enemy is frightened 1.",
                Success = "As critical success, but your aura's size doesn't increase.",
                Failure = "You fail to enter the stance.",
                CriticalFailure = "You fail to enter the stance and can't take this action again for 1 minute.", 
            };
        }
            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("06944de8-dbf6-4d3f-b383-9e4da3435674"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
