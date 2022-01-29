using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class WanderingOasis : Template
    {
        public static readonly Guid ID = Guid.Parse("5b6aa1e7-f7eb-4807-99b3-5c3757b42e63");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Wandering Oasis",
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
            yield return new TextBlock { Id = Guid.Parse("56a78ab4-98e2-45ed-8e07-a8e10f90e524"), Type = TextBlockType.Text, Text = $"You're surrounded by soothing energy. You and allies within 60 feet of you are protected from severe environmental heat and cold. If you're legendary in Survival, you and those allies are also protected from extreme environmental heat and cold." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificSkillProficiency(Guid.Parse("cc9a3b61-1178-46dc-8ea6-28b441f94b7d"), Proficiencies.Instances.Master.ID, Skills.Instances.Survival.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("79604275-338a-4bac-864e-d3fbf6769d2c"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
