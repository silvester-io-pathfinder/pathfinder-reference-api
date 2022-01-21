using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class EmeraldBoughsHideaway : Template
    {
        public static readonly Guid ID = Guid.Parse("f4e74578-4f59-4b30-8b39-9920b1ad4739");

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
            yield return new TextBlock { Id = Guid.Parse("492fb38b-d079-480e-a471-a897b0bcd0a9"), Type = TextBlockType.Text, Text = "You use Emerald Bough techniques to create a small extradimensional space called a hideaway that lasts as long as you are conscious. The hideaway functions as a (item: type I bag of holding | Bag of Holding I), but has no Bulk and takes no hands; it holds one object with a maximum Bulk equal to your highest mental ability score modifier; as you open the hideaway with pure thought, activating it to retrieve an item is a free action with the envision component instead of a single action with the (action: Interact) component." };
            yield return new TextBlock { Id = Guid.Parse("60c278bb-8c7a-4bf2-905f-322de20abef8"), Type = TextBlockType.Text, Text = "The hideaway's access point appears as an obviously magical gap within 1 foot of your body. Only you can access the hideaway; you can you use an (action: Interact) action each round to physically hold it open for another person. A successful (spell: dispel magic) spell or similar effect against your spell DC and the hideaway's counteract level of 2 expels the object; the object is also expelled if you become unconscious. After a successful (spell: dispel magic) spell or when you become conscious again, the hideaway immediately reforms with no additional action from you. You can also dismiss the hideaway (if it is empty) or re-form it using a single action with the envision component." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("cc394f1e-13e5-492e-b7f8-03311cf88e72"), Feats.Instances.MagaambyanAttendantDedication.ID);
            builder.Manual(Guid.Parse("3096157c-3bfc-4241-ae67-e730518a67ac"), "Emerald Boughs affiliation");
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("7304a710-11c8-458b-8776-b344a58b8fd5"),
                SourceId = Sources.Instances.LostOmensCharacterGuide.ID,
                Page = -1
            };
        }
    }
}
