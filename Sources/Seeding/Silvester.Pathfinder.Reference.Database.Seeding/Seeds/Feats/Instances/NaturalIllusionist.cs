using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class NaturalIllusionist : Template
    {
        public static readonly Guid ID = Guid.Parse("ce426ccb-048e-4906-a956-39543dc8dba2");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Natural Illusionist",
                Level = 5,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("19ad4a56-e555-4fe1-938d-472ae3394c6c"), Type = TextBlockType.Text, Text = "By drawing upon the First World's magic, you can siphon a portion of that malleable world to create a convincing illusion. Once per day, you can cast (spell: illusory disguise), (spell: item facade), or (spell: ventriloquism). At 7th level, the spell is heightened to 2nd level, and every 2 levels thereafter, the spell is heightened an additional spell level." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("a08d7ce2-74eb-4356-80de-08f7dc3d89ea"), Feats.Instances.IllusionSense.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("743d599a-b452-468c-8b6f-44d918ad8f19"),
                SourceId = Sources.Instances.LostOmensCharacterGuide.ID,
                Page = -1
            };
        }
    }
}
