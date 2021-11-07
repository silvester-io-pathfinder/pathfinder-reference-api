using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class PlanarSurvival : Template
    {
        public static readonly Guid ID = Guid.Parse("085f32e5-8bf6-4449-b625-26c3b1bac7d6");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Planar Survival",
                Level = 7,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("25b16ff4-7c22-46e8-b499-3f26af45d467"), Type = TextBlockType.Text, Text = "You can (Action: Subsist) using Survival on different planes, even those without resources or natural phenomena you normally need. For instance, you can forage for food even if the plane lacks food that could normally sustain you. A success on your check to (Action: Subsist) can also reduce the damage dealt by the plane, at the GM’s discretion." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificSkillProficiency(Guid.Parse("8dd6b719-03e2-4a5c-b935-dbbda07fb055"), Proficiencies.Instances.Master.ID, Skills.Instances.Survival.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("38dc8b50-aea7-485a-87b0-00fefb82ddaa"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
