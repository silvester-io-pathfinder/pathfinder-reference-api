using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class FamiliarsLanguage : Template
    {
        public static readonly Guid ID = Guid.Parse("82ac3c38-a592-4a82-966d-a7f8d24501f8");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Familiar's Language",
                Level = 2,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = "This feat has the trait corresponding to the tradition of spells you cast ((trait: arcane), (trait: divine), (trait: occult), or (trait: primal)).",
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("fe927ed1-ff15-49eb-866e-75e6d7a2c7ce"), Type = TextBlockType.Text, Text = "You’ve learned to speak with your familiar and other creatures like it. You can ask questions of, receive answers from, and use the Diplomacy skill with creatures of the same family of animals as your familiar. For example, if your familiar were a cat, you could gain the effects of speak with animals for any felines (including leopards, lions, and tigers, among others). This ability doesn’t make them more friendly than normal. If your familiar ever changes to a different creature, you can’t use this ability for 1 week while you absorb your new familiar’s language." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveAnyFamiliar(Guid.Parse("a2f7fa7b-ae33-43af-a596-9f7076da0f97"));
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("0c04fc11-8b99-4e71-b19f-19c0e213931b"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
