using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class CollapseArmor : Template
    {
        public static readonly Guid ID = Guid.Parse("1a4a2aa8-8c89-437e-a13c-8176e35ab807");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Collapse Armor",
                Level = 2,
                ActionTypeId = ActionTypes.Instances.OneAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("0a7bb5ae-3bb7-4cc2-9754-bd4530521a6e"), Type = TextBlockType.Text, Text = "You’ve modified your armor innovation to collapse into a more compact form so you can don or remove it in an instant. If you’re wearing your innovation when you Collapse your Armor, you remove it instantly, and it compresses into its compact form, which is held in both of your hands (if you don’t have both hands available, it falls to the ground in an adjacent space). If you’re holding your armor in compact form when you take this action, it unfolds back into its armor form onto your body." };
            yield return new TextBlock { Id = Guid.Parse("141c58a8-d516-48a1-97cb-8986d575d366"), Type = TextBlockType.Text, Text = "In compact form, your armor innovation is easier to carry, with a Bulk 1 lower than the Bulk listed for it, to a minimum of light Bulk (carried armor normally has a Bulk 1 higher than listed in the armor entry)." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificInnovation(Guid.Parse("d6aa1927-8c2b-4ea1-8082-ea3d64c9b5ca"), Innovations.Instances.Armor.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("681edc97-d421-4084-93ce-c007c8344e99"),
                SourceId = Sources.Instances.GunsAndGears.ID,
                Page = -1
            };
        }
    }
}
