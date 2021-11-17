using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class BoundingSpirit : Template
    {
        public static readonly Guid ID = Guid.Parse("ba29060c-78f4-45f1-a92c-09cc1f3c1aac");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Bounding Spirit",
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
            yield return new TextBlock { Id = Guid.Parse("8c64ff84-47e2-44de-9072-0f78dcc0454d"), Type = TextBlockType.Text, Text = "The weapon gains the (trait: thrown 30 feet|thrown 30 feet) trait and has the (item: returning rune|Returning Runestone) (even if it already has its maximum number of property runes)." };
            yield return new TextBlock { Id = Guid.Parse("d6aec9fb-cbce-4af1-a349-4d686eb7484c"), Type = TextBlockType.Text, Text = "__Corruption Flaw__ When you make a (action: Strike) with a thrown or ranged weapon and miss, reroll the (action: Strike), targeting your ally nearest to the tar" };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            //TODO: Add prerequisites.
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("96dda843-2be2-439b-be6c-68defa906885"),
                SourceId = Sources.Instances.SecretsOfMagic.ID,
                Page = -1
            };
        }
    }
}
