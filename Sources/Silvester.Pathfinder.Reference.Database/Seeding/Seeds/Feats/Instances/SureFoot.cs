using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class SureFoot : Template
    {
        public static readonly Guid ID = Guid.Parse("48eb5ee3-cd9c-4735-9478-b1a252f3cee7");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Sure Foot",
                Level = 4,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("bf7bdd0e-baba-4235-ad8a-baded9c87840"), Type = TextBlockType.Text, Text = "You know the secrets of moving in your favored terrain. You gain a +2 circumstance bonus to skill checks to move within your favored terrain, such as Acrobatics checks to (action: Balance) on ice, Athletics checks to (action: Swim) in rough water, Acrobatics checks to (action: Fly) in windy conditions, and so forth." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("fc3a73c7-7055-4bf1-a6dc-6ad65387691f"), Feats.Instances.HorizonWalkerDedication.ID);
            builder.HaveSpecificSkillProficiency(Guid.Parse("44005f9c-8dd9-4eea-85bd-109afd75fd24"), Proficiencies.Instances.Expert.ID, Skills.Instances.Acrobatics.ID);
            builder.HaveSpecificSkillProficiency(Guid.Parse("032e6b3d-5e15-4caa-a4c9-574c0adab398"), Proficiencies.Instances.Expert.ID, Skills.Instances.Athletics.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("547fad32-7c0e-429d-8e37-57194422af31"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
