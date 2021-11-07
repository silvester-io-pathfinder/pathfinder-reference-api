using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class SpellRelay : Template
    {
        public static readonly Guid ID = Guid.Parse("16806367-01ae-4b32-a23d-fc51c806bed4");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Spell Relay",
                Level = 8,
                ActionTypeId = ActionTypes.Instances.Reaction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = "An ally Casts a Spell and you are within that spell's range.",
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("cbb17444-fcbb-4903-bf60-12c1c2900da8"), Type = TextBlockType.Text, Text = "You open the power inside you to your ally’s spellcasting, using your magic to boost their range. Your ally can use you as the point of origin for their spell, calculating range and cover from your space instead of their own." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("af2d84ae-0550-4a57-960f-07af07d48b78"), Feats.Instances.WellspringMageDedication.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("3e00fdde-3949-4099-8186-28d56bd95450"),
                SourceId = Sources.Instances.SecretsOfMagic.ID,
                Page = -1
            };
        }
    }
}
