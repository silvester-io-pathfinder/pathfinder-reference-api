using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class ElementalLore : Template
    {
        public static readonly Guid ID = Guid.Parse("5d11fc54-a2c5-4359-8a1e-b3bdfc9a8362");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Elemental Lore",
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
            yield return new TextBlock { Id = Guid.Parse("ce671f55-8fc4-4202-8ca8-c902bf8a2649"), Type = TextBlockType.Text, Text = "You’ve devoted yourself to researching the secrets of the Inner Sphere. You gain the trained proficiency in your choice of Survival and either Arcana or Nature. If you would automatically become trained in Survival (from your background or class, for example), you instead become trained in a skill of your choice. You also become trained in the Lore associated with your Elemental Plane of origin (such as Plane of Fire Lore)." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("c8fe5b5f-cd9d-475b-b042-5e20fba03066"),
                SourceId = Sources.Instances.LostOmensAncestryGuide.ID,
                Page = -1
            };
        }
    }
}
