using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class Converge : Template
    {
        public static readonly Guid ID = Guid.Parse("67828a5f-85a4-4b5d-8ae9-98a0edf68720");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Converge",
                Level = 16,
                ActionTypeId = ActionTypes.Instances.Reaction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = "You make a successful ranged attack against an opponent who is within your overwatch field, and who is within reach of one or more of your allies who is also within your overwatch field.",
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("4f99c2d6-6cd2-4e9c-940d-0ba413e375c8"), Type = TextBlockType.Text, Text = "Informing your ally of an opening created by your shot, you coordinate to set them up to hit the target at the same time. Your ally can make a melee (action: Strike) against the triggering foe as a reaction. This (action: Strike) doesn’t count toward that ally’s multiple attack penalty, and their multiple attack penalty doesn’t apply to this (action: Strike). If your ally’s (action: Strike) is successful, combine the damage from your successful ranged attack with the damage from your ally’s melee attack for the purpose of determining resistances and weaknesses." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("ca723137-e1cc-4760-8915-7ce6976f9f32"), Feats.Instances.OverwatchDedication.ID);
            builder.HaveSpecificSkillProficiency(Guid.Parse("38d082fa-4995-4a1b-ae5c-ee2ee411cddc"), Proficiencies.Instances.Master.ID, Skills.Instances.Percepton.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("74ddace7-153a-4952-a66b-efd8d90eb644"),
                SourceId = Sources.Instances.GunsAndGears.ID,
                Page = -1
            };
        }
    }
}
