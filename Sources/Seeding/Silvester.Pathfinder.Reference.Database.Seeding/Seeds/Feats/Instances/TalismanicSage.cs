using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class TalismanicSage : Template
    {
        public static readonly Guid ID = Guid.Parse("7e5b5f4b-8e5b-4c18-8d54-1e981e872993");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Talismanic Sage",
                Level = 14,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("13638c14-a41d-4125-b245-8c3dab28e3d3"), Type = TextBlockType.Text, Text = "You have forgotten more about talismans than lesser warriors have ever known. Normally, affixing more than one talisman to an item causes the talismans to be suppressed, but when you (action: Affix a Talisman), you can specially treat one item you’re working on, allowing it to have two active talismans at once. This special treatment ends if you use (action: Affix a Talisman) to treat a new item for this ability." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("8394be16-b403-4d99-b572-812b2fd02c51"), Feats.Instances.TalismanDabblerDedication.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("fd176765-d7b9-46a1-8d30-f191a2dc5fad"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
