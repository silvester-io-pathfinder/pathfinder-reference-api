using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class ShieldedTome : Template
    {
        public static readonly Guid ID = Guid.Parse("f3d3fedd-0000-423a-a25c-7d6024aee23e");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Shielded Tome",
                Level = 6,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("a98bc957-9a80-4f32-b1c7-c23df29279fc"), Type = TextBlockType.Text, Text = "During your daily preparations, you can magically fuse a shield into your favorite book, where it appears as an elaborate bookmark. While the two are fused, the book shares the Hardness, Hit Points, and Broken Threshold of the shield, and it can be used to (feat: Shield Block) if you have that reaction, with a requirement of “You have (action: Raised the Tome | Raise a Tome)” instead of the usual requirements." };
            yield return new TextBlock { Id = Guid.Parse("397d51dc-3af5-4248-9c57-bcf212e7014f"), Type = TextBlockType.Text, Text = "You can switch the fused item’s form from a book to a shield with a book-shaped motif as a single action, which has the (trait: concentrate) trait. When the item is in book form, you can read the book and (action: Raised the Tome | Raise a Tome), and when it’s in shield form, you can (action: Raise the Shield | Raise a Shield), Activate it, and gain any other benefits or effects the shield normally has (such as a spellguard shield’s bonus to saving throws against magic). The fusion lasts until your next daily preparations." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("13096cda-b209-4776-852a-2742290b8fa8"), Feats.Instances.RaiseATome.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("05ad081c-1488-4dc0-9bff-d6793c38f56d"),
                SourceId = Sources.Instances.SecretsOfMagic.ID,
                Page = -1
            };
        }
    }
}
