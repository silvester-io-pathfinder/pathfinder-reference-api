using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class GrippliGlide : Template
    {
        public static readonly Guid ID = Guid.Parse("72f9f550-750c-44b1-a82a-5634a6f6de7d");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Grippli Glide",
                Level = 5,
                ActionTypeId = ActionTypes.Instances.OneAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("3c9ced41-1e4f-4a56-99dc-299115612fd4"), Type = TextBlockType.Text, Text = "You can use your webbed feet to guide your fall. You glide slowly toward the ground, 5 feet down (10 feet if you don’t have both hands free) and up to 25 feet forward through the air. As long as you spend at least 1 action gliding each round and have not yet reached the ground, you remain in the air at the end of your turn." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificHeritage(Guid.Parse("32fb1ab0-e686-4315-be52-0562c037b6cb"), Heritages.Instances.WindwebGrippli.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("190ac5ac-ca57-4a62-bc41-20696da84373"),
                SourceId = Sources.Instances.LostOmensMwangiExpanse.ID,
                Page = -1
            };
        }
    }
}
