using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class UnconventionalWeaponry : Template
    {
        public static readonly Guid ID = Guid.Parse("0304b05b-e6fb-48a2-8566-c2dd72f7b8d4");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Unconventional Weaponry",
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
            yield return new TextBlock { Id = Guid.Parse("a705ee38-a7ad-4aac-9811-1487aa90982f"), Type = TextBlockType.Text, Text = "You’ve familiarized yourself with a particular weapon, potentially from another ancestry or culture. Choose an uncommon simple or martial weapon with a trait corresponding to an ancestry (such as dwarf, goblin, or orc) or that is common in another culture. You gain access to that weapon, and for the purpose of determining your proficiency, that weapon is a simple weapon." };
            yield return new TextBlock { Id = Guid.Parse("3349563f-ee19-42d6-89ed-71ceea17bd70"), Type = TextBlockType.Text, Text = "If you are trained in all martial weapons, you can choose an uncommon advanced weapon with such a trait. You gain access to that weapon, and for the purpose of determining your proficiency, that weapon is a martial weapon." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("92f75451-6757-4341-ab03-39eada0bb8db"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
