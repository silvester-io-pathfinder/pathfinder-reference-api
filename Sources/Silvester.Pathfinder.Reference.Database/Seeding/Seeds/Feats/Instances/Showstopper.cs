using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class Showstopper : Template
    {
        public static readonly Guid ID = Guid.Parse("a18f935a-8511-4182-8e44-5ea3a80b65f5");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Showstopper",
                Level = 16,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("6139a054-043f-4f53-a86b-02b15ff9980e"), Type = TextBlockType.Text, Text = "Your twirling weapons create a grand distraction that’s difficult to look away from. When using (feat: Pistol Twirl) to (action: Feint), you can target all enemies within your weapon’s first range increment who you can perceive and who can see you. You roll one Deception check and compare it against each target’s Perception DC." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("9431b7bf-9b7e-497c-a2fe-7eb2d77e2aef"), Feats.Instances.PistolTwirl.ID);
            builder.HaveSpecificSkillProficiency(Guid.Parse("2f220fa4-3305-496d-b5dc-79824cfb044b"), Proficiencies.Instances.Master.ID, Skills.Instances.Deception.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("7b6fd118-b4a6-4548-a08e-aec2b1fb01d0"),
                SourceId = Sources.Instances.GunsAndGears.ID,
                Page = -1
            };
        }
    }
}
