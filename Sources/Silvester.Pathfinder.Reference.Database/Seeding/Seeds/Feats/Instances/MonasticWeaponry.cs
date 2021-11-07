using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class MonasticWeaponry : Template
    {
        public static readonly Guid ID = Guid.Parse("d747e168-dba3-404b-a778-b5c78dc8d444");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Monastic Weaponry",
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
            yield return new TextBlock { Id = Guid.Parse("5f402663-26b3-4b75-9688-e4aecbcc70b8"), Type = TextBlockType.Text, Text = "You have trained with the traditional weaponry of your monastery or school. You gain access to uncommon weapons that have the (trait: monk | Monk - Weapon) trait and become trained in simple and martial monk weapons. When your proficiency rank for unarmed attacks increases to expert or master, your proficiency rank for these weapons increases to expert or master as well." };
            yield return new TextBlock { Id = Guid.Parse("1bfd64bc-ed40-4725-8aab-e4dab5ec6c4a"), Type = TextBlockType.Text, Text = "You can use melee monk weapons with any of your monk feats or monk abilities that normally require unarmed attacks, though not if the feat or ability requires you to use a single specific type of attack, such as (feat: Crane Stance)." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("730c2356-a348-4a11-943b-21647e8fc130"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
