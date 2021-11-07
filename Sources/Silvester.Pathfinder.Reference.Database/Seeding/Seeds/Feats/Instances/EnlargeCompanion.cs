using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class EnlargeCompanion : Template
    {
        public static readonly Guid ID = Guid.Parse("99ec7b8d-ecfd-4535-a7b3-0614fd3fbf46");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Enlarge Companion",
                Level = 8,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("fff0520d-a58d-4481-bfcf-60f4f2f13152"), Type = TextBlockType.Text, Text = "You make your companion enormous. You gain the (spell: enlarge companion) warden spell. Increase the number of Focus Points in your focus pool by 1." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificAnimalCompanionAmount(Guid.Parse("d75016fa-8ca7-4f6c-9454-095623f97ace"), Comparators.GreaterThanOrEqualTo, amount: 1);
            builder.HaveSpecificClass(Guid.Parse("84a858e0-50b4-4b77-a54e-dff26b07013a"), Classes.Instances.Ranger.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("4bda875a-8282-4012-a6cf-a6ade1ade247"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
