using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class ShieldedTome : Template
    {
        public static readonly Guid ID = Guid.Parse("bfb03ab1-edc3-4766-b7c4-6c54317868fb");

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
            yield return new TextBlock { Id = Guid.Parse("039d6e0c-aa7e-4e1a-957e-7aa76fdfe5d9"), Type = TextBlockType.Text, Text = "During your daily preparations, you can magically fuse a shield into your favorite book, where it appears as an elaborate bookmark. While the two are fused, the book shares the Hardness, Hit Points, and Broken Threshold of the shield, and it can be used to (feat: Shield Block) if you have that reaction, with a requirement of “You have (action: Raised the Tome | Raise a Tome)” instead of the usual requirements." };
            yield return new TextBlock { Id = Guid.Parse("b92396a3-9e0c-4e2b-a948-6f6413e5063e"), Type = TextBlockType.Text, Text = "You can switch the fused item’s form from a book to a shield with a book-shaped motif as a single action, which has the (trait: concentrate) trait. When the item is in book form, you can read the book and (action: Raised the Tome | Raise a Tome), and when it’s in shield form, you can (action: Raise the Shield | Raise a Shield), Activate it, and gain any other benefits or effects the shield normally has (such as a spellguard shield’s bonus to saving throws against magic). The fusion lasts until your next daily preparations." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("333f5678-bc44-40e5-ab21-f944dabfc7b9"), Feats.Instances.RaiseATome.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("127f8f69-cb86-4622-9a20-52db428194b9"),
                SourceId = Sources.Instances.SecretsOfMagic.ID,
                Page = -1
            };
        }
    }
}
