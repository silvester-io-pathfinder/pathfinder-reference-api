using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class WideOverwatch : Template
    {
        public static readonly Guid ID = Guid.Parse("397bfea0-03a4-45c1-907a-fbcebaa8bd6e");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Wide Overwatch",
                Level = 10,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("1c69a874-f657-4f1e-a1df-ae2c3373107c"), Type = TextBlockType.Text, Text = "Through a variety of perceptive techniques, careful routines, and upgrades to your enhanced visual gear, you have become able to observe and maintain your overwatch at a much greater distance. Increase the size of your overwatch field from 30 feet to 60 feet." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("0186b70d-67aa-4492-aab9-550d54d97e91"), Feats.Instances.OverwatchDedication.ID);
            builder.HaveSpecificSkillProficiency(Guid.Parse("cbdb3c6b-f5c3-4aac-89c3-804518187630"), Proficiencies.Instances.Master.ID, Skills.Instances.Perception.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("314d506e-f976-4c33-85b5-ba918eae6268"),
                SourceId = Sources.Instances.GunsAndGears.ID,
                Page = -1
            };
        }
    }
}
