using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class CascadeBearersSpellcasting : Template
    {
        public static readonly Guid ID = Guid.Parse("2e20f76b-1316-4282-b128-88c89c110b46");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Cascade Bearers Spellcasting",
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
            yield return new TextBlock { Id = Guid.Parse("b6a00d08-8639-43b0-bc89-37006fb252a5"), Type = TextBlockType.Text, Text = "Your Cascade Bearer training allows you to broaden the horizons of your halcyon spells further than most Magaambyans, weaving in spiritual magic. You can select halcyon spells from the divine or occult spell lists in additional to the arcane or primal spell lists, though they are still halcyon spells (so you choose when casting if they are arcane or primal spells). You gain a halcyon cantrip and a halcyon 1st-level spell." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("d12a8dfa-7002-4ebf-9390-fdd4951440f8"), Feats.Instances.MagaambyanAttendantDedication.ID);
            builder.Manual(Guid.Parse("f89b7b78-00d1-48ab-bc35-9550bfaf8a9e"), "Cascade Bearers affiliation.");
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("511c2f54-7d15-47e0-9b4b-546a07b7ffba"),
                SourceId = Sources.Instances.LostOmensCharacterGuide.ID,
                Page = -1
            };
        }
    }
}
