using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class Converge : Template
    {
        public static readonly Guid ID = Guid.Parse("4051987e-b1ba-4c33-952c-db4d3000318a");

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
            yield return new TextBlock { Id = Guid.Parse("0b42bb34-8c44-4fe1-a9fc-1127d7bf383f"), Type = TextBlockType.Text, Text = "Informing your ally of an opening created by your shot, you coordinate to set them up to hit the target at the same time. Your ally can make a melee (action: Strike) against the triggering foe as a reaction. This (action: Strike) doesn’t count toward that ally’s multiple attack penalty, and their multiple attack penalty doesn’t apply to this (action: Strike). If your ally’s (action: Strike) is successful, combine the damage from your successful ranged attack with the damage from your ally’s melee attack for the purpose of determining resistances and weaknesses." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("13a75ab3-2610-402f-8c21-75aab789f3ab"), Feats.Instances.OverwatchDedication.ID);
            builder.HaveSpecificSkillProficiency(Guid.Parse("5d157438-16b4-474a-b2b7-a7bebcf59625"), Proficiencies.Instances.Master.ID, Skills.Instances.Perception.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("69d436d5-d003-43e7-b421-41f288c35c3d"),
                SourceId = Sources.Instances.GunsAndGears.ID,
                Page = -1
            };
        }
    }
}
