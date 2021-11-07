using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class CascadeBearersSpellcasting : Template
    {
        public static readonly Guid ID = Guid.Parse("2668bf0d-9a7d-4f16-98e5-d129f8fa130d");

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
            yield return new TextBlock { Id = Guid.Parse("58a1617c-ab88-4776-9cd6-8eadd0b5afe4"), Type = TextBlockType.Text, Text = "Your Cascade Bearer training allows you to broaden the horizons of your halcyon spells further than most Magaambyans, weaving in spiritual magic. You can select halcyon spells from the divine or occult spell lists in additional to the arcane or primal spell lists, though they are still halcyon spells (so you choose when casting if they are arcane or primal spells). You gain a halcyon cantrip and a halcyon 1st-level spell." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("4cdd6ac4-8973-4b0d-ab22-fcc1fae8e237"), Feats.Instances.MagaambyanAttendantDedication.ID);
            builder.Manual(Guid.Parse("a28ed344-bee4-4d32-8db5-9ff99fc141a6"), "Cascade Bearers affiliation.");
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("ce7b75f5-d076-4f5a-b115-932b55724498"),
                SourceId = Sources.Instances.LostOmensCharacterGuide.ID,
                Page = -1
            };
        }
    }
}
