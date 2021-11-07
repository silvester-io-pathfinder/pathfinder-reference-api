using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class BlessedDenial : Template
    {
        public static readonly Guid ID = Guid.Parse("e4808121-7f19-4420-ba46-981dc05a5626");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Blessed Denial",
                Level = 12,
                ActionTypeId = ActionTypes.Instances.Reaction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = "An ally within 30 feet would become frightened, drained, enfeebled, sickened, or stupefied.",
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("b76d54bd-0e45-46ba-baf8-7f38e7cff957"), Type = TextBlockType.Text, Text = "You exude peace and protection, lessening a harmful condition as it falls upon an ally. Reduce the value of the condition your ally would take by 1 (to a minimum of 0). If the ally takes more than one condition at the same time, choose one to reduce." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("74614760-7833-4e6f-b386-c67e80834c20"), Feats.Instances.BlessedOneDedication.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("b2733198-53d8-43ae-8bb4-de7aa7739345"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
