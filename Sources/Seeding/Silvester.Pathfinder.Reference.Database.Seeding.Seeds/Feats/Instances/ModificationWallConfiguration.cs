using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class ModificationWallConfiguration : Template
    {
        public static readonly Guid ID = Guid.Parse("5f6c78f1-42da-4819-9771-17e1beef5588");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Modification - Wall Configuration",
                Level = -1,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("3ccf0dc3-5dc4-4c85-bf8e-763fc5059ac2"), Type = TextBlockType.Text, Text = "Your innovation can transform from a mobile construct to a stationary battlefield emplacement. It can unfold as a 2-action activity that has the (trait: manipulate) trait, changing from its usual form into a thin, straight wall of metal and gears up to 10 feet tall and 30 feet long. The wall must extend through your innovation's original space. While your construct is a wall, it can't take any actions except to use the same activity to transform back, and it can't defend itself easily, making it flat-footed and giving it an additional –2 status penalty to its AC. The wall blocks line of sight and effect unless your innovation has half its maximum HP or fewer, at which point holes in the wall allow creatures to see through and attack with cover, and Tiny creatures to slip through." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("e5e0db65-dea3-4180-8971-44b2d98de80d"),
                SourceId = Sources.Instances.GunsAndGears.ID,
                Page = -1
            };
        }
    }
}
