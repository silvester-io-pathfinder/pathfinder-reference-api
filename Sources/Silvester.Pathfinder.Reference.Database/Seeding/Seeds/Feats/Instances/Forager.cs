using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class Forager : Template
    {
        public static readonly Guid ID = Guid.Parse("404be47c-123c-4e7e-af79-72a68ac16b78");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Forager",
                Level = 1,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("07d8d3d3-98bb-43d1-b7ed-fb7623d5df9b"), Type = TextBlockType.Text, Text = "While using Survival to (Action: Subsist), if you roll any result worse than a success, you get a success. On a success, you can provide subsistence living for yourself and four additional creatures, and on a critical success, you can take care of twice as many creatures as on a success." };
            yield return new TextBlock { Id = Guid.Parse("e538eceb-3038-4b7a-8c77-5fa931f3adef"), Type = TextBlockType.Text, Text = "Each time your proficiency rank in Survival increases, double the number of additional creatures you can take care of on a success (to eight if you’re an expert, 16 if you’re a master, or 32 if you’re legendary). You can choose to care for half the number of additional creatures and provide a comfortable living instead of subsistence living." };
            yield return new TextBlock { Id = Guid.Parse("7b987d5c-5682-4dab-b890-abc66254c8bc"), Type = TextBlockType.Text, Text = "Multiple smaller creatures or creatures with significantly smaller appetites than a human are counted as a single creature for this feat, and larger creatures or those with significantly greater appetites each count as multiple creatures. The GM determines how much a non-human creature needs to eat." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificSkillProficiency(Guid.Parse("136caf73-5496-44bd-9845-95ab375a77b5"), Proficiencies.Instances.Trained.ID, Skills.Instances.Survival.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("f380a924-6e03-48de-80da-6a143d5fb1a6"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
