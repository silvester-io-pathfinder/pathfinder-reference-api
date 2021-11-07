using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class RaiseATome : Template
    {
        public static readonly Guid ID = Guid.Parse("fb8e0f07-8205-47ee-abd2-3126ed2c0ebe");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Raise a Tome",
                Level = 1,
                ActionTypeId = ActionTypes.Instances.OneAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("ab74b9db-a60d-47ef-b8aa-90e0f79eddc3"), Type = TextBlockType.Text, Text = "You raise up the book you’re holding and flip it open to defend yourself and expedite your studies. The book remains raised until the start of your next turn. While you have a book raised, you gain a +2 circumstance bonus to AC and a +1 circumstance bonus to (action: Recall Knowledge) to identify creatures using a skill related to the subject of the book (Arcana if you’re using your (item: spellbook)). This bonus is in addition to any item bonus the book normally gives to the check." };
            yield return new TextBlock { Id = Guid.Parse("54548d2c-bc4b-4242-82e1-f5ad1330f3c2"), Type = TextBlockType.Text, Text = "If you have (feat: Shield Block), you can use the tome for that feat (Hardness 3, HP 12, BT 6) as though it were a shield. Whenever you use an ability that allows you to (action: Raise a Shield), such as (feat: Emergency Targe), you can (action: Raise a Tome | Raise a Shield) instead, changing any requirements that normally require a shield to apply to your book." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("ad822d7c-7f33-45d2-ac11-16e4ea3e8896"),
                SourceId = Sources.Instances.SecretsOfMagic.ID,
                Page = -1
            };
        }
    }
}
