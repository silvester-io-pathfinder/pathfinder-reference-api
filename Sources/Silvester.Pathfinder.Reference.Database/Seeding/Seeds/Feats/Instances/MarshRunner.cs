using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class MarshRunner : Template
    {
        public static readonly Guid ID = Guid.Parse("11582651-b3b9-4f8b-9686-c0eb6ea79e46");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Marsh Runner",
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
            yield return new TextBlock { Id = Guid.Parse("87cc5421-236f-45f2-9b2e-62e87977ad67"), Type = TextBlockType.Text, Text = "You are adept at moving through marshy terrain. When you use the (Action: Step) action, you can ignore difficult terrain caused by flooding, swamps, or quicksand. In addition, when you use the Acrobatics skill to (Action: Balance) on narrow surfaces or uneven marshy ground, you aren’t flat-footed, and if you roll a success on the Acrobatics check, you get a critical success instead." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificMovementMethod(Guid.Parse("3fb890c3-728d-4ee9-90c7-836f5a32ae21"), MovementMethod.Swimming);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("4dec8727-8d42-4dfa-8350-37f0f8dfea51"),
                SourceId = Sources.Instances.LostOmensCharacterGuide.ID,
                Page = -1
            };
        }
    }
}
