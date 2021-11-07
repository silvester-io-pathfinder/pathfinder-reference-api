using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class ModificationComplexSimplicity : Template
    {
        public static readonly Guid ID = Guid.Parse("28d63b92-f63c-4101-be9a-5a116bc40278");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Modification - Complex Simplicity",
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
            yield return new TextBlock { Id = Guid.Parse("b3702f22-c55c-4c88-a668-5c3d3579760f"), Type = TextBlockType.Enumeration, Text = "*Simple Weapon Only**" };
            yield return new TextBlock { Id = Guid.Parse("80bfd989-387d-4e74-ae03-7c91de589a21"), Type = TextBlockType.Text, Text = "Increase your innovation’s weapon damage die by one step (d4 to d6, d6 to d8, d8 to d10, d10 to d12). In addition, it gains one of the following traits of your choice: (trait: versatile B), (trait: versatile P), or (trait: versatile S)." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("0b2d48da-7b14-4ee8-a555-a94f61deb9fb"),
                SourceId = Sources.Instances.GunsAndGears.ID,
                Page = -1
            };
        }
    }
}
