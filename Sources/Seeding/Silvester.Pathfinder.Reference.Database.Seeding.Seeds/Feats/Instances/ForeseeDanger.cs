using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class ForeseeDanger : Template
    {
        public static readonly Guid ID = Guid.Parse("9983193d-225d-4c69-9cf4-325154e5b4a3");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Foresee Danger",
                Level = 12,
                ActionTypeId = ActionTypes.Instances.Reaction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = "A creature targets you with an attack and you can see the attacker.",
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("d0421327-083c-484b-baca-93c5d19c2efc"), Type = TextBlockType.Text, Text = "You perceive every possible way your foe's attack could land and attempt to avoid them all. The triggering attack roll targets your Perception DC instead of your AC. Though this allows you to avoid taking penalties to your AC, it doesn't remove any conditions or other effects causing such penalties. For example, an enemy with sneak attack would still deal extra damage to you for being flat-footed, even though you wouldn't take the -2 circumstance penalty when defending against the attack." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("d5c5c973-ccc1-4b03-8649-2be7c41137d7"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
