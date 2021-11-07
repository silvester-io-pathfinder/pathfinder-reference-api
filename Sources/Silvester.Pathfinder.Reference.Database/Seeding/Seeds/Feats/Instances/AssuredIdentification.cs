using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class AssuredIdentification : Template
    {
        public static readonly Guid ID = Guid.Parse("8e4cec24-a5bb-4e80-9866-c4c8c36d8949");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Assured Identification",
                Level = 2,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("ba7cf9f0-3386-4843-a186-7f64dcdb453b"), Type = TextBlockType.Text, Text = "You rarely misidentify an item. When using Arcana, Nature, Occultism, or Religion checks to (action: Identify Magic), if you roll a critical failure, you get a failure instead. If you would misidentify a (trait: cursed) item because you roll a success but not a critical success, you simply can’t identify it instead." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.AddOr(Guid.Parse("3f593bd5-2d06-4cd4-bdd4-5668901b5e84"), or => 
            {
                or.HaveSpecificSkillProficiency(Guid.Parse("fb84b79f-2dfe-4381-8582-cf18867355d5"), Proficiencies.Instances.Expert.ID, Skills.Instances.Arcana.ID);
                or.HaveSpecificSkillProficiency(Guid.Parse("005215a0-db01-48db-bf6f-92aac2b3d3c0"), Proficiencies.Instances.Expert.ID, Skills.Instances.Nature.ID);
                or.HaveSpecificSkillProficiency(Guid.Parse("5f1c6af9-c293-41ab-992e-4dda3d1e51e2"), Proficiencies.Instances.Expert.ID, Skills.Instances.Occultism.ID);
                or.HaveSpecificSkillProficiency(Guid.Parse("af1e954e-671d-4dcf-abdb-a3ea7052acce"), Proficiencies.Instances.Expert.ID, Skills.Instances.Religion.ID);
            });
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("1122562d-f7e3-4c16-9678-341cdb7d581c"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
