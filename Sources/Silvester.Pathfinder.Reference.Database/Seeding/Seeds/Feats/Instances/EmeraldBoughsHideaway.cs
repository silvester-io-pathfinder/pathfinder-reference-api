using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class EmeraldBoughsHideaway : Template
    {
        public static readonly Guid ID = Guid.Parse("8d9f3b8f-1ef4-40bb-a681-b94b5c2beffd");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Emerald Boughs Hideaway",
                Level = 10,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("fc0268ba-e25b-4e11-b350-9faaff1b05a8"), Type = TextBlockType.Text, Text = "You use Emerald Bough techniques to create a small extradimensional space called a hideaway that lasts as long as you are conscious. The hideaway functions as a (item: type I bag of holding | Bag of Holding I), but has no Bulk and takes no hands; it holds one object with a maximum Bulk equal to your highest mental ability score modifier; as you open the hideaway with pure thought, activating it to retrieve an item is a free action with the envision component instead of a single action with the (action: Interact) component." };
            yield return new TextBlock { Id = Guid.Parse("2baaaaea-bbb8-4c0f-b90e-6232fa4c2dea"), Type = TextBlockType.Text, Text = "The hideaway’s access point appears as an obviously magical gap within 1 foot of your body. Only you can access the hideaway; you can you use an (action: Interact) action each round to physically hold it open for another person. A successful (spell: dispel magic) spell or similar effect against your spell DC and the hideaway’s counteract level of 2 expels the object; the object is also expelled if you become unconscious. After a successful (spell: dispel magic) spell or when you become conscious again, the hideaway immediately reforms with no additional action from you. You can also dismiss the hideaway (if it is empty) or re-form it using a single action with the envision component." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("731e86d0-ea08-4bf9-b7bb-6658ad5db33b"), Feats.Instances.MagaambyanAttendantDedication.ID);
            builder.Manual(Guid.Parse("77f97e24-be7a-4682-bef0-10adc9db305d"), "Emerald Boughs affiliation");
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("e99dfd3a-fdea-4cad-ad5d-f9b60b5a8b11"),
                SourceId = Sources.Instances.LostOmensCharacterGuide.ID,
                Page = -1
            };
        }
    }
}
