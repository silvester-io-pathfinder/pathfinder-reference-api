using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class InspireCompetence : Template
    {
        public static readonly Guid ID = Guid.Parse("c169a29a-1e5b-4022-ab63-624c62a04ee3");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Inspire Competence",
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
            yield return new TextBlock { Id = Guid.Parse("1c7d7394-b603-4225-a151-a34a54be4b11"), Type = TextBlockType.Text, Text = "You learn the (spell: inspire competence) composition cantrip, which aids your allies’ skills." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificMuse(Guid.Parse("224c81fa-1ecb-46e9-99ff-037ca8dbd2a7"), Muses.Instances.Maestro.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("2fedc4fc-c974-4992-957e-d37f9541740d"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
