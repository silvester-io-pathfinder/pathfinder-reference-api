using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class EnvenomFangs : Template
    {
        public static readonly Guid ID = Guid.Parse("f9a0a47d-e4b5-4cf5-addc-0b1ad70932b5");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Envenom Fangs",
                Level = 5,
                ActionTypeId = ActionTypes.Instances.OneAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = "a number of times per day equal to your level"
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("a816b013-cc9b-434a-91c2-663b5dab4206"), Type = TextBlockType.Text, Text = "You envenom your fangs. If the next fangs (Action: Strike) you make before the end of your next turn hits and deals damage, the (Action: Strike) deals an additional 1d6 poison damage. On a critical failure, the poison is wasted as normal." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("e3a6bd25-a894-4813-9dcd-4dca357f4166"), Feats.Instances.SharpFangs.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("605c045c-caa3-4ee9-ad1a-bf7597c69202"),
                SourceId = Sources.Instances.LostOmensCharacterGuide.ID,
                Page = -1
            };
        }
    }
}
