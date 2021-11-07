using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class WitchsCharge : Template
    {
        public static readonly Guid ID = Guid.Parse("431f1bea-5a1a-4005-bfd6-fcc5c010bcd1");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Witch's Charge",
                Level = 6,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = "This feat has the trait corresponding to the tradition of spells you cast ((trait: arcane), (trait: divine), (trait: occult), or (trait: primal)).",
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("70c0548a-9409-47e3-9bc3-9ae17bfe567b"), Type = TextBlockType.Text, Text = "You forge a magical link with another creature, granting you awareness of that creature’s condition and creating a conduit for spellcasting. During your daily preparations, you can designate one willing creature as your charge. You are always aware of your charge’s direction from you, its distance from you, and any conditions affecting it. In addition, you can cast spells with a range of touch on your charge from a range of 30 feet. These effects persist until your next daily preparations." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("7c300003-9905-466d-abc1-bc51ebe8bae4"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
