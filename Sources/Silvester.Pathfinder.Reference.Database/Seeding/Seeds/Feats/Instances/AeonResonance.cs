using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class AeonResonance : Template
    {
        public static readonly Guid ID = Guid.Parse("0598e5d1-9531-46d3-ad1d-b47ccb3a46dc");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Aeon Resonance",
                Level = 4,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = true,
                Special = "At 8th level, you can take this feat again. If you do, you gain the resonance powers of up to four invested aeon stones instead of only one.",
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("d0d9d98f-7cce-45d1-a798-e30f583e8ab4"), Type = TextBlockType.Text, Text = "You gain the resonant power of one embedded aeon stone as if it were placed in a wayfinder. While you can embed multiple aeon stones in your flesh, you can gain the resonance power from only one embedded stone at a time, selected each day when you make your daily preparations." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("38f6a36b-e296-4fd8-b956-28441a0d0c52"), Feats.Instances.EmbedAeonStone.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("d57da104-1f79-4cac-abef-23143716d46a"),
                SourceId = Sources.Instances.SecretsOfMagic.ID,
                Page = -1
            };
        }
    }
}
