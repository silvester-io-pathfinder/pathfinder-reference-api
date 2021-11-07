using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class ArcaneTattoos : Template
    {
        public static readonly Guid ID = Guid.Parse("0f726960-a7db-4206-9203-aa922e3b36da");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Arcane Tattoos",
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
            yield return new TextBlock { Id = Guid.Parse("6686bd72-7fa6-42de-bcd7-c8d98e174a15"), Type = TextBlockType.Text, Text = "~ Access: Varisian ethnicity or New Thassilon nationality" };
            yield return new TextBlock { Id = Guid.Parse("90b409d3-8444-4257-b829-df8f7705a937"), Type = TextBlockType.Text, Text = "You have tattoos on your body corresponding to one of the ancient Thassilonian schools of magic. Choose one of the following schools of magic: abjuration ((spell: shield)), conjuration ((spell: tanglefoot)), enchantment ((spell: daze)), evocation ((spell: electric arc)), illusion ((spell: ghost sound)), necromancy ((spell: chill touch)), or transmutation ((spell: sigil)). You can cast the associated cantrip (listed in parentheses) as an innate arcane spell at will." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("4d64b8ad-1c48-4378-b603-992ea7427ef1"),
                SourceId = Sources.Instances.LostOmensCharacterGuide.ID,
                Page = -1
            };
        }
    }
}
