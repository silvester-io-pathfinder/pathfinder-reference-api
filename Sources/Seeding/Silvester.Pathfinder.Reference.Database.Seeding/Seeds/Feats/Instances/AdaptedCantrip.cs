using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class AdaptedCantrip : Template
    {
        public static readonly Guid ID = Guid.Parse("d8ed5220-805e-4baa-9951-1ca015c812a1");

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
            yield return new TextBlock { Id = Guid.Parse("a38b4391-c20a-4927-8930-c588b021b051"), Type = TextBlockType.Text, Text = "Through study of multiple magical traditions, you've altered a spell to suit your spellcasting style. Choose one cantrip from a magical tradition other than your own. If you have a spell repertoire or a spellbook, replace one of the cantrips you know or have in your spellbook with the chosen spell. If you prepare spells without a spellbook (if you're a cleric or druid, for example), one of your cantrips must always be the chosen spell, and you prepare the rest normally. You can cast this cantrip as a spell of your class's tradition." };
            yield return new TextBlock { Id = Guid.Parse("126a3b88-6e64-4487-bc45-f46e4fcabd22"), Type = TextBlockType.Text, Text = "If you swap or retrain this cantrip later, you can choose its replacement from the same alternate tradition or a different one." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveAnyMagicTradition(Guid.Parse("e496e0f5-b8fa-4933-90c9-1276e98f136d"));
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("586817da-dcc8-49e2-8e0f-52b1a5b3b004"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
