using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class Camouflage : Template
    {
        public static readonly Guid ID = Guid.Parse("6c2efc20-449b-434b-9dbb-967410765005");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Camouflage",
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
            yield return new TextBlock { Id = Guid.Parse("430ff55a-4f88-49d4-9fb3-e842d3c988e2"), Type = TextBlockType.Text, Text = "You alter your appearance to blend in to the wilderness. In natural terrain, you can (action: Sneak) even if you’re observed." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificSkillProficiency(Guid.Parse("0ce9e237-7f2e-4dde-b120-7a8315c8820a"), Proficiencies.Instances.Master.ID, Skills.Instances.Stealth.ID);
            builder.HaveSpecificFeat(Guid.Parse("44e9463a-fe61-41b1-8b54-164de1c3c4ff"), Feats.Instances.ScoutDedication.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("a1f5f21d-ce22-44f0-8b2b-b360a837e141"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
