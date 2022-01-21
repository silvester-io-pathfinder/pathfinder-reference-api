using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class SpotTranslate : Template
    {
        public static readonly Guid ID = Guid.Parse("857d75e7-e059-4b5a-96d3-18ab99e0fcef");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Spot Translate",
                Level = 4,
                ActionTypeId = ActionTypes.Instances.Reaction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = "Another creature within 60 feet uses a linguistic effect in a language you understand.",
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("0edde832-5ae1-4560-a8d7-bcdf2a91970c"), Type = TextBlockType.Text, Text = "You interpret a creature's words, repeating their message in a different language that you know. If the triggering effect's targets speak either the original language or the one you translated into, they are affected." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("c1a6fc88-68a6-4598-a11b-bd2d897c17b2"), Feats.Instances.LinguistDedication.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("133d008e-090a-44a2-8223-b8d639b08d88"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
