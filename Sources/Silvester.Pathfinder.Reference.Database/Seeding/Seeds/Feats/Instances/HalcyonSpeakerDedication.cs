using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class HalcyonSpeakerDedication : Template
    {
        public static readonly Guid ID = Guid.Parse("c6867704-ea6a-41e4-ab1a-6524f94343cb");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Halcyon Speaker Dedication",
                Level = 6,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = "You cannot select another dedication feat until you have gained two other feats from the halcyon speaker archetype.",
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("e86435bc-8807-41f4-97a8-224d159377e3"), Type = TextBlockType.Text, Text = "You devote much of your study to halcyon magic. You gain access to two common Halcyon cantrips and two common 1st-level halcyon spells (see halcyon spells on Lost Omens Character Guide pg 100). In addition to being able to cast your halcyon spells via your arcane or primal spell slots, you also gain a 1st-level halcyon spell slot. You can use your halcyon spell slots to spontaneously cast your halcyon spells." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("679fc464-bf23-49a0-8bb9-77c62097652d"), Feats.Instances.MagaambyanAttendantDedication.ID);
            builder.Manual(Guid.Parse("9b68f5d7-abdd-4e40-9b1c-8f2d46d9d36f"), "Member of the Magaambya of conversant rank.");
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("67e2b38a-e20e-4383-88f3-4a472c8b5c12"),
                SourceId = Sources.Instances.LostOmensCharacterGuide.ID,
                Page = -1
            };
        }
    }
}
