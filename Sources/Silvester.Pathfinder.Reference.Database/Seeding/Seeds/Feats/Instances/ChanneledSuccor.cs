using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class ChanneledSuccor : Template
    {
        public static readonly Guid ID = Guid.Parse("00bc9145-3088-4740-b575-88515d0abb91");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Channeled Succor",
                Level = 8,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("2bd27b11-6d3c-4f85-900c-f69f4463f594"), Type = TextBlockType.Text, Text = "You can remove conditions with divine grace. You can sacrifice one (spell: heal) spell you’ve prepared in your extra slots from healing font to cast one of the following spells instead: (spell: remove curse), (spell: remove disease), (spell: remove paralysis), or (spell: restoration). The spell is heightened to the same level as the heal spell you sacrificed." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificDivineFont(Guid.Parse("ba8db759-8b9b-491b-bb3c-31195fd09b25"), DivineFonts.Instances.Heal.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("1806d223-2727-4534-9a01-8fd374c5b28a"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
