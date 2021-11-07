using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class FelineForm : Template
    {
        public static readonly Guid ID = Guid.Parse("07b3bd92-560e-4558-91bf-6947b316f39f");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Feline Form",
                Level = -1,
                ActionTypeId = ActionTypes.Instances.OneAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("31dfa4f1-67a7-4ef1-b4b5-e57a5577c6d2"), Type = TextBlockType.Text, Text = "You transform into a feline form resembling a house cat, which has the statistics of 1st-level (spell: pest form). Your feline form has a consistent appearance with features that match your humanoid form, such as your eye or hair color. Using Feline Form counts as creating a disguise for the (action: Impersonate) use of Deception. You lose any unarmed (action: Strikes | Strike) you gained from a heritage or ancestry feat in this form. You can remain in your feline form indefinitely, and you can shift back to your true form by using this action again." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("fe2ba015-d12c-4c85-a4af-8bb1fe1632a6"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
