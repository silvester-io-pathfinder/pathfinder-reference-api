using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class AdaptedCantrip : Template
    {
        public static readonly Guid ID = Guid.Parse("964ce44b-f553-4d73-ab28-f785bb5edd9d");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Adapted Cantrip",
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
            yield return new TextBlock { Id = Guid.Parse("fa8041b9-5737-4f9b-8966-d1643ef566e7"), Type = TextBlockType.Text, Text = "Through study of multiple magical traditions, you’ve altered a spell to suit your spellcasting style. Choose one cantrip from a magical tradition other than your own. If you have a spell repertoire or a spellbook, replace one of the cantrips you know or have in your spellbook with the chosen spell. If you prepare spells without a spellbook (if you’re a cleric or druid, for example), one of your cantrips must always be the chosen spell, and you prepare the rest normally. You can cast this cantrip as a spell of your class’s tradition." };
            yield return new TextBlock { Id = Guid.Parse("c4116365-9c56-4dd2-b6ae-9a12a0afdc49"), Type = TextBlockType.Text, Text = "If you swap or retrain this cantrip later, you can choose its replacement from the same alternate tradition or a different one." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveAnyMagicTradition(Guid.Parse("37b417fd-737a-4787-afd2-dbd16355585d"));
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("81259df5-d4d9-4be2-b075-e772362e5e12"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
